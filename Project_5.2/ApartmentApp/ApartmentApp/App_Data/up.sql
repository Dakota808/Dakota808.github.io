﻿--Users Table Request Forms
Create Table [dbo].[Requests]
(
	[ID] int identity (1,1) not null,
	[FirstName] Nvarchar(64) not null,
	[LastName] Nvarchar(64) not null,
	[PhoneNumber] Nvarchar(12) not null,
	[ApartmentName] Nvarchar(64) not null,
	[Unit] int not null,
	[RequestReport] Nvarchar(256) not null,
	[RequestTime] Datetime not null,
	[SubmitRequest] bit not null,
	Constraint [PK.dbo.Requests] Primary Key Clustered ([ID] ASC)

);

Insert Into [dbo].[Requests] (FirstName, LastName, PhoneNumber, ApartmentName, Unit, RequestReport, RequestTime, SubmitRequest) Values
('Jake', 'Collins', '808-694-2289', 'Alamoana Apartments', 302, 'Need to have someone check our smoke deterctors are functioning', '2018-08-24', 0),
('Aichi', 'Sendou', '808-551-2750', 'Mililani Apartments', 442, 'Requesting for cleaners to come in and clean for my new roommate', '2018-09-18', 1),
('Kai', 'Toshiki', '520-678-1180', 'Mililani Apartments', 442, 'Moving into the apartment on september 30th, 2018', '2018-09-18', 1),
('Tess', 'Chandler', '510-467-1267', 'Colonial Apartments', 102, 'Need the floors replaced in the apartment.', '2018-10-21', 1),
('Misaki', 'Tokura', '405-635-7659', 'Waikiki Apartments', 202, 'Bathroom pluming fixture, and replace shower head', '2018-11-04', 0)
Go