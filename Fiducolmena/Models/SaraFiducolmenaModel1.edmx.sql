
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/20/2022 11:41:28
-- Generated from EDMX file: C:\Users\Administrator\source\repos\SARA_Fiducolmena\Fiducolmena\Models\SaraFiducolmenaModel1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SARLAFTFIDUCOLMENA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Autorizacion_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autorizacion] DROP CONSTRAINT [FK_Autorizacion_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_Formulario_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Formulario] DROP CONSTRAINT [FK_Formulario_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_Informacion_proyecto_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Informacion_proyecto] DROP CONSTRAINT [FK_Informacion_proyecto_Persona];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[C__BiometricValidationStateDBContext]', 'U') IS NOT NULL
    DROP TABLE [dbo].[C__BiometricValidationStateDBContext];
GO
IF OBJECT_ID(N'[dbo].[Autorizacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autorizacion];
GO
IF OBJECT_ID(N'[dbo].[BiometricValidationState]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BiometricValidationState];
GO
IF OBJECT_ID(N'[dbo].[Formulario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formulario];
GO
IF OBJECT_ID(N'[dbo].[Informacion_proyecto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Informacion_proyecto];
GO
IF OBJECT_ID(N'[dbo].[Persona_fidu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persona_fidu];
GO
IF OBJECT_ID(N'[dbo].[Persona_val]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persona_val];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[vw_informacion_persona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[vw_informacion_persona];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__BiometricValidationStateDBContext'
CREATE TABLE [dbo].[C__BiometricValidationStateDBContext] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Autorizacion'
CREATE TABLE [dbo].[Autorizacion] (
    [id] bigint  NOT NULL,
    [autorizacion_1] bit  NOT NULL,
    [autorizacion_2] bit  NOT NULL,
    [autorizacion_3] bit  NOT NULL,
    [persona_id] varchar(50)  NOT NULL
);
GO

-- Creating table 'BiometricValidationState'
CREATE TABLE [dbo].[BiometricValidationState] (
    [CorrelationId] uniqueidentifier  NOT NULL,
    [CurrentState] nvarchar(64)  NULL,
    [Version] int  NOT NULL,
    [RequestNumber] nvarchar(50)  NULL,
    [IdentificationType] nvarchar(max)  NULL,
    [IdentificationNumber] nvarchar(max)  NULL,
    [FirstName] nvarchar(max)  NULL,
    [MiddleName] nvarchar(max)  NULL,
    [FirstSurname] nvarchar(max)  NULL,
    [SecondSurname] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [CellPhoneNumber] nvarchar(max)  NULL,
    [TelephoneNumber] nvarchar(max)  NULL,
    [Unit] nvarchar(max)  NULL,
    [Product] nvarchar(max)  NULL,
    [UserInformationReceived] datetime  NULL,
    [UserInformationStored] datetime  NULL,
    [EmailToValidationSended] datetime  NULL,
    [IdentityValidationReceived] datetime  NULL,
    [IdentityValidationSended] datetime  NULL,
    [DocumentsToSignReceived] datetime  NULL,
    [DocumentsToSignSended] datetime  NULL,
    [DocumentsSignedReceived] datetime  NULL,
    [DocumentsSignedStored] datetime  NULL,
    [SignatureStampsGenerated] bit  NOT NULL,
    [SignatureEvidenceGenerated] bit  NOT NULL,
    [SignatureIntegrationServiceData] nvarchar(max)  NULL,
    [Error] nvarchar(max)  NULL,
    [DateExpiry] datetime  NULL
);
GO

-- Creating table 'Formulario'
CREATE TABLE [dbo].[Formulario] (
    [id] bigint  NOT NULL,
    [fecha_diligenciamiento] datetime  NOT NULL,
    [nombre_proceso] varchar(50)  NOT NULL,
    [persona_id] varchar(50)  NOT NULL
);
GO

-- Creating table 'Informacion_proyecto'
CREATE TABLE [dbo].[Informacion_proyecto] (
    [id] bigint  NOT NULL,
    [producto] varchar(50)  NOT NULL,
    [numero_encargo] bigint  NOT NULL,
    [ciudad] varchar(50)  NOT NULL,
    [inmueble] varchar(50)  NOT NULL,
    [unidad] varchar(50)  NOT NULL,
    [torre] varchar(50)  NOT NULL,
    [valor_inmueble] bigint  NOT NULL,
    [cantidad_garage] bigint  NOT NULL,
    [cantidad_depositos] bigint  NOT NULL,
    [valor_cuota_inicial] bigint  NOT NULL,
    [persona_id] varchar(50)  NOT NULL,
    [Num_Enc_Fijo] bigint  NOT NULL
);
GO

-- Creating table 'Persona_fidu'
CREATE TABLE [dbo].[Persona_fidu] (
    [identificacion] varchar(50)  NOT NULL,
    [tipo_identificacion] varchar(50)  NOT NULL,
    [fecha_expedicion] datetime  NULL,
    [primer_nombre] varchar(50)  NULL,
    [segundo_nombre] varchar(50)  NULL,
    [primer_apellido] varchar(50)  NULL,
    [segundo_apellido] varchar(50)  NULL,
    [enroll] varchar(50)  NOT NULL
);
GO

-- Creating table 'Persona_val'
CREATE TABLE [dbo].[Persona_val] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IDENTIFICATION_NUMBER] varchar(50)  NOT NULL,
    [ID_IDENTIFICATION_TYPE] varchar(20)  NULL,
    [FIRST_NAME] varchar(50)  NOT NULL,
    [MIDDLE_NAME] varchar(50)  NOT NULL,
    [FIRST_SURNAME] varchar(50)  NOT NULL,
    [SECOND_SURNAME] varchar(50)  NOT NULL,
    [MAIL_ADDRESS] varchar(150)  NULL,
    [TELEPHONE_NUMBER] varchar(15)  NULL,
    [CELLPHONE_NUMBER] varchar(15)  NULL,
    [REQUEST_NUMBER] varchar(50)  NOT NULL,
    [PRODUCT] varchar(50)  NULL,
    [UNIT] varchar(50)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'vw_informacion_persona'
CREATE TABLE [dbo].[vw_informacion_persona] (
    [identificacion] varchar(50)  NOT NULL,
    [tipo_identificacion] varchar(50)  NOT NULL,
    [fecha_expedicion] datetime  NULL,
    [primer_nombre] varchar(50)  NULL,
    [segundo_nombre] varchar(50)  NULL,
    [primer_apellido] varchar(50)  NULL,
    [segundo_apellido] varchar(50)  NULL,
    [autorizacion_1] bit  NOT NULL,
    [autorizacion_2] bit  NOT NULL,
    [autorizacion_3] bit  NOT NULL,
    [producto] varchar(50)  NOT NULL,
    [numero_encargo] bigint  NOT NULL,
    [ciudad] varchar(50)  NOT NULL,
    [inmueble] varchar(50)  NOT NULL,
    [unidad] varchar(50)  NOT NULL,
    [torre] varchar(50)  NOT NULL,
    [valor_inmueble] bigint  NOT NULL,
    [cantidad_garage] bigint  NOT NULL,
    [cantidad_depositos] bigint  NOT NULL,
    [valor_cuota_inicial] bigint  NOT NULL,
    [fecha_diligenciamiento] datetime  NOT NULL,
    [nombre_proceso] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId] in table 'C__BiometricValidationStateDBContext'
ALTER TABLE [dbo].[C__BiometricValidationStateDBContext]
ADD CONSTRAINT [PK_C__BiometricValidationStateDBContext]
    PRIMARY KEY CLUSTERED ([MigrationId] ASC);
GO

-- Creating primary key on [id] in table 'Autorizacion'
ALTER TABLE [dbo].[Autorizacion]
ADD CONSTRAINT [PK_Autorizacion]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [CorrelationId] in table 'BiometricValidationState'
ALTER TABLE [dbo].[BiometricValidationState]
ADD CONSTRAINT [PK_BiometricValidationState]
    PRIMARY KEY CLUSTERED ([CorrelationId] ASC);
GO

-- Creating primary key on [id] in table 'Formulario'
ALTER TABLE [dbo].[Formulario]
ADD CONSTRAINT [PK_Formulario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Informacion_proyecto'
ALTER TABLE [dbo].[Informacion_proyecto]
ADD CONSTRAINT [PK_Informacion_proyecto]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [identificacion] in table 'Persona_fidu'
ALTER TABLE [dbo].[Persona_fidu]
ADD CONSTRAINT [PK_Persona_fidu]
    PRIMARY KEY CLUSTERED ([identificacion] ASC);
GO

-- Creating primary key on [IDENTIFICATION_NUMBER] in table 'Persona_val'
ALTER TABLE [dbo].[Persona_val]
ADD CONSTRAINT [PK_Persona_val]
    PRIMARY KEY CLUSTERED ([IDENTIFICATION_NUMBER] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [identificacion], [tipo_identificacion], [autorizacion_1], [autorizacion_2], [autorizacion_3], [producto], [numero_encargo], [ciudad], [inmueble], [unidad], [torre], [valor_inmueble], [cantidad_garage], [cantidad_depositos], [valor_cuota_inicial], [fecha_diligenciamiento], [nombre_proceso] in table 'vw_informacion_persona'
ALTER TABLE [dbo].[vw_informacion_persona]
ADD CONSTRAINT [PK_vw_informacion_persona]
    PRIMARY KEY CLUSTERED ([identificacion], [tipo_identificacion], [autorizacion_1], [autorizacion_2], [autorizacion_3], [producto], [numero_encargo], [ciudad], [inmueble], [unidad], [torre], [valor_inmueble], [cantidad_garage], [cantidad_depositos], [valor_cuota_inicial], [fecha_diligenciamiento], [nombre_proceso] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [persona_id] in table 'Autorizacion'
ALTER TABLE [dbo].[Autorizacion]
ADD CONSTRAINT [FK_Autorizacion_Persona]
    FOREIGN KEY ([persona_id])
    REFERENCES [dbo].[Persona_fidu]
        ([identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Autorizacion_Persona'
CREATE INDEX [IX_FK_Autorizacion_Persona]
ON [dbo].[Autorizacion]
    ([persona_id]);
GO

-- Creating foreign key on [persona_id] in table 'Formulario'
ALTER TABLE [dbo].[Formulario]
ADD CONSTRAINT [FK_Formulario_Persona]
    FOREIGN KEY ([persona_id])
    REFERENCES [dbo].[Persona_fidu]
        ([identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Formulario_Persona'
CREATE INDEX [IX_FK_Formulario_Persona]
ON [dbo].[Formulario]
    ([persona_id]);
GO

-- Creating foreign key on [persona_id] in table 'Informacion_proyecto'
ALTER TABLE [dbo].[Informacion_proyecto]
ADD CONSTRAINT [FK_Informacion_proyecto_Persona]
    FOREIGN KEY ([persona_id])
    REFERENCES [dbo].[Persona_fidu]
        ([identificacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Informacion_proyecto_Persona'
CREATE INDEX [IX_FK_Informacion_proyecto_Persona]
ON [dbo].[Informacion_proyecto]
    ([persona_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------