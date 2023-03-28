CREATE TABLE users
(
    user_id UNIQUEIDENTIFIER PRIMARY KEY,
    name_user VARCHAR (50) NOT NULL,
    email VARCHAR (50) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
);    
 
CREATE TABLE clients
(    
    client_id UNIQUEIDENTIFIER PRIMARY KEY,
    name_client VARCHAR (50) NOT NULL,
    user_id UNIQUEIDENTIFIER NULL,
    created_at DATETIME,
    FOREIGN KEY (user_id) 
    REFERENCES users (user_id)
);