--users

INSERT users (user_id, name_user, email, created_at) 
VALUES ('668020f4-adbd-4f11-983e-5132262a3e1a', 'Mario', 'mario64@hotmail.com', GETDATE());

INSERT users (user_id, name_user, email, created_at) 
VALUES ('40015849-0914-44a0-be52-bfc8e25f8e78', 'Luigi', 'luigi_0987@hotmail.com', GETDATE());

INSERT users (user_id, name_user, email, created_at) 
VALUES ('4eaf6ea4-8007-483a-80d4-507deaf379b4', 'Peach', 'princess_peach@hotmail.com', GETDATE());

--clients

--Mario's clients

INSERT clients (client_id, name_client, user_id, created_at) 
VALUES ('e89ef5d5-5411-4757-8d77-f3939e14d3c7', 'Client 01', '668020f4-adbd-4f11-983e-5132262a3e1a', GETDATE());

INSERT clients (client_id, name_client, user_id, created_at) 
VALUES ('1eb23824-3fff-4125-902c-27bdf1311fe5', 'Client 02', '668020f4-adbd-4f11-983e-5132262a3e1a', GETDATE());

INSERT clients (client_id, name_client, user_id, created_at) 
VALUES ('4eaf6ea4-8007-483a-80d4-507deaf379b4', 'Client 03', '668020f4-adbd-4f11-983e-5132262a3e1a', GETDATE());

--Luigi's clients

INSERT clients (client_id, name_client, user_id, created_at) 
VALUES ('e09e0c16-5366-483a-b89c-5ba32b413a94', 'Client 01', '40015849-0914-44a0-be52-bfc8e25f8e78', GETDATE());

--Peach's clients
INSERT clients (client_id, name_client, user_id, created_at) 
VALUES ('ea8f1979-3778-497f-93e4-7c0a38c99743', 'Client 01', '4eaf6ea4-8007-483a-80d4-507deaf379b4', GETDATE());