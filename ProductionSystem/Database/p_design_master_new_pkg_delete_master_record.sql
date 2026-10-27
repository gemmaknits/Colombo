-- =============================================
-- Author        : Programmer
-- Create date   : 18/09/2026
-- Last Modified : 18/09/2026
-- Description   : Delete an unused Design Master and preserve its audit history.
-- Execute1      : dbo.p_design_master_new_pkg_delete_master_record
-- =============================================
CREATE PROCEDURE dbo.p_design_master_new_pkg_delete_master_record
    @p_item_id bigint,
    @p_design_no varchar(20),
    @p_log_empcd varchar(20)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET LOCK_TIMEOUT 10000;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Enforce the existing Design Master edit permission on the server too.
        IF NULLIF(LTRIM(RTRIM(@p_log_empcd)), '') IS NULL
           OR NOT EXISTS (SELECT 1 FROM dbo.Userrole WITH (HOLDLOCK)
                          WHERE empcd = @p_log_empcd AND Roleid = 'R0003')
            THROW 51000, 'Permission denied: Design Master edit permission is required.', 1;

        DECLARE @design_no varchar(20);
        SELECT @design_no = RTRIM(Design_no)
        FROM dbo.dm WITH (UPDLOCK, HOLDLOCK)
        WHERE item_id = @p_item_id;
        IF @design_no IS NULL OR @design_no <> @p_design_no
            THROW 51001, 'Design no longer exists or has changed. Reload it before deleting.', 1;

        -- Do not delete inconsistent specifications or silently cascade new relationships.
        IF EXISTS (SELECT 1 FROM dbo.designs WITH (UPDLOCK, HOLDLOCK)
                   WHERE (Design_no = @design_no AND item_id IS NOT NULL AND item_id <> @p_item_id)
                      OR (item_id = @p_item_id AND Design_no <> @design_no))
            THROW 51002, 'Design specification identity is inconsistent. Contact support.', 1;
        IF EXISTS (SELECT 1 FROM sys.foreign_keys
                   WHERE referenced_object_id IN (OBJECT_ID('dbo.dm'), OBJECT_ID('dbo.designs'))
                     AND delete_referential_action <> 0)
            THROW 51003, 'A cascading Design relationship requires review before deletion.', 1;

        IF EXISTS (SELECT 1 FROM dbo.dm WITH (UPDLOCK, HOLDLOCK)
                   WHERE parent_design = @design_no AND item_id <> @p_item_id)
            THROW 51004, 'Design is used as a parent by another Design Master.', 1;

        -- Legacy business tables often have no foreign keys. Check both their item IDs
        -- and design codes, including BOM components, orders, stock and attachments.
        -- Business history is included, but migration/backup/work tables are not live
        -- references. HOLDLOCK retains reference-range locks until commit.
        DECLARE @references TABLE (table_name nvarchar(517), column_name sysname, by_id bit);
        INSERT @references
        SELECT QUOTENAME(s.name) + '.' + QUOTENAME(t.name), c.name,
               CASE WHEN ty.name IN ('bigint','int','smallint','numeric','decimal') THEN 1 ELSE 0 END
        FROM sys.tables t
        JOIN sys.schemas s ON s.schema_id = t.schema_id
        JOIN sys.columns c ON c.object_id = t.object_id
        JOIN sys.types ty ON ty.user_type_id = c.user_type_id
        WHERE t.is_ms_shipped = 0
          AND t.name NOT LIKE '[_]%'
          AND t.name NOT LIKE '%bak%'
          AND t.name NOT LIKE 'mig[_]%'
          AND t.name NOT LIKE 'temp[_]%'
          AND t.name NOT LIKE '%[_]bk%'
          AND t.name NOT LIKE '%[_]snap[_]%'
          AND t.object_id NOT IN (OBJECT_ID('dbo.dm'), OBJECT_ID('dbo.designs'),
                                 OBJECT_ID('dbo.dm_log'), OBJECT_ID('dbo.designs_log'))
          AND ((ty.name IN ('char','varchar','nchar','nvarchar')
                AND (c.name LIKE '%design_no%' OR c.name IN
                     ('itcd','design','design_c','design_y','design_cross','design_ver',
                      'parent_design','design_fg','source_doc_number')))
               OR (ty.name IN ('bigint','int','smallint','numeric','decimal')
                   AND (c.name = 'item_id' OR c.name LIKE '%[_]item_id')));

        -- Include declared references even when their column naming differs.
        INSERT @references
        SELECT QUOTENAME(OBJECT_SCHEMA_NAME(f.parent_object_id)) + '.' + QUOTENAME(OBJECT_NAME(f.parent_object_id)),
               COL_NAME(f.parent_object_id, f.parent_column_id),
               CASE WHEN COL_NAME(f.referenced_object_id, f.referenced_column_id) = 'item_id' THEN 1 ELSE 0 END
        FROM sys.foreign_key_columns f
        WHERE f.referenced_object_id = OBJECT_ID('dbo.dm')
          AND f.parent_object_id <> OBJECT_ID('dbo.designs')
          AND COL_NAME(f.referenced_object_id, f.referenced_column_id) IN ('item_id','Design_no');

        DECLARE @table nvarchar(517), @column sysname, @by_id bit,
                @sql nvarchar(max), @used bit, @message nvarchar(2048);
        DECLARE reference_cursor CURSOR LOCAL FAST_FORWARD FOR
            SELECT DISTINCT table_name, column_name, by_id FROM @references
            ORDER BY table_name, column_name;
        OPEN reference_cursor;
        FETCH NEXT FROM reference_cursor INTO @table, @column, @by_id;
        WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @used = 0;
            SET @sql = N'IF EXISTS (SELECT 1 FROM ' + @table + N' WITH (HOLDLOCK) WHERE '
                       + QUOTENAME(@column) + CASE WHEN @by_id = 1 THEN N' = @id' ELSE N' = @code' END
                       + N') SET @found = 1;';
            EXEC sys.sp_executesql @sql, N'@id bigint, @code varchar(20), @found bit OUTPUT',
                 @id = @p_item_id, @code = @design_no, @found = @used OUTPUT;
            IF @used = 1
            BEGIN
                SET @message = N'Cannot delete Design ' + @design_no + N': referenced by '
                             + @table + N'.' + QUOTENAME(@column) + N'.';
                THROW 51005, @message, 1;
            END;
            FETCH NEXT FROM reference_cursor INTO @table, @column, @by_id;
        END;
        CLOSE reference_cursor;
        DEALLOCATE reference_cursor;

        -- Record the original master/specification and actor before deleting either row.
        EXEC dbo.log_dm @p_log_empcd, @p_item_id, 'DEL';
        DELETE FROM dbo.designs WHERE Design_no = @design_no;
        DELETE FROM dbo.dm WHERE item_id = @p_item_id AND Design_no = @design_no;
        IF @@ROWCOUNT <> 1
            THROW 51006, 'Design was not deleted. The transaction has been rolled back.', 1;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
