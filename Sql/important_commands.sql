--delete data from a table

DELETE FROM users

DELETE FROM clients

--deleting the tables

DROP TABLE users

DROP TABLE clients

--fetching data linked to user id, change id only

SELECT 
	c.name_client,
	c.client_id,
	u.name_user,
	u.email
FROM users AS u
INNER JOIN clients AS c
ON c.user_id  = u.user_id
WHERE c.user_id = '668020F4-ADBD-4F11-983E-5132262A3E1A'
