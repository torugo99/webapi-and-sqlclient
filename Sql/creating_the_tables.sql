CREATE TABLE users
(
    user_id UNIQUEIDENTIFIER PRIMARY KEY,
    name VARCHAR (50) NOT NULL,
    email VARCHAR (50) UNIQUE NOT NULL,
    created_at DATETIME2 NOT NULL,
);    
 
CREATE TABLE clients
(    
    client_id UNIQUEIDENTIFIER PRIMARY KEY,
    name VARCHAR (50) NOT NULL,
    user_id UNIQUEIDENTIFIER,
    created_at DATETIME2 NOT NULL,
    FOREIGN KEY (user_id) 
    REFERENCES users (user_id)
);