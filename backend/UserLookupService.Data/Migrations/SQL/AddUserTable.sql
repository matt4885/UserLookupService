IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
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

CREATE TABLE [User] (
    [Id] uniqueidentifier NOT NULL,
    [GivenName] nvarchar(50) NOT NULL,
    [FamilyName] nvarchar(50) NOT NULL,
    [Email] nvarchar(128) NOT NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [Address] nvarchar(95) NOT NULL,
    [State] nvarchar(15) NOT NULL,
    [ZipCode] nvarchar(12) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220123190159_AddUserTable', N'6.0.1');
GO

COMMIT;
GO