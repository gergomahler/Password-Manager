CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [url] NCHAR(100) NOT NULL, 
    [username] NCHAR(30) NULL, 
    [email] NCHAR(50) NULL, 
    [password] NCHAR(30) NOT NULL, 
    [userID] INT NOT NULL, 
    CONSTRAINT [userID] FOREIGN KEY ([userID]) REFERENCES [User]([Id])
)
