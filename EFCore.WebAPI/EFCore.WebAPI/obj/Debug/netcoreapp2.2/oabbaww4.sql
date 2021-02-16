IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Dependentes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [DtNascimento] datetime2 NOT NULL,
    CONSTRAINT [PK_Dependentes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Enderecos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Pessoas] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [EnderecoId] int NOT NULL,
    [DependenteId] int NOT NULL,
    [DtNascimento] datetime2 NOT NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pessoas_Dependentes_DependenteId] FOREIGN KEY ([DependenteId]) REFERENCES [Dependentes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Pessoas_Enderecos_EnderecoId] FOREIGN KEY ([EnderecoId]) REFERENCES [Enderecos] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Pessoas_DependenteId] ON [Pessoas] ([DependenteId]);

GO

CREATE INDEX [IX_Pessoas_EnderecoId] ON [Pessoas] ([EnderecoId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210216013407_initial', N'2.2.6-servicing-10079');

GO

