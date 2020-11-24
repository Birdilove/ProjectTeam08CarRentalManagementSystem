CREATE TABLE [dbo].[Reservations]
(
	[ReservationId] INT NOT NULL IDENTITY,
	[StartDate] DATE NOT NULL,
	[EndDate] DATE NOT NULL,
	[CustomerId] INT NOT NULL,
	[CarId] INT NOT NULL,
	[IsReturend] BIT NOT NULL,
	CONSTRAINT [PK_Reservations] PRIMARY KEY ([ReservationId]),
	CONSTRAINT [FK_Reservations_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([CustomerId]),
	CONSTRAINT [FK_Reservations_Car] FOREIGN KEY ([CarId]) REFERENCES [Cars]([CarId])

)
