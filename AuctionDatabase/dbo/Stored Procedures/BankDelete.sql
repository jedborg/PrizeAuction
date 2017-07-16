CREATE PROC [dbo].[BankDelete] 
    @BankId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Bank]
	WHERE  [BankId] = @BankId

	COMMIT
