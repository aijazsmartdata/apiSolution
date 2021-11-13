CREATE TABLE [dbo].[User] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [UserName]         NVARCHAR (100) NULL,
    [LastName]      NVARCHAR (100) NULL,
    [FirstName]     NVARCHAR (100) NULL,
    [Password]   NVARCHAR (100) NULL,    
    [Status]        CHAR (1)       NOT NULL,
    [IsActive]      BIT            CONSTRAINT [DF_Use_IsActive] DEFAULT ((1)) NOT NULL,
    [CreatedOn]     DATETIME       NOT NULL,
    [ModifiedOn]    DATETIME       NULL,
    CONSTRAINT [PK_User_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_User_Status] CHECK ([Status]='A' OR [Status]='D' OR [Status]='R'),  
    CONSTRAINT [UK_User_UserName] UNIQUE NONCLUSTERED ([UserName] ASC)
);