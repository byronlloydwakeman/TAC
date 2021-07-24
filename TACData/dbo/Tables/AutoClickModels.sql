CREATE TABLE [dbo].[AutoClickModels]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [MinHealth] INT NOT NULL DEFAULT 100, 
    [MinMana] INT NOT NULL DEFAULT 20, 
    [Armor] NVARCHAR(20) NULL, 
    [Accessories] NVARCHAR(100) NULL, 
    [Mount] NVARCHAR(20) NULL,
    [Minions] NVARCHAR(20) NULL,
    [Grapple] NVARCHAR(20) NULL,
    [Potions] NVARCHAR(50) NULL,
    [Buffs] NVARCHAR(50) NULL,
    [Weapons] NVARCHAR(100) NOT NULL, 
    [Boss] NVARCHAR(20) NOT NULL, 
    [Moves] NVARCHAR(MAX) NOT NULL, 
    [Timing] NVARCHAR(MAX) NOT NULL
)
