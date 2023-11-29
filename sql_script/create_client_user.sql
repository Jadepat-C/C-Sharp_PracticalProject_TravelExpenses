-- Create Login
CREATE LOGIN practicalProjectClient
	WITH PASSWORD = 'client_Login1';
USE [personal]
CREATE USER practicalProjectClient 
	WITH DEFAULT_SCHEMA = [practical-project];
	GRANT UPDATE, INSERT, SELECT, DELETE ON [practical-project].[travelq] TO practicalProjectClient;
GO

-- See user in database
select name as username,
       create_date,
       modify_date,
       type_desc as type,
       authentication_type_desc as authentication_type
from sys.database_principals
where type not in ('A', 'G', 'R', 'X')
      and sid is not null
      and name != 'guest'
order by username;