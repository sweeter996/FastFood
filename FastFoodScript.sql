USE [master]
GO
/****** Object:  Database [FastFoodDB]    Script Date: 13/11/2017 1:26:16 SA ******/
CREATE DATABASE [FastFoodDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FastFoodDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FastFoodDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FastFoodDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FastFoodDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FastFoodDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FastFoodDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FastFoodDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FastFoodDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FastFoodDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FastFoodDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FastFoodDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FastFoodDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FastFoodDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FastFoodDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FastFoodDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FastFoodDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FastFoodDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FastFoodDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FastFoodDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FastFoodDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FastFoodDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FastFoodDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FastFoodDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FastFoodDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FastFoodDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FastFoodDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FastFoodDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FastFoodDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FastFoodDB] SET  MULTI_USER 
GO
ALTER DATABASE [FastFoodDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FastFoodDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FastFoodDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FastFoodDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FastFoodDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 13/11/2017 1:26:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Phone] [nchar](12) NULL,
	[Address] [nvarchar](200) NULL,
	[Salary] [float] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FoodCategories]    Script Date: 13/11/2017 1:26:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategories](
	[FoodCategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_FoodCategories] PRIMARY KEY CLUSTERED 
(
	[FoodCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Foods]    Script Date: 13/11/2017 1:26:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[FoodID] [int] NOT NULL,
	[FoodName] [nvarchar](50) NULL,
	[FoodCategory] [int] NULL,
	[FoodPrice] [float] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 13/11/2017 1:26:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Price] [float] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 13/11/2017 1:26:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[EmployeeID] [int] NULL,
	[Orderdate] [date] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 13/11/2017 1:26:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Username] [nchar](10) NULL,
	[Password] [nchar](10) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Phone], [Address], [Salary], [Note]) VALUES (1, N'Owner', N'Owner', N'12345678    ', N'dsadsd', 123, N'')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Phone], [Address], [Salary], [Note]) VALUES (2, N'A', N'Nguyễn Văn', N'1234567     ', N'11/3 Nguyễn Tuân', 3400000, N'')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Phone], [Address], [Salary], [Note]) VALUES (3, N'B', N'Lê Thị', N'12345678    ', N'26 Võ Văn Tần', 5000000, N'')
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Phone], [Address], [Salary], [Note]) VALUES (4, N'C', N'Nguyễn Văn', N'123         ', N'abv', 3440000, N'')
INSERT [dbo].[Users] ([UserID], [EmployeeID], [Username], [Password], [Note]) VALUES (1, 1, N'Admin     ', N'Admin     ', NULL)
INSERT [dbo].[Users] ([UserID], [EmployeeID], [Username], [Password], [Note]) VALUES (2, 2, N'Assistant1', N'123       ', NULL)
INSERT [dbo].[Users] ([UserID], [EmployeeID], [Username], [Password], [Note]) VALUES (3, 3, N'Assistant2', N'123       ', NULL)
ALTER TABLE [dbo].[Foods]  WITH CHECK ADD  CONSTRAINT [FK_Foods_FoodCategories] FOREIGN KEY([FoodCategory])
REFERENCES [dbo].[FoodCategories] ([FoodCategoryID])
GO
ALTER TABLE [dbo].[Foods] CHECK CONSTRAINT [FK_Foods_FoodCategories]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Foods] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Foods] ([FoodID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Foods]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [FastFoodDB] SET  READ_WRITE 
GO
