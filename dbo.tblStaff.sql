CREATE TABLE [dbo].[tblStaff] (
    [StaffId]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NULL,
    [Position] VARCHAR (100) NULL,
    [Email]    VARCHAR (100) NULL,
    [Phone]    VARCHAR (20)  NULL,
    [Hiredate] DATE          NULL,
    [Active]   BIT           NULL,
    PRIMARY KEY CLUSTERED ([StaffId] ASC)
);

