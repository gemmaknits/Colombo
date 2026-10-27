-- Fix: Add PLD (packno) branch to p_stock_d_barcode_rep
-- Problem: SP does not handle packno (PLD number) from strolls_d_o
-- Added: 2026-06-22

ELSE IF EXISTS (
    SELECT roll_no_d
    FROM strolls_d_o
    WHERE isnull(packno,'') = @roll_no
        AND isnull(packno,'') <> ''
        AND isnull(@loc,'') = ''
)
BEGIN

    INSERT INTO #strockdbarcode
    (dinno, dindt, dfno, jobno, design_no, compo, Labeldes, article, gwth, fwth,
     grade, color, custcolor, custcolor_one_line, loc, lot, roll_no_o, roll_no_d, cartno,
     kg, mts, yds, sonoid, pono, sono, mts_issued, gross_mts, gross_wt_kg)

    SELECT  rtrim(din.dinno) as dinno,
            convert(varchar(10),din.dindt,103) as dindt,
            rtrim(din.dfno) as dfno,
            rtrim(din.lot) as jobno,
            rtrim(din.design_no) as design_no,
            rtrim(dm.compo_for_tag) cust_design_no,
            rtrim(soitm.Labeldes) as Labeldes,
            rtrim(dm.refdesno) as article,
            rtrim(din.gwth) as gwth,
            rtrim(din.fwth) as fwth,
            rtrim(din.gr) as grade,
            rtrim(din.col) as color,
            substring(rtrim(din.custcolor), 1, 6) + char(13) + rtrim(ltrim(substring(rtrim(din.custcolor), 7, 100))) as custcolor,
            substring(rtrim(din.custcolor), 1, 6) + rtrim(ltrim(substring(rtrim(din.custcolor), 7, 100))) as custcolor_one_line,
            rtrim(din.loc) as loc,
            din.lot lot,
            rtrim(din.roll_no_o) as roll_no_o,
            '*' + rtrim(din.roll_no_d) + '*' as roll_no_d,
            rtrim(din.roll_no_o) cartno,
            cast(dout.kg as numeric(10,2)) as kg,
            cast(dout.mts as numeric(10,2)) as mts,
            cast(dout.yds as numeric(10,2)) as yds,
            dout.sonoid,
            rtrim(so.custpo) pono,
            rtrim(so.sono) sono,
            din.mts_issued,
            din.gross_mts,
            din.gross_wt_kg

    FROM strolls_d_o dout
    LEFT JOIN strolls_d din ON din.roll_no_d = dout.roll_no_d
    LEFT JOIN dm ON din.design_no = dm.design_no
    LEFT JOIN soitm ON soitm.sonoid = dout.sonoid
    LEFT JOIN so ON soitm.sono = so.sono
    WHERE dout.packno = @roll_no

    ORDER BY din.roll_no_d

    PRINT '%DOUT WITH PACK NO (PLD)'

END
