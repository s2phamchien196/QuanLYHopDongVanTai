USE [QLHopDong]
GO

/****** Object:  Table [dbo].[GiaCuoc]    Script Date: 05/13/2019 00:39:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GiaCuoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TrongTai] [nvarchar](20) NULL,
	[kmdau] [int] NULL,
	[kmtieptheo] [int] NULL,
	[thoigiancho] [int] NULL,
	[trongtaiBangso] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[Xe]    Script Date: 05/13/2019 00:40:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Xe](
	[BienSo] [nvarchar](100) NOT NULL,
	[LoaiXe] [nvarchar](100) NOT NULL,
	[HanBaoHiem] [date] NULL,
	[MoTa] [nvarchar](200) NULL,
	[IDGiaCuoc] [int] NULL,
	[trangthai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BienSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([IDGiaCuoc])
REFERENCES [dbo].[GiaCuoc] ([ID])
GO
-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[LaiPhu]    Script Date: 05/13/2019 00:43:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LaiPhu](
	[MaTaiXe] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiXe] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTaiXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO




-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[TaiXe]    Script Date: 05/13/2019 00:33:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaiXe](
	[MaTaiXe] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiXe] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTaiXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

-->>

USE [QLHopDong]
GO

/****** Object:  Table [dbo].[taikhoan]    Script Date: 05/13/2019 00:34:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[taikhoan](
	[tendangnhap] [varchar](20) NOT NULL,
	[matkhau] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 05/13/2019 00:35:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoaiHopDong](
	[maloai] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[LoaiHang]    Script Date: 05/13/2019 00:35:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoaiHang](
	[MaLoaiHang] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHang] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

-->>

USE [QLHopDong]
GO

/****** Object:  Table [dbo].[KhachHang]    Script Date: 05/13/2019 00:37:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[SoTaiKhoan] [nvarchar](20) NOT NULL,
	[MaSoThue] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[HopDong]    Script Date: 05/13/2019 00:38:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HopDong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayHopDong] [date] NOT NULL,
	[NoiNhan] [nvarchar](100) NOT NULL,
	[NoiGiao] [nvarchar](100) NOT NULL,
	[MaLoaiHang] [int] NOT NULL,
	[KhoiLuong] [int] NOT NULL,
	[HaoHut] [int] NOT NULL,
	[makhachhang] [int] NOT NULL,
	[LoaiHopDong] [nvarchar](50) NULL,
	[trangthai] [int] NULL,
	[SoHopDong] [nvarchar](20) NOT NULL,
	[ngayhethan] [date] NULL,
	[DatCoc] [int] NULL,
	[sothang] [int] NULL,
	[mathang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHopDong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([makhachhang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO

ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LoaiHang] ([MaLoaiHang])
GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[DonHang]    Script Date: 05/13/2019 00:38:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[SoLuongXe] [int] NULL,
	[SoHangConLai] [float] NULL,
	[TrangThai] [nvarchar](100) NULL,
	[SoHopDong] [nvarchar](20) NULL,
	[ngayvanchuyen] [datetime] NULL,
	[mota] [nvarchar](200) NULL,
	[khoiluong] [float] NULL,
	[DatCoc] [int] NULL,
	[SoKm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([SoHopDong])
REFERENCES [dbo].[HopDong] ([SoHopDong])
GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[DieuXe]    Script Date: 05/13/2019 00:38:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DieuXe](
	[MaDieuXe] [int] IDENTITY(1,1) NOT NULL,
	[MaTaiXe] [int] NULL,
	[BienSo] [nvarchar](100) NOT NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
	[MaDon] [int] NULL,
	[ThucCho] [float] NULL,
	[TaiXePhu] [int] NULL,
	[thoigiancho] [int] NULL,
	[thoigiandi] [int] NULL,
	[quadem] [int] NULL,
	[khoihanh] [datetime] NULL,
	[vebai] [datetime] NULL,
	[thanhtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDieuXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[DieuXe]  WITH CHECK ADD FOREIGN KEY([BienSo])
REFERENCES [dbo].[Xe] ([BienSo])
GO

ALTER TABLE [dbo].[DieuXe]  WITH CHECK ADD FOREIGN KEY([MaDon])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO

ALTER TABLE [dbo].[DieuXe]  WITH CHECK ADD FOREIGN KEY([MaTaiXe])
REFERENCES [dbo].[TaiXe] ([MaTaiXe])
GO

ALTER TABLE [dbo].[DieuXe]  WITH CHECK ADD FOREIGN KEY([TaiXePhu])
REFERENCES [dbo].[LaiPhu] ([MaTaiXe])
GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[LichTrinh]    Script Date: 05/13/2019 00:39:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LichTrinh](
	[MaLichTrinh] [int] IDENTITY(1,1) NOT NULL,
	[DiaDiem] [nvarchar](100) NULL,
	[MaDieuXe] [int] NULL,
	[thoigian] [datetime] NULL,
	[tinhtrang] [nvarchar](100) NULL,
	[ghichu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLichTrinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[LichTrinh]  WITH CHECK ADD FOREIGN KEY([MaDieuXe])
REFERENCES [dbo].[DieuXe] ([MaDieuXe])
GO


-->>
USE [QLHopDong]
GO

/****** Object:  Table [dbo].[thanhtoan]    Script Date: 05/13/2019 00:39:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[thanhtoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[madon] [int] NULL,
	[Tongtien] [int] NULL,
	[khachtra] [int] NULL,
	[tralai] [int] NULL,
	[trangthai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[thanhtoan]  WITH CHECK ADD FOREIGN KEY([madon])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO


-->>


-->>
