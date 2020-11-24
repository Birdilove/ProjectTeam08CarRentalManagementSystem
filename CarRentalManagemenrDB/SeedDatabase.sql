/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (1, N'Daphne', N'Bloxam', N'604-218-8579')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (2, N'Wilhelm', N'Hadden', N'778-543-1364')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (3, N'Lance', N'Metzing', N'778-534-1364')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (4, N'Rori', N'Blazek', N'236-913-4963')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (5, N'Wynn', N'Bricksey', N'604-913-4963')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (6, N'Maren', N'Stranl', N'778-953-3006')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (7, N'Lira', N'Phlippsen', N'236-547-1606')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (8, N'Kathrine', N'Weatherhead', N'604-638-8956')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (9, N'Rici', N'Lamas', N'604-283-8953')
INSERT INTO [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [PhoneNumber]) VALUES (10, N'Jorrie', N'Bechley', N'778-478-0961')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO

SET IDENTITY_INSERT [dbo].[CarTypes] ON
INSERT INTO [dbo].[CarTypes] ([TypeId], [Type]) VALUES (1, N'SEDAN')
INSERT INTO [dbo].[CarTypes] ([TypeId], [Type]) VALUES (2, N'SUV')
INSERT INTO [dbo].[CarTypes] ([TypeId], [Type]) VALUES (3, N'HATCHBACK')
INSERT INTO [dbo].[CarTypes] ([TypeId], [Type]) VALUES (4, N'ROADSTER')
INSERT INTO [dbo].[CarTypes] ([TypeId], [Type]) VALUES (5, N'COUPE')
INSERT INTO [dbo].[CarTypes] ([TypeId], [Type]) VALUES (6, N'VAN')
SET IDENTITY_INSERT [dbo].[CarTypes] OFF
GO

SET IDENTITY_INSERT [dbo].[CarMakes] ON
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (1, N'ACURA')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (2, N'AUDI')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (3, N'BMW')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (4, N'CHEVROLET')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (5, N'CHRYSLER')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (6, N'HYUNDAI')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (7, N'HUMMER')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (8, N'INFINITI')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (9, N'JAGUAR')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (10, N'JEEP')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (11, N'MERCEDES-BENZ')
INSERT INTO [dbo].[CarMakes] ([MakeId], [Make]) VALUES (12, N'TESLA')

SET IDENTITY_INSERT [dbo].[CarMakes] OFF
GO

SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (1, 1, 1, N'White', N'AcuraTLX', 2019, 80) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (2, 1, 2, N'Black', N'AudiA8', 2019, 100) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (3, 3, 3, N'Red', N'BmwX7', 2020, 200) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (4, 1, 4, N'White', N'Malibu', 2019, 100) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (5, 1, 5, N'Gray', N'Crysler300', 2019, 80) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (6, 4, 6, N'Blue', N'Veloster', 2020, 100) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (7, 2, 7, N'Black', N'HummerH3', 2019, 80) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (8, 1, 8, N'Gray', N'InfinitiQ50', 2015, 50) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (9, 1, 9, N'Red', N'JaguarXE', 2020, 200) 
INSERT INTO [dbo].[Cars] ([CarId], [TypeId], [MakeId], [Color], [Model], [Year], [Price]) VALUES (10, 2, 10, N'White', N'Cherokee', 2018, 100) 
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO

SET IDENTITY_INSERT [dbo].[Reservations] ON
INSERT INTO [dbo].[Reservations] ([ReservationId], [StartDate], [EndDate], [CustomerId], [CarId], [IsReturend]) VALUES (1, N'2020-11-1', N'2020-11-2', 1, 2, 1)
INSERT INTO [dbo].[Reservations] ([ReservationId], [StartDate], [EndDate], [CustomerId], [CarId], [IsReturend]) VALUES (2, N'2020-11-24', N'2020-11-25', 2, 1, 1)
INSERT INTO [dbo].[Reservations] ([ReservationId], [StartDate], [EndDate], [CustomerId], [CarId], [IsReturend]) VALUES (3, N'2020-11-29', N'2020-11-30', 3, 4, 1)
INSERT INTO [dbo].[Reservations] ([ReservationId], [StartDate], [EndDate], [CustomerId], [CarId], [IsReturend]) VALUES (4, N'2020-12-3', N'2020-12-4', 4, 3, 0)
INSERT INTO [dbo].[Reservations] ([ReservationId], [StartDate], [EndDate], [CustomerId], [CarId], [IsReturend]) VALUES (5, N'2020-12-10', N'2020-12-15', 5, 9, 0)
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO

