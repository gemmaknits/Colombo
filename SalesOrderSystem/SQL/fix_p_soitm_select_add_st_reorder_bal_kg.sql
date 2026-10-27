SET NOCOUNT ON;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

IF COL_LENGTH('dbo.soitm', 'st_reorder_bal_kg') IS NULL
BEGIN
    THROW 50001, 'Column dbo.soitm.st_reorder_bal_kg was not found.', 1;
END;

DECLARE @definition nvarchar(max);
DECLARE @updated_definition nvarchar(max);
DECLARE @needle nvarchar(max);
DECLARE @replacement nvarchar(max);

SELECT @definition = OBJECT_DEFINITION(OBJECT_ID(N'dbo.p_soitm_select'));

IF @definition IS NULL
BEGIN
    THROW 50002, 'Procedure dbo.p_soitm_select was not found.', 1;
END;

IF @definition LIKE N'% as st_reorder_bal_kg%'
BEGIN
    PRINT 'dbo.p_soitm_select already returns st_reorder_bal_kg.';
END
ELSE
BEGIN
    SET @needle = N'RTRIM(so.cust_addl_info) cust_addl_info';
    SET @replacement =
        N'cast(isnull(soitm.st_reorder_bal_kg, 0) as numeric(15,2)) as st_reorder_bal_kg,' +
        CHAR(13) + CHAR(10) + CHAR(9) +
        @needle;

    SET @definition = REPLACE(@definition, @needle, @replacement);

    IF @definition = OBJECT_DEFINITION(OBJECT_ID(N'dbo.p_soitm_select'))
    BEGIN
        THROW 50003, 'Could not find insertion point in dbo.p_soitm_select.', 1;
    END;
END;

SET @updated_definition = @definition;
SET @updated_definition = REPLACE(@updated_definition, N'CREATE PROCEDURE', N'ALTER PROCEDURE');
SET @updated_definition = REPLACE(@updated_definition, N'CREATE PROC', N'ALTER PROC');

EXEC sys.sp_executesql @updated_definition;

PRINT 'dbo.p_soitm_select updated with QUOTED_IDENTIFIER ON and st_reorder_bal_kg.';
