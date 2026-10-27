SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [SO].[p_so_stclose_pkg_stlist_open_select]
    @p_design_no        CHAR(20) = NULL,
    @p_customer_name    CHAR(50) = NULL,
    @p_stno             CHAR(15) = NULL,
    @p_sales_person_code CHAR(5) = NULL,
    @p_closing_status   CHAR(10) = 'OPEN'
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @closing_status_value INT = NULL

    IF @p_closing_status = 'CLOSED' SET @closing_status_value = 1
    IF @p_closing_status = 'OPEN'   SET @closing_status_value = 0

    SELECT
         a.sono
        ,a.sodt
        ,f.name AS cust_name
        ,a.sonoid
        ,a.so_line_id
        ,a.design_no
        ,d.article_name
        ,clr.color_name
        ,a.so_qty AS st_qty
        ,a.so_uom AS uom
        ,CAST(CASE
            WHEN a.so_uom = 'KGS' THEN a.so_qty
            WHEN a.so_uom = 'MTS' AND d.finished_yield > 0 THEN a.so_qty / d.finished_yield
            WHEN a.so_uom = 'YDS' AND d.finished_yield > 0 THEN a.so_qty / d.finished_yield * 0.9144
         END AS NUMERIC(15,2)) AS st_qty_kg
        ,a.closed
        ,a.closedt
        ,ko.knitting_qty
        ,CAST(CASE
            WHEN a.so_uom = 'KGS' THEN a.so_qty
            WHEN a.so_uom = 'MTS' AND d.finished_yield > 0 THEN a.so_qty / d.finished_yield
            WHEN a.so_uom = 'YDS' AND d.finished_yield > 0 THEN a.so_qty / d.finished_yield * 0.9144
         END AS NUMERIC(15,2)) - ISNULL(ko.knitting_qty, 0) AS ko_bal_kg
        ,balg.bal_kg
        ,ISNULL(alloc.so_qty_kg, 0) AS so_qty_kg
        ,CAST(CASE
            WHEN a.so_uom = 'KGS' THEN a.so_qty
            WHEN a.so_uom = 'MTS' AND d.finished_yield > 0 THEN a.so_qty / d.finished_yield
            WHEN a.so_uom = 'YDS' AND d.finished_yield > 0 THEN a.so_qty / d.finished_yield * 0.9144
         END AS NUMERIC(15,2)) - ISNULL(alloc.so_qty_kg, 0) AS st_bal_kg
    FROM dbo.poc_sales_order_v a
    INNER JOIN dbo.poc_design_master_v d
        ON d.design_no = a.design_no COLLATE thai_ci_ai
    INNER JOIN dbo.poc_customers_v f
        ON f.custcd = a.custcd COLLATE thai_ci_ai
    LEFT JOIN dbo.poc_color_master_v clr
        ON clr.color_code = a.color_code COLLATE thai_ci_ai
    LEFT JOIN (
        SELECT st_line_id, SUM(CAST(ISNULL(alloc_kg, 0) AS NUMERIC(15,2))) AS so_qty_kg
        FROM dbo.st_order_alloc
        GROUP BY st_line_id
    ) alloc ON alloc.st_line_id = a.so_line_id
    LEFT JOIN (
        SELECT ko.sono, ko.design_no, SUM(ko.knitting_qty) AS knitting_qty
        FROM dbo.poc_knitting_order_v ko
        INNER JOIN dbo.poc_lookup_values_v lv
            ON lv.lookup_value_id = ko.production_order_type_id
        WHERE lv.lookup_value_code = 'KINO'
        GROUP BY ko.sono, ko.design_no
    ) ko ON ko.sono = a.sono COLLATE thai_ci_ai
        AND ko.design_no = a.design_no
    LEFT JOIN (
        SELECT sono, design_no, SUM(bal_kg) AS bal_kg
        FROM dbo.poc_greige_in_v
        GROUP BY sono, design_no
        HAVING SUM(ISNULL(bal_kg, 0)) > 0
    ) balg ON balg.sono = a.sono COLLATE thai_ci_ai
        AND balg.design_no = a.design_no
    WHERE a.order_type = 'STOCK'
      AND a.cancel_status = 0
      AND a.closed = CASE WHEN @closing_status_value IS NOT NULL THEN @closing_status_value ELSE a.closed END
      AND (
            a.design_no LIKE SUBSTRING(@p_design_no, 1, 8) + '%'
         OR d.article_name LIKE RTRIM(@p_design_no) + '%'
         OR @p_design_no IS NULL
         OR a.so_line_id IN (
                SELECT so_line_id
                FROM SO.so_alternate_items_v
                WHERE alternate_item_code LIKE SUBSTRING(@p_design_no, 1, 8) + '%'
            )
          )
      AND (a.sono = @p_stno OR @p_stno IS NULL)
      AND (f.name LIKE RTRIM(@p_customer_name) + '%' OR @p_customer_name IS NULL)
      AND (a.sales_person_code = @p_sales_person_code OR @p_sales_person_code IS NULL)
    ORDER BY a.sodt
END
GO

ALTER PROCEDURE [SO].[p_so_stclose_pkg_reserve_to_st]
    @p_so_line_id BIGINT
AS
BEGIN
    SET NOCOUNT ON

    SELECT
         so.sonoid
        ,so.so_line_id
        ,so.sono
        ,st.sono AS st_sono
        ,CAST(ISNULL(st.so_qty, 0) AS NUMERIC(15,2)) AS st_so_qty
        ,st.closed AS st_closed
        ,d.finished_yield
        ,so.customer_name
        ,so.design_no
        ,so.so_qty
        ,so.so_uom
        ,CAST(ISNULL(a.alloc_kg, 0) AS NUMERIC(15,2)) AS so_qty_kg
        ,CAST(CASE
            WHEN RTRIM(st.so_uom) IN ('KG', 'KGS') THEN st.so_qty
            WHEN RTRIM(st.so_uom) = 'MTS' AND ISNULL(d.finished_yield, 0) > 0
                THEN st.so_qty / d.finished_yield
            WHEN RTRIM(st.so_uom) = 'YDS' AND ISNULL(d.finished_yield, 0) > 0
                THEN st.so_qty / d.finished_yield * 0.9144
            ELSE 0
         END AS NUMERIC(15,2)) AS st_so_qty_kg
        ,df.df_qty_kg
        ,so.color_code
        ,clr.color_name
        ,so.closed
        ,so.ref_so_line_id
        ,a.st_order_alloc_id
        ,a.alloc_kg
        ,a.alloc_mts
        ,a.alloc_date
        ,a.alloc_by
    FROM dbo.st_order_alloc a
    INNER JOIN dbo.poc_sales_order_v so
        ON so.so_line_id = a.so_line_id
    INNER JOIN dbo.poc_sales_order_v st
        ON st.so_line_id = a.st_line_id
    INNER JOIN dbo.poc_design_master_v d
        ON d.design_no = st.design_no COLLATE thai_ci_ai
    LEFT JOIN dbo.poc_color_master_v clr
        ON clr.color_code = so.color_code COLLATE thai_ci_ai
    LEFT JOIN (
        SELECT sonoid, SUM(qc_kg) AS df_qty_kg
        FROM dbo.poc_dforder_items_v
        GROUP BY sonoid
    ) df ON df.sonoid = so.sonoid
    WHERE a.st_line_id = @p_so_line_id
      AND ISNULL(so.cancel_status, 0) = 0
    ORDER BY a.alloc_date, so.sonoid
END
GO
