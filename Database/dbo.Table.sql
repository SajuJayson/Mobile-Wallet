CREATE TABLE [dbo].[CustomerInfo]
(
	[CustomerID] INT NOT NULL  IDENTITY(1000, 1), 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Email] VARCHAR(100) NOT NULL UNIQUE, 
    [AccountNo] INT NOT NULL, 
    PRIMARY KEY ([CustomerID])
)
