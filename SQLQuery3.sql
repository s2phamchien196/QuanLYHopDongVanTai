Create table LichTrinh
(
	MaLichTrinh int identity primary key,
	ngay date,
	DiaDiem nvarchar(100),
	MaDieuXe int foreign key references DieuXe(MaDieuXe)
	 
)
Create table ChiTietLichTrinh
(
	MaSo int identity primary key,
	ThoiGian nvarchar(20),
	TinhTrang nvarchar(20),
	Malichtrinh int foreign key references LichTrinh(MaLichTrinh)
	 
)
create table DieuXe
(
 MaDieuXe int identity primary key,
 Ngay date,
 MaTaiXe int foreign key references TaiXe(MaTaiXe),
 BienSo int foreign key references Xe(BienSo),
 TrangThai nvarchar(100),
 ngayVeBai date,
 MaDon int foreign key references MaDonHang(DonHang),
 SoPalletCho int,
 )
 
create table DonHang
(
 MaDonHang int identity primary key,
SoLuongXe int,
TenTuyen nvarchar(100),
SoHopDong int foreign key references HopDong(SoHopDong),
SoHangConLai int
 )

create table LoaiHopDong
(
 maloai int identity primary key,
ten nvarchar(100),
 )
 create table LoaiHang
(
 MaLoaiHang int identity primary key,
TenLoaiHang nvarchar(30),
 )
  -->   update cái dưới 
 ALTER  TABLE  DieuXe add TaiXePhu int foreign key references TaiXe(MaTaiXe)
  alter table HopDong
  add trangthai int, Pallet int
-->Xóa cái cột TaiXePhu ở bảng Diễu Cũ đi
 alter table DieuXe 
  add  TaiXePhu int foreign key references LaiPhu(MaTaiXe)
  alter table DieuXe 
  drop column TaiXePhu
create table LaiPhu
(
	MaTaiXe int identity primary key,
	TenTaiXe nvarchar(100),
	NgaySinh Date,
	GioiTinh nvarchar(20),
	DiaChi nvarchar(100),
	SDT nvarchar (12),
) 
