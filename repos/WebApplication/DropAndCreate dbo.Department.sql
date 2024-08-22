USE [Company]
GO

/****** Object: Table [dbo].[Department] Script Date: 20-08-2024 14:12:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Department];


GO
CREATE TABLE [dbo].[Department] (
    [Id]   INT           NOT NULL,
    [Name] VARCHAR (100) NULL,
	CONSTRAINT [PK_Department] PRIMARY KEY (id)
	
);


