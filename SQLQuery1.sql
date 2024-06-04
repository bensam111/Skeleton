USE [p2708970]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStaff_FilterByStaffId]
		@StaffId = 5

SELECT	@return_value as 'Return Value'

GO
