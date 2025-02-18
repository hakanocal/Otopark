USE [master]
GO
/****** Object:  Database [otopark]    Script Date: 8.5.2020 21:13:23 ******/
CREATE DATABASE [otopark]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'otopark', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\otopark.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'otopark_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\otopark_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [otopark] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [otopark].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [otopark] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [otopark] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [otopark] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [otopark] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [otopark] SET ARITHABORT OFF 
GO
ALTER DATABASE [otopark] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [otopark] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [otopark] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [otopark] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [otopark] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [otopark] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [otopark] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [otopark] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [otopark] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [otopark] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [otopark] SET  DISABLE_BROKER 
GO
ALTER DATABASE [otopark] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [otopark] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [otopark] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [otopark] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [otopark] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [otopark] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [otopark] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [otopark] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [otopark] SET  MULTI_USER 
GO
ALTER DATABASE [otopark] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [otopark] SET DB_CHAINING OFF 
GO
ALTER DATABASE [otopark] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [otopark] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [otopark]
GO
/****** Object:  Table [dbo].[araclar]    Script Date: 8.5.2020 21:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[araclar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[plaka] [varchar](20) NOT NULL,
	[marka] [varchar](50) NULL,
	[model] [varchar](50) NULL,
	[renk] [varchar](50) NULL,
	[arac_turu] [varchar](50) NULL,
	[tc] [varchar](11) NULL,
	[ad] [varchar](70) NULL,
	[soyad] [varchar](70) NULL,
	[telefon] [varchar](11) NULL,
	[email] [varchar](70) NULL,
	[park_yeri] [varchar](50) NULL,
	[giris_tarihi] [varchar](50) NULL,
	[giris_saati] [varchar](50) NULL,
	[cikis_tarihi] [varchar](50) NULL,
	[cikis_saati] [varchar](50) NULL,
	[sure] [varchar](50) NULL,
	[ucret] [int] NULL,
 CONSTRAINT [PK_araclar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gecmis]    Script Date: 8.5.2020 21:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gecmis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[plaka] [varchar](20) NOT NULL,
	[marka] [varchar](50) NULL,
	[model] [varchar](50) NULL,
	[renk] [varchar](50) NULL,
	[arac_turu] [varchar](50) NULL,
	[tc] [varchar](11) NULL,
	[ad] [varchar](70) NULL,
	[soyad] [varchar](70) NULL,
	[telefon] [varchar](11) NULL,
	[email] [varchar](70) NULL,
	[park_yeri] [varchar](50) NULL,
	[giris_tarihi] [varchar](50) NULL,
	[giris_saati] [varchar](50) NULL,
	[cikis_tarihi] [varchar](50) NULL,
	[cikis_saati] [varchar](50) NULL,
	[sure] [varchar](50) NULL,
	[ucret] [int] NULL,
 CONSTRAINT [PK_gecmis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[markalar]    Script Date: 8.5.2020 21:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[markalar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marka] [varchar](50) NULL,
	[model] [varchar](50) NULL,
 CONSTRAINT [PK_markalar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[park_yeri]    Script Date: 8.5.2020 21:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[park_yeri](
	[park_yeri] [varchar](50) NOT NULL,
	[durum] [varchar](50) NULL,
 CONSTRAINT [PK_park_yeri] PRIMARY KEY CLUSTERED 
(
	[park_yeri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ucretlendirme]    Script Date: 8.5.2020 21:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ucretlendirme](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[otomobil_pikap_minubus] [int] NULL,
	[midibus_otobus_kamyon] [int] NULL,
	[motosiklet] [int] NULL,
	[diger] [int] NULL,
 CONSTRAINT [PK_ucretlendirme] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [otopark] SET  READ_WRITE 
GO
