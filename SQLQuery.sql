CREATE TABLE [dbo].[admin] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [email]        VARCHAR (MAX) NULL,
    [username]     VARCHAR (MAX) NULL,
    [password]     VARCHAR (MAX) NULL,
    [date_created] DATE          NULL,
	[fullname]	   VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
