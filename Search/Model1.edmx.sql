
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/28/2022 10:16:09
-- Generated from EDMX file: C:\Users\dokki\source\repos\깨끗한나라\Search\Search\Test.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Test];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[TestModelStoreContainer].[Test]', 'U') IS NOT NULL
    DROP TABLE [TestModelStoreContainer].[Test];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Test'
CREATE TABLE [dbo].[Test] (
    [Location] int  NOT NULL,
    [Year] int  NOT NULL,
    [Month] int  NOT NULL,
    [Day] int  NOT NULL,
    [Hour] int  NOT NULL,
    [Minute] int  NOT NULL,
    [Second] int  NOT NULL,
    [Decimal] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Location], [Year], [Month], [Day], [Hour], [Minute], [Second], [Decimal] in table 'Test'
ALTER TABLE [dbo].[Test]
ADD CONSTRAINT [PK_Test]
    PRIMARY KEY CLUSTERED ([Location], [Year], [Month], [Day], [Hour], [Minute], [Second], [Decimal] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------