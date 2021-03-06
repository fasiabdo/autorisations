-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/21/2022 12:24:18
-- Generated from EDMX file: F:\Csharp programs\auto\auto\ModelPermis.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Autorisation];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Permis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permis];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Permis'
CREATE TABLE [dbo].[Permis] (
    [NDecision] varchar(50)  NOT NULL,
    [NomPrenom] varchar(50)  NOT NULL,
    [Autorisation] varchar(50)  NULL,
    [Reference_Fonciers] varchar(50)  NULL,
    [pv] datetime  NULL,
    [typePermis] varchar(50)  NOT NULL,
    [document] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NDecision] in table 'Permis'
ALTER TABLE [dbo].[Permis]
ADD CONSTRAINT [PK_Permis]
    PRIMARY KEY CLUSTERED ([NDecision] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------