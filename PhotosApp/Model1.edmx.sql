
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 21:34:05
-- Generated from EDMX file: C:\Users\Paul\source\repos\PhotosApp\PhotosApp\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestPerson];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotoPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_PhotoPerson];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Locatie] nvarchar(max)  NOT NULL,
    [Anotimp] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(max)  NOT NULL,
    [PhotoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotoId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PhotoPerson]
    FOREIGN KEY ([PhotoId])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPerson'
CREATE INDEX [IX_FK_PhotoPerson]
ON [dbo].[People]
    ([PhotoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------