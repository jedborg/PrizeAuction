
CREATE PROC [dbo].[PersonSelectByName] 
    @Name int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT *
	FROM   [dbo].[Person] 
	WHERE  FirstName + LastName like @Name 

	COMMIT

