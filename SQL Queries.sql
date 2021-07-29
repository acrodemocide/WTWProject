--Duplicate Email Addresses Query

SELECT email FROM Employee GROUP BY email HAVING COUNT(email) > 1

--Greatest Salary Query
SELECT d.name, c.name, c.salary FROM DetailedEmployee a
	JOIN (
		SELECT TOP 1 salary FROM DetailedEmployee WHERE departmentId = 2 GROUP BY salary ORDER BY salary DESC
	) b ON a.salary = b.salary c
	JOIN Department d
	ON c.departmentId = d.departmentId