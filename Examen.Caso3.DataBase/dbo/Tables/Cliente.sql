CREATE TABLE [dbo].[Cliente] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Activo]          BIT           NOT NULL,
    [FechaRegistro]   DATETIME      NOT NULL,
    [Nombres]         VARCHAR (250) NOT NULL,
    [Apellidos]       VARCHAR (250) NOT NULL,
    [Correo]          VARCHAR (320) NOT NULL,
    [FechaNacimiento] DATETIME      NULL,
    [Direccion]       VARCHAR (800) NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Cliente_Correo]
    ON [dbo].[Cliente]([Correo] ASC);

