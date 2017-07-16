
CREATE PROC [dbo].[PersonSelectActive] 
    @PersonId int
AS 

	SELECT * 
	FROM   [dbo].[Person] 
	WHERE  Active = 1 

