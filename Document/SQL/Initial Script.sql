
USE [PlacovuEnterprise]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Hometown] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEAutoNumberSetup]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEAutoNumberSetup](
	[AutoNumberSetupID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentName] [nvarchar](50) NULL,
	[DocumentCode] [nvarchar](5) NOT NULL,
	[Prefix] [nvarchar](4) NULL,
	[Separator] [nchar](1) NULL,
	[NextNumber] [int] NULL,
	[Year] [nvarchar](50) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_BSEAutoNumberSetup] PRIMARY KEY CLUSTERED 
(
	[AutoNumberSetupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBankAccount]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBankAccount](
	[BankAccountID] [int] IDENTITY(1,1) NOT NULL,
	[BankID] [int] NULL,
	[BranchID] [int] NULL,
	[BankAccName] [nvarchar](30) NULL,
	[Description] [nvarchar](250) NULL,
	[AccountNo] [nvarchar](50) NULL,
	[AccountType] [nvarchar](50) NULL,
	[isActive] [bit] NULL,
	[IBANNo] [nvarchar](50) NULL,
	[CurrencyCode] [int] NULL,
	[SwiftCode] [nvarchar](50) NULL,
	[GLAccount] [int] NULL,
	[BusinessUnitID] [int] NULL,
 CONSTRAINT [PK_BSEBankAccount] PRIMARY KEY CLUSTERED 
(
	[BankAccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBankInfo]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBankInfo](
	[BankID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[AddressLine1] [nvarchar](1000) NULL,
	[AddressLine2] [nvarchar](1000) NULL,
	[City] [nvarchar](20) NULL,
	[Country] [int] NULL,
	[ZipCode] [nvarchar](50) NULL,
	[State] [nvarchar](20) NULL,
 CONSTRAINT [PK_BSEBankInfo] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBillType]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBillType](
	[BillTypeID] [int] IDENTITY(1,1) NOT NULL,
	[BillType] [nvarchar](50) NULL,
 CONSTRAINT [PK_BSEBillType] PRIMARY KEY CLUSTERED 
(
	[BillTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBranchInfo]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBranchInfo](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[BankID] [int] NULL,
	[BranchCode] [nvarchar](10) NULL,
	[BranchName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[AddressLine1] [nvarchar](1000) NULL,
	[AddressLine2] [nvarchar](1000) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[ZipCode] [nvarchar](20) NULL,
	[Country] [int] NULL,
	[SWIFTCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_BSEBranchInfo] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBusinessParty]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBusinessParty](
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessPartyName] [nvarchar](100) NULL,
	[Company] [nvarchar](100) NULL,
	[Street] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[CountryID] [int] NULL,
	[CountryName] [varchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[AccountCode] [int] NULL,
	[Nature] [nvarchar](2) NULL,
	[AddressLine1] [nvarchar](1000) NULL,
	[AddressLine2] [nvarchar](1000) NULL,
	[State] [nvarchar](20) NULL,
	[IsActive] [bit] NULL,
	[ItemTypeID] [int] NULL,
	[IsEmployee] [bit] NOT NULL,
	[EmployeeID] [bigint] NULL,
 CONSTRAINT [PK_BSEBusinessParty] PRIMARY KEY CLUSTERED 
(
	[BusinessPartyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBusinessPartyBankInfo]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBusinessPartyBankInfo](
	[BusinessPartyBankInfoID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessPartyID] [int] NULL,
	[BankName] [nvarchar](100) NULL,
	[BranchName] [nvarchar](100) NULL,
	[BranchCode] [nvarchar](50) NULL,
	[AccountNumber] [nvarchar](50) NULL,
	[SWIFTCode] [nvarchar](50) NULL,
	[ABANumber] [nvarchar](50) NULL,
	[AddressLine1] [nvarchar](250) NULL,
	[AddressLine2] [nvarchar](250) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](50) NULL,
	[CountryID] [int] NULL,
	[Contact1] [nvarchar](250) NULL,
	[Contact2] [nvarchar](250) NULL,
	[Contact3] [nvarchar](250) NULL,
 CONSTRAINT [PK_BSE_BusinessPartyBankInfo] PRIMARY KEY CLUSTERED 
(
	[BusinessPartyBankInfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBusinessUnit]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBusinessUnit](
	[BusinessUnitID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitCode] [nvarchar](10) NULL,
	[BusinessUnitName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[CompanyID] [int] NULL,
	[WeekStartingDay] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Address] [nvarchar](250) NULL,
	[DecimalRounding] [int] NULL,
	[CostCalMethod] [nvarchar](5) NULL,
	[FactoryAddress] [nvarchar](250) NULL,
 CONSTRAINT [PK_BSEBusinessUnit] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEBusinessWorkingDay]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEBusinessWorkingDay](
	[WoringDayID] [int] IDENTITY(1,1) NOT NULL,
	[DayName] [nvarchar](50) NULL,
	[IsWorkingDay] [bit] NULL,
	[IsStartingDay] [bit] NULL,
	[DayValue] [int] NULL,
	[BusinessUnitID] [int] NULL,
 CONSTRAINT [PK_BSEBusinessWorkingDay] PRIMARY KEY CLUSTERED 
(
	[WoringDayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSECompany]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSECompany](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[createdBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_BSECompany] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSECountry]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSECountry](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[ISO] [varchar](5) NULL,
	[CountryName] [varchar](100) NULL,
	[ISO3] [varchar](5) NULL,
	[NumCode] [varchar](5) NULL,
 CONSTRAINT [PK__BSECountry] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSECurrency]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSECurrency](
	[CurrencyID] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyCode] [nvarchar](5) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[LongName] [nvarchar](250) NULL,
	[AfterDecimalName] [nvarchar](250) NULL,
	[Rate] [numeric](18, 0) NULL,
	[RateAsOf] [datetime] NULL,
	[IsBase] [bit] NULL,
 CONSTRAINT [PK_PTSL_TB_Base_Currency] PRIMARY KEY CLUSTERED 
(
	[CurrencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSECustomer]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSECustomer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Company] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[Country] [int] NULL,
	[City] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[AccountNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_BSECustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEDepartment]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEDepartment](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[DepartmentName] [nvarchar](150) NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_BSEDepartment] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEDistrictName]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEDistrictName](
	[DistrictID] [int] NOT NULL,
	[DictrictName] [nvarchar](50) NULL,
	[DivisionID] [nchar](50) NULL,
 CONSTRAINT [PK_BSEDistrictName] PRIMARY KEY CLUSTERED 
(
	[DistrictID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSELocation]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSELocation](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[LocationName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[AddressLine1] [nvarchar](250) NULL,
	[AddressLine2] [nvarchar](250) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](20) NULL,
	[CountryID] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK__BSELocation] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEMeasurementUnit]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEMeasurementUnit](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](10) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_BSEMeasurementUnit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEOperatingUnit]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEOperatingUnit](
	[OperatingUnitID] [int] IDENTITY(1,1) NOT NULL,
	[OperatingUnitName] [nvarchar](100) NULL,
	[IsActive] [bit] NULL,
	[BusinessUnitID] [int] NULL,
 CONSTRAINT [PK_BSEOperatingUnit] PRIMARY KEY CLUSTERED 
(
	[OperatingUnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEPaymentMode]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEPaymentMode](
	[PayModeID] [int] NOT NULL,
	[PayModeName] [varchar](200) NULL,
	[PayModeDescription] [varchar](4000) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_BSEPaymentMode] PRIMARY KEY CLUSTERED 
(
	[PayModeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEPaymentStatus]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEPaymentStatus](
	[PaymentStatusID] [int] NOT NULL,
	[PaymentStatusName] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_BSEPaymentStatus] PRIMARY KEY CLUSTERED 
(
	[PaymentStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEPaymentTerm]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEPaymentTerm](
	[PaymentTermID] [tinyint] NOT NULL,
	[TermName] [varchar](200) NULL,
	[TermDescription] [varchar](2000) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_BSEPaymentTerm] PRIMARY KEY CLUSTERED 
(
	[PaymentTermID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEPaymentType]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEPaymentType](
	[PaymentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_BSEPaymentType] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEProject]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEProject](
	[BusinessunitID] [int] NOT NULL,
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[StartDate] [datetime] NULL,
	[ClosedDate] [datetime] NULL,
	[AccountCash] [int] NULL,
	[AccountExp] [int] NULL,
	[IsActive] [bit] NULL,
	[FarmerID] [bigint] NULL,
	[SeasonID] [int] NOT NULL,
	[ProductionJournalID] [bigint] NULL,
 CONSTRAINT [PK_BSEProject] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSEReportParams]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSEReportParams](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[FooterLine1] [nvarchar](500) NULL,
	[FooterLine2] [nvarchar](500) NULL,
	[FooterLine3] [nvarchar](500) NULL,
	[FooterLine4] [nvarchar](500) NULL,
 CONSTRAINT [PK_BSEReport_Params] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSESupplier]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSESupplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
	[Company] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[Country] [int] NULL,
	[City] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[AccountNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_BSESupplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountConfiguration]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountConfiguration](
	[ConfigurationID] [int] NOT NULL,
	[ConfigurationName] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
	[AccountCode] [int] NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_FACAccountConfiguration] PRIMARY KEY CLUSTERED 
