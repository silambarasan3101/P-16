﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Task] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(50) NOT NULL,
    [Description] nvarchar(250) NOT NULL,
    [DueDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Task] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230901105009_EmployeeMig', N'7.0.10');
GO

COMMIT;
GO

