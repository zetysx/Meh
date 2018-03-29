USE [master]
GO
/****** Object:  Database [CameraShop]    Script Date: 11/5/2017 5:51:32 PM ******/
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
/****** Object:  Table [dbo].[tblAccount]    Script Date: 11/5/2017 5:51:32 PM ******/
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
/****** Object:  Table [dbo].[tblCamera]    Script Date: 11/5/2017 5:51:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCamera](
	[CameraID] [nvarchar](50) NOT NULL,
	[CameraName] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[CamBienHinhAnh] [nvarchar](200) NULL,
	[DoPhanGiai] [nvarchar](200) NULL,
	[KhoangCach] [nvarchar](200) NULL,
	[OngKinh] [nvarchar](200) NULL,
	[TamXaHongNgoai] [nvarchar](200) NULL,
	[Nguon] [nvarchar](50) NULL,
	[NhietDo] [nvarchar](50) NULL,
	[ChatLieu] [nvarchar](200) NULL,
	[HoTro] [nvarchar](200) NULL,
	[Status] [bit] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_tblCamera] PRIMARY KEY CLUSTERED 
(
	[CameraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 11/5/2017 5:51:32 PM ******/
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
/****** Object:  Table [dbo].[tblHistory]    Script Date: 11/5/2017 5:51:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHistory](
	[HistoryID] [nvarchar](50) NOT NULL,
	[CameraID] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[DateAdd] [date] NULL,
 CONSTRAINT [PK_tblHistory] PRIMARY KEY CLUSTERED 
(
	[HistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOrderDetail]    Script Date: 11/5/2017 5:51:32 PM ******/
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
/****** Object:  Table [dbo].[tblOrderList]    Script Date: 11/5/2017 5:51:32 PM ******/
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
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'akiyama', N'7183496', N'Staff', N'Nguyễn Hoàng Hải Đăng', CAST(N'1992-09-09' AS Date), N'Nam       ', N'Tp.HCM', 3000, 1)
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'hainat', N'123', N'Staff', N'Nguyễn Ân Thiện Hải', CAST(N'1996-11-09' AS Date), N'Nam       ', N'Kon Tum', 2000, 1)
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'manager', N'123', N'Manager', N'Hải Đăng', CAST(N'2017-10-21' AS Date), N'Nam       ', N'TP.HCM', 5000, 1)
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'quyetnp', N'123', N'Staff', N'Nguyễn Phương Quyết', CAST(N'1996-11-15' AS Date), N'Nam       ', N'Tp.Hcm', 2000, 1)
INSERT [dbo].[tblAccount] ([Username], [Password], [Role], [Name], [BirthDay], [Sex], [Address], [Salary], [Status]) VALUES (N'staff', N'123', N'Staff', N'Quyết', CAST(N'2017-06-08' AS Date), N'Nam       ', N'Tp.hcm', 2000, 1)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam1', N'VP - 113TVI', 2200000, N'', N'2.0 Megapixel', N'300-500m', N'2D&3D-DNR', N'ARRAY LED. IR 20-30m', N'12V DC', N'', N'OSD', N'', 1, 46)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam2', N'HD VP-281TVI', 1200000, N'', N'1.0 Megapixel', N'20-30m', N'Hồng Ngoại Quan Sát 3.6mm (6, 8 , 12mm tùy chọn)', N'25/30fps@720P - HD (1280 x720)', N'12V DC', N'', N'', N'Day/Night (ICR). AWB, AGC, BLC, 3D-DNR', 1, 36)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam3', N'HD VP-282TVI', 1700000, N'', N'2.0 Megapixel', N'300 - 500m', N'Hồng Ngoại 3.6mm', N'30 - 40m', N'12V DC', N'', N'', N' Day/Night (ICR), AWB, AGC, BLC, 3D-DNR, DWDR, Defog, OSD', 1, 20)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam4', N'VP-282TVI', 1700000, N'', N'2.0 Megapixel', N'300-500m', N'Hồng ngoại 3.6mm', N'30 - 40m', N'12V DC', N'', N'', N'Day/Night (ICR), AWB, AGC, BLC, 3D-DNR, DWDR, Defog, OSD', 1, 17)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam5', N'VP-116TVI', 1600000, N'', N'1.0 Megapixel', N'25/30fps@720P - HD (1280 x 720 )', N'Hồng ngoại camera full HD: 3 Array LED.', N'20 -30m.', N'12V DC', N'', N'', N' Day/Night (ICR), AWB, AGC, BLC, 3D-DNR', 1, 14)
INSERT [dbo].[tblCamera] ([CameraID], [CameraName], [Price], [CamBienHinhAnh], [DoPhanGiai], [KhoangCach], [OngKinh], [TamXaHongNgoai], [Nguon], [NhietDo], [ChatLieu], [HoTro], [Status], [Quantity]) VALUES (N'Cam6', N'VP-111TVI', 1800000, N'', N'1.0 Megapixel', N'25/30fps@720P - HD (1280 x 720 )', N'Ống kính cố định camera quan sát 3,6mm (6, 8, 12mm tùy chọn)', N'Hồng ngoại camera HD: 3 Array LED.', N'12V DC.', N'', N'', N'Day/Night (ICR), AWB, AGC, BLC, 3D-DNR', 1, 11)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus1', N'Nguyễn Hoàng Hải Đăng', CAST(N'1992-09-09' AS Date), N'Nam', N'Tp.Hcm', N'Khach hang than thiet', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus2', N'Nguyễn Phương Quyết', CAST(N'1996-02-22' AS Date), N'Nam', N'Tp.HCM', N'Khach hang thuong', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus3', N'Nguyễn Ân Thiện Hải', CAST(N'1996-09-01' AS Date), N'Nam', N'Kon Tum', N'Khach hang than thiet', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus4', N'Nguyễn Hoàng Nam', CAST(N'1996-11-21' AS Date), N'Nam', N'Đà Nẵng', N'Khach hang thuong', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus5', N'Trương Quang Minh', CAST(N'1996-11-05' AS Date), N'Nam', N'Lâm Đồng', N'Khach hang thuong', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus6', N'Nguyễn Việt Hùng', CAST(N'1996-11-01' AS Date), N'Nam', N'Kon Tum', N'Khach hang thuong', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus7', N'Bạch Minh Nam', CAST(N'1996-06-05' AS Date), N'Nam', N'Tp. Hcm', N'Khach hang than thiet', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus8', N'Vũ Tiến An', CAST(N'1996-06-10' AS Date), N'Nam', N'Cà Mau', N'Khach hang than thiet', 1)
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [BirthDay], [Sex], [Address], [Type], [Status]) VALUES (N'Cus9', N'Trần Thọ Tường', CAST(N'1996-08-20' AS Date), N'Nam', N'Đà Nẵng', N'Khach hang than thiet', 1)
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History1', N'Cam1', 50, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History2', N'Cam2', 40, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History3', N'Cam3', 30, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History4', N'Cam4', 20, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History5', N'Cam5', 10, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History6', N'Cam6', 5, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History7', N'Cam6', 10, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblHistory] ([HistoryID], [CameraID], [Quantity], [DateAdd]) VALUES (N'History8', N'Cam5', 10, CAST(N'2017-11-05' AS Date))
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList1', N'Cam1', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList1', N'Cam2', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList1', N'Cam3', N'4', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList2', N'Cam4', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList2', N'Cam5', N'2', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList2', N'Cam6', N'3', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList3', N'Cam5', N'4', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList3', N'Cam6', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList4', N'Cam1', N'2', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList4', N'Cam2', N'2', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList4', N'Cam3', N'2', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList5', N'Cam3', N'2', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList5', N'Cam4', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList6', N'Cam1', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList6', N'Cam2', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList6', N'Cam3', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList7', N'Cam3', N'1', N'')
INSERT [dbo].[tblOrderDetail] ([OrderListID], [CameraID], [Quantity], [Note]) VALUES (N'OrderList8', N'Cam4', N'1', N'')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList1', N'Cus1', CAST(N'2017-11-05' AS Date), N'Manager')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList2', N'Cus1', CAST(N'2017-11-05' AS Date), N'Manager')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList3', N'Cus1', CAST(N'2017-11-05' AS Date), N'Manager')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList4', N'Cus2', CAST(N'2017-11-05' AS Date), N'Manager')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList5', N'Cus3', CAST(N'2017-11-05' AS Date), N'Manager')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList6', N'Cus1', CAST(N'2017-11-05' AS Date), N'Staff')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList7', N'Cus1', CAST(N'2017-11-05' AS Date), N'Staff')
INSERT [dbo].[tblOrderList] ([OrderListID], [CustomerID], [Date], [UsernameID]) VALUES (N'OrderList8', N'Cus2', CAST(N'2017-11-05' AS Date), N'Staff')
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
