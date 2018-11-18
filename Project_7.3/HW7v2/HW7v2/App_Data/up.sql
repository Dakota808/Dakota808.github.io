Create Table [dbo].[SearchLogs]
(
	[ID] int Identity (1,1) not null,
	[RequestTime] Datetime not null,
	[RequestType] nvarchar (100) not null,
	[ClientIp] nvarchar (100) not null,
	[BrowserSearch] nvarchar (200) not null,

	constraint [PK_dbo.SearchLogs] Primary Key clustered ([ID] ASC)


);