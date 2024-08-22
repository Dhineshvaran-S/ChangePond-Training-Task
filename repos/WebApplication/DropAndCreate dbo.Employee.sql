USE [Company]
GO

/****** Object: Table [dbo].[Employee] Script Date: 20-08-2024 14:20:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Employee];


GO
CREATE TABLE [dbo].[Employee] (
    [Id]           INT           NOT NULL,
    [Departmentid] INT           NULL,
    [Name]         VARCHAR (100) NULL,
    [Designation ] VARCHAR (25)  NULL,
	constraint pk_employee primary key (id)
);


