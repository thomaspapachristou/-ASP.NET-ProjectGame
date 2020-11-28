CREATE TABLE [dbo].[Aventure]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Titre] VARCHAR(250) NOT NULL, 
    [DateCreation] DATETIME NOT NULL DEFAULT (getdate())
)
