CREATE TABLE [dbo].[tblStaff] (
    [StaffId]  INT           IDENTITY (1, 1) NOT NULL,
    [name]     VARCHAR (100) NULL,
    [position] VARCHAR (100) NULL,
    [email]    VARCHAR (100) NULL,
    [phone]    VARCHAR (20)  NULL,
    [hiredate] DATE          NULL,
    [Active]   BIT           NULL,
    PRIMARY KEY CLUSTERED ([StaffId] ASC)
);

