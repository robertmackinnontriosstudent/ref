CREATE FUNCTION listEmployees(@locName varchar(40))
RETURNS TABLE AS
RETURN (
SELECT * FROM employee WHERE dept_no IN
(SELECT dept_no from department WHERE location like @locName));
GO
 SELECT * FROM listEmployees('Dallas')