(
	[ConfigurationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountingPeriod]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountingPeriod](
	[AccountingPeriodID] [int] IDENTITY(1,1) NOT NULL,
	[AccountingPeriodCode] [nvarchar](12) NULL,
	[AccountingPeriodName] [nchar](100) NULL,
	[FiscalYearID] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[APStatus] [nvarchar](10) NULL,
	[IsOpening] [bit] NULL,
	[ClosedBy] [int] NULL,
	[ClosingDate] [datetime] NULL,
	[ReOpenBy] [int] NULL,
	[ReOpenDate] [datetime] NULL,
	[FiscalYear] [int] NULL,
	[AccountingPeriod] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[FiscalYearDisplay] [nvarchar](50) NULL,
 CONSTRAINT [PK_FACAccountingPeriod] PRIMARY KEY CLUSTERED 
(
	[AccountingPeriodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_FACAccountingPeriodCode] UNIQUE NONCLUSTERED 
(
	[AccountingPeriodCode] ASC,
	[BusinessUnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountingPeriodTest]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountingPeriodTest](
	[AccountingPeriodID] [int] IDENTITY(1,1) NOT NULL,
	[AccountingPeriodCode] [nvarchar](10) NULL,
	[AccountingPeriodName] [nchar](100) NULL,
	[FiscalYearID] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[APStatus] [nvarchar](10) NULL,
	[IsOpening] [bit] NULL,
 CONSTRAINT [PK_FACAccountingPeriodTest] PRIMARY KEY CLUSTERED 
(
	[AccountingPeriodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_FACAccountingPeriodTest_CodeUnique] UNIQUE NONCLUSTERED 
(
	[AccountingPeriodCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountingReportType]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountingReportType](
	[ReportTypeID] [int] NOT NULL,
	[AccountTypeName] [varchar](200) NULL,
	[TypeDescription] [varchar](500) NULL,
 CONSTRAINT [PK_FACAccountingReportType] PRIMARY KEY CLUSTERED 
(
	[ReportTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountMasterType]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountMasterType](
	[AccountMasterTypeID] [int] NOT NULL,
	[MasterTypeName] [varchar](50) NULL,
	[MasterTypeDescription] [varchar](200) NULL,
	[DrCr] [char](1) NULL,
 CONSTRAINT [PK_FACAccountMasterType] PRIMARY KEY CLUSTERED 
(
	[AccountMasterTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountSubType]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountSubType](
	[AccountSubTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AccountTypeID] [int] NOT NULL,
	[AccountSubTypeName] [varchar](200) NOT NULL,
	[Description] [varchar](500) NULL,
	[NatureDrCr] [char](1) NOT NULL,
 CONSTRAINT [PK_FACAccountSubType] PRIMARY KEY CLUSTERED 
(
	[AccountSubTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACAccountType]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACAccountType](
	[AccountTypeID] [int] NOT NULL,
	[AccountMasterTypeID] [int] NOT NULL,
	[AccountTypeName] [varchar](200) NULL,
	[Description] [varchar](500) NULL,
	[AppearInReportTypeID] [int] NULL,
	[NatureDrCr] [char](1) NULL,
 CONSTRAINT [PK_FACAccountType] PRIMARY KEY CLUSTERED 
(
	[AccountTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACApplyPrepayment]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACApplyPrepayment](
	[ApplyPrepaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[SourcePaymentID] [bigint] NULL,
	[DestPaymentID] [bigint] NULL,
	[SourceID] [bigint] NULL,
	[Source] [nvarchar](3) NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[ApplyDate] [datetime] NULL,
	[AppliedPaymentAmount] [money] NULL,
	[AccountingDate] [datetime] NULL,
 CONSTRAINT [PK_FACApplyPrepayment] PRIMARY KEY CLUSTERED 
(
	[ApplyPrepaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACBilling]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACBilling](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[BillDate] [datetime] NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[DueDate] [datetime] NULL,
	[DueAmount] [money] NULL,
	[Reference] [nvarchar](50) NULL,
	[Memo] [nvarchar](250) NULL,
	[PaymentTermID] [tinyint] NULL,
	[PaymentStatusID] [int] NULL,
	[Balance] [money] NULL,
	[IsPayable] [bit] NULL,
	[IsAdditionExpense] [bit] NULL,
	[SourceOfBill] [nvarchar](50) NULL,
	[SourceRecordID] [bigint] NULL,
	[EntryBy] [int] NULL,
	[EntryDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
 CONSTRAINT [PK_FACBilling] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACBillingDetail]    Script Date: 5/21/2018 5:44:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACBillingDetail](
	[BillDetailID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NULL,
	[ItemID] [int] NULL,
	[ItemAmount] [money] NULL,
	[ItemMemo] [nvarchar](500) NULL,
	[MeasurementUnitID] [int] NULL,
	[ItemQuantity] [int] NULL,
	[ItemUnitPrice] [money] NULL,
 CONSTRAINT [PK_FACBillingDetail] PRIMARY KEY CLUSTERED 
(
	[BillDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACChartOfAccount]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACChartOfAccount](
	[AccountCode] [int] NOT NULL,
	[AccountName] [varchar](50) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[ParentAccountCode] [int] NULL,
	[OppositParentAccountCode] [int] NULL,
	[AccountMasterTypeID] [int] NULL,
	[AccountTypeID] [int] NOT NULL,
	[AccountSubTypeID] [int] NULL,
	[ContraAccountOf] [int] NULL,
	[IsGLAccount] [bit] NULL,
	[IsActive] [bit] NULL,
	[CurrentBalance] [money] NULL,
	[CurrentBalanceUpdateDate] [datetime] NULL,
	[IsCashAccount] [bit] NULL,
	[IsBankAccount] [bit] NULL,
	[IsInterUnit] [bit] NULL,
 CONSTRAINT [PK_FACChartOfAccount] PRIMARY KEY CLUSTERED 
(
	[AccountCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACChartOfAccountsStat]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACChartOfAccountsStat](
	[AccountCode] [int] NOT NULL,
	[TotalDebitAmount] [money] NULL,
	[TotalCreditAmount] [money] NULL,
	[TotalBalance] [money] NULL,
 CONSTRAINT [PK_FACChartOfAccountsStat] PRIMARY KEY CLUSTERED 
(
	[AccountCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACCreditMemo]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACCreditMemo](
	[CreditMemoID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [bigint] NULL,
	[BusinessPartyID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[CreditAmount] [money] NULL,
	[CreditMemoStatusID] [int] NULL,
	[CreditMemoDate] [datetime] NULL,
	[AccountingDate] [datetime] NULL,
	[Reference] [nvarchar](100) NULL,
	[Comments] [nvarchar](250) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[AccountCode] [int] NULL,
 CONSTRAINT [PK_FACCreditMemo] PRIMARY KEY CLUSTERED 
(
	[CreditMemoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACCreditMemoStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACCreditMemoStatus](
	[CreditMemoStatusID] [int] IDENTITY(1,1) NOT NULL,
	[CreditMemoStatusName] [nvarchar](50) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_FACCreditMemoStatus] PRIMARY KEY CLUSTERED 
(
	[CreditMemoStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACDebitMemo]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACDebitMemo](
	[DebitMemoID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [bigint] NULL,
	[BusinessPartyID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[DebitAmount] [money] NULL,
	[DebitMemoStatusID] [int] NULL,
	[DebitMemoDate] [datetime] NULL,
	[AccountingDate] [datetime] NULL,
	[AccountCode] [int] NULL,
	[Reference] [nvarchar](100) NULL,
	[Comments] [nvarchar](250) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[PurchaseReturnID] [bigint] NULL,
 CONSTRAINT [PK_FACDebitMemo] PRIMARY KEY CLUSTERED 
(
	[DebitMemoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACDebitMemoStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACDebitMemoStatus](
	[DebitMemoStatusID] [int] IDENTITY(1,1) NOT NULL,
	[DebitMemoStatusName] [nvarchar](50) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_FACDebitMemoStatus] PRIMARY KEY CLUSTERED 
(
	[DebitMemoStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACFinSecurityRule]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACFinSecurityRule](
	[BusinessUnitID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[RuleName] [nvarchar](50) NULL,
	[Description] [nvarchar](500) NULL,
	[CanViewAllInvoice] [bit] NOT NULL,
	[MaxValue] [money] NOT NULL,
	[CanViewAllJournal] [bit] NOT NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_FACFinSecurityRule] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACFiscalYear]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACFiscalYear](
	[FiscalYearID] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[FiscalYearStatus] [nvarchar](50) NULL,
	[BusinessUnitID] [int] NULL,
 CONSTRAINT [PK_FACFiscalYear] PRIMARY KEY CLUSTERED 
(
	[FiscalYearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACFiscalYearTest]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACFiscalYearTest](
	[FiscalYearID] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[FiscalYearStatus] [nvarchar](50) NULL,
 CONSTRAINT [PK_FACFiscalYearTest] PRIMARY KEY CLUSTERED 
(
	[FiscalYearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACGLedger]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACGLedger](
	[BusinessUnitID] [int] NOT NULL,
	[FiscalYear] [int] NOT NULL,
	[AccountingPeriod] [int] NOT NULL,
	[AccountCode] [int] NOT NULL,
	[PostedDrAmount] [money] NOT NULL,
	[PostedCrAmount] [money] NOT NULL,
	[PostedTotalAmount] [money] NULL,
	[GLedgerID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[TimeStamp] [timestamp] NULL,
	[AccountingPeriodID] [int] NULL,
 CONSTRAINT [PK_FACGLedger] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC,
	[AccountCode] ASC,
	[FiscalYear] ASC,
	[AccountingPeriod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACGLSecurityRule]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACGLSecurityRule](
	[RuleId] [int] IDENTITY(1,1) NOT NULL,
	[RuleName] [nvarchar](150) NULL,
	[RuleDescription] [nvarchar](250) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_FACGLSecurityRule] PRIMARY KEY CLUSTERED 
(
	[RuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACGLSecurityRuleAndCOA]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACGLSecurityRuleAndCOA](
	[RuleID] [int] NOT NULL,
	[AccountCode] [int] NOT NULL,
	[Timestamp] [timestamp] NULL,
 CONSTRAINT [PK_FACGLSecurityRuleAndCOA] PRIMARY KEY CLUSTERED 
(
	[RuleID] ASC,
	[AccountCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACInitialBalance]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACInitialBalance](
	[BusinessUnitID] [int] NOT NULL,
	[FiscalYear] [int] NOT NULL,
	[AccountingPeriod] [int] NOT NULL,
	[AccountCode] [int] NOT NULL,
	[PostedDrAmount] [money] NOT NULL,
	[PostedCrAmount] [money] NOT NULL,
	[PostedTotalAmount] [money] NULL,
	[AccountingPeriodID] [int] NULL,
	[GLedgerID] [uniqueidentifier] NULL,
	[TimeStamp] [timestamp] NULL,
	[AddedBy] [int] NULL,
	[DateAdded] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[DateUpdated] [datetime] NULL,
	[IsCommitted] [bit] NULL,
	[CommittedBy] [int] NULL,
	[DateCommitted] [datetime] NULL,
 CONSTRAINT [PK_FACInitialBalance] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC,
	[FiscalYear] ASC,
	[AccountingPeriod] ASC,
	[AccountCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACInterUnitTranType]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACInterUnitTranType](
	[InterUnitTranTypeID] [smallint] NOT NULL,
	[InterUnitTranType] [nvarchar](50) NULL,
 CONSTRAINT [PK_FACInterUnitTranType] PRIMARY KEY CLUSTERED 
(
	[InterUnitTranTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACJournal]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACJournal](
	[JournalID] [bigint] IDENTITY(1,1) NOT NULL,
	[JournalCode] [nvarchar](100) NULL,
	[BusinessUnitID] [int] NULL,
	[JournalTypeID] [int] NOT NULL,
	[JournalDate] [datetime] NOT NULL,
	[ReferenceNo] [nvarchar](100) NULL,
	[Description] [nvarchar](500) NULL,
	[TotalDrAmount] [money] NULL,
	[TotalCrAmount] [money] NULL,
	[IsAdjustment] [bit] NULL,
	[IsVerified] [bit] NOT NULL,
	[VerifiedBy] [int] NULL,
	[VerifiedDate] [datetime] NULL,
	[JournalStatus] [nvarchar](5) NULL,
	[RowState] [char](1) NULL,
	[SourcesProcessID] [varchar](10) NULL,
	[SourcesProcessDesc] [varchar](200) NULL,
	[SourcesProcessRecordID] [bigint] NULL,
	[FiscaleYear] [int] NULL,
	[AccountingPeriod] [int] NULL,
	[OpeningPeriodID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[PostedBy] [int] NULL,
	[PostedDate] [datetime] NULL,
	[CancelledBy] [int] NULL,
	[CancelledDate] [datetime] NULL,
	[ProjectID] [int] NULL,
	[InterUnitTranTypeID] [smallint] NULL,
	[InterUnitBUID] [int] NULL,
	[RowID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[Timestamp] [timestamp] NULL,
 CONSTRAINT [PK_FACJournal] PRIMARY KEY CLUSTERED 
(
	[JournalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACJournalDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACJournalDetail](
	[JournalDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[JournalID] [bigint] NOT NULL,
	[AccountCode] [int] NOT NULL,
	[DrAmount] [money] NULL,
	[CrAmount] [money] NULL,
	[DrCrFactor] [varchar](5) NULL,
	[Description] [varchar](50) NULL,
	[ForeignDrAmount] [money] NULL,
	[ForeignCrAmount] [money] NULL,
	[BusinessPartyID] [int] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_FACJournalDetail] PRIMARY KEY CLUSTERED 
(
	[JournalDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACJournalType]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACJournalType](
	[JournalTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](20) NULL,
	[TypeDescription] [varchar](50) NULL,
 CONSTRAINT [PK_FACJournalType] PRIMARY KEY CLUSTERED 
(
	[JournalTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACPayment]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACPayment](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentDate] [datetime] NULL,
	[BusinessUnitID] [int] NULL,
	[PaymentAmount] [money] NULL,
	[PaymentModeID] [int] NULL,
	[BankID] [int] NULL,
	[GLAccountCode] [int] NULL,
	[BankAccountID] [int] NULL,
	[BranchID] [int] NULL,
	[CheckNumber] [nvarchar](50) NULL,
	[Memo] [nvarchar](250) NULL,
	[IsPayable] [bit] NULL,
 CONSTRAINT [PK_FACPayment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACPaymentDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACPaymentDetail](
	[PaymentDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentID] [int] NULL,
	[BillID] [int] NULL,
	[BillPaymentAmount] [money] NULL,
	[BusinessPartyID] [int] NULL,
 CONSTRAINT [PK_FACPaymentDetail] PRIMARY KEY CLUSTERED 
(
	[PaymentDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACPrepayment]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACPrepayment](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[PrepaymentInvoiceID] [bigint] NULL,
	[PayDate] [datetime] NULL,
	[PayAmount] [money] NULL,
	[PayModeID] [int] NULL,
	[BankID] [int] NULL,
	[BranchID] [int] NULL,
	[BankAccountID] [int] NULL,
	[BankAccountCode] [int] NULL,
	[BankCheckNo] [nvarchar](50) NULL,
	[Memo] [varchar](max) NULL,
	[RefNo] [nvarchar](50) NULL,
	[JournalID] [bigint] NULL,
 CONSTRAINT [PK_FACPrepayment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACPrepaymentInvoice]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACPrepaymentInvoice](
	[PrepaymentInvoiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[InvoiceDate] [datetime] NULL,
	[BusinessPartyID] [int] NULL,
	[EmployeeID] [bigint] NULL,
	[InvoiceAmount] [money] NULL,
	[DueDate] [datetime] NULL,
	[InvoiceNote] [varchar](2000) NULL,
	[InvoiceStatusID] [int] NULL,
	[PaymentStatusID] [int] NULL,
	[CurrencyID] [int] NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[ConversionRate] [money] NULL,
	[AvailableAmount] [money] NULL,
 CONSTRAINT [PK_FACPrepaymentInvoice] PRIMARY KEY CLUSTERED 
(
	[PrepaymentInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACPrepaymentInvoiceStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACPrepaymentInvoiceStatus](
	[InvStatusID] [int] IDENTITY(1,1) NOT NULL,
	[InvStatusName] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_FACPrepaymentInvoiceStatus] PRIMARY KEY CLUSTERED 
(
	[InvStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACSourceProcess]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACSourceProcess](
	[ProcessID] [varchar](10) NOT NULL,
	[ProcessDescription] [varchar](500) NULL,
 CONSTRAINT [PK_FACCourceProcess] PRIMARY KEY CLUSTERED 
(
	[ProcessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTemporaryFund]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTemporaryFund](
	[TemporaryFundID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[TotalIssuedAmount] [money] NULL,
	[DateIssued] [datetime] NULL,
	[FundIssuedTo] [int] NULL,
	[FundIssuedBy] [int] NULL,
	[TotalReveivedAmount] [money] NULL,
	[DateReceived] [datetime] NULL,
	[FundReceivedBy] [int] NULL,
	[IssueNote] [text] NULL,
	[CloseNote] [text] NULL,
	[IsClosed] [bit] NULL,
 CONSTRAINT [PK_FACTemporaryFund] PRIMARY KEY CLUSTERED 
(
	[TemporaryFundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACUserAndGLSecurityRule]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACUserAndGLSecurityRule](
	[UserID] [int] NOT NULL,
	[RuleID] [int] NOT NULL,
	[Timestamp] [timestamp] NULL,
 CONSTRAINT [PK_FACUserAndGLSecurityRule] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[RuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACVoucher]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACVoucher](
	[VoucherID] [bigint] NOT NULL,
	[BusinessUnitID] [int] NULL,
	[VoucherDate] [datetime] NULL,
	[PurchaseInvoiceID] [bigint] NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[PurchaseOrderID] [bigint] NULL,
	[InvoiceDate] [datetime] NULL,
	[BusinessPartyID] [int] NULL,
	[InvoiceAmount] [money] NULL,
	[MerchandiseAmount] [money] NULL,
	[DiscountAmount] [money] NULL,
	[DebitMemoAmt] [money] NULL,
	[InvoiceNote] [nvarchar](2000) NULL,
	[InvoiceStatusID] [int] NULL,
	[PaymentStatusID] [int] NULL,
	[PaymentTerms] [nvarchar](500) NULL,
	[PaymentTermID] [int] NULL,
	[PaymentedAmount] [money] NULL,
	[CurrencyID] [int] NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[ConversionRate] [money] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[AccountingDate] [datetime] NULL,
	[DateAdded] [datetime] NULL,
	[AddedBy] [int] NULL,
	[DateUpdated] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[SalesOrderID] [bigint] NULL,
	[SalesInvoiceID] [bigint] NULL,
	[AdditionalExpConfigID] [int] NULL,
	[CloseType] [nvarchar](10) NULL,
	[CloseReason] [nvarchar](250) NULL,
	[ClosedBy] [int] NULL,
	[ClosingDate] [datetime] NULL,
	[DiscountType] [int] NULL,
	[JournalID] [bigint] NULL,
	[IsCancelled] [bit] NULL,
	[CancelledDate] [datetime] NULL,
	[CancellationReason] [nvarchar](500) NULL,
	[CancelledBy] [int] NULL,
	[SalesBankRefNo] [nvarchar](100) NULL,
	[SalesNegotiationDate] [datetime] NULL,
	[SalesRealizationDate] [datetime] NULL,
	[SalesBLNo] [nvarchar](100) NULL,
	[SalesBLDate] [datetime] NULL,
	[SalesVassel] [nvarchar](250) NULL,
	[PurchasereceiptID] [bigint] NULL,
	[ProjectID] [int] NULL,
	[InvoiceTypeID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVAdjustment]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVAdjustment](
	[AdjustmentID] [int] IDENTITY(1,1) NOT NULL,
	[AdjustmentDate] [datetime] NULL,
	[BusinessUnitID] [int] NULL,
	[StorageLocationID] [int] NULL,
	[AdjustmentByUserID] [int] NULL,
	[SummaryNote] [nvarchar](250) NULL,
	[AccountCode] [int] NULL,
 CONSTRAINT [PK_INVAdjustment] PRIMARY KEY CLUSTERED 
(
	[AdjustmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVDelivery]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVDelivery](
	[DeliveryID] [bigint] IDENTITY(1,1) NOT NULL,
	[DeliveredBy] [int] NULL,
	[DeleveryDate] [date] NULL,
	[SalesOrderID] [bigint] NULL,
	[BusinessUnitID] [int] NULL,
	[ChallanNo] [nvarchar](50) NULL,
	[ChallanDate] [date] NULL,
	[Comments] [nvarchar](200) NULL,
	[BusinessPartyID] [int] NULL,
	[ProjectID] [int] NULL,
	[SalesInvoiceID] [bigint] NULL,
	[DeliveryInvoiceStatus] [nvarchar](10) NULL,
	[DeliveryStatus] [nvarchar](10) NULL,
	[DeliveryReturnStatus] [nvarchar](10) NULL,
	[DeliverySource] [int] NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [datetime] NULL,
	[PostedBy] [int] NULL,
	[PostedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeliveryMode] [nvarchar](10) NULL,
 CONSTRAINT [PK_INVDelivery] PRIMARY KEY CLUSTERED 
(
	[DeliveryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVDeliveryDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVDeliveryDetail](
	[BusinessUnitID] [int] NULL,
	[DeliveryID] [bigint] NULL,
	[DeliveryDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesOrderID] [bigint] NULL,
	[SalesOrderDetailsID] [bigint] NULL,
	[LCID] [bigint] NULL,
	[LCDetailsID] [bigint] NULL,
	[ItemID] [int] NULL,
	[DeliveryDate] [date] NULL,
	[DeliveredQty] [numeric](18, 2) NULL,
	[SalesOrderQty] [numeric](18, 2) NULL,
	[ReturnQty] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[PrevDeliveredQty] [numeric](18, 2) NULL,
	[StorageLocationID] [int] NULL,
	[IsDelevered] [bit] NULL,
 CONSTRAINT [PK_INVDeliveryDetail] PRIMARY KEY CLUSTERED 
(
	[DeliveryDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVDeliveryLCDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVDeliveryLCDetail](
	[DeliveryLCDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[DeliveryDetailID] [bigint] NULL,
	[DeliveryID] [bigint] NULL,
	[SalesOrderID] [bigint] NULL,
	[BusinessUnitID] [int] NULL,
	[ItemID] [int] NULL,
	[MeasurementUnitID] [int] NULL,
	[LCID] [bigint] NULL,
	[DeliveredQty] [numeric](18, 2) NULL,
 CONSTRAINT [PK_INVDeliveryLCDetail] PRIMARY KEY CLUSTERED 
(
	[DeliveryLCDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVInventoryRule]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVInventoryRule](
	[InvetoryRulesID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NOT NULL,
	[AllowNegativeBalance] [bit] NOT NULL,
	[CrearteRealTimeAccounting] [bit] NOT NULL,
	[UpdatedBy] [int] NULL,
	[DateUpdated] [datetime] NULL,
	[TimeStamp] [timestamp] NULL,
 CONSTRAINT [PK_INVInventoryRule] PRIMARY KEY CLUSTERED 
(
	[InvetoryRulesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVInventoryType]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVInventoryType](
	[InventoryTypeID] [int] NOT NULL,
	[InventoryTypeName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[AccountCodeDr] [int] NULL,
	[AccountCodeCr] [int] NULL,
 CONSTRAINT [PK_INVInventoryType] PRIMARY KEY CLUSTERED 
(
	[InventoryTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemBalance]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemBalance](
	[ItemBalanceID] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[ItemName] [nvarchar](100) NULL,
	[ItemGroupID] [int] NULL,
	[ItemTypeID] [int] NULL,
	[ItemBusinessUnitID] [int] NULL,
	[ItemStorageLocationID] [int] NULL,
	[ItemTotal] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
	[AvgPrice] [money] NOT NULL,
	[AvgPricePurchase] [money] NULL,
	[AvgPriceProduction] [money] NULL,
	[OpeningQty] [numeric](18, 2) NULL,
	[OpeningQtyAP] [numeric](18, 2) NULL,
	[OpeningCogmAP] [money] NULL,
 CONSTRAINT [PK_INVPutawaySummary] PRIMARY KEY CLUSTERED 
(
	[ItemBalanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemGroup]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemGroup](
	[ItemGroupID] [int] IDENTITY(1,1) NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[GroupName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[BusinessUnitID] [int] NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_INVItemGroup] PRIMARY KEY CLUSTERED 
(
	[ItemGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemInfo]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemInfo](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[ParentItemID] [int] NULL,
	[ItemGroupID] [int] NULL,
	[ItemTypeID] [int] NULL,
	[ItemName] [nvarchar](100) NOT NULL,
	[ItemDescription] [nvarchar](200) NULL,
	[PurchaseDescription] [nvarchar](200) NULL,
	[SalesDescription] [nvarchar](200) NULL,
	[MeasurementUnitID] [int] NULL,
	[CostPrice] [money] NULL,
	[MinimumSellingPrice] [money] NULL,
	[MaximumSellingPrice] [money] NULL,
	[VATPlanID] [int] NULL,
	[DiscountPlanID] [int] NULL,
	[ReorderLevel] [int] NULL,
	[PreferredSupplierID] [int] NULL,
	[PurchaseLeadTime] [int] NULL,
	[SalesLeadTime] [int] NULL,
	[IsActive] [bit] NULL,
	[COGSAccountCode] [int] NULL,
	[IncomeAccCode] [int] NULL,
	[AssetAccCode] [int] NULL,
	[Balance] [numeric](18, 2) NULL,
	[QtyPerPack] [numeric](18, 2) NULL,
 CONSTRAINT [PK_INVItemInfo] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemInitialBalance]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemInitialBalance](
	[ItemID] [int] NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[ItemGroupID] [int] NULL,
	[ItemTypeID] [int] NULL,
	[ItemBusinessUnitID] [int] NOT NULL,
	[ItemStorageLocationID] [int] NOT NULL,
	[ItemTotal] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
	[IsCommitted] [bit] NULL,
 CONSTRAINT [PK_INVItemInitialBalance_1] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[ItemBusinessUnitID] ASC,
	[ItemStorageLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemMovement]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemMovement](
	[MovementID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NOT NULL,
	[IssuedStorageLocationID] [int] NULL,
	[IssuedDate] [datetime] NULL,
	[IssuedBy] [int] NULL,
	[ReceivedStorageLocationID] [int] NULL,
	[ReceivedBy] [int] NULL,
	[Note] [nvarchar](500) NULL,
	[IssuedHrSectionID] [int] NULL,
	[IssueType] [int] NOT NULL,
	[MovementTypeID] [int] NULL,
	[timestamp] [timestamp] NULL,
	[IsCancelled] [bit] NOT NULL,
	[CancelledBy] [int] NULL,
	[CancelledDate] [datetime] NULL,
	[JournalID] [bigint] NULL,
	[MovementStausID] [int] NULL,
	[PostedBy] [int] NULL,
	[PostedDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_INVItemMovement] PRIMARY KEY CLUSTERED 
(
	[MovementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemMovementDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemMovementDetail](
	[MovemenDetailtID] [bigint] IDENTITY(1,1) NOT NULL,
	[MovementID] [bigint] NULL,
	[ItemID] [int] NULL,
	[IssuedQty] [numeric](18, 2) NULL,
	[AvgIssuePrice] [money] NULL,
 CONSTRAINT [PK_INVItemMovementDetail] PRIMARY KEY CLUSTERED 
(
	[MovemenDetailtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemMovementType]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemMovementType](
	[BusinessUnitID] [int] NOT NULL,
	[MovementTypeID] [int] NOT NULL,
	[MovementTypeName] [nvarchar](150) NULL,
	[AccountCode] [int] NULL,
	[AccountCodeIsRequired] [bit] NULL,
	[UserCanModify] [bit] NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_INVItemMovementType_1] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC,
	[MovementTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemPriceHistory]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemPriceHistory](
	[ItemPriceHistoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[OldPurchasePrice] [money] NULL,
	[NewPurchasePrice] [money] NULL,
	[OldSellingPrice] [money] NULL,
	[NewSellingPrice] [money] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_INVItemPriceHistory] PRIMARY KEY CLUSTERED 
(
	[ItemPriceHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVItemType]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVItemType](
	[ItemTypeID] [int] NOT NULL,
	[ItemTypeName] [nvarchar](100) NULL,
	[ItemTypeDesc] [nvarchar](500) NULL,
	[IsSellingItem] [bit] NULL,
	[IsPurchasingItem] [bit] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_INVItemType] PRIMARY KEY CLUSTERED 
(
	[ItemTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVPrimaryItemBalance]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVPrimaryItemBalance](
	[PrimaryItemBalanceID] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[ItemName] [nvarchar](50) NULL,
	[ItemGroupID] [int] NULL,
	[ItemTypeID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[TotalQuantity] [numeric](18, 2) NULL,
	[PutawayQuantity] [numeric](18, 2) NULL,
	[ValuatedQuantity] [numeric](18, 2) NULL,
 CONSTRAINT [PK_INVPrimaryItemBalance] PRIMARY KEY CLUSTERED 
(
	[PrimaryItemBalanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVPutaway]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVPutaway](
	[PutawayID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[PutawayDate] [datetime] NULL,
	[PutawayBy] [int] NULL,
 CONSTRAINT [PK_INVPutaway] PRIMARY KEY CLUSTERED 
(
	[PutawayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVPutawayDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVPutawayDetail](
	[PutawayDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[PutawayID] [bigint] NOT NULL,
	[BusinessUnitID] [int] NULL,
	[PurchaseReceiptID] [bigint] NULL,
	[PurchaseReceiptDetailsID] [bigint] NOT NULL,
	[PurchaseReceiptDate] [datetime] NULL,
	[PutawayDate] [datetime] NULL,
	[ItemID] [int] NOT NULL,
	[PutawayQty] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[StorageLocationID] [int] NOT NULL,
	[PrimaryItemBalanceID] [bigint] NULL,
	[LineTotal] [money] NULL,
	[UnitPrice] [decimal](18, 6) NULL,
 CONSTRAINT [PK_INVPutawayDetail] PRIMARY KEY CLUSTERED 
(
	[PutawayDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVSOLCDOItemDetailMap]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVSOLCDOItemDetailMap](
	[SOLCDOItemDetailMapID] [uniqueidentifier] NOT NULL,
	[SalesOrderID] [bigint] NULL,
	[LCID] [bigint] NULL,
	[DeliveryID] [bigint] NULL,
	[ItemID] [int] NULL,
	[SalesOrderQty] [money] NULL,
	[LCQty] [money] NULL,
	[DeliveryQty] [money] NULL,
 CONSTRAINT [PK_INVSOLCDOItemDetailMap] PRIMARY KEY CLUSTERED 
(
	[SOLCDOItemDetailMapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVStorageLocation]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVStorageLocation](
	[StorageLocationID] [int] NOT NULL,
	[BusinessUnitID] [int] NOT NULL,
	[LocationID] [int] NULL,
	[StorageLocationName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[InventoryTypeID] [int] NULL,
 CONSTRAINT [PK_INVStorageLocation] PRIMARY KEY CLUSTERED 
(
	[StorageLocationID] ASC,
	[BusinessUnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVUserAndIssuer]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVUserAndIssuer](
	[IssuerID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_INVUserAndIssuer] PRIMARY KEY CLUSTERED 
(
	[IssuerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVUserAndIssuerDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVUserAndIssuerDetail](
	[IssuerID] [bigint] NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_INVUserAndIssuerDetail] PRIMARY KEY CLUSTERED 
(
	[IssuerID] ASC,
	[ItemTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseHistory]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseHistory](
	[PurchaseHistoryID] [uniqueidentifier] NOT NULL,
	[BusinessUnitID] [int] NULL,
	[TransactionDate] [datetime] NULL,
	[PurchaseOrderID] [bigint] NULL,
	[PurchaseOrderDate] [datetime] NULL,
	[PurchaseReceiptID] [bigint] NULL,
	[PurchaseReceiptDate] [datetime] NULL,
	[InvoiceID] [bigint] NULL,
	[InvoiceDate] [datetime] NULL,
	[ItemID] [bigint] NOT NULL,
	[ItemQty] [numeric](18, 2) NOT NULL,
	[ItemUnitPrice] [money] NOT NULL,
	[CurrencyID] [int] NULL,
	[ConversionRate] [money] NULL,
	[OrderUnitPrice] [money] NOT NULL,
	[ItemBalanceQty] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_PRSPurchaseHistory] PRIMARY KEY CLUSTERED 
(
	[PurchaseHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseInvoice]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseInvoice](
	[PurchaseInvoiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[PurchaseOrderID] [bigint] NULL,
	[InvoiceDate] [datetime] NULL,
	[BusinessPartyID] [int] NULL,
	[InvoiceAmount] [money] NULL,
	[MerchandiseAmount] [money] NULL,
	[DiscountAmount] [money] NULL,
	[DebitMemoAmt] [money] NULL,
	[DueDate] [datetime] NULL,
	[InvoiceNote] [nvarchar](2000) NULL,
	[InvoiceStatusID] [int] NULL,
	[PaymentStatusID] [int] NULL,
	[PaymentTerms] [nvarchar](500) NULL,
	[PaymentTermID] [int] NULL,
	[PaymentedAmount] [money] NULL,
	[CurrencyID] [int] NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[ConversionRate] [money] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[AccountingDate] [datetime] NULL,
	[DateAdded] [datetime] NULL,
	[AddedBy] [int] NULL,
	[DateUpdated] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[SalesOrderID] [bigint] NULL,
	[SalesInvoiceID] [bigint] NULL,
	[AdditionalExpConfigID] [int] NULL,
	[CloseType] [nvarchar](10) NULL,
	[CloseReason] [nvarchar](250) NULL,
	[ClosedBy] [int] NULL,
	[ClosingDate] [datetime] NULL,
	[DiscountType] [int] NULL,
	[JournalID] [bigint] NULL,
	[IsCancelled] [bit] NULL,
	[CancelledDate] [datetime] NULL,
	[CancellationReason] [nvarchar](500) NULL,
	[CancelledBy] [int] NULL,
	[SalesBankRefNo] [nvarchar](100) NULL,
	[SalesNegotiationDate] [datetime] NULL,
	[SalesRealizationDate] [datetime] NULL,
	[SalesBLNo] [nvarchar](100) NULL,
	[SalesBLDate] [datetime] NULL,
	[SalesVassel] [nvarchar](250) NULL,
	[PurchasereceiptID] [bigint] NULL,
	[ProjectID] [int] NULL,
	[InvoiceTypeID] [int] NULL,
 CONSTRAINT [PK_PRSPurchaseInvoice] PRIMARY KEY CLUSTERED 
(
	[PurchaseInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseInvoiceDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseInvoiceDetail](
	[PurchaseInvoiceDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [bigint] NULL,
	[PurchaseInvoiceID] [bigint] NOT NULL,
	[ItemID] [int] NULL,
	[PurchaseOrderQty] [numeric](18, 2) NULL,
	[PrevInvoicedQty] [numeric](18, 2) NULL,
	[InvoicedQty] [numeric](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LineTotal] [money] NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[Specification] [nvarchar](500) NULL,
	[GLAccountCode] [int] NULL,
 CONSTRAINT [PK_PRSPurchaseInvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseInvoiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseInvoiceType]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseInvoiceType](
	[InvoiceTypeID] [int] NOT NULL,
	[InvoiceTypeName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSPurchaseInvoiceType] PRIMARY KEY CLUSTERED 
(
	[InvoiceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseOrder]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseOrder](
	[PurchaseOrderID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[ContractLCNo] [nvarchar](150) NULL,
	[PurchaseOrderDate] [datetime] NULL,
	[ShipToLocationID] [int] NULL,
	[PartialShipment] [nvarchar](150) NULL,
	[ShippingAddress] [nvarchar](500) NULL,
	[PaymentTerms] [nvarchar](500) NULL,
	[TotalOrderQty] [numeric](18, 2) NULL,
	[TotalAmount] [money] NULL,
	[CurrencyID] [int] NULL,
	[ConversionRate] [money] NULL,
	[BankBranchID] [int] NULL,
	[OrderStatusID] [int] NULL,
	[POReceiptStatusID] [int] NULL,
	[Note] [nvarchar](500) NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
 CONSTRAINT [PK_PRSPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseOrderDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseOrderDetail](
	[PurchaseOrderDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [bigint] NULL,
	[ItemID] [int] NULL,
	[PurchaseOrderQty] [numeric](18, 2) NULL,
	[PrevInvoicedQty] [numeric](18, 2) NULL,
	[TotalReceivedQty] [numeric](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LineTotal] [money] NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[Specification] [text] NULL,
	[TotalReturnedQuantity] [numeric](18, 2) NULL,
 CONSTRAINT [PK_PRSPurchaseOrderDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseOrderReceiptStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseOrderReceiptStatus](
	[POReceiptStatusID] [int] NOT NULL,
	[POReceiptStatusName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSPOReceiptStatus] PRIMARY KEY CLUSTERED 
(
	[POReceiptStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseOrderStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseOrderStatus](
	[OrderStatusID] [int] NOT NULL,
	[OrderStatusName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSPurchaseOrderStatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchasePayment]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchasePayment](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NULL,
	[PurchaseInvoiceID] [bigint] NULL,
	[PayDate] [datetime] NULL,
	[AccountingDate] [datetime] NULL,
	[PayAmount] [money] NULL,
	[PayModeID] [int] NULL,
	[ReceivingBank] [int] NULL,
	[GLAccountCode] [int] NULL,
	[RecBankCheckNo] [nvarchar](50) NULL,
	[Memo] [varchar](max) NULL,
	[RefNo] [nvarchar](50) NULL,
	[CurrencyID] [int] NULL,
	[FxConversionRate] [money] NULL,
	[JournalID] [bigint] NULL,
	[PurchaseOrderID] [bigint] NULL,
	[PaymentTypeID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[RecBranchID] [int] NULL,
	[RecBankAccountID] [int] NULL,
	[AddedBy] [int] NULL,
	[DateAdded] [datetime] NULL,
	[IsAdvance] [bit] NULL,
	[Balance] [money] NULL,
	[IsCancelled] [bit] NULL,
	[CancelledDate] [datetime] NULL,
	[CancellationReason] [nvarchar](500) NULL,
	[CancelledBy] [int] NULL,
	[projectId] [int] NULL,
	[IsQuick] [bit] NULL,
	[AdjPrepaymentAmount] [money] NULL,
 CONSTRAINT [PK_PRSPurchasePayment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseReceipt]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseReceipt](
	[PurchasereceiptID] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplyerID] [int] NULL,
	[ReceiptDate] [date] NULL,
	[PurchaseOrderID] [bigint] NULL,
	[BusinessUnitID] [int] NULL,
	[ChallanNo] [nvarchar](50) NULL,
	[ChallanDate] [date] NULL,
	[Comments] [nvarchar](200) NULL,
	[RecieptStatusID] [int] NULL,
	[ReceiptInvStatusID] [int] NULL,
	[InvoiceID] [bigint] NULL,
	[ReceivedBy] [int] NULL,
	[JournalID] [bigint] NULL,
	[AccountingDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[AddedDate] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [date] NULL,
	[PostedBy] [int] NULL,
	[PostedDate] [date] NULL,
	[ReceiptReturnStatus] [nvarchar](10) NULL,
 CONSTRAINT [PK_PRSPurchaseReceipt] PRIMARY KEY CLUSTERED 
(
	[PurchasereceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseReceiptDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseReceiptDetail](
	[PurchaseReceiptDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [bigint] NULL,
	[PurchasereceiptID] [bigint] NULL,
	[BusinessUnitID] [int] NULL,
	[ReceiptDate] [date] NULL,
	[ItemID] [int] NULL,
	[PurchaseOrderQty] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[ReceivedQty] [numeric](18, 2) NULL,
	[Remark] [nvarchar](50) NULL,
	[IsPutAway] [bit] NULL,
	[PutawayID] [bigint] NULL,
	[ReturnQty] [numeric](18, 2) NULL,
	[LineTotal] [money] NULL,
	[UnitPrice] [decimal](18, 6) NULL,
 CONSTRAINT [PK_PRSPurchaseReceiptDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseReceiptDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseRecieptStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseRecieptStatus](
	[RecieptStatusID] [int] NOT NULL,
	[RecieptStatusName] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSPurchaseRecieptStatus] PRIMARY KEY CLUSTERED 
(
	[RecieptStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseRequisition]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseRequisition](
	[RequisitionID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[RequisitionDate] [datetime] NULL,
	[ExpectedRecieveDate] [datetime] NULL,
	[TotalOrderQty] [numeric](18, 2) NULL,
	[TotalAmount] [money] NULL,
	[RequisitionStatusID] [int] NULL,
	[Note] [nvarchar](500) NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[ClosedBy] [int] NULL,
	[ClosedDate] [datetime] NULL,
 CONSTRAINT [PK_PRSPurchaseRequisition] PRIMARY KEY CLUSTERED 
(
	[RequisitionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseRequisitionDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseRequisitionDetail](
	[RequisitionDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[RequisitionID] [bigint] NULL,
	[ItemID] [int] NULL,
	[RequistionQty] [numeric](18, 2) NULL,
	[UnitPrice] [money] NULL,
	[LineTotal] [money] NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_PRSPurchaseRequisitionDetail] PRIMARY KEY CLUSTERED 
(
	[RequisitionDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseRequisitionStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseRequisitionStatus](
	[RequisitionStatusID] [int] NOT NULL,
	[RequisitionStatusName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSPurchaseRequisitionStatus] PRIMARY KEY CLUSTERED 
(
	[RequisitionStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseReturn]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseReturn](
	[PurchaseReturnID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseRecieptID] [bigint] NULL,
	[PurchaseOrderID] [bigint] NULL,
	[PurchaseReturnDate] [datetime] NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[ChallanNo] [nvarchar](50) NULL,
	[ChallanDate] [datetime] NULL,
	[Comments] [nvarchar](250) NULL,
	[ReturnStatusID] [int] NULL,
	[CMRequired] [bit] NULL,
	[CreditMemoID] [bigint] NULL,
	[CMStatus] [nvarchar](20) NULL,
	[AccountingDate] [datetime] NULL,
	[JournalID] [bigint] NULL,
 CONSTRAINT [PK_PRSPurchaseReturn] PRIMARY KEY CLUSTERED 
(
	[PurchaseReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseReturnDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseReturnDetail](
	[PurchaseReturnDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseReturnID] [bigint] NULL,
	[PurchaseReceiptID] [bigint] NULL,
	[PurchaseRecipetDetailID] [bigint] NULL,
	[ItemID] [int] NULL,
	[MeasurmentUnitID] [int] NULL,
	[MeasurmentUnitText] [nvarchar](50) NULL,
	[RecieptQty] [numeric](18, 2) NULL,
	[ReturnQty] [numeric](18, 2) NULL,
	[ReturnReason] [nvarchar](50) NULL,
 CONSTRAINT [PK_PRSPurchaseReturnDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseReturnDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSPurchaseReturnStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSPurchaseReturnStatus](
	[ReturnStatusID] [int] NOT NULL,
	[ReturnStatusName] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSPurchaseReturnStatus] PRIMARY KEY CLUSTERED 
(
	[ReturnStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSReceipt_Inv_Status]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSReceipt_Inv_Status](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSReceipt_Inv_Status] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSUserAndReceiver]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSUserAndReceiver](
	[ReceiverID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSUserAndReceiver] PRIMARY KEY CLUSTERED 
(
	[ReceiverID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRSUserAndReceiverDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRSUserAndReceiverDetail](
	[ReceiverID] [bigint] NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PRSUserAndReceiverDetail] PRIMARY KEY CLUSTERED 
(
	[ReceiverID] ASC,
	[ItemTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECApplication]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECApplication](
	[ApplicationID] [int] NOT NULL,
	[ApplicationName] [nvarchar](50) NULL,
	[DisplayOrder] [int] NULL,
	[TileCssClass] [nvarchar](50) NULL,
	[IconImageUrl] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[ApplicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECComponent]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECComponent](
	[ModuleID] [int] NULL,
	[ComponentID] [int] NOT NULL,
	[ComponentName] [nvarchar](100) NULL,
	[IsParent] [bit] NULL,
	[ParentID] [int] NULL,
	[NavigationUrl] [nvarchar](200) NULL,
	[DisplayOrder] [int] NULL,
	[IsActive] [bit] NULL,
	[IsTopMenuItem] [bit] NULL,
 CONSTRAINT [PK_ErpComponent] PRIMARY KEY CLUSTERED 
(
	[ComponentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECModule]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECModule](
	[ApplicationID] [int] NOT NULL,
	[ModuleID] [int] NOT NULL,
	[ModuleName] [nvarchar](100) NULL,
	[DisplayOrder] [int] NULL,
	[IsActive] [bit] NULL,
	[IsParentModule] [bit] NULL,
	[ParentModuleID] [int] NULL,
	[HasChildModule] [bit] NULL,
 CONSTRAINT [PK_SECModule] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECPermissionList]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECPermissionList](
	[PermissionListID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionListName] [nvarchar](100) NULL,
	[ShortDescription] [nvarchar](250) NULL,
	[LongDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_Periscope_Sec_PermissionList_1] PRIMARY KEY CLUSTERED 
(
	[PermissionListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECPermissionListDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECPermissionListDetail](
	[PermissionListDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[PermissionListID] [int] NOT NULL,
	[ModuleID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL,
	[CanView] [bit] NULL,
	[CanAdd] [bit] NULL,
	[CanEdit] [bit] NULL,
	[CanDelete] [bit] NULL,
 CONSTRAINT [PK_PTSL_TB_Admin_PermissionListDetail] PRIMARY KEY CLUSTERED 
(
	[PermissionListID] ASC,
	[ModuleID] ASC,
	[ComponentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECRole]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECRole](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_PTSL_TB_Admin_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECRoleAndPermission]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECRoleAndPermission](
	[RoleID] [int] NOT NULL,
	[PermissionListID] [int] NOT NULL,
	[TimeStamp] [timestamp] NULL,
 CONSTRAINT [PK_PTSL_TB_Admin_RoleAndPermission] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[PermissionListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECUser]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserLoginID] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[EmployeeID] [nvarchar](10) NULL,
	[EmployeeName] [nvarchar](100) NULL,
	[PrimaryEmail] [nvarchar](150) NULL,
	[SecondaryEmail] [nvarchar](150) NULL,
	[PrimaryPhone] [nvarchar](150) NULL,
	[SecondaryPhone] [nvarchar](150) NULL,
	[IsLocked] [bit] NULL,
	[IsActive] [bit] NULL,
	[RowState] [varchar](1) NULL,
	[timestamp] [timestamp] NULL,
	[RowID] [uniqueidentifier] ROWGUIDCOL  NULL,
	[BusinessUnitId] [int] NULL,
 CONSTRAINT [PK_PSTL_Base_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECUserAndBusinessUnit]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECUserAndBusinessUnit](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[OperatingUnitID] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_SECUserAndBusinessUnitID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECUserAndRole]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECUserAndRole](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_SECUserAndRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSAdditionalExpConfig]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSAdditionalExpConfig](
	[AdditionalExpConfigID] [int] NOT NULL,
	[AdditionalExpConfigName] [nvarchar](250) NULL,
	[ItemID] [int] NULL,
	[IsActive] [bit] NULL,
	[BusinessUnitID] [int] NULL,
 CONSTRAINT [PK_SLSAdditionalExpConfig] PRIMARY KEY CLUSTERED 
(
	[AdditionalExpConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSAddlExpDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSAddlExpDetail](
	[SalesInvoiceID] [bigint] NOT NULL,
	[BillLadingNo] [nvarchar](250) NOT NULL,
	[BillLadingDate] [datetime] NOT NULL,
	[Vassel] [nvarchar](250) NOT NULL,
	[DateNegotiation] [datetime] NULL,
	[DateRealization] [datetime] NULL,
	[BankReference] [nvarchar](150) NULL,
	[Subsidy] [nvarchar](50) NULL,
	[Remarks] [nvarchar](250) NULL,
 CONSTRAINT [PK_SLSAddlExpDetail] PRIMARY KEY CLUSTERED 
(
	[SalesInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSCashSalesConfiguration]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSCashSalesConfiguration](
	[ConfigurationID] [int] NOT NULL,
	[BusinessUnitID] [int] NULL,
	[DefaultCustomerID] [int] NULL,
	[GLCashAccountCode] [int] NULL,
	[VATPayableAccountCode] [int] NULL,
	[GDiscountAccountCode] [int] NULL,
	[DefaultVatPercent] [money] NULL,
 CONSTRAINT [PK_SLSCashSalesConfiguration] PRIMARY KEY CLUSTERED 
(
	[ConfigurationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSDeliveryStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSDeliveryStatus](
	[SODeliveryStatusID] [int] NOT NULL,
	[SODeliveryStatusName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_SLSDeliveryStatus] PRIMARY KEY CLUSTERED 
(
	[SODeliveryStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSInvoiceStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSInvoiceStatus](
	[InvStatusID] [int] IDENTITY(1,1) NOT NULL,
	[InvStatusName] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_SLSInvoiveStatus] PRIMARY KEY CLUSTERED 
(
	[InvStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSLC]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSLC](
	[LCID] [bigint] IDENTITY(1,1) NOT NULL,
	[LCNumber] [nvarchar](100) NULL,
	[LCDate] [datetime] NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[LCNotes] [nvarchar](200) NULL,
	[LCMapStatus] [nvarchar](10) NULL,
	[LCTypeID] [int] NULL,
	[LCAmount] [money] NULL,
	[CurrencyID] [int] NULL,
	[LCExpiryDate] [date] NULL,
	[LCExpiryCountryID] [int] NULL,
	[FileNumber] [nvarchar](100) NULL,
	[LCShipByDate] [date] NULL,
	[DaysOfSight] [int] NULL,
	[DocSubmissionDays] [int] NULL,
	[InterestRate] [numeric](18, 2) NULL,
	[PartialShipmentAllow] [bit] NULL,
	[TranshipmentAllow] [bit] NULL,
	[BankID] [int] NULL,
	[BranchID] [int] NULL,
	[BusinessPartyBankID] [int] NULL,
	[ExportLCNumber] [nvarchar](100) NULL,
	[ExportLCDate] [date] NULL,
	[ExportLCNotes] [nvarchar](500) NULL,
	[LCInvoiceStatusID] [int] NULL,
	[LCDocsStatusID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[PostedBy] [int] NULL,
	[PostedDate] [datetime] NULL,
 CONSTRAINT [PK_SLSLC] PRIMARY KEY CLUSTERED 
(
	[LCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSLC_Details]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSLC_Details](
	[BusinessUnitID] [int] NULL,
	[LCID] [bigint] NULL,
	[LCDetailsID] [bigint] IDENTITY(100001,1) NOT NULL,
	[SalesOrderID] [bigint] NULL,
	[SalesOrderDetailsID] [bigint] NULL,
	[SalesOrderRevision] [int] NULL,
	[ItemID] [int] NULL,
	[LCQty] [numeric](18, 2) NULL,
	[LCQtyDelivered] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
 CONSTRAINT [PK_SLSLC_Details] PRIMARY KEY CLUSTERED 
(
	[LCDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSLC_DocsWorkflow]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSLC_DocsWorkflow](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LCID] [bigint] NULL,
	[DocsSubmissionPartyDate] [datetime] NULL,
	[DocsSubmissionPartyNote] [nvarchar](200) NULL,
	[EnteredBy1] [int] NULL,
	[EnteredByDate1] [datetime] NULL,
	[DocsAcceptancePartyDate] [datetime] NULL,
	[DocsAcceptancePartyNote] [nvarchar](200) NULL,
	[EnteredBy2] [int] NULL,
	[EnteredByDate2] [datetime] NULL,
	[DocsSubmissionBankDate] [datetime] NULL,
	[DocsSubmissionBankNote] [nvarchar](200) NULL,
	[EnteredBy3] [int] NULL,
	[EnteredByDate3] [datetime] NULL,
	[DocsAcceptanceBankDate] [datetime] NULL,
	[DocsAcceptanceBankNote] [nvarchar](200) NULL,
	[EnteredBy4] [int] NULL,
	[EnteredByDate4] [datetime] NULL,
 CONSTRAINT [PK_SLSLC_DocsWorkflow] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSLCDocsStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSLCDocsStatus](
	[LCDocsStatusID] [int] IDENTITY(1,1) NOT NULL,
	[LCDocsStatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_SLSLCDocsStatus] PRIMARY KEY CLUSTERED 
(
	[LCDocsStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSLCInvoiceStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSLCInvoiceStatus](
	[LCInvoiceStatusID] [int] IDENTITY(1,1) NOT NULL,
	[LCInvoiceStatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_SLSLCInvoiceStatus] PRIMARY KEY CLUSTERED 
(
	[LCInvoiceStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSMfgInstruction]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSMfgInstruction](
	[MIID] [bigint] IDENTITY(1,1) NOT NULL,
	[MIDate] [datetime] NULL,
	[SalesOrderID] [bigint] NULL,
	[SpecialInstruction] [nvarchar](500) NULL,
	[Survey] [nvarchar](200) NULL,
	[NatureOfWinding] [nvarchar](50) NULL,
	[MaxOilContent] [numeric](18, 2) NULL,
	[SpoolSize] [nvarchar](50) NULL,
	[TPI_TPM] [nvarchar](50) NULL,
	[MoistureRegain] [nvarchar](50) NULL,
	[BreakingStrength] [nvarchar](50) NULL,
	[QualityRatio] [nvarchar](50) NULL,
	[CoV] [nvarchar](50) NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[ContractLCNo] [nvarchar](150) NULL,
	[MaxShipmentDate] [datetime] NULL,
	[PortofDestination] [nvarchar](150) NULL,
	[ShippingMarks] [nvarchar](500) NULL,
	[Note] [nvarchar](500) NULL,
	[ProductionStatusID] [int] NULL,
	[DocumentNumber] [nvarchar](100) NULL,
	[MIStatus] [int] NULL,
	[ApprovedBy] [int] NULL,
	[ApproveDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
 CONSTRAINT [PK_SLSMI] PRIMARY KEY CLUSTERED 
(
	[MIID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSMfgInstructionDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSMfgInstructionDetail](
	[MfgInstructionDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[MIID] [bigint] NULL,
	[ItemID] [int] NULL,
	[SalesOrderQty] [numeric](18, 2) NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[Specification] [nvarchar](500) NULL,
	[BatchID] [int] NULL,
	[PackingID] [int] NULL,
	[SalesOrderDetailsID] [bigint] NULL,
 CONSTRAINT [PK_SLSMfgInstructionDetail] PRIMARY KEY CLUSTERED 
(
	[MfgInstructionDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSMfgInstructionStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSMfgInstructionStatus](
	[MfgInstructionStatusID] [int] NOT NULL,
	[MfgInstructionStatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_SLSMfgInstructionStatus] PRIMARY KEY CLUSTERED 
(
	[MfgInstructionStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesInvoice]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesInvoice](
	[SalesInvoiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[SalesOrderID] [bigint] NULL,
	[LCID] [bigint] NULL,
	[InvoiceDate] [datetime] NULL,
	[BusinessPartyID] [int] NULL,
	[InvoiceAmount] [money] NULL,
	[MerchandiseAmount] [money] NULL,
	[DiscountAmount] [money] NULL,
	[CreditMemoAmt] [money] NULL,
	[DueDate] [datetime] NULL,
	[InvoiceNote] [varchar](2000) NULL,
	[InvoiceStatusID] [int] NULL,
	[PaymentStatusID] [int] NULL,
	[PaymentTerms] [nvarchar](500) NULL,
	[PaymentTermID] [int] NULL,
	[PaymentedAmount] [money] NULL,
	[CurrencyID] [int] NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[ConversionRate] [money] NULL,
	[AccountingDate] [datetime] NULL,
	[CloseType] [nvarchar](10) NULL,
	[CloseReason] [nvarchar](250) NULL,
	[ClosedBy] [int] NULL,
	[ClosingDate] [datetime] NULL,
	[DateAdded] [datetime] NULL,
	[AddedBy] [int] NULL,
	[DateUpdated] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[JournalID] [bigint] NULL,
	[IsCancelled] [bit] NULL,
	[CancelledDate] [datetime] NULL,
	[CancellationReason] [nvarchar](500) NULL,
	[CancelledBy] [int] NULL,
	[DocumentNumber] [nvarchar](100) NULL,
	[ProjectID] [int] NULL,
	[DeliveryID] [bigint] NULL,
	[VATPercentage] [money] NULL,
	[VATAmount] [money] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[SalesInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesInvoiceDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesInvoiceDetail](
	[SalesInvoiceDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesOrderID] [bigint] NULL,
	[LCID] [bigint] NULL,
	[SalesInvoiceID] [bigint] NOT NULL,
	[ItemID] [int] NULL,
	[SalesOrderQty] [numeric](18, 2) NULL,
	[PrevInvoicedQty] [numeric](18, 2) NULL,
	[InvoicedQty] [numeric](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LineTotal] [money] NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[AdvancePayment] [money] NULL,
	[AdjustedTotal] [money] NULL,
	[Specification] [nvarchar](500) NULL,
	[ItemDisplayName] [nvarchar](100) NULL,
	[GLAccountCode] [int] NULL,
	[LineDiscount] [money] NULL,
	[LineDiscountAmount] [money] NULL,
	[LineVAT] [money] NULL,
	[LineVATAmount] [money] NULL,
 CONSTRAINT [PK_SLSSalesInvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[SalesInvoiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrder]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrder](
	[SalesOrderID] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[ContractLCNo] [nvarchar](150) NULL,
	[SalesOrderDate] [datetime] NULL,
	[MaxShipmentDate] [datetime] NULL,
	[PortofDestination] [nvarchar](150) NULL,
	[PartialShipment] [nvarchar](150) NULL,
	[ShippingMarks] [nvarchar](500) NULL,
	[PaymentTerms] [nvarchar](500) NULL,
	[SOPaymentMode] [smallint] NULL,
	[TotalOrderQty] [numeric](18, 2) NULL,
	[TotalAmount] [money] NULL,
	[CurrencyID] [int] NULL,
	[ConversionRate] [money] NULL,
	[BankBranchID] [int] NULL,
	[OrderStatusID] [int] NULL,
	[Note] [nvarchar](500) NULL,
	[MIID] [bigint] NULL,
	[AdvancePayment] [money] NULL,
	[SODeliveryStatusID] [int] NULL,
	[ApprovedBy] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[RejectedBy] [int] NULL,
	[RejectedDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[DateAdded] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[DateUpdated] [datetime] NULL,
	[DocumentNumber] [nvarchar](100) NULL,
	[ChangeOrder] [bigint] NULL,
 CONSTRAINT [PK_SLSSalesOrder] PRIMARY KEY CLUSTERED 
(
	[SalesOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderAmendment]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderAmendment](
	[AmendmentID] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesOrderID] [bigint] NULL,
	[AmendedBy] [int] NULL,
	[AmendedDate] [datetime] NULL,
	[AmendNotes] [nvarchar](200) NULL,
 CONSTRAINT [PK_SLSSalesOrderAmendment] PRIMARY KEY CLUSTERED 
(
	[AmendmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderAmendmentDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderAmendmentDetail](
	[AmendmentDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[AmendmentID] [bigint] NULL,
	[SalesOrderDetailID] [bigint] NULL,
	[ItemID] [int] NULL,
	[PrevQuantity] [numeric](18, 2) NULL,
	[NewQuantity] [numeric](18, 2) NULL,
	[PrevRate] [money] NULL,
	[NewRate] [money] NULL,
 CONSTRAINT [PK_SLSSalesOrderAmendmentDetail] PRIMARY KEY CLUSTERED 
(
	[AmendmentDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderDetail]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderDetail](
	[BusinessUnitID] [int] NULL,
	[SalesOrderDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesOrderID] [bigint] NULL,
	[ItemID] [int] NULL,
	[SalesOrderQty] [numeric](18, 2) NULL,
	[PrevInvoicedQty] [numeric](18, 2) NULL,
	[TotalLCQty] [numeric](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LineTotal] [money] NULL,
	[MeasurementUnitID] [int] NULL,
	[MeasurementUnitText] [nvarchar](50) NULL,
	[Specification] [nvarchar](500) NULL,
	[AdvancePayment] [money] NULL,
	[PrevDeliveredQty] [numeric](18, 2) NULL,
	[ItemDisplayName] [nvarchar](100) NULL,
 CONSTRAINT [PK_SLSSalesOrderDetail] PRIMARY KEY CLUSTERED 
(
	[SalesOrderDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderDetailForDO]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderDetailForDO](
	[SODetailsForDOID] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesOrderDetailsID] [bigint] NULL,
	[SalesOrderID] [bigint] NULL,
	[ItemID] [bigint] NULL,
	[LCQty] [numeric](18, 2) NULL,
	[NonLCQty] [numeric](18, 2) NULL,
	[LCID] [bigint] NULL,
	[DeliveredQty] [numeric](18, 2) NULL,
 CONSTRAINT [PK_SLSSalesOrderDetailForDO] PRIMARY KEY CLUSTERED 
(
	[SODetailsForDOID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderDetailSpec]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderDetailSpec](
	[SalesOrderDetailsID] [bigint] NOT NULL,
	[SpecConfigID] [int] NOT NULL,
	[SpecConfigValue] [nvarchar](250) NULL,
	[SalesOrderID] [bigint] NULL,
 CONSTRAINT [PK_SLSSalesOrderDetailSpec_1] PRIMARY KEY CLUSTERED 
(
	[SalesOrderDetailsID] ASC,
	[SpecConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderSpecConfig]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderSpecConfig](
	[SpecConfigID] [int] NOT NULL,
	[SpecConfigName] [nvarchar](150) NULL,
 CONSTRAINT [PK_SalesOrderSpecConfig] PRIMARY KEY CLUSTERED 
(
	[SpecConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderStatus]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderStatus](
	[OrderStatusID] [int] IDENTITY(1,1) NOT NULL,
	[OrderStatusName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_SLSSalesOrderStatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderTerms]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderTerms](
	[SalesOrderID] [bigint] NOT NULL,
	[SOTermsConfigID] [int] NOT NULL,
	[SOTermsValue] [nvarchar](1000) NULL,
 CONSTRAINT [PK_SLSSalesOrderTerms] PRIMARY KEY CLUSTERED 
(
	[SalesOrderID] ASC,
	[SOTermsConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesOrderTermsConfig]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesOrderTermsConfig](
	[SOTermsConfigID] [int] IDENTITY(1,1) NOT NULL,
	[SOTermsConfigName] [nvarchar](250) NULL,
	[TermsDefaultValue] [nvarchar](1000) NULL,
 CONSTRAINT [PK_SLSSalesOrderTermsConfig] PRIMARY KEY CLUSTERED 
(
	[SOTermsConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesPayment]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesPayment](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[SalesInvoiceID] [bigint] NULL,
	[PayDate] [datetime] NULL,
	[AccouningDate] [datetime] NULL,
	[PayAmount] [money] NULL,
	[Balance] [money] NULL,
	[IsAdvance] [bit] NULL,
	[PayModeID] [int] NULL,
	[ReceivingBank] [int] NULL,
	[GLAccountCode] [int] NULL,
	[RecBankCheckNo] [nvarchar](50) NULL,
	[Memo] [varchar](max) NULL,
	[RefNo] [nvarchar](50) NULL,
	[CurrencyID] [int] NULL,
	[FxConversionRate] [money] NULL,
	[JournalID] [bigint] NULL,
	[SalesOrderID] [bigint] NULL,
	[PaymentTypeID] [int] NULL,
	[BusinessUnitID] [int] NULL,
	[RecBranchID] [int] NULL,
	[RecBankAccountID] [int] NULL,
	[BankChargeAmount] [money] NULL,
	[AddedBy] [int] NULL,
	[DateAdded] [datetime] NULL,
	[IsCancelled] [bit] NULL,
	[CancelledDate] [date] NULL,
	[CancellationReason] [nvarchar](500) NULL,
	[CancelledBy] [int] NULL,
	[AdjPrepaymentAmount] [money] NULL,
 CONSTRAINT [PK_SLSSalesPayment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesReturn]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesReturn](
	[SalesReturnID] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemDeliveryID] [bigint] NULL,
	[SalesOrderID] [bigint] NULL,
	[SalesReturnDate] [datetime] NULL,
	[BusinessUnitID] [int] NULL,
	[BusinessPartyID] [int] NULL,
	[ChallanNo] [nvarchar](50) NULL,
	[ChallanDate] [datetime] NULL,
	[Comments] [nvarchar](250) NULL,
	[ReturnStatus] [nvarchar](50) NULL,
	[AccountingDate] [datetime] NULL,
	[JournalID] [bigint] NULL,
	[CMRequired] [bit] NULL,
	[CreditMemoID] [bigint] NULL,
	[CMStatus] [nvarchar](20) NULL,
 CONSTRAINT [PK_SLSSalesReturn] PRIMARY KEY CLUSTERED 
(
	[SalesReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSalesReturnDetails]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSalesReturnDetails](
	[SalesReturnDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesReturnID] [bigint] NULL,
	[DeliveryDetailID] [bigint] NULL,
	[ItemID] [int] NULL,
	[MeasurmentUnitID] [int] NULL,
	[DeliveryQty] [numeric](18, 2) NULL,
	[ReturnQty] [numeric](18, 2) NULL,
	[ReturnReason] [nvarchar](50) NULL,
	[DeliveryID] [bigint] NULL,
 CONSTRAINT [PK_SLSSalesReturnDetails] PRIMARY KEY CLUSTERED 
(
	[SalesReturnDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSOChange_hdr]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSOChange_hdr](
	[BusinessUnitID] [int] NOT NULL,
	[SO_ID] [bigint] NOT NULL,
	[Chng_Ord_Seq] [int] NOT NULL,
	[FieldName] [nvarchar](100) NOT NULL,
	[Chng_Ord_Batch] [int] NULL,
	[Chng_Value] [nvarchar](500) NULL,
	[ChangedBy] [int] NULL,
	[ChangedDate] [datetime] NULL,
 CONSTRAINT [PK_SLSSOChange_hdr] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC,
	[SO_ID] ASC,
	[Chng_Ord_Seq] ASC,
	[FieldName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSOChange_line]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSOChange_line](
	[BusinessUnitID] [int] NOT NULL,
	[SO_ID] [bigint] NOT NULL,
	[SO_Detail_ID] [bigint] NOT NULL,
	[Chng_Ord_Seq] [int] NOT NULL,
	[FieldName] [nvarchar](100) NOT NULL,
	[Chng_Ord_Batch] [int] NULL,
	[Chng_Value] [nvarchar](500) NULL,
	[ChangedBy] [int] NULL,
	[ChangedDate] [datetime] NULL,
 CONSTRAINT [PK_SLSSOChange_line] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitID] ASC,
	[SO_ID] ASC,
	[SO_Detail_ID] ASC,
	[Chng_Ord_Seq] ASC,
	[FieldName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLSSOPaymentMode]    Script Date: 5/21/2018 5:44:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLSSOPaymentMode](
	[SO_PayModeID] [smallint] IDENTITY(1,1) NOT NULL,
	[SO_PaymodeName] [nvarchar](50) NULL,
	[SO_PaymodeDescription] [nvarchar](200) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_SLSSOPaymentMode] PRIMARY KEY CLUSTERED 
(
	[SO_PayModeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/21/2018 5:44:41 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 5/21/2018 5:44:41 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 5/21/2018 5:44:41 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 5/21/2018 5:44:41 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 5/21/2018 5:44:41 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/21/2018 5:44:41 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BSEBusinessParty] ADD  CONSTRAINT [DF_BSEBusinessParty_IsEmployee]  DEFAULT ((0)) FOR [IsEmployee]
GO
ALTER TABLE [dbo].[FACBilling] ADD  CONSTRAINT [DF_FACBilling_IsAdditionExpense]  DEFAULT ((0)) FOR [IsAdditionExpense]
GO
ALTER TABLE [dbo].[FACChartOfAccount] ADD  CONSTRAINT [DF_FACChartOfAccount_IsGLAccount]  DEFAULT ((1)) FOR [IsGLAccount]
GO
ALTER TABLE [dbo].[FACChartOfAccount] ADD  CONSTRAINT [DF_FACChartOfAccount_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[FACFinSecurityRule] ADD  CONSTRAINT [DF_FACFinSecurityRule_MaxValue]  DEFAULT ((0)) FOR [MaxValue]
GO
ALTER TABLE [dbo].[FACGLedger] ADD  CONSTRAINT [DF_FACGLedger_PostedDrAmount]  DEFAULT ((0)) FOR [PostedDrAmount]
GO
ALTER TABLE [dbo].[FACGLedger] ADD  CONSTRAINT [DF_FACGLedger_PostedCrAmount]  DEFAULT ((0)) FOR [PostedCrAmount]
GO
ALTER TABLE [dbo].[FACGLedger] ADD  CONSTRAINT [DF_FACGLedger_PostedTotalAmount]  DEFAULT ((0)) FOR [PostedTotalAmount]
GO
ALTER TABLE [dbo].[FACGLedger] ADD  CONSTRAINT [DF_FACGLedger_GLedgerID]  DEFAULT (newid()) FOR [GLedgerID]
GO
ALTER TABLE [dbo].[FACInitialBalance] ADD  CONSTRAINT [DF_FACInitialBalance_PostedDrAmount]  DEFAULT ((0)) FOR [PostedDrAmount]
GO
ALTER TABLE [dbo].[FACInitialBalance] ADD  CONSTRAINT [DF_FACInitialBalance_PostedCrAmount]  DEFAULT ((0)) FOR [PostedCrAmount]
GO
ALTER TABLE [dbo].[FACInitialBalance] ADD  CONSTRAINT [DF_FACInitialBalance_PostedTotalAmount]  DEFAULT ((0)) FOR [PostedTotalAmount]
GO
ALTER TABLE [dbo].[FACInitialBalance] ADD  CONSTRAINT [DF_FACInitialBalance_GLedgerID]  DEFAULT (newid()) FOR [GLedgerID]
GO
ALTER TABLE [dbo].[FACJournal] ADD  CONSTRAINT [DF_PTSL_TB_FinAc_Journal_VerifiedDate]  DEFAULT (getdate()) FOR [VerifiedDate]
GO
ALTER TABLE [dbo].[FACJournal] ADD  CONSTRAINT [DF_PTSL_TB_FinAc_Journal_RowID]  DEFAULT (newid()) FOR [RowID]
GO
ALTER TABLE [dbo].[INVItemBalance] ADD  CONSTRAINT [DF_INVItemBalance_AvgPrice]  DEFAULT ((0)) FOR [AvgPrice]
GO
ALTER TABLE [dbo].[INVItemInitialBalance] ADD  CONSTRAINT [DF_INVItemInitialBalance_IsCommited]  DEFAULT ((0)) FOR [IsCommitted]
GO
ALTER TABLE [dbo].[INVItemType] ADD  CONSTRAINT [DF_INVItemType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] ADD  CONSTRAINT [DF_PRSPurchaseInvoice_IsCancelled]  DEFAULT ((0)) FOR [IsCancelled]
GO
ALTER TABLE [dbo].[PRSPurchaseOrderDetail] ADD  CONSTRAINT [DF_PRSPurchaseOrderDetail_PrevInvoicedQty]  DEFAULT ((0)) FOR [PrevInvoicedQty]
GO
ALTER TABLE [dbo].[PRSPurchaseOrderDetail] ADD  CONSTRAINT [DF_PRSPurchaseOrderDetail_PrevInvoicedQty1]  DEFAULT ((0)) FOR [TotalReceivedQty]
GO
ALTER TABLE [dbo].[PRSPurchasePayment] ADD  CONSTRAINT [DF_PRSPurchasePayment_IsCancelled]  DEFAULT ((0)) FOR [IsCancelled]
GO
ALTER TABLE [dbo].[SECUser] ADD  CONSTRAINT [DF_SECUser_RowID]  DEFAULT (newid()) FOR [RowID]
GO
ALTER TABLE [dbo].[SECUserAndBusinessUnit] ADD  CONSTRAINT [DF_SECUserAndBusinessUnit_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[SLSSalesInvoice] ADD  CONSTRAINT [DF_SLSSalesInvoice_IsCancelled]  DEFAULT ((0)) FOR [IsCancelled]
GO
ALTER TABLE [dbo].[SLSSalesOrderDetail] ADD  CONSTRAINT [DF_SLSSalesOrderDetail_InvoicedQty]  DEFAULT ((0)) FOR [PrevInvoicedQty]
GO
ALTER TABLE [dbo].[SLSSalesPayment] ADD  CONSTRAINT [DF_SLSSalesPayment_IsCancelled]  DEFAULT ((0)) FOR [IsCancelled]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[BSEBankAccount]  WITH CHECK ADD  CONSTRAINT [FK_BSEBankAccount_BSEBankInfo] FOREIGN KEY([BankID])
REFERENCES [dbo].[BSEBankInfo] ([BankID])
GO
ALTER TABLE [dbo].[BSEBankAccount] CHECK CONSTRAINT [FK_BSEBankAccount_BSEBankInfo]
GO
ALTER TABLE [dbo].[BSEBankAccount]  WITH CHECK ADD  CONSTRAINT [FK_BSEBankAccount_BSEBranchInfo] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BSEBranchInfo] ([BranchID])
GO
ALTER TABLE [dbo].[BSEBankAccount] CHECK CONSTRAINT [FK_BSEBankAccount_BSEBranchInfo]
GO
ALTER TABLE [dbo].[BSEBranchInfo]  WITH CHECK ADD  CONSTRAINT [FK_BSEBranchInfo_BSEBankInfo] FOREIGN KEY([BankID])
REFERENCES [dbo].[BSEBankInfo] ([BankID])
GO
ALTER TABLE [dbo].[BSEBranchInfo] CHECK CONSTRAINT [FK_BSEBranchInfo_BSEBankInfo]
GO
ALTER TABLE [dbo].[BSEBusinessParty]  WITH CHECK ADD  CONSTRAINT [FK_BSEBusinessParty_BSECountry] FOREIGN KEY([CountryID])
REFERENCES [dbo].[BSECountry] ([CountryID])
GO
ALTER TABLE [dbo].[BSEBusinessParty] CHECK CONSTRAINT [FK_BSEBusinessParty_BSECountry]
GO
ALTER TABLE [dbo].[BSEBusinessPartyBankInfo]  WITH CHECK ADD  CONSTRAINT [FK_BSEBusinessPartyBankInfo_BSEBusinessPartyBankInfo] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[BSEBusinessPartyBankInfo] CHECK CONSTRAINT [FK_BSEBusinessPartyBankInfo_BSEBusinessPartyBankInfo]
GO
ALTER TABLE [dbo].[BSEBusinessPartyBankInfo]  WITH CHECK ADD  CONSTRAINT [FK_BSEBusinessPartyBankInfo_BSECountry] FOREIGN KEY([CountryID])
REFERENCES [dbo].[BSECountry] ([CountryID])
GO
ALTER TABLE [dbo].[BSEBusinessPartyBankInfo] CHECK CONSTRAINT [FK_BSEBusinessPartyBankInfo_BSECountry]
GO
ALTER TABLE [dbo].[BSEBusinessUnit]  WITH CHECK ADD  CONSTRAINT [FK_BSEBusinessUnit_BSECompany] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[BSECompany] ([CompanyID])
GO
ALTER TABLE [dbo].[BSEBusinessUnit] CHECK CONSTRAINT [FK_BSEBusinessUnit_BSECompany]
GO
ALTER TABLE [dbo].[BSEDepartment]  WITH CHECK ADD  CONSTRAINT [FK_BSEDepartment_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[BSEDepartment] CHECK CONSTRAINT [FK_BSEDepartment_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[BSELocation]  WITH CHECK ADD  CONSTRAINT [FK_BSELocation_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[BSELocation] CHECK CONSTRAINT [FK_BSELocation_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[BSELocation]  WITH CHECK ADD  CONSTRAINT [FK_BSELocation_BSECountry] FOREIGN KEY([CountryID])
REFERENCES [dbo].[BSECountry] ([CountryID])
GO
ALTER TABLE [dbo].[BSELocation] CHECK CONSTRAINT [FK_BSELocation_BSECountry]
GO
ALTER TABLE [dbo].[BSEProject]  WITH CHECK ADD  CONSTRAINT [FK_BSEProject__FACChartOfAccount1] FOREIGN KEY([AccountExp])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[BSEProject] CHECK CONSTRAINT [FK_BSEProject__FACChartOfAccount1]
GO
ALTER TABLE [dbo].[BSEProject]  WITH CHECK ADD  CONSTRAINT [FK_BSEProject_BSEBusinessUnit] FOREIGN KEY([BusinessunitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[BSEProject] CHECK CONSTRAINT [FK_BSEProject_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[BSEProject]  WITH CHECK ADD  CONSTRAINT [FK_BSEProject_FACChartOfAccount] FOREIGN KEY([AccountCash])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[BSEProject] CHECK CONSTRAINT [FK_BSEProject_FACChartOfAccount]
GO
ALTER TABLE [dbo].[BSEReportParams]  WITH CHECK ADD  CONSTRAINT [FK_BSEReportParam_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[BSEReportParams] CHECK CONSTRAINT [FK_BSEReportParam_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACAccountConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountConfiguration_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[FACAccountConfiguration] CHECK CONSTRAINT [FK_FACAccountConfiguration_FACChartOfAccount]
GO
ALTER TABLE [dbo].[FACAccountingPeriod]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountingPeriod_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACAccountingPeriod] CHECK CONSTRAINT [FK_FACAccountingPeriod_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACAccountingPeriod]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountingPeriod_FACFiscalYear] FOREIGN KEY([FiscalYearID])
REFERENCES [dbo].[FACFiscalYear] ([FiscalYearID])
GO
ALTER TABLE [dbo].[FACAccountingPeriod] CHECK CONSTRAINT [FK_FACAccountingPeriod_FACFiscalYear]
GO
ALTER TABLE [dbo].[FACAccountingPeriod]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountingPeriod_SECUser] FOREIGN KEY([ClosedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[FACAccountingPeriod] CHECK CONSTRAINT [FK_FACAccountingPeriod_SECUser]
GO
ALTER TABLE [dbo].[FACAccountingPeriod]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountingPeriod_SECUserP] FOREIGN KEY([ReOpenBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[FACAccountingPeriod] CHECK CONSTRAINT [FK_FACAccountingPeriod_SECUserP]
GO
ALTER TABLE [dbo].[FACAccountingPeriodTest]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountingPeriodTest_FACFiscalYearTest] FOREIGN KEY([FiscalYearID])
REFERENCES [dbo].[FACFiscalYearTest] ([FiscalYearID])
GO
ALTER TABLE [dbo].[FACAccountingPeriodTest] CHECK CONSTRAINT [FK_FACAccountingPeriodTest_FACFiscalYearTest]
GO
ALTER TABLE [dbo].[FACAccountingReportType]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountingReportType_FACAccountType] FOREIGN KEY([ReportTypeID])
REFERENCES [dbo].[FACAccountType] ([AccountTypeID])
GO
ALTER TABLE [dbo].[FACAccountingReportType] CHECK CONSTRAINT [FK_FACAccountingReportType_FACAccountType]
GO
ALTER TABLE [dbo].[FACAccountSubType]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountSubType_FACAccountType] FOREIGN KEY([AccountTypeID])
REFERENCES [dbo].[FACAccountType] ([AccountTypeID])
GO
ALTER TABLE [dbo].[FACAccountSubType] CHECK CONSTRAINT [FK_FACAccountSubType_FACAccountType]
GO
ALTER TABLE [dbo].[FACAccountType]  WITH CHECK ADD  CONSTRAINT [FK_FACAccountType_FACAccountMasterType] FOREIGN KEY([AccountMasterTypeID])
REFERENCES [dbo].[FACAccountMasterType] ([AccountMasterTypeID])
GO
ALTER TABLE [dbo].[FACAccountType] CHECK CONSTRAINT [FK_FACAccountType_FACAccountMasterType]
GO
ALTER TABLE [dbo].[FACBilling]  WITH CHECK ADD  CONSTRAINT [FK_FACBilling_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACBilling] CHECK CONSTRAINT [FK_FACBilling_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACBilling]  WITH CHECK ADD  CONSTRAINT [FK_FACBilling_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACBilling] CHECK CONSTRAINT [FK_FACBilling_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACBilling]  WITH CHECK ADD  CONSTRAINT [FK_FACBilling_BSEPaymentStatus] FOREIGN KEY([PaymentStatusID])
REFERENCES [dbo].[BSEPaymentStatus] ([PaymentStatusID])
GO
ALTER TABLE [dbo].[FACBilling] CHECK CONSTRAINT [FK_FACBilling_BSEPaymentStatus]
GO
ALTER TABLE [dbo].[FACBilling]  WITH CHECK ADD  CONSTRAINT [FK_FACBilling_BSEPaymentTerm] FOREIGN KEY([PaymentTermID])
REFERENCES [dbo].[BSEPaymentTerm] ([PaymentTermID])
GO
ALTER TABLE [dbo].[FACBilling] CHECK CONSTRAINT [FK_FACBilling_BSEPaymentTerm]
GO
ALTER TABLE [dbo].[FACBillingDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACBillingDetail_BSEMeasurementUnit] FOREIGN KEY([MeasurementUnitID])
REFERENCES [dbo].[BSEMeasurementUnit] ([UnitID])
GO
ALTER TABLE [dbo].[FACBillingDetail] CHECK CONSTRAINT [FK_FACBillingDetail_BSEMeasurementUnit]
GO
ALTER TABLE [dbo].[FACBillingDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACBillingDetail_FAC_Billing] FOREIGN KEY([BillID])
REFERENCES [dbo].[FACBilling] ([BillID])
GO
ALTER TABLE [dbo].[FACBillingDetail] CHECK CONSTRAINT [FK_FACBillingDetail_FAC_Billing]
GO
ALTER TABLE [dbo].[FACBillingDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACBillingDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[FACBillingDetail] CHECK CONSTRAINT [FK_FACBillingDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[FACChartOfAccount]  WITH CHECK ADD  CONSTRAINT [FK_FACChartOfAccount_FACAccountSubType] FOREIGN KEY([AccountSubTypeID])
REFERENCES [dbo].[FACAccountSubType] ([AccountSubTypeID])
GO
ALTER TABLE [dbo].[FACChartOfAccount] CHECK CONSTRAINT [FK_FACChartOfAccount_FACAccountSubType]
GO
ALTER TABLE [dbo].[FACChartOfAccountsStat]  WITH CHECK ADD  CONSTRAINT [FK_FACChartOfAccountsStat_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[FACChartOfAccountsStat] CHECK CONSTRAINT [FK_FACChartOfAccountsStat_FACChartOfAccount]
GO
ALTER TABLE [dbo].[FACCreditMemo]  WITH CHECK ADD  CONSTRAINT [FK_FACCreditMemo_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACCreditMemo] CHECK CONSTRAINT [FK_FACCreditMemo_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACCreditMemo]  WITH CHECK ADD  CONSTRAINT [FK_FACCreditMemo_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACCreditMemo] CHECK CONSTRAINT [FK_FACCreditMemo_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACCreditMemo]  WITH CHECK ADD  CONSTRAINT [FK_FACCreditMemo_FACCreditMemoStatus] FOREIGN KEY([CreditMemoStatusID])
REFERENCES [dbo].[FACCreditMemoStatus] ([CreditMemoStatusID])
GO
ALTER TABLE [dbo].[FACCreditMemo] CHECK CONSTRAINT [FK_FACCreditMemo_FACCreditMemoStatus]
GO
ALTER TABLE [dbo].[FACDebitMemo]  WITH CHECK ADD  CONSTRAINT [FK_FACDebitMemo_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACDebitMemo] CHECK CONSTRAINT [FK_FACDebitMemo_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACDebitMemo]  WITH CHECK ADD  CONSTRAINT [FK_FACDebitMemo_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACDebitMemo] CHECK CONSTRAINT [FK_FACDebitMemo_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACDebitMemo]  WITH CHECK ADD  CONSTRAINT [FK_FACDebitMemo_FACDebitMemoStatus] FOREIGN KEY([DebitMemoStatusID])
REFERENCES [dbo].[FACDebitMemoStatus] ([DebitMemoStatusID])
GO
ALTER TABLE [dbo].[FACDebitMemo] CHECK CONSTRAINT [FK_FACDebitMemo_FACDebitMemoStatus]
GO
ALTER TABLE [dbo].[FACFiscalYear]  WITH CHECK ADD  CONSTRAINT [FK_FACFiscalYear_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACFiscalYear] CHECK CONSTRAINT [FK_FACFiscalYear_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACGLedger]  WITH CHECK ADD  CONSTRAINT [FK_FACGLedger_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[FACGLedger] CHECK CONSTRAINT [FK_FACGLedger_FACChartOfAccount]
GO
ALTER TABLE [dbo].[FACGLSecurityRuleAndCOA]  WITH CHECK ADD  CONSTRAINT [FK_FACGLSecurityRuleAndCOA_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[FACGLSecurityRuleAndCOA] CHECK CONSTRAINT [FK_FACGLSecurityRuleAndCOA_FACChartOfAccount]
GO
ALTER TABLE [dbo].[FACGLSecurityRuleAndCOA]  WITH CHECK ADD  CONSTRAINT [FK_FACGLSecurityRuleAndCOA_FACGLSecurityRule] FOREIGN KEY([RuleID])
REFERENCES [dbo].[FACGLSecurityRule] ([RuleId])
GO
ALTER TABLE [dbo].[FACGLSecurityRuleAndCOA] CHECK CONSTRAINT [FK_FACGLSecurityRuleAndCOA_FACGLSecurityRule]
GO
ALTER TABLE [dbo].[FACInitialBalance]  WITH CHECK ADD  CONSTRAINT [FK_FACInitialBalance_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[FACInitialBalance] CHECK CONSTRAINT [FK_FACInitialBalance_FACChartOfAccount]
GO
ALTER TABLE [dbo].[FACJournal]  WITH CHECK ADD  CONSTRAINT [FK_FACJournal_BSEBusinessUnit_IntraUnit] FOREIGN KEY([InterUnitBUID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACJournal] CHECK CONSTRAINT [FK_FACJournal_BSEBusinessUnit_IntraUnit]
GO
ALTER TABLE [dbo].[FACJournal]  WITH CHECK ADD  CONSTRAINT [FK_FACJournal_FAC_BusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACJournal] CHECK CONSTRAINT [FK_FACJournal_FAC_BusinessUnit]
GO
ALTER TABLE [dbo].[FACJournal]  WITH CHECK ADD  CONSTRAINT [FK_FACJournal_FACInterUnitTranType] FOREIGN KEY([InterUnitTranTypeID])
REFERENCES [dbo].[FACInterUnitTranType] ([InterUnitTranTypeID])
GO
ALTER TABLE [dbo].[FACJournal] CHECK CONSTRAINT [FK_FACJournal_FACInterUnitTranType]
GO
ALTER TABLE [dbo].[FACJournal]  WITH CHECK ADD  CONSTRAINT [FK_FACJournal_FACJournalType] FOREIGN KEY([JournalTypeID])
REFERENCES [dbo].[FACJournalType] ([JournalTypeID])
GO
ALTER TABLE [dbo].[FACJournal] CHECK CONSTRAINT [FK_FACJournal_FACJournalType]
GO
ALTER TABLE [dbo].[FACJournalDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACJournalDetail_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACJournalDetail] CHECK CONSTRAINT [FK_FACJournalDetail_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACJournalDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACJournalDetail_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[FACJournalDetail] CHECK CONSTRAINT [FK_FACJournalDetail_FACChartOfAccount]
GO
ALTER TABLE [dbo].[FACJournalDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACJournalDetail_FACJournal] FOREIGN KEY([JournalID])
REFERENCES [dbo].[FACJournal] ([JournalID])
GO
ALTER TABLE [dbo].[FACJournalDetail] CHECK CONSTRAINT [FK_FACJournalDetail_FACJournal]
GO
ALTER TABLE [dbo].[FACPayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPayment_BSEBankAccount] FOREIGN KEY([BankAccountID])
REFERENCES [dbo].[BSEBankAccount] ([BankAccountID])
GO
ALTER TABLE [dbo].[FACPayment] CHECK CONSTRAINT [FK_FACPayment_BSEBankAccount]
GO
ALTER TABLE [dbo].[FACPayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPayment_BSEBankInfo] FOREIGN KEY([BankID])
REFERENCES [dbo].[BSEBankInfo] ([BankID])
GO
ALTER TABLE [dbo].[FACPayment] CHECK CONSTRAINT [FK_FACPayment_BSEBankInfo]
GO
ALTER TABLE [dbo].[FACPayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPayment_BSEBranchInfo] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BSEBranchInfo] ([BranchID])
GO
ALTER TABLE [dbo].[FACPayment] CHECK CONSTRAINT [FK_FACPayment_BSEBranchInfo]
GO
ALTER TABLE [dbo].[FACPayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPayment_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACPayment] CHECK CONSTRAINT [FK_FACPayment_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACPayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPayment_BSEPaymentMode] FOREIGN KEY([PaymentModeID])
REFERENCES [dbo].[BSEPaymentMode] ([PayModeID])
GO
ALTER TABLE [dbo].[FACPayment] CHECK CONSTRAINT [FK_FACPayment_BSEPaymentMode]
GO
ALTER TABLE [dbo].[FACPaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACPaymentDetail_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACPaymentDetail] CHECK CONSTRAINT [FK_FACPaymentDetail_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACPaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACPaymentDetail_FACBilling] FOREIGN KEY([BillID])
REFERENCES [dbo].[FACBilling] ([BillID])
GO
ALTER TABLE [dbo].[FACPaymentDetail] CHECK CONSTRAINT [FK_FACPaymentDetail_FACBilling]
GO
ALTER TABLE [dbo].[FACPaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_FACPaymentDetail_FACPayment] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[FACPayment] ([PaymentID])
GO
ALTER TABLE [dbo].[FACPaymentDetail] CHECK CONSTRAINT [FK_FACPaymentDetail_FACPayment]
GO
ALTER TABLE [dbo].[FACPrepayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepayment_BSEBankAccount] FOREIGN KEY([BankAccountID])
REFERENCES [dbo].[BSEBankAccount] ([BankAccountID])
GO
ALTER TABLE [dbo].[FACPrepayment] CHECK CONSTRAINT [FK_FACPrepayment_BSEBankAccount]
GO
ALTER TABLE [dbo].[FACPrepayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepayment_BSEBankInfo] FOREIGN KEY([BankID])
REFERENCES [dbo].[BSEBankInfo] ([BankID])
GO
ALTER TABLE [dbo].[FACPrepayment] CHECK CONSTRAINT [FK_FACPrepayment_BSEBankInfo]
GO
ALTER TABLE [dbo].[FACPrepayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepayment_BSEBranchInfo] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BSEBranchInfo] ([BranchID])
GO
ALTER TABLE [dbo].[FACPrepayment] CHECK CONSTRAINT [FK_FACPrepayment_BSEBranchInfo]
GO
ALTER TABLE [dbo].[FACPrepayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepayment_BSEBusinessParty] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACPrepayment] CHECK CONSTRAINT [FK_FACPrepayment_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACPrepayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepayment_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACPrepayment] CHECK CONSTRAINT [FK_FACPrepayment_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACPrepayment]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepayment_FACPrepaymentInvoice] FOREIGN KEY([PrepaymentInvoiceID])
REFERENCES [dbo].[FACPrepaymentInvoice] ([PrepaymentInvoiceID])
GO
ALTER TABLE [dbo].[FACPrepayment] CHECK CONSTRAINT [FK_FACPrepayment_FACPrepaymentInvoice]
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepaymentInvoice_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice] CHECK CONSTRAINT [FK_FACPrepaymentInvoice_BSEBusinessParty]
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepaymentInvoice_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice] CHECK CONSTRAINT [FK_FACPrepaymentInvoice_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepaymentInvoice_BSECurrency] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[BSECurrency] ([CurrencyID])
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice] CHECK CONSTRAINT [FK_FACPrepaymentInvoice_BSECurrency]
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice]  WITH CHECK ADD  CONSTRAINT [FK_FACPrepaymentInvoice_FACPrepaymentInvoiceStatus] FOREIGN KEY([InvoiceStatusID])
REFERENCES [dbo].[FACPrepaymentInvoiceStatus] ([InvStatusID])
GO
ALTER TABLE [dbo].[FACPrepaymentInvoice] CHECK CONSTRAINT [FK_FACPrepaymentInvoice_FACPrepaymentInvoiceStatus]
GO
ALTER TABLE [dbo].[FACUserAndGLSecurityRule]  WITH CHECK ADD  CONSTRAINT [FK_FACUserAndGLSecurityRule_FACGLSecurityRule] FOREIGN KEY([RuleID])
REFERENCES [dbo].[FACGLSecurityRule] ([RuleId])
GO
ALTER TABLE [dbo].[FACUserAndGLSecurityRule] CHECK CONSTRAINT [FK_FACUserAndGLSecurityRule_FACGLSecurityRule]
GO
ALTER TABLE [dbo].[FACUserAndGLSecurityRule]  WITH CHECK ADD  CONSTRAINT [FK_FACUserAndGLSecurityRule_SECUser] FOREIGN KEY([UserID])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[FACUserAndGLSecurityRule] CHECK CONSTRAINT [FK_FACUserAndGLSecurityRule_SECUser]
GO
ALTER TABLE [dbo].[INVAdjustment]  WITH CHECK ADD  CONSTRAINT [FK_INVAdjustment_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVAdjustment] CHECK CONSTRAINT [FK_INVAdjustment_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVAdjustment]  WITH CHECK ADD  CONSTRAINT [FK_INVAdjustment_FACChartOfAccount] FOREIGN KEY([AccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[INVAdjustment] CHECK CONSTRAINT [FK_INVAdjustment_FACChartOfAccount]
GO
ALTER TABLE [dbo].[INVDeliveryDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVDeliveryDetail_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVDeliveryDetail] CHECK CONSTRAINT [FK_INVDeliveryDetail_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVDeliveryDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVDeliveryDetail_INVDelivery] FOREIGN KEY([DeliveryID])
REFERENCES [dbo].[INVDelivery] ([DeliveryID])
GO
ALTER TABLE [dbo].[INVDeliveryDetail] CHECK CONSTRAINT [FK_INVDeliveryDetail_INVDelivery]
GO
ALTER TABLE [dbo].[INVDeliveryDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVDeliveryDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[INVDeliveryDetail] CHECK CONSTRAINT [FK_INVDeliveryDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[INVInventoryRule]  WITH CHECK ADD  CONSTRAINT [FK_INVInventoryRule_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVInventoryRule] CHECK CONSTRAINT [FK_INVInventoryRule_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVInventoryType]  WITH CHECK ADD  CONSTRAINT [FK_INVInventoryType_FACChartOfAccount] FOREIGN KEY([AccountCodeDr])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[INVInventoryType] CHECK CONSTRAINT [FK_INVInventoryType_FACChartOfAccount]
GO
ALTER TABLE [dbo].[INVItemGroup]  WITH CHECK ADD  CONSTRAINT [FK_INVItemGroup_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVItemGroup] CHECK CONSTRAINT [FK_INVItemGroup_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVItemGroup]  WITH CHECK ADD  CONSTRAINT [FK_INVItemGroup_INVItemType] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[INVItemType] ([ItemTypeID])
GO
ALTER TABLE [dbo].[INVItemGroup] CHECK CONSTRAINT [FK_INVItemGroup_INVItemType]
GO
ALTER TABLE [dbo].[INVItemInfo]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInfo_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVItemInfo] CHECK CONSTRAINT [FK_INVItemInfo_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVItemInfo]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInfo_BSEMeasurementUnit] FOREIGN KEY([MeasurementUnitID])
REFERENCES [dbo].[BSEMeasurementUnit] ([UnitID])
GO
ALTER TABLE [dbo].[INVItemInfo] CHECK CONSTRAINT [FK_INVItemInfo_BSEMeasurementUnit]
GO
ALTER TABLE [dbo].[INVItemInfo]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInfo_FACChartOfAccount] FOREIGN KEY([COGSAccountCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[INVItemInfo] CHECK CONSTRAINT [FK_INVItemInfo_FACChartOfAccount]
GO
ALTER TABLE [dbo].[INVItemInfo]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInfo_FACChartOfAccount1] FOREIGN KEY([IncomeAccCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[INVItemInfo] CHECK CONSTRAINT [FK_INVItemInfo_FACChartOfAccount1]
GO
ALTER TABLE [dbo].[INVItemInfo]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInfo_FACChartOfAccount2] FOREIGN KEY([AssetAccCode])
REFERENCES [dbo].[FACChartOfAccount] ([AccountCode])
GO
ALTER TABLE [dbo].[INVItemInfo] CHECK CONSTRAINT [FK_INVItemInfo_FACChartOfAccount2]
GO
ALTER TABLE [dbo].[INVItemInfo]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInfo_INVItemGroup] FOREIGN KEY([ItemGroupID])
REFERENCES [dbo].[INVItemGroup] ([ItemGroupID])
GO
ALTER TABLE [dbo].[INVItemInfo] CHECK CONSTRAINT [FK_INVItemInfo_INVItemGroup]
GO
ALTER TABLE [dbo].[INVItemInitialBalance]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInitialBalance_BSEBusinessUnit] FOREIGN KEY([ItemBusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVItemInitialBalance] CHECK CONSTRAINT [FK_INVItemInitialBalance_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVItemInitialBalance]  WITH CHECK ADD  CONSTRAINT [FK_INVItemInitialBalance_BSEMeasurementUnit] FOREIGN KEY([MeasurementUnitID])
REFERENCES [dbo].[BSEMeasurementUnit] ([UnitID])
GO
ALTER TABLE [dbo].[INVItemInitialBalance] CHECK CONSTRAINT [FK_INVItemInitialBalance_BSEMeasurementUnit]
GO
ALTER TABLE [dbo].[INVItemMovement]  WITH CHECK ADD  CONSTRAINT [FK_INVItemMovement_BSEBusinessUnit1] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVItemMovement] CHECK CONSTRAINT [FK_INVItemMovement_BSEBusinessUnit1]
GO
ALTER TABLE [dbo].[INVItemMovementDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVItemMovementDetail_INVItemMovement] FOREIGN KEY([MovementID])
REFERENCES [dbo].[INVItemMovement] ([MovementID])
GO
ALTER TABLE [dbo].[INVItemMovementDetail] CHECK CONSTRAINT [FK_INVItemMovementDetail_INVItemMovement]
GO
ALTER TABLE [dbo].[INVItemMovementType]  WITH CHECK ADD  CONSTRAINT [FK_INVItemMovementType_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVItemMovementType] CHECK CONSTRAINT [FK_INVItemMovementType_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVPrimaryItemBalance]  WITH CHECK ADD  CONSTRAINT [FK_INVPrimaryItemBalance_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[INVPrimaryItemBalance] CHECK CONSTRAINT [FK_INVPrimaryItemBalance_INVItemInfo]
GO
ALTER TABLE [dbo].[INVPutaway]  WITH CHECK ADD  CONSTRAINT [FK_INVPutaway_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVPutaway] CHECK CONSTRAINT [FK_INVPutaway_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVPutawayDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVPutawayDetail_BSEMeasurementUnit] FOREIGN KEY([MeasurementUnitID])
REFERENCES [dbo].[BSEMeasurementUnit] ([UnitID])
GO
ALTER TABLE [dbo].[INVPutawayDetail] CHECK CONSTRAINT [FK_INVPutawayDetail_BSEMeasurementUnit]
GO
ALTER TABLE [dbo].[INVPutawayDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVPutawayDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[INVPutawayDetail] CHECK CONSTRAINT [FK_INVPutawayDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[INVPutawayDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVPutawayDetail_INVPutaway] FOREIGN KEY([PutawayID])
REFERENCES [dbo].[INVPutaway] ([PutawayID])
GO
ALTER TABLE [dbo].[INVPutawayDetail] CHECK CONSTRAINT [FK_INVPutawayDetail_INVPutaway]
GO
ALTER TABLE [dbo].[INVStorageLocation]  WITH CHECK ADD  CONSTRAINT [FK_INVStorageLocation_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVStorageLocation] CHECK CONSTRAINT [FK_INVStorageLocation_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVStorageLocation]  WITH CHECK ADD  CONSTRAINT [FK_INVStorageLocation_BSELocation] FOREIGN KEY([LocationID])
REFERENCES [dbo].[BSELocation] ([LocationID])
GO
ALTER TABLE [dbo].[INVStorageLocation] CHECK CONSTRAINT [FK_INVStorageLocation_BSELocation]
GO
ALTER TABLE [dbo].[INVUserAndIssuer]  WITH CHECK ADD  CONSTRAINT [FK_INVUserAndIssuer_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[INVUserAndIssuer] CHECK CONSTRAINT [FK_INVUserAndIssuer_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[INVUserAndIssuerDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVUserAndIssuerDetail_INVItemType] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[INVItemType] ([ItemTypeID])
GO
ALTER TABLE [dbo].[INVUserAndIssuerDetail] CHECK CONSTRAINT [FK_INVUserAndIssuerDetail_INVItemType]
GO
ALTER TABLE [dbo].[INVUserAndIssuerDetail]  WITH CHECK ADD  CONSTRAINT [FK_INVUserAndIssuerDetail_INVUserAndIssuer] FOREIGN KEY([IssuerID])
REFERENCES [dbo].[INVUserAndIssuer] ([IssuerID])
GO
ALTER TABLE [dbo].[INVUserAndIssuerDetail] CHECK CONSTRAINT [FK_INVUserAndIssuerDetail_INVUserAndIssuer]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoice_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] CHECK CONSTRAINT [FK_PRSPurchaseInvoice_BSEBusinessParty]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoice_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] CHECK CONSTRAINT [FK_PRSPurchaseInvoice_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoice_BSECurrency] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[BSECurrency] ([CurrencyID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] CHECK CONSTRAINT [FK_PRSPurchaseInvoice_BSECurrency]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoice_PRSPurchaseInvoiceType] FOREIGN KEY([InvoiceTypeID])
REFERENCES [dbo].[PRSPurchaseInvoiceType] ([InvoiceTypeID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] CHECK CONSTRAINT [FK_PRSPurchaseInvoice_PRSPurchaseInvoiceType]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoice_PRSPurchaseOrder] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[PRSPurchaseOrder] ([PurchaseOrderID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] CHECK CONSTRAINT [FK_PRSPurchaseInvoice_PRSPurchaseOrder]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoice_SLSInvoiceStatus] FOREIGN KEY([InvoiceStatusID])
REFERENCES [dbo].[SLSInvoiceStatus] ([InvStatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoice] CHECK CONSTRAINT [FK_PRSPurchaseInvoice_SLSInvoiceStatus]
GO
ALTER TABLE [dbo].[PRSPurchaseInvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseInvoiceDetail_PRSPurchaseInvoice] FOREIGN KEY([PurchaseInvoiceID])
REFERENCES [dbo].[PRSPurchaseInvoice] ([PurchaseInvoiceID])
GO
ALTER TABLE [dbo].[PRSPurchaseInvoiceDetail] CHECK CONSTRAINT [FK_PRSPurchaseInvoiceDetail_PRSPurchaseInvoice]
GO
ALTER TABLE [dbo].[PRSPurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrder_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrder] CHECK CONSTRAINT [FK_PRSPurchaseOrder_BSEBusinessParty]
GO
ALTER TABLE [dbo].[PRSPurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrder_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrder] CHECK CONSTRAINT [FK_PRSPurchaseOrder_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[PRSPurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrder_BSECurrency] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[BSECurrency] ([CurrencyID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrder] CHECK CONSTRAINT [FK_PRSPurchaseOrder_BSECurrency]
GO
ALTER TABLE [dbo].[PRSPurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrder_BSELocation] FOREIGN KEY([ShipToLocationID])
REFERENCES [dbo].[BSELocation] ([LocationID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrder] CHECK CONSTRAINT [FK_PRSPurchaseOrder_BSELocation]
GO
ALTER TABLE [dbo].[PRSPurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrder_PRSPurchaseOrderReceiptStatus] FOREIGN KEY([POReceiptStatusID])
REFERENCES [dbo].[PRSPurchaseOrderReceiptStatus] ([POReceiptStatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrder] CHECK CONSTRAINT [FK_PRSPurchaseOrder_PRSPurchaseOrderReceiptStatus]
GO
ALTER TABLE [dbo].[PRSPurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrder_PRSPurchaseOrderStatus] FOREIGN KEY([OrderStatusID])
REFERENCES [dbo].[PRSPurchaseOrderStatus] ([OrderStatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrder] CHECK CONSTRAINT [FK_PRSPurchaseOrder_PRSPurchaseOrderStatus]
GO
ALTER TABLE [dbo].[PRSPurchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrderDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrderDetail] CHECK CONSTRAINT [FK_PRSPurchaseOrderDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[PRSPurchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseOrderDetail_PRSPurchaseOrder] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[PRSPurchaseOrder] ([PurchaseOrderID])
GO
ALTER TABLE [dbo].[PRSPurchaseOrderDetail] CHECK CONSTRAINT [FK_PRSPurchaseOrderDetail_PRSPurchaseOrder]
GO
ALTER TABLE [dbo].[PRSPurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchasePayment_BSEBankAccount] FOREIGN KEY([RecBankAccountID])
REFERENCES [dbo].[BSEBankAccount] ([BankAccountID])
GO
ALTER TABLE [dbo].[PRSPurchasePayment] CHECK CONSTRAINT [FK_PRSPurchasePayment_BSEBankAccount]
GO
ALTER TABLE [dbo].[PRSPurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchasePayment_BSEBankInfo] FOREIGN KEY([ReceivingBank])
REFERENCES [dbo].[BSEBankInfo] ([BankID])
GO
ALTER TABLE [dbo].[PRSPurchasePayment] CHECK CONSTRAINT [FK_PRSPurchasePayment_BSEBankInfo]
GO
ALTER TABLE [dbo].[PRSPurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchasePayment_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[PRSPurchasePayment] CHECK CONSTRAINT [FK_PRSPurchasePayment_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[PRSPurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchasePayment_BSEPaymentMode] FOREIGN KEY([PayModeID])
REFERENCES [dbo].[BSEPaymentMode] ([PayModeID])
GO
ALTER TABLE [dbo].[PRSPurchasePayment] CHECK CONSTRAINT [FK_PRSPurchasePayment_BSEPaymentMode]
GO
ALTER TABLE [dbo].[PRSPurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchasePayment_BSEPaymentType] FOREIGN KEY([PaymentTypeID])
REFERENCES [dbo].[BSEPaymentType] ([PaymentTypeID])
GO
ALTER TABLE [dbo].[PRSPurchasePayment] CHECK CONSTRAINT [FK_PRSPurchasePayment_BSEPaymentType]
GO
ALTER TABLE [dbo].[PRSPurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchasePayment_PRSPurchaseInvoice] FOREIGN KEY([PurchaseInvoiceID])
REFERENCES [dbo].[PRSPurchaseInvoice] ([PurchaseInvoiceID])
GO
ALTER TABLE [dbo].[PRSPurchasePayment] CHECK CONSTRAINT [FK_PRSPurchasePayment_PRSPurchaseInvoice]
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceipt_BSEBusinessParty1] FOREIGN KEY([SupplyerID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt] CHECK CONSTRAINT [FK_PRSPurchaseReceipt_BSEBusinessParty1]
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceipt_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt] CHECK CONSTRAINT [FK_PRSPurchaseReceipt_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceipt_PRSPurchaseOrder] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[PRSPurchaseOrder] ([PurchaseOrderID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt] CHECK CONSTRAINT [FK_PRSPurchaseReceipt_PRSPurchaseOrder]
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceipt_PRSPurchaseRecieptStatus] FOREIGN KEY([RecieptStatusID])
REFERENCES [dbo].[PRSPurchaseRecieptStatus] ([RecieptStatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt] CHECK CONSTRAINT [FK_PRSPurchaseReceipt_PRSPurchaseRecieptStatus]
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceipt_PRSReceipt_Inv_Status] FOREIGN KEY([ReceiptInvStatusID])
REFERENCES [dbo].[PRSReceipt_Inv_Status] ([StatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt] CHECK CONSTRAINT [FK_PRSPurchaseReceipt_PRSReceipt_Inv_Status]
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceipt_SECUser] FOREIGN KEY([ReceivedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceipt] CHECK CONSTRAINT [FK_PRSPurchaseReceipt_SECUser]
GO
ALTER TABLE [dbo].[PRSPurchaseReceiptDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceiptDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceiptDetail] CHECK CONSTRAINT [FK_PRSPurchaseReceiptDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[PRSPurchaseReceiptDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReceiptDetail_PRSPurchaseReceipt] FOREIGN KEY([PurchasereceiptID])
REFERENCES [dbo].[PRSPurchaseReceipt] ([PurchasereceiptID])
GO
ALTER TABLE [dbo].[PRSPurchaseReceiptDetail] CHECK CONSTRAINT [FK_PRSPurchaseReceiptDetail_PRSPurchaseReceipt]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_PRSPurchaseRequisitionStatus] FOREIGN KEY([RequisitionStatusID])
REFERENCES [dbo].[PRSPurchaseRequisitionStatus] ([RequisitionStatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_PRSPurchaseRequisitionStatus]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_SECUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_SECUser]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_SECUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_SECUser1]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_SECUser2] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_SECUser2]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_SECUser3] FOREIGN KEY([ClosedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_SECUser3]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_SECUser4] FOREIGN KEY([RejectedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_SECUser4]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisition_SECUser5] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisition] CHECK CONSTRAINT [FK_PRSPurchaseRequisition_SECUser5]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisitionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisitionDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisitionDetail] CHECK CONSTRAINT [FK_PRSPurchaseRequisitionDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[PRSPurchaseRequisitionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseRequisitionDetail_PRSPurchaseRequisition] FOREIGN KEY([RequisitionID])
REFERENCES [dbo].[PRSPurchaseRequisition] ([RequisitionID])
GO
ALTER TABLE [dbo].[PRSPurchaseRequisitionDetail] CHECK CONSTRAINT [FK_PRSPurchaseRequisitionDetail_PRSPurchaseRequisition]
GO
ALTER TABLE [dbo].[PRSPurchaseReturn]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReturn_PRSPurchaseReturnStatus] FOREIGN KEY([ReturnStatusID])
REFERENCES [dbo].[PRSPurchaseReturnStatus] ([ReturnStatusID])
GO
ALTER TABLE [dbo].[PRSPurchaseReturn] CHECK CONSTRAINT [FK_PRSPurchaseReturn_PRSPurchaseReturnStatus]
GO
ALTER TABLE [dbo].[PRSPurchaseReturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReturnDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[PRSPurchaseReturnDetail] CHECK CONSTRAINT [FK_PRSPurchaseReturnDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[PRSPurchaseReturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSPurchaseReturnDetail_PRSPurchaseReturn] FOREIGN KEY([PurchaseReturnID])
REFERENCES [dbo].[PRSPurchaseReturn] ([PurchaseReturnID])
GO
ALTER TABLE [dbo].[PRSPurchaseReturnDetail] CHECK CONSTRAINT [FK_PRSPurchaseReturnDetail_PRSPurchaseReturn]
GO
ALTER TABLE [dbo].[PRSUserAndReceiver]  WITH CHECK ADD  CONSTRAINT [FK_PRSUserAndReceiver_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[PRSUserAndReceiver] CHECK CONSTRAINT [FK_PRSUserAndReceiver_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[PRSUserAndReceiverDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSUserAndReceiverDetail_INVItemType] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[INVItemType] ([ItemTypeID])
GO
ALTER TABLE [dbo].[PRSUserAndReceiverDetail] CHECK CONSTRAINT [FK_PRSUserAndReceiverDetail_INVItemType]
GO
ALTER TABLE [dbo].[PRSUserAndReceiverDetail]  WITH CHECK ADD  CONSTRAINT [FK_PRSUserAndReceiverDetail_PRSUserAndReceiver] FOREIGN KEY([ReceiverID])
REFERENCES [dbo].[PRSUserAndReceiver] ([ReceiverID])
GO
ALTER TABLE [dbo].[PRSUserAndReceiverDetail] CHECK CONSTRAINT [FK_PRSUserAndReceiverDetail_PRSUserAndReceiver]
GO
ALTER TABLE [dbo].[SECModule]  WITH CHECK ADD  CONSTRAINT [FK_SECModule_SECApplication] FOREIGN KEY([ApplicationID])
REFERENCES [dbo].[SECApplication] ([ApplicationID])
GO
ALTER TABLE [dbo].[SECModule] CHECK CONSTRAINT [FK_SECModule_SECApplication]
GO
ALTER TABLE [dbo].[SECPermissionListDetail]  WITH CHECK ADD  CONSTRAINT [FK_SECPermissionListDetail_SECComponent1] FOREIGN KEY([ComponentID])
REFERENCES [dbo].[SECComponent] ([ComponentID])
GO
ALTER TABLE [dbo].[SECPermissionListDetail] CHECK CONSTRAINT [FK_SECPermissionListDetail_SECComponent1]
GO
ALTER TABLE [dbo].[SECPermissionListDetail]  WITH CHECK ADD  CONSTRAINT [FK_SECPermissionListDetail_SECPermissionList] FOREIGN KEY([PermissionListID])
REFERENCES [dbo].[SECPermissionList] ([PermissionListID])
GO
ALTER TABLE [dbo].[SECPermissionListDetail] CHECK CONSTRAINT [FK_SECPermissionListDetail_SECPermissionList]
GO
ALTER TABLE [dbo].[SECRoleAndPermission]  WITH CHECK ADD  CONSTRAINT [FK_SECRoleAndPermission_SECPermissionList] FOREIGN KEY([PermissionListID])
REFERENCES [dbo].[SECPermissionList] ([PermissionListID])
GO
ALTER TABLE [dbo].[SECRoleAndPermission] CHECK CONSTRAINT [FK_SECRoleAndPermission_SECPermissionList]
GO
ALTER TABLE [dbo].[SECRoleAndPermission]  WITH CHECK ADD  CONSTRAINT [FK_SECRoleAndPermission_SECRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[SECRole] ([RoleID])
GO
ALTER TABLE [dbo].[SECRoleAndPermission] CHECK CONSTRAINT [FK_SECRoleAndPermission_SECRole]
GO
ALTER TABLE [dbo].[SECUserAndBusinessUnit]  WITH CHECK ADD  CONSTRAINT [FK_SECUserAndBusinessUnit_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[SECUserAndBusinessUnit] CHECK CONSTRAINT [FK_SECUserAndBusinessUnit_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[SECUserAndBusinessUnit]  WITH CHECK ADD  CONSTRAINT [FK_SECUserAndBusinessUnit_SECUser] FOREIGN KEY([UserID])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[SECUserAndBusinessUnit] CHECK CONSTRAINT [FK_SECUserAndBusinessUnit_SECUser]
GO
ALTER TABLE [dbo].[SECUserAndRole]  WITH CHECK ADD  CONSTRAINT [FK_SECUserAndRole_SECRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[SECRole] ([RoleID])
GO
ALTER TABLE [dbo].[SECUserAndRole] CHECK CONSTRAINT [FK_SECUserAndRole_SECRole]
GO
ALTER TABLE [dbo].[SECUserAndRole]  WITH CHECK ADD  CONSTRAINT [FK_SECUserAndRole_SECUser] FOREIGN KEY([UserID])
REFERENCES [dbo].[SECUser] ([UserID])
GO
ALTER TABLE [dbo].[SECUserAndRole] CHECK CONSTRAINT [FK_SECUserAndRole_SECUser]
GO
ALTER TABLE [dbo].[SLSAdditionalExpConfig]  WITH CHECK ADD  CONSTRAINT [FK_SLSAdditionalExpConfig_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[SLSAdditionalExpConfig] CHECK CONSTRAINT [FK_SLSAdditionalExpConfig_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[SLSAdditionalExpConfig]  WITH CHECK ADD  CONSTRAINT [FK_SLSAdditionalExpConfig_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[SLSAdditionalExpConfig] CHECK CONSTRAINT [FK_SLSAdditionalExpConfig_INVItemInfo]
GO
ALTER TABLE [dbo].[SLSAddlExpDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSAddlExpDetail_SLSSalesInvoice] FOREIGN KEY([SalesInvoiceID])
REFERENCES [dbo].[SLSSalesInvoice] ([SalesInvoiceID])
GO
ALTER TABLE [dbo].[SLSAddlExpDetail] CHECK CONSTRAINT [FK_SLSAddlExpDetail_SLSSalesInvoice]
GO
ALTER TABLE [dbo].[SLSLC]  WITH CHECK ADD  CONSTRAINT [FK_SLSLC_SLSLCDocsStatus] FOREIGN KEY([LCDocsStatusID])
REFERENCES [dbo].[SLSLCDocsStatus] ([LCDocsStatusID])
GO
ALTER TABLE [dbo].[SLSLC] CHECK CONSTRAINT [FK_SLSLC_SLSLCDocsStatus]
GO
ALTER TABLE [dbo].[SLSLC]  WITH CHECK ADD  CONSTRAINT [FK_SLSLC_SLSLCInvoiceStatus] FOREIGN KEY([LCInvoiceStatusID])
REFERENCES [dbo].[SLSLCInvoiceStatus] ([LCInvoiceStatusID])
GO
ALTER TABLE [dbo].[SLSLC] CHECK CONSTRAINT [FK_SLSLC_SLSLCInvoiceStatus]
GO
ALTER TABLE [dbo].[SLSLC_Details]  WITH CHECK ADD  CONSTRAINT [FK_SLSLC_Details_SLSLC] FOREIGN KEY([LCID])
REFERENCES [dbo].[SLSLC] ([LCID])
GO
ALTER TABLE [dbo].[SLSLC_Details] CHECK CONSTRAINT [FK_SLSLC_Details_SLSLC]
GO
ALTER TABLE [dbo].[SLSLC_DocsWorkflow]  WITH CHECK ADD  CONSTRAINT [FK_SLSLC_DocsWorkflow_SLSLC] FOREIGN KEY([LCID])
REFERENCES [dbo].[SLSLC] ([LCID])
GO
ALTER TABLE [dbo].[SLSLC_DocsWorkflow] CHECK CONSTRAINT [FK_SLSLC_DocsWorkflow_SLSLC]
GO
ALTER TABLE [dbo].[SLSMfgInstruction]  WITH CHECK ADD  CONSTRAINT [FK_SLSMfgInstruction_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[SLSMfgInstruction] CHECK CONSTRAINT [FK_SLSMfgInstruction_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[SLSMfgInstruction]  WITH CHECK ADD  CONSTRAINT [FK_SLSMfgInstruction_SLSMfgInstructionStatus] FOREIGN KEY([MIStatus])
REFERENCES [dbo].[SLSMfgInstructionStatus] ([MfgInstructionStatusID])
GO
ALTER TABLE [dbo].[SLSMfgInstruction] CHECK CONSTRAINT [FK_SLSMfgInstruction_SLSMfgInstructionStatus]
GO
ALTER TABLE [dbo].[SLSMfgInstruction]  WITH CHECK ADD  CONSTRAINT [FK_SLSMfgInstruction_SLSSalesOrder] FOREIGN KEY([SalesOrderID])
REFERENCES [dbo].[SLSSalesOrder] ([SalesOrderID])
GO
ALTER TABLE [dbo].[SLSMfgInstruction] CHECK CONSTRAINT [FK_SLSMfgInstruction_SLSSalesOrder]
GO
ALTER TABLE [dbo].[SLSMfgInstructionDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSMfgInstructionDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[SLSMfgInstructionDetail] CHECK CONSTRAINT [FK_SLSMfgInstructionDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[SLSMfgInstructionDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSMfgInstructionDetail_SLSMfgInstruction] FOREIGN KEY([MIID])
REFERENCES [dbo].[SLSMfgInstruction] ([MIID])
GO
ALTER TABLE [dbo].[SLSMfgInstructionDetail] CHECK CONSTRAINT [FK_SLSMfgInstructionDetail_SLSMfgInstruction]
GO
ALTER TABLE [dbo].[SLSSalesInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesInvoice_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[SLSSalesInvoice] CHECK CONSTRAINT [FK_SLSSalesInvoice_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[SLSSalesInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesInvoice_BSEPaymentStatus] FOREIGN KEY([PaymentStatusID])
REFERENCES [dbo].[BSEPaymentStatus] ([PaymentStatusID])
GO
ALTER TABLE [dbo].[SLSSalesInvoice] CHECK CONSTRAINT [FK_SLSSalesInvoice_BSEPaymentStatus]
GO
ALTER TABLE [dbo].[SLSSalesInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesInvoice_SLSInvoiceStatus] FOREIGN KEY([InvoiceStatusID])
REFERENCES [dbo].[SLSInvoiceStatus] ([InvStatusID])
GO
ALTER TABLE [dbo].[SLSSalesInvoice] CHECK CONSTRAINT [FK_SLSSalesInvoice_SLSInvoiceStatus]
GO
ALTER TABLE [dbo].[SLSSalesInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesInvoice_SLSLC] FOREIGN KEY([LCID])
REFERENCES [dbo].[SLSLC] ([LCID])
GO
ALTER TABLE [dbo].[SLSSalesInvoice] CHECK CONSTRAINT [FK_SLSSalesInvoice_SLSLC]
GO
ALTER TABLE [dbo].[SLSSalesInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesInvoice_SLSSalesOrder] FOREIGN KEY([SalesOrderID])
REFERENCES [dbo].[SLSSalesOrder] ([SalesOrderID])
GO
ALTER TABLE [dbo].[SLSSalesInvoice] CHECK CONSTRAINT [FK_SLSSalesInvoice_SLSSalesOrder]
GO
ALTER TABLE [dbo].[SLSSalesInvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesInvoiceDetail_SLSSalesInvoice] FOREIGN KEY([SalesInvoiceID])
REFERENCES [dbo].[SLSSalesInvoice] ([SalesInvoiceID])
GO
ALTER TABLE [dbo].[SLSSalesInvoiceDetail] CHECK CONSTRAINT [FK_SLSSalesInvoiceDetail_SLSSalesInvoice]
GO
ALTER TABLE [dbo].[SLSSalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrder_BSEBusinessParty] FOREIGN KEY([BusinessPartyID])
REFERENCES [dbo].[BSEBusinessParty] ([BusinessPartyID])
GO
ALTER TABLE [dbo].[SLSSalesOrder] CHECK CONSTRAINT [FK_SLSSalesOrder_BSEBusinessParty]
GO
ALTER TABLE [dbo].[SLSSalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrder_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[SLSSalesOrder] CHECK CONSTRAINT [FK_SLSSalesOrder_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[SLSSalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrder_BSECurrency] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[BSECurrency] ([CurrencyID])
GO
ALTER TABLE [dbo].[SLSSalesOrder] CHECK CONSTRAINT [FK_SLSSalesOrder_BSECurrency]
GO
ALTER TABLE [dbo].[SLSSalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrder_SLSDeliveryStatus] FOREIGN KEY([SODeliveryStatusID])
REFERENCES [dbo].[SLSDeliveryStatus] ([SODeliveryStatusID])
GO
ALTER TABLE [dbo].[SLSSalesOrder] CHECK CONSTRAINT [FK_SLSSalesOrder_SLSDeliveryStatus]
GO
ALTER TABLE [dbo].[SLSSalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrder_SLSSalesOrderStatus] FOREIGN KEY([OrderStatusID])
REFERENCES [dbo].[SLSSalesOrderStatus] ([OrderStatusID])
GO
ALTER TABLE [dbo].[SLSSalesOrder] CHECK CONSTRAINT [FK_SLSSalesOrder_SLSSalesOrderStatus]
GO
ALTER TABLE [dbo].[SLSSalesOrderAmendmentDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrderAmendmentDetail_SLSSalesOrderAmendment] FOREIGN KEY([AmendmentID])
REFERENCES [dbo].[SLSSalesOrderAmendment] ([AmendmentID])
GO
ALTER TABLE [dbo].[SLSSalesOrderAmendmentDetail] CHECK CONSTRAINT [FK_SLSSalesOrderAmendmentDetail_SLSSalesOrderAmendment]
GO
ALTER TABLE [dbo].[SLSSalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrderDetail_INVItemInfo] FOREIGN KEY([ItemID])
REFERENCES [dbo].[INVItemInfo] ([ItemID])
GO
ALTER TABLE [dbo].[SLSSalesOrderDetail] CHECK CONSTRAINT [FK_SLSSalesOrderDetail_INVItemInfo]
GO
ALTER TABLE [dbo].[SLSSalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrderDetail_SLSSalesOrder] FOREIGN KEY([SalesOrderID])
REFERENCES [dbo].[SLSSalesOrder] ([SalesOrderID])
GO
ALTER TABLE [dbo].[SLSSalesOrderDetail] CHECK CONSTRAINT [FK_SLSSalesOrderDetail_SLSSalesOrder]
GO
ALTER TABLE [dbo].[SLSSalesOrderDetailSpec]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrderDetailSpec_SLSSalesOrderDetail] FOREIGN KEY([SalesOrderDetailsID])
REFERENCES [dbo].[SLSSalesOrderDetail] ([SalesOrderDetailsID])
GO
ALTER TABLE [dbo].[SLSSalesOrderDetailSpec] CHECK CONSTRAINT [FK_SLSSalesOrderDetailSpec_SLSSalesOrderDetail]
GO
ALTER TABLE [dbo].[SLSSalesOrderDetailSpec]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesOrderDetailSpec_SLSSalesOrderSpecConfig] FOREIGN KEY([SpecConfigID])
REFERENCES [dbo].[SLSSalesOrderSpecConfig] ([SpecConfigID])
GO
ALTER TABLE [dbo].[SLSSalesOrderDetailSpec] CHECK CONSTRAINT [FK_SLSSalesOrderDetailSpec_SLSSalesOrderSpecConfig]
GO
ALTER TABLE [dbo].[SLSSalesPayment]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesPayment_BSEBankAccount] FOREIGN KEY([RecBankAccountID])
REFERENCES [dbo].[BSEBankAccount] ([BankAccountID])
GO
ALTER TABLE [dbo].[SLSSalesPayment] CHECK CONSTRAINT [FK_SLSSalesPayment_BSEBankAccount]
GO
ALTER TABLE [dbo].[SLSSalesPayment]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesPayment_BSEBankInfo] FOREIGN KEY([ReceivingBank])
REFERENCES [dbo].[BSEBankInfo] ([BankID])
GO
ALTER TABLE [dbo].[SLSSalesPayment] CHECK CONSTRAINT [FK_SLSSalesPayment_BSEBankInfo]
GO
ALTER TABLE [dbo].[SLSSalesPayment]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesPayment_BSEBusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BSEBusinessUnit] ([BusinessUnitID])
GO
ALTER TABLE [dbo].[SLSSalesPayment] CHECK CONSTRAINT [FK_SLSSalesPayment_BSEBusinessUnit]
GO
ALTER TABLE [dbo].[SLSSalesPayment]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesPayment_BSEPaymentMode] FOREIGN KEY([PayModeID])
REFERENCES [dbo].[BSEPaymentMode] ([PayModeID])
GO
ALTER TABLE [dbo].[SLSSalesPayment] CHECK CONSTRAINT [FK_SLSSalesPayment_BSEPaymentMode]
GO
ALTER TABLE [dbo].[SLSSalesPayment]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesPayment_BSEPaymentType] FOREIGN KEY([PaymentTypeID])
REFERENCES [dbo].[BSEPaymentType] ([PaymentTypeID])
GO
ALTER TABLE [dbo].[SLSSalesPayment] CHECK CONSTRAINT [FK_SLSSalesPayment_BSEPaymentType]
GO
ALTER TABLE [dbo].[SLSSalesPayment]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesPayment_SLSSalesInvoice] FOREIGN KEY([SalesInvoiceID])
REFERENCES [dbo].[SLSSalesInvoice] ([SalesInvoiceID])
GO
ALTER TABLE [dbo].[SLSSalesPayment] CHECK CONSTRAINT [FK_SLSSalesPayment_SLSSalesInvoice]
GO
ALTER TABLE [dbo].[SLSSalesReturnDetails]  WITH CHECK ADD  CONSTRAINT [FK_SLSSalesReturnDetails_SLSSalesReturn] FOREIGN KEY([SalesReturnID])
REFERENCES [dbo].[SLSSalesReturn] ([SalesReturnID])
GO
ALTER TABLE [dbo].[SLSSalesReturnDetails] CHECK CONSTRAINT [FK_SLSSalesReturnDetails_SLSSalesReturn]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'D=Debit
C=Credit
N=Not Defined
R=Reverse. Example: Asset-Debit, Accomulated Depreciation should be Credit.
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FACAccountSubType', @level2type=N'COLUMN',@level2name=N'NatureDrCr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'D=Debit
C=Credit
N=Not Defined
R=Reverse. Example: Asset-Debit, Accomulated Depreciation should be Credit.
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FACAccountType', @level2type=N'COLUMN',@level2name=N'NatureDrCr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User ID from user Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'INVPutaway', @level2type=N'COLUMN',@level2name=N'PutawayBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User ID from user Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'INVPutawayDetail', @level2type=N'COLUMN',@level2name=N'PutawayQty'
GO
USE [master]
GO
ALTER DATABASE [PlacovuEnterprise] SET  READ_WRITE 
GO
