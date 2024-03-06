CREATE TABLE [dbo].[admin] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [image]        IMAGE         NULL,
    [username]     VARCHAR (MAX) NULL,
    [password]     VARCHAR (MAX) NULL,
    [email]        VARCHAR (MAX) NULL,
    [fullname]     VARCHAR (MAX) NULL,
    [date_created] DATE          NULL,
	[usertype]     VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

