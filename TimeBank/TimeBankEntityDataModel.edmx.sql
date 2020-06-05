
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/26/2020 19:37:47
-- Generated from EDMX file: C:\Users\josep\OneDrive\Documentos\UOC\FP\P6\Proyecto\TimeBank\TimeBank\TimeBankEntityDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TimeBank];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_users_consumer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Activity] DROP CONSTRAINT [fk_users_consumer];
GO
IF OBJECT_ID(N'[dbo].[fk_users_producer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Activity] DROP CONSTRAINT [fk_users_producer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Activity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activity];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Activities'
CREATE TABLE [dbo].[Activities] (
    [activityId] int IDENTITY(1,1) NOT NULL,
    [activityName] varchar(100)  NOT NULL,
    [hours] int  NOT NULL,
    [activityDate] datetime  NOT NULL,
    [userConsumer] int  NOT NULL,
    [userProducer] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [userId] int IDENTITY(1,1) NOT NULL,
    [userName] varchar(100)  NOT NULL,
    [phone] varchar(100)  NOT NULL,
    [email] varchar(100)  NOT NULL,
    [hours] int  NOT NULL,
    [password] varchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [activityId] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [PK_Activities]
    PRIMARY KEY CLUSTERED ([activityId] ASC);
GO

-- Creating primary key on [userId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([userId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [userConsumer] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [fk_users_consumer]
    FOREIGN KEY ([userConsumer])
    REFERENCES [dbo].[People]
        ([userId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_users_consumer'
CREATE INDEX [IX_fk_users_consumer]
ON [dbo].[Activities]
    ([userConsumer]);
GO

-- Creating foreign key on [userProducer] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [fk_users_producer]
    FOREIGN KEY ([userProducer])
    REFERENCES [dbo].[People]
        ([userId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_users_producer'
CREATE INDEX [IX_fk_users_producer]
ON [dbo].[Activities]
    ([userProducer]);
GO

-- Creating some users
insert into Person (userName, phone, email, hours, password)
values ('Marcos', '666777888', 'marcos@mail.com', 5, 'marcospass')

insert into Person (userName, phone, email, hours, password)
values ('Helena', '678123456', 'helena@mail.com', 10, 'helenapass')

insert into Person (userName, phone, email, hours, password)
values ('Marta', '612783233', 'marta@mail.com', 15, 'martapass')

-- Creating some Activities

insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A1 C: MARCOS P: HELENA', 5, getdate(), 1, 2)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A2 C: HELENA P: MARTA', 5, getdate(), 2, 3)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A3 C: MARCOS P: MARCOS', 5, getdate(), 1, 1)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A4 C: HELENA P: HELENA', 5, getdate(), 2, 2)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A5 C: MARTA P: MARTA', 5, getdate(), 3, 3)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A6 C: MARTA P: MARCOS', 5, getdate(), 3, 1)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A7 C: MARTA P: MARCOS', 5, getdate(), 3, 1)

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------