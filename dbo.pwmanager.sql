CREATE TABLE [dbo].[pwmanager] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
	[image]        IMAGE         NULL,
	[recordname]   VARCHAR (MAX) NULL,
    [email]        VARCHAR (MAX) NULL,
    [username]     VARCHAR (MAX) NULL,
    [password]     VARCHAR (MAX) NULL,
    [date_created] DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

