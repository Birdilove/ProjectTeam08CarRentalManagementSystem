CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[PhoneNumber] NVARCHAR(15) NOT NULL,
	CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
)
