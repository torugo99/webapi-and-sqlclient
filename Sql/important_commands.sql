--delete data from a table

DELETE FROM users

DELETE FROM clients

--

SELECT 
c.name,
c.client_id,
u.name,
u.email
FROM clients AS c
INNER JOIN users  AS u
WHERE u.user_id = '668020F4-ADBD-4F11-983E-5132262A3E1A';