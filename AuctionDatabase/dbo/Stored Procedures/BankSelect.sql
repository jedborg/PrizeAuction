CREATE PROC [dbo].[BankSelect] 
    @BankId int
AS 

	SELECT *
	FROM   [dbo].[Bank] 
	WHERE  ([BankId] = @BankId OR @BankId IS NULL) 

