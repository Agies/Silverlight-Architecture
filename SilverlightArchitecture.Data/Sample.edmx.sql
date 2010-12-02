
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/01/2010 07:04:08
-- Generated from EDMX file: C:\Code\Silverlight-Architecture\SilverlightArchitecture.Data\Sample.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sample];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BusinessBases'
CREATE TABLE [dbo].[BusinessBases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedDate] datetime  NOT NULL
);
GO

-- Creating table 'BusinessBases_Entity'
CREATE TABLE [dbo].[BusinessBases_Entity] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'BusinessBases_Address'
CREATE TABLE [dbo].[BusinessBases_Address] (
    [EntityId] int  NOT NULL,
    [Address1] nvarchar(max)  NOT NULL,
    [Address2] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'BusinessBases_Company'
CREATE TABLE [dbo].[BusinessBases_Company] (
    [CompanyId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'BusinessBases_Person'
CREATE TABLE [dbo].[BusinessBases_Person] (
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BusinessBases'
ALTER TABLE [dbo].[BusinessBases]
ADD CONSTRAINT [PK_BusinessBases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinessBases_Entity'
ALTER TABLE [dbo].[BusinessBases_Entity]
ADD CONSTRAINT [PK_BusinessBases_Entity]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinessBases_Address'
ALTER TABLE [dbo].[BusinessBases_Address]
ADD CONSTRAINT [PK_BusinessBases_Address]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinessBases_Company'
ALTER TABLE [dbo].[BusinessBases_Company]
ADD CONSTRAINT [PK_BusinessBases_Company]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinessBases_Person'
ALTER TABLE [dbo].[BusinessBases_Person]
ADD CONSTRAINT [PK_BusinessBases_Person]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EntityId] in table 'BusinessBases_Address'
ALTER TABLE [dbo].[BusinessBases_Address]
ADD CONSTRAINT [FK_EntityAddress]
    FOREIGN KEY ([EntityId])
    REFERENCES [dbo].[BusinessBases_Entity]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntityAddress'
CREATE INDEX [IX_FK_EntityAddress]
ON [dbo].[BusinessBases_Address]
    ([EntityId]);
GO

-- Creating foreign key on [CompanyId] in table 'BusinessBases_Company'
ALTER TABLE [dbo].[BusinessBases_Company]
ADD CONSTRAINT [FK_CompanyCompany]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[BusinessBases_Company]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyCompany'
CREATE INDEX [IX_FK_CompanyCompany]
ON [dbo].[BusinessBases_Company]
    ([CompanyId]);
GO

-- Creating foreign key on [Id] in table 'BusinessBases_Entity'
ALTER TABLE [dbo].[BusinessBases_Entity]
ADD CONSTRAINT [FK_Entity_inherits_BusinessBase]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BusinessBases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BusinessBases_Address'
ALTER TABLE [dbo].[BusinessBases_Address]
ADD CONSTRAINT [FK_Address_inherits_BusinessBase]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BusinessBases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BusinessBases_Company'
ALTER TABLE [dbo].[BusinessBases_Company]
ADD CONSTRAINT [FK_Company_inherits_Entity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BusinessBases_Entity]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BusinessBases_Person'
ALTER TABLE [dbo].[BusinessBases_Person]
ADD CONSTRAINT [FK_Person_inherits_Entity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BusinessBases_Entity]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------