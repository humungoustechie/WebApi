CREATE TABLE [Milkman].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(50) NOT NULL, 
    [Firstname] VARCHAR(30) NOT NULL, 
    [Surname] VARCHAR(30) NOT NULL, 
    [Title] VARCHAR(15) NULL, 
    [Email] VARCHAR(100) NOT NULL
)
