IF OBJECT_ID('SO.p_stk_glamorise_greige_summary', 'P') IS NOT NULL
    DROP PROCEDURE SO.p_stk_glamorise_greige_summary
GO

SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [SO].[p_stk_glamorise_greige_summary]
    @datefr   varchar(8)   = '',
    @dateto   varchar(8)   = '',
    @customer varchar(100) = ''
AS
BEGIN
    SET NOCOUNT ON;

    -- Step 1: total ST (greige booking) qty per design, optionally filtered by customer name
    SELECT
        sti.design_no,
        MAX(sti.uom)        AS uom,
        SUM(sti.qty)        AS total_st_qty,
        MAX(st.sodt)        AS last_st_date
    INTO #st
    FROM soitm sti
    INNER JOIN so st         ON st.sono = sti.sono
        AND st.order_type = 'STOCK'
        AND ISNULL(st.cancel_status, 0) = 0
    LEFT  JOIN Customers c   ON c.custcd = st.custcd
    WHERE (@datefr   = '' OR CONVERT(varchar(8), st.sodt, 112) >= @datefr)
      AND (@dateto   = '' OR CONVERT(varchar(8), st.sodt, 112) <= @dateto)
      AND (@customer = '' OR c.name LIKE '%' + @customer + '%')
    GROUP BY sti.design_no;

    -- Step 2: total OC (sales order) qty allocated to each design's ST orders
    SELECT
        sti.design_no,
        SUM(ISNULL(soi.qty, 0)) AS total_oc_qty
    INTO #oc
    FROM st_order_alloc alloc
    INNER JOIN soitm sti ON sti.so_line_id = alloc.st_line_id
    INNER JOIN so st     ON st.sono = sti.sono
        AND st.order_type = 'STOCK'
        AND ISNULL(st.cancel_status, 0) = 0
    LEFT  JOIN Customers c ON c.custcd = st.custcd
    LEFT  JOIN soitm soi ON soi.so_line_id = alloc.so_line_id
    WHERE (@datefr   = '' OR CONVERT(varchar(8), st.sodt, 112) >= @datefr)
      AND (@dateto   = '' OR CONVERT(varchar(8), st.sodt, 112) <= @dateto)
      AND (@customer = '' OR c.name LIKE '%' + @customer + '%')
    GROUP BY sti.design_no;

    -- Step 3: comma-separated list of ST nos for remark column
    SELECT
        sti.design_no,
        STUFF((
            SELECT DISTINCT ', ' + st2.sono
            FROM soitm sti2
            INNER JOIN so st2    ON st2.sono = sti2.sono
                AND st2.order_type = 'STOCK'
                AND ISNULL(st2.cancel_status, 0) = 0
            LEFT  JOIN Customers c2 ON c2.custcd = st2.custcd
            WHERE sti2.design_no = sti.design_no
              AND (@datefr   = '' OR CONVERT(varchar(8), st2.sodt, 112) >= @datefr)
              AND (@dateto   = '' OR CONVERT(varchar(8), st2.sodt, 112) <= @dateto)
              AND (@customer = '' OR c2.name LIKE '%' + @customer + '%')
            FOR XML PATH(''), TYPE
        ).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS sono_remark
    INTO #remark
    FROM soitm sti
    INNER JOIN so st ON st.sono = sti.sono
        AND st.order_type = 'STOCK'
        AND ISNULL(st.cancel_status, 0) = 0
    LEFT  JOIN Customers c ON c.custcd = st.custcd
    WHERE (@datefr   = '' OR CONVERT(varchar(8), st.sodt, 112) >= @datefr)
      AND (@dateto   = '' OR CONVERT(varchar(8), st.sodt, 112) <= @dateto)
      AND (@customer = '' OR c.name LIKE '%' + @customer + '%')
    GROUP BY sti.design_no;

    -- Final result
    SELECT
        st.design_no,
        CONVERT(varchar(10), st.last_st_date, 103)     AS last_st_date,
        ISNULL(dm.refdesno, st.design_no)              AS article,
        ISNULL(des.compo, '')                          AS composition,
        st.uom,
        st.total_st_qty                                AS total_greige_booked_yds,
        ISNULL(oc.total_oc_qty, 0)                     AS total_oc_allocated_yds,
        st.total_st_qty - ISNULL(oc.total_oc_qty, 0)  AS balance_greige_yds,
        CAST(0 AS NUMERIC(15, 2))                      AS greige_ready_yds,
        CAST(0 AS NUMERIC(15, 2))                      AS greige_pending_yds,
        ISNULL(r.sono_remark, '')                      AS sono_remark
    FROM #st st
    LEFT  JOIN #oc     oc  ON oc.design_no  = st.design_no
    LEFT  JOIN #remark r   ON r.design_no   = st.design_no
    INNER JOIN dm          ON dm.design_no  = st.design_no
    LEFT  JOIN designs des ON des.design_no = st.design_no
    ORDER BY st.design_no;

    IF OBJECT_ID('tempdb..#st')     IS NOT NULL DROP TABLE #st;
    IF OBJECT_ID('tempdb..#oc')     IS NOT NULL DROP TABLE #oc;
    IF OBJECT_ID('tempdb..#remark') IS NOT NULL DROP TABLE #remark;
END;
GO
