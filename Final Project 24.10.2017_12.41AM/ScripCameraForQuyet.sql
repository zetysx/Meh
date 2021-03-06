USE [master]
GO
/****** Object:  Database [CameraShop]    Script Date: 11/2/2017 4:24:19 PM ******/
CREATE DATABASE [CameraShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CameraShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.AKIYAMA\MSSQL\DATA\CameraShop.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CameraShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.AKIYAMA\MSSQL\DATA\CameraShop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CameraShop] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CameraShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CameraShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CameraShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CameraShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CameraShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CameraShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CameraShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CameraShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CameraShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CameraShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CameraShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CameraShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CameraShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CameraShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CameraShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CameraShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CameraShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CameraShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CameraShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CameraShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CameraShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CameraShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CameraShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CameraShop] SET RECOVERY FULL 
GO
ALTER DATABASE [CameraShop] SET  MULTI_USER 
GO
ALTER DATABASE [CameraShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CameraShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CameraShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CameraShop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CameraShop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CameraShop', N'ON'
GO
USE [CameraShop]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 11/2/2017 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[BirthDay] [date] NULL,
	[Sex] [nchar](10) NULL,
	[Address] [nvarchar](50) NULL,
	[Salary] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCamera]    Script Date: 11/2/2017 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCamera](
	[CameraID] [nvarchar](50) NOT NULL,
	[CameraName] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[CamBienHinhAnh] [nvarchar](50) NULL,
	[DoPhanGiai] [nvarchar](50) NULL,
	[KhoangCach] [nvarchar](50) NULL,
	[OngKinh] [nvarchar](50) NULL,
	[TamXaHongNgoai] [nvarchar](50) NULL,
	[Nguon] [nvarchar](50) NULL,
	[NhietDo] [nvarchar](50) NULL,
	[ChatLieu] [nvarchar](50) NULL,
	[HoTro] [nvarchar](50) NULL,
	[Status] [bit] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_tblCamera] PRIMARY KEY CLUSTERED 
(
	[CameraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 11/2/2017 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[BirthDay] [date] NULL,
	[Sex] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOrderDetail]    Script Date: 11/2/2017 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrderDetail](
	[OrderListID] [nvarchar](50) NOT NULL,
	[CameraID] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
	[Note] [nvarchar](250) NULL,
 CONSTRAINT [PK_tblOrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderListID] ASC,
	[CameraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOrderList]    Script Date: 11/2/2017 4:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrderList](
	[OrderListID] [nvarchar](50) NOT NULL,
	[CustomerID] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[UsernameID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblOrder] PRIMARY KEY CLUSTERED 
(
	[OrderListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'Manager', N'123', N'Manager', N'Hải Đăng', CAST(N'2017-10-21' AS Date), N'Nam       ', N'TP.HCM', 5000, 1)
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'Staff', N'123', N'Staff', N'Quyết', CAST(N'2017-06-08' AS Date), N'Nam       ', N'Tp.hcm', 2000, 1)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam1', N'cam1', 1, N'1', N'1', N'1', N'11', N'11', N'1', N'1', N'1', N'1', 1, 0)
ALTER TABLE [dbo].[tblOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblOrderDetail_tblCamera] FOREIGN KEY([CameraID])
REFERENCES [dbo].[tblCamera] ([CameraID])
GO
ALTER TABLE [dbo].[tblOrderDetail] CHECK CONSTRAINT [FK_tblOrderDetail_tblCamera]
GO
ALTER TABLE [dbo].[tblOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblOrderDetail_tblOrderList] FOREIGN KEY([OrderListID])
REFERENCES [dbo].[tblOrderList] ([OrderListID])
GO
ALTER TABLE [dbo].[tblOrderDetail] CHECK CONSTRAINT [FK_tblOrderDetail_tblOrderList]
GO
ALTER TABLE [dbo].[tblOrderList]  WITH CHECK ADD  CONSTRAINT [FK_tblOrder_tblAccount] FOREIGN KEY([UsernameID])
REFERENCES [dbo].[tblAccount] ([Username])
GO
ALTER TABLE [dbo].[tblOrderList] CHECK CONSTRAINT [FK_tblOrder_tblAccount]
GO
ALTER TABLE [dbo].[tblOrderList]  WITH CHECK ADD  CONSTRAINT [FK_tblOrder_tblCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([CustomerID])
GO
ALTER TABLE [dbo].[tblOrderList] CHECK CONSTRAINT [FK_tblOrder_tblCustomer]
GO
USE [master]
GO
ALTER DATABASE [CameraShop] SET  READ_WRITE 
GO
