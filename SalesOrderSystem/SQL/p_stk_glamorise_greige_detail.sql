IF OBJECT_ID('SO.p_stk_glamorise_greige_detail', 'P') IS NOT NULL
    DROP PROCEDURE SO.p_stk_glamorise_greige_detail
GO

SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [SO].[p_stk_glamorise_greige_detail]
    @design_no  varchar(20)  = '',
    @datefr     varchar(8)   = '',
    @dateto     varchar(8)   = '',
    @customer   varchar(100) = ''
AS
BEGIN
    SET NOCOUNT ON;

    -- Result Set 1: S/T (Greige Booking) orders
    SELECT DISTINCT
        storder.sodt                                    AS sodt_sort,
        storder.sono                                    AS st_no,
        CONVERT(varchar(10), storder.sodt, 103)         AS st_date,
        ISNULL(dm.refdesno, sti.design_no)              AS product,
        sti.design_no                                   AS customer_design,
        'GREIGE'                                        AS cus_color,
        sti.qty                                         AS st_qty,
        sti.uom                                         AS st_uom
    FROM soitm sti
    INNER JOIN so storder    ON storder.sono = sti.sono
        AND storder.order_type = 'STOCK'
        AND ISNULL(storder.cancel_status, 0) = 0
    LEFT  JOIN dm            ON dm.design_no = sti.design_no
    LEFT  JOIN Customers c   ON c.custcd = storder.custcd
    WHERE sti.design_no = @design_no
      AND (@datefr   = '' OR CONVERT(varchar(8), storder.sodt, 112) >= @datefr)
      AND (@dateto   = '' OR CONVERT(varchar(8), storder.sodt, 112) <= @dateto)
      AND (@customer = '' OR c.name LIKE '%' + @customer + '%')
    ORDER BY storder.sodt;

    -- Result Set 2: O/C (Sales Order) items linked back to the filtered ST rows
    SELECT
        sti.sono                                        AS st_no,
        soorder.sono                                    AS oc_no,
        CONVERT(varchar(10), soorder.sodt, 103)         AS oc_date,
        soorder.custpo                                  AS cust_po,
        ISNULL(dm2.refdesno, soi.design_no)             AS article,
        soi.col                                         AS cus_color,
        soi.custcol                                     AS color_code,
        soi.qty                                         AS oc_qty,
        soi.uom                                         AS oc_uom
    FROM st_order_alloc alloc
    INNER JOIN soitm sti     ON sti.so_line_id = alloc.st_line_id
    INNER JOIN so storder    ON storder.sono = sti.sono
        AND storder.order_type = 'STOCK'
        AND ISNULL(storder.cancel_status, 0) = 0
    LEFT  JOIN Customers c   ON c.custcd = storder.custcd
    INNER JOIN soitm soi     ON soi.so_line_id = alloc.so_line_id
    INNER JOIN so soorder    ON soorder.sono = soi.sono
    LEFT  JOIN dm dm2        ON dm2.design_no = soi.design_no
    WHERE sti.design_no = @design_no
      AND (@datefr   = '' OR CONVERT(varchar(8), storder.sodt, 112) >= @datefr)
      AND (@dateto   = '' OR CONVERT(varchar(8), storder.sodt, 112) <= @dateto)
      AND (@customer = '' OR c.name LIKE '%' + @customer + '%')
    ORDER BY storder.sodt, soorder.sodt, soi.col;
END;
GO
