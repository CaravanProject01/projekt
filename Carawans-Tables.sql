/*
**		Caravans - Database
**
** Kod generujacy tabeli bazy danych.
** Wszystkie tabeli sa ulozone w kolejnosci tworzenia
*/

CREATE TABLE [dbo].[State] (
    [IdState]     UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]        VARCHAR (50)     NULL,							/*Nazwa*/
    [Descripcion] VARCHAR (500)    NULL,							/*Opis*/
    [ShortDes] VARCHAR(100) NULL,									/*Krotki opis*/
    PRIMARY KEY CLUSTERED ([IdState] ASC)
);
/*Tabela stanow*/


CREATE TABLE [dbo].[Article] (
    [IdArticle]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]        VARCHAR(50)              NULL,					/*Nazwa*/
    [Price]       INT              NULL,							/*Cena*/
    [Prod]        INT              NULL,							/*Produkcja*/
    [Requisition] INT              NULL,							/*Zapotrzebowanie*/
    PRIMARY KEY CLUSTERED ([IdArticle] ASC)
);
/*Tabela towarow*/


CREATE TABLE [dbo].[Locs] (
    [IdLoc] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]  VARCHAR (50)     NULL,									/*Nazwa*/
    PRIMARY KEY CLUSTERED ([IdLoc] ASC)
);
/*Tabela lokacje*/


CREATE TABLE [dbo].[Roads] (
    [IdRoad]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdLoc_1] UNIQUEIDENTIFIER NOT NULL,
    [IdLoc_2] UNIQUEIDENTIFIER NOT NULL,
    [Length]  INT              DEFAULT ((1)) NOT NULL,
    [Name] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([IdRoad] ASC),
    CONSTRAINT [FK_Roads_ToLocs_1] FOREIGN KEY ([IdLoc_1]) REFERENCES [dbo].[Locs] ([IdLoc]),
    CONSTRAINT [FK_Roads_ToLocs_2] FOREIGN KEY ([IdLoc_2]) REFERENCES [dbo].[Locs] ([IdLoc])
);
/*Tabela drog*/


CREATE TABLE [dbo].[Caravan] (
    [IdCaravan] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdLoc]     UNIQUEIDENTIFIER NOT NULL,							/*Klucz obcy Lokacji*/
    [Wagons]    INT              DEFAULT ((1)) NOT NULL,			/*Wozy*/
    [Guard]     INT              DEFAULT ((0)) NOT NULL,			/*Ochroniarzy*/
    [Duration]  INT              DEFAULT ((0)) NOT NULL,			/*Trwanie*/
    [Minions]   INT              DEFAULT ((0)) NOT NULL,			/*Pacholkowie*/
    PRIMARY KEY CLUSTERED ([IdCaravan] ASC),
    CONSTRAINT [FK_Caravan_ToLocs] FOREIGN KEY ([IdLoc]) REFERENCES [dbo].[Locs] ([IdLoc])
);
/*Tabela karawany*/


CREATE TABLE [dbo].[Town] (
    [IdTown]     UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]       VARCHAR (50)     DEFAULT ('NewTown') NOT NULL,		/*Nazwa*/
    [Population] INT              DEFAULT ((1)) NOT NULL,			/*Populacja*/
    [IdLoc]      UNIQUEIDENTIFIER NOT NULL,							/*Klucz obcy Lokacji*/
    [Military]   INT              DEFAULT ((0)) NOT NULL,			/*Gotownosc wojenna*/
    [Prosperity] INT              DEFAULT ((0)) NOT NULL,			/*Dobrobyt*/
    [Food]       INT              DEFAULT ((1)) NOT NULL,			/*Zywnosc*/
    PRIMARY KEY CLUSTERED ([IdTown] ASC),
    CONSTRAINT [FK_Town_ToLocs] FOREIGN KEY ([IdLoc]) REFERENCES [dbo].[Locs] ([IdLoc])
);
/*Tabela miast*/


CREATE TABLE [dbo].[Art_in_Town] (
    [IdTown]      UNIQUEIDENTIFIER NOT NULL,						/*Klucz obcy Miasta*/
    [IdArticle]   UNIQUEIDENTIFIER NOT NULL,						/*Klucz obcy Towaru*/
    [Number]      INT              DEFAULT ((0)) NOT NULL,			/*Ilosc*/
    [Requisition] INT              DEFAULT ((1)) NOT NULL,			/*Zapotrzebowanie*/
    [Production]  INT              DEFAULT ((0)) NOT NULL,			/*Produkcja*/
    CONSTRAINT [FK_Art_in_Town_ToArticle] FOREIGN KEY ([IdArticle]) REFERENCES [dbo].[Article] ([IdArticle]),
    CONSTRAINT [FK_Art_in_Town_ToTown] FOREIGN KEY ([IdTown]) REFERENCES [dbo].[Town] ([IdTown])
);
/*Tabela towarow-w-miastach*/


CREATE TABLE [dbo].[Art_in_Cravan] (
    [IdCaravan] UNIQUEIDENTIFIER  NOT NULL,							/*Klucz obcy Karawany*/
    [IdArticle] UNIQUEIDENTIFIER  NOT NULL,							/*Klucz obcy Towaru*/
    [Number]    INT DEFAULT ((0)) NOT NULL,							/*Ilosc*/
    CONSTRAINT [FK_Art_in_Caravan_Caravan] FOREIGN KEY ([IdCaravan]) REFERENCES [dbo].[Caravan] ([IdCaravan]),
    CONSTRAINT [FK_Art_in_Caravan_ToArticle] FOREIGN KEY ([IdArticle]) REFERENCES [dbo].[Article] ([IdArticle])
);
/*Tabela towarow-w-karawanie*/


CREATE TABLE [dbo].[Town_State] (
    [IdTown]   UNIQUEIDENTIFIER NOT NULL,							/*Klucz obcy Miasta*/
    [IdState]  UNIQUEIDENTIFIER NOT NULL,							/*Klucz obcy Stanu*/
    [Duration] INT              DEFAULT ((1)) NOT NULL,				/*Trwanie*/
    CONSTRAINT [FK_Town_State_ToTown] FOREIGN KEY ([IdTown]) REFERENCES [dbo].[Town] ([IdTown]),
    CONSTRAINT [FK_Town_State_ToState] FOREIGN KEY ([IdState]) REFERENCES [dbo].[State] ([IdState])
);
/*Tabela stanow-miasta*/