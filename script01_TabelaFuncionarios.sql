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

CREATE TABLE [TB_FUNCIONARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Funcao] int NOT NULL,
    [HorasDeServico] int NOT NULL,
    CONSTRAINT [PK_TB_FUNCIONARIOS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Funcao', N'HorasDeServico', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_FUNCIONARIOS]'))
    SET IDENTITY_INSERT [TB_FUNCIONARIOS] ON;
INSERT INTO [TB_FUNCIONARIOS] ([Id], [Funcao], [HorasDeServico], [Nome])
VALUES (1, 2, 8, 'Guilherme'),
(2, 6, 8, 'Jessica'),
(3, 1, 8, 'Leonardo'),
(4, 3, 8, 'Lucas'),
(5, 4, 8, 'Rogerio'),
(6, 5, 8, 'Cleber Machado');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Funcao', N'HorasDeServico', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_FUNCIONARIOS]'))
    SET IDENTITY_INSERT [TB_FUNCIONARIOS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240427201535_InitialCreate', N'8.0.4');
GO

COMMIT;
GO

