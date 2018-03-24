/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2008 (10.0.2531)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2012
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [HeThongQuanLy]
GO
ALTER TABLE [dbo].[PdbSupplies] DROP CONSTRAINT [FK_PdbSupplies_PdbStaff]
GO
ALTER TABLE [dbo].[PdbStaffEvent] DROP CONSTRAINT [FK_PdbStaffEvent_PdbStaff]
GO
ALTER TABLE [dbo].[PdbStaffEvent] DROP CONSTRAINT [FK_PdbStaffEvent_PdbEvent]
GO
ALTER TABLE [dbo].[PdbSalary] DROP CONSTRAINT [FK_PdbSalary_PdbStaff]
GO
ALTER TABLE [dbo].[PdbEducationLevel] DROP CONSTRAINT [FK_PdbEducationLevel_PdbStaff]
GO
ALTER TABLE [dbo].[PdbContract] DROP CONSTRAINT [FK_PdbContract_PdbStaff]
GO
ALTER TABLE [dbo].[PdbAccount] DROP CONSTRAINT [FK_PdbAccount_PdbStaff]
GO
ALTER TABLE [dbo].[PdbSupplies] DROP CONSTRAINT [DF_PdbSupplies_isReturn]
GO
ALTER TABLE [dbo].[PdbSupplies] DROP CONSTRAINT [DF_PdbSupplies_Quantity]
GO
ALTER TABLE [dbo].[PdbStaffEvent] DROP CONSTRAINT [DF_PdbStaffEvent_isPaidByStaff]
GO
ALTER TABLE [dbo].[PdbStaffEvent] DROP CONSTRAINT [DF_PdbStaffEvent_isStatus]
GO
ALTER TABLE [dbo].[PdbStaff] DROP CONSTRAINT [DF_PdbStaff_isMarried]
GO
ALTER TABLE [dbo].[PdbEvent] DROP CONSTRAINT [DF_PdbEvent_Money_Staff_Pay]
GO
ALTER TABLE [dbo].[PdbEvent] DROP CONSTRAINT [DF_PdbEvent_Scale]
GO
ALTER TABLE [dbo].[PdbEvent] DROP CONSTRAINT [DF_PdbEvent_ActualCosts]
GO
ALTER TABLE [dbo].[PdbEvent] DROP CONSTRAINT [DF_PdbEvent_CostsAwarded]
GO
ALTER TABLE [dbo].[PdbEvent] DROP CONSTRAINT [DF_PdbEvent_ExpectedCost]
GO
ALTER TABLE [dbo].[PdbAccount] DROP CONSTRAINT [DF_PdbAccount_isActive]
GO
/****** Object:  Table [dbo].[PdbSupplies]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbSupplies]
GO
/****** Object:  Table [dbo].[PdbStaffEvent]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbStaffEvent]
GO
/****** Object:  Table [dbo].[PdbStaff]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbStaff]
GO
/****** Object:  Table [dbo].[PdbSalary]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbSalary]
GO
/****** Object:  Table [dbo].[PdbEvent]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbEvent]
GO
/****** Object:  Table [dbo].[PdbEducationLevel]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbEducationLevel]
GO
/****** Object:  Table [dbo].[PdbContract]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbContract]
GO
/****** Object:  Table [dbo].[PdbAccount]    Script Date: 10/8/2017 12:11:23 AM ******/
DROP TABLE [dbo].[PdbAccount]
GO
/****** Object:  Table [dbo].[PdbAccount]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbAccount](
	[IDAccount] [uniqueidentifier] NOT NULL,
	[IDStaff] [uniqueidentifier] NOT NULL,
	[AccountName] [nchar](20) NOT NULL,
	[AccountPassword] [nchar](20) NOT NULL,
	[AccountLevel] [nvarchar](20) NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_PdbAccount] PRIMARY KEY CLUSTERED 
(
	[IDAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbContract]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbContract](
	[IDContract] [uniqueidentifier] NOT NULL,
	[IDStaff] [uniqueidentifier] NOT NULL,
	[ContractType] [nvarchar](20) NOT NULL,
	[ContractDescription] [nvarchar](50) NULL,
	[PayForms] [nvarchar](20) NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[SignDate] [datetime2](7) NULL,
 CONSTRAINT [PK_PdbContract] PRIMARY KEY CLUSTERED 
(
	[IDContract] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbEducationLevel]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbEducationLevel](
	[ID_EL] [uniqueidentifier] NOT NULL,
	[IDStaff] [uniqueidentifier] NOT NULL,
	[NameEL] [nvarchar](50) NOT NULL,
	[Major] [nvarchar](40) NOT NULL,
	[CertificateType] [nvarchar](20) NOT NULL,
	[PlaceProvide] [nvarchar](50) NOT NULL,
	[Result] [nvarchar](20) NOT NULL,
	[DateOut] [datetime2](7) NOT NULL,
	[DateProvide] [datetime2](7) NOT NULL,
	[Note] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PdbEducationLevel] PRIMARY KEY CLUSTERED 
(
	[ID_EL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbEvent]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbEvent](
	[ID_Event] [uniqueidentifier] NOT NULL,
	[EventName] [nvarchar](50) NOT NULL,
	[ExpectedCost] [money] NOT NULL,
	[CostsAwarded] [money] NOT NULL,
	[ActualCosts] [money] NOT NULL,
	[DateStart] [datetime2](7) NOT NULL,
	[DateEnd] [datetime2](7) NOT NULL,
	[Location] [nvarchar](100) NOT NULL,
	[Scale] [nvarchar](50) NOT NULL,
	[EventContent] [nvarchar](500) NOT NULL,
	[TravelBy] [nvarchar](50) NOT NULL,
	[Money_Staff_Pay] [money] NULL,
 CONSTRAINT [PK_PdbEvent] PRIMARY KEY CLUSTERED 
(
	[ID_Event] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbSalary]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbSalary](
	[IDSalary] [uniqueidentifier] NOT NULL,
	[IDStaff] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_PdbSalary] PRIMARY KEY CLUSTERED 
(
	[IDSalary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbStaff]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbStaff](
	[ID_Staff] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthday] [datetime2](7) NOT NULL,
	[IndentityCard] [nchar](10) NOT NULL,
	[Date_Create_IC] [datetime2](7) NOT NULL,
	[Place_Create_IC] [nvarchar](50) NOT NULL,
	[Hometown] [nvarchar](50) NOT NULL,
	[Phone] [nchar](15) NOT NULL,
	[AddressNumber] [nchar](20) NOT NULL,
	[AddressStreet] [nvarchar](20) NOT NULL,
	[AddressWard] [nchar](20) NOT NULL,
	[AddressDistrict] [nvarchar](30) NULL,
	[AddressCity] [nvarchar](30) NOT NULL,
	[Sex] [nvarchar](5) NOT NULL,
	[Department] [nvarchar](30) NOT NULL,
	[Position] [nvarchar](30) NOT NULL,
	[isMarried] [bit] NOT NULL,
	[DateStartWork] [datetime2](7) NOT NULL,
	[DateEndWork] [datetime2](7) NULL,
	[Image] [image] NOT NULL,
	[Produce] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID_Staff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbStaffEvent]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbStaffEvent](
	[ID_StaffEvent] [uniqueidentifier] NOT NULL,
	[ID_Staff] [uniqueidentifier] NOT NULL,
	[ID_Event] [uniqueidentifier] NOT NULL,
	[isStatus] [bit] NOT NULL,
	[isPaidByStaff] [bit] NULL,
 CONSTRAINT [PK_PdbStaffEvent] PRIMARY KEY CLUSTERED 
(
	[ID_StaffEvent] ASC,
	[ID_Staff] ASC,
	[ID_Event] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PdbSupplies]    Script Date: 10/8/2017 12:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PdbSupplies](
	[IDSupplies] [uniqueidentifier] NOT NULL,
	[IDStaff] [uniqueidentifier] NOT NULL,
	[NameSupplies] [nvarchar](50) NOT NULL,
	[ReasonBorrow] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[DateBorrow] [datetime2](7) NOT NULL,
	[DateReturn] [datetime2](7) NULL,
	[StatusBefore] [nvarchar](50) NOT NULL,
	[StatusAfter] [nvarchar](50) NOT NULL,
	[isReturn] [bit] NOT NULL,
 CONSTRAINT [PK_PdbSupplies] PRIMARY KEY CLUSTERED 
(
	[IDSupplies] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PdbAccount] ADD  CONSTRAINT [DF_PdbAccount_isActive]  DEFAULT ((0)) FOR [isActive]
GO
ALTER TABLE [dbo].[PdbEvent] ADD  CONSTRAINT [DF_PdbEvent_ExpectedCost]  DEFAULT ((0)) FOR [ExpectedCost]
GO
ALTER TABLE [dbo].[PdbEvent] ADD  CONSTRAINT [DF_PdbEvent_CostsAwarded]  DEFAULT ((0)) FOR [CostsAwarded]
GO
ALTER TABLE [dbo].[PdbEvent] ADD  CONSTRAINT [DF_PdbEvent_ActualCosts]  DEFAULT ((0)) FOR [ActualCosts]
GO
ALTER TABLE [dbo].[PdbEvent] ADD  CONSTRAINT [DF_PdbEvent_Scale]  DEFAULT (N'All') FOR [Scale]
GO
ALTER TABLE [dbo].[PdbEvent] ADD  CONSTRAINT [DF_PdbEvent_Money_Staff_Pay]  DEFAULT ((0)) FOR [Money_Staff_Pay]
GO
ALTER TABLE [dbo].[PdbStaff] ADD  CONSTRAINT [DF_PdbStaff_isMarried]  DEFAULT ((0)) FOR [isMarried]
GO
ALTER TABLE [dbo].[PdbStaffEvent] ADD  CONSTRAINT [DF_PdbStaffEvent_isStatus]  DEFAULT ((1)) FOR [isStatus]
GO
ALTER TABLE [dbo].[PdbStaffEvent] ADD  CONSTRAINT [DF_PdbStaffEvent_isPaidByStaff]  DEFAULT ((0)) FOR [isPaidByStaff]
GO
ALTER TABLE [dbo].[PdbSupplies] ADD  CONSTRAINT [DF_PdbSupplies_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[PdbSupplies] ADD  CONSTRAINT [DF_PdbSupplies_isReturn]  DEFAULT ((0)) FOR [isReturn]
GO
ALTER TABLE [dbo].[PdbAccount]  WITH CHECK ADD  CONSTRAINT [FK_PdbAccount_PdbStaff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[PdbStaff] ([ID_Staff])
GO
ALTER TABLE [dbo].[PdbAccount] CHECK CONSTRAINT [FK_PdbAccount_PdbStaff]
GO
ALTER TABLE [dbo].[PdbContract]  WITH CHECK ADD  CONSTRAINT [FK_PdbContract_PdbStaff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[PdbStaff] ([ID_Staff])
GO
ALTER TABLE [dbo].[PdbContract] CHECK CONSTRAINT [FK_PdbContract_PdbStaff]
GO
ALTER TABLE [dbo].[PdbEducationLevel]  WITH CHECK ADD  CONSTRAINT [FK_PdbEducationLevel_PdbStaff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[PdbStaff] ([ID_Staff])
GO
ALTER TABLE [dbo].[PdbEducationLevel] CHECK CONSTRAINT [FK_PdbEducationLevel_PdbStaff]
GO
ALTER TABLE [dbo].[PdbSalary]  WITH CHECK ADD  CONSTRAINT [FK_PdbSalary_PdbStaff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[PdbStaff] ([ID_Staff])
GO
ALTER TABLE [dbo].[PdbSalary] CHECK CONSTRAINT [FK_PdbSalary_PdbStaff]
GO
ALTER TABLE [dbo].[PdbStaffEvent]  WITH CHECK ADD  CONSTRAINT [FK_PdbStaffEvent_PdbEvent] FOREIGN KEY([ID_Event])
REFERENCES [dbo].[PdbEvent] ([ID_Event])
GO
ALTER TABLE [dbo].[PdbStaffEvent] CHECK CONSTRAINT [FK_PdbStaffEvent_PdbEvent]
GO
ALTER TABLE [dbo].[PdbStaffEvent]  WITH CHECK ADD  CONSTRAINT [FK_PdbStaffEvent_PdbStaff] FOREIGN KEY([ID_Staff])
REFERENCES [dbo].[PdbStaff] ([ID_Staff])
GO
ALTER TABLE [dbo].[PdbStaffEvent] CHECK CONSTRAINT [FK_PdbStaffEvent_PdbStaff]
GO
ALTER TABLE [dbo].[PdbSupplies]  WITH CHECK ADD  CONSTRAINT [FK_PdbSupplies_PdbStaff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[PdbStaff] ([ID_Staff])
GO
ALTER TABLE [dbo].[PdbSupplies] CHECK CONSTRAINT [FK_PdbSupplies_PdbStaff]
GO
