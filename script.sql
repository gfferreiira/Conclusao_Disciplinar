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

CREATE TABLE [TB_USUARIOS] (
    [Id] int NOT NULL IDENTITY,
    [UserName] varchar(200) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] varchar(200) NOT NULL,
    [Email] varchar(200) NOT NULL,
    CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TB_FUNCIONARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Funcao] int NOT NULL,
    [HorasDeServico] int NOT NULL,
    [UsuarioId] int NULL,
    CONSTRAINT [PK_TB_FUNCIONARIOS] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_FUNCIONARIOS_TB_USUARIOS_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIOS] ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Funcao', N'HorasDeServico', N'Nome', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[TB_FUNCIONARIOS]'))
    SET IDENTITY_INSERT [TB_FUNCIONARIOS] ON;
INSERT INTO [TB_FUNCIONARIOS] ([Id], [Funcao], [HorasDeServico], [Nome], [UsuarioId])
VALUES (1, 2, 8, 'Guilherme', NULL),
(2, 6, 8, 'Jessica', NULL),
(3, 1, 8, 'Leonardo', NULL),
(4, 3, 8, 'Lucas', NULL),
(5, 4, 8, 'Rogerio', NULL),
(6, 5, 8, 'Cleber Machado', NULL);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Funcao', N'HorasDeServico', N'Nome', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[TB_FUNCIONARIOS]'))
    SET IDENTITY_INSERT [TB_FUNCIONARIOS] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'UserName') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] ON;
INSERT INTO [TB_USUARIOS] ([Id], [DataAcesso], [Email], [Foto], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [Perfil], [UserName])
VALUES (1, NULL, 'seuEmail@gmail.com', NULL, -23.520024100000001E0, -46.596497999999997E0, 0x76D6C80BA3384D8D564851C50C5798CDA0F4E396AF547D66665AB1AF969970ED424429B831CE96A6BB59FAE46D605D7F8DFC13ABFAB498C4DCE62E119A2F1A7E, 0xEB84A7524E561A4323C33DF7ACA45E3043326A4C42D9E73D8628ABF0586D28ADD4E237F8E22B921B39457EC6B355BE6DEF16B127548389D29568476338CFB8938C7D86BED6FDAA7AAA2AB148968E521BB4C9F4A8D766E51FA07A9F8054821011F83E9165AC3AE3CBBC5F446C0E884CD9CF4FCFCBA666AC18B9E4D6CE3813EE6B, 'Admin', 'UsuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'UserName') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] OFF;
GO

CREATE INDEX [IX_TB_FUNCIONARIOS_UsuarioId] ON [TB_FUNCIONARIOS] ([UsuarioId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240626010023_InitialCreate', N'8.0.4');
GO

COMMIT;
GO

