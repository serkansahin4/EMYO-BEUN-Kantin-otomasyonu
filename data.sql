USE [master]
GO
/****** Object:  Database [BeunKantin]    Script Date: 10.06.2021 22:09:24 ******/
CREATE DATABASE [BeunKantin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BeunKantin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BeunKantin.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BeunKantin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BeunKantin_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BeunKantin] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BeunKantin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BeunKantin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BeunKantin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BeunKantin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BeunKantin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BeunKantin] SET ARITHABORT OFF 
GO
ALTER DATABASE [BeunKantin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BeunKantin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BeunKantin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BeunKantin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BeunKantin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BeunKantin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BeunKantin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BeunKantin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BeunKantin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BeunKantin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BeunKantin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BeunKantin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BeunKantin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BeunKantin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BeunKantin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BeunKantin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BeunKantin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BeunKantin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BeunKantin] SET  MULTI_USER 
GO
ALTER DATABASE [BeunKantin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BeunKantin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BeunKantin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BeunKantin] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BeunKantin] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BeunKantin]
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrators](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[Parola] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HesapOzetleri]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HesapOzetleri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciHesapId] [varchar](50) NOT NULL,
	[YuklenenBakiye] [float] NOT NULL,
	[YuklemeTarihi] [date] NOT NULL,
 CONSTRAINT [PK_Hesaplar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[KategoriId] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[KategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Musteriler](
	[OgrenciHesapId] [varchar](50) NOT NULL,
	[OgrenciAdi] [varchar](50) NOT NULL,
	[OgrenciSoyadi] [varchar](50) NOT NULL,
	[OgrenciNo] [varchar](20) NOT NULL,
	[Bakiye] [float] NOT NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[OgrenciHesapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](50) NOT NULL,
	[Soyadi] [varchar](50) NOT NULL,
	[TcNo] [nchar](11) NOT NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[Parola] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SatisRaporu]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SatisRaporu](
	[SatisId] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [int] NOT NULL,
	[OgrenciHesapId] [varchar](50) NOT NULL,
	[PersonelId] [int] NOT NULL,
	[SatisAdedi] [int] NOT NULL,
	[ToplamFiyati] [float] NOT NULL,
	[SatisTarihi] [date] NOT NULL,
 CONSTRAINT [PK_SatisRaporu] PRIMARY KEY CLUSTERED 
(
	[SatisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UrunIade]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UrunIade](
	[Iadeid] [int] IDENTITY(1,1) NOT NULL,
	[SatisId] [int] NOT NULL,
	[IadeAlanPersonelId] [int] NOT NULL,
	[IadeAlimTarihi] [date] NOT NULL,
	[IadeSebebi] [varchar](200) NOT NULL,
	[IadeAdedi] [int] NOT NULL,
 CONSTRAINT [PK_UrunIade] PRIMARY KEY CLUSTERED 
(
	[Iadeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[Marka] [varchar](50) NOT NULL,
	[KategoriId] [int] NOT NULL,
	[Adi] [varchar](50) NOT NULL,
	[StokAdedi] [int] NOT NULL,
	[BirimFiyati] [float] NOT NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UrunStokTarihi]    Script Date: 10.06.2021 22:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunStokTarihi](
	[StokId] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [int] NOT NULL,
	[EklenenAdet] [int] NOT NULL,
	[Tarih] [date] NOT NULL,
 CONSTRAINT [PK_UrunStokTarihi] PRIMARY KEY CLUSTERED 
(
	[StokId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[HesapOzetleri]  WITH CHECK ADD  CONSTRAINT [FK_HesapOzetleri_Musteriler1] FOREIGN KEY([OgrenciHesapId])
REFERENCES [dbo].[Musteriler] ([OgrenciHesapId])
GO
ALTER TABLE [dbo].[HesapOzetleri] CHECK CONSTRAINT [FK_HesapOzetleri_Musteriler1]
GO
ALTER TABLE [dbo].[SatisRaporu]  WITH CHECK ADD  CONSTRAINT [FK_SatisRaporu_Musteriler1] FOREIGN KEY([OgrenciHesapId])
REFERENCES [dbo].[Musteriler] ([OgrenciHesapId])
GO
ALTER TABLE [dbo].[SatisRaporu] CHECK CONSTRAINT [FK_SatisRaporu_Musteriler1]
GO
ALTER TABLE [dbo].[SatisRaporu]  WITH CHECK ADD  CONSTRAINT [FK_SatisRaporu_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personeller] ([PersonelId])
GO
ALTER TABLE [dbo].[SatisRaporu] CHECK CONSTRAINT [FK_SatisRaporu_Personel]
GO
ALTER TABLE [dbo].[SatisRaporu]  WITH CHECK ADD  CONSTRAINT [FK_SatisRaporu_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([UrunId])
GO
ALTER TABLE [dbo].[SatisRaporu] CHECK CONSTRAINT [FK_SatisRaporu_Urunler]
GO
ALTER TABLE [dbo].[UrunIade]  WITH CHECK ADD  CONSTRAINT [FK_UrunIade_SatisRaporu] FOREIGN KEY([SatisId])
REFERENCES [dbo].[SatisRaporu] ([SatisId])
GO
ALTER TABLE [dbo].[UrunIade] CHECK CONSTRAINT [FK_UrunIade_SatisRaporu]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Kategoriler1] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoriler] ([KategoriId])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategoriler1]
GO
ALTER TABLE [dbo].[UrunStokTarihi]  WITH CHECK ADD  CONSTRAINT [FK_UrunStokTarihi_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([UrunId])
GO
ALTER TABLE [dbo].[UrunStokTarihi] CHECK CONSTRAINT [FK_UrunStokTarihi_Urunler]
GO
USE [master]
GO
ALTER DATABASE [BeunKantin] SET  READ_WRITE 
GO
