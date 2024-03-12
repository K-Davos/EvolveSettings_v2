CREATE TABLE [dbo].[encryptor] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [filename]     VARCHAR (MAX) NULL,
    [password]     VARCHAR (MAX) NULL,
	[description]  VARCHAR (MAX) NULL,
    [location]     VARCHAR (MAX) NULL,
    [date_created] DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

