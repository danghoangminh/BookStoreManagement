create database QLNS
go

use QLNS
set dateformat DMY
go

create table CHITIETHOADON
(
	MAHOADON int primary key not null,
	MASACH char(13),
	SOLUONG int,
	GIATIEN int,
	THANHTIEN int
)
go

create table HOADON
(
	MAHOADON int identity primary key not null,
	TENKHACHHANG nvarchar(50),
	NGAYLAP datetime,
	TONGTIEN decimal(10,2) 
)
go

create table KHO
(
	MASACH char(13) primary key not null,
	SOLUONG int
)
go

create table LINHVUC
(
	TENLINHVUC nvarchar(30) primary key not null
)
go

create table LOAISACH
(
	TENLOAISACH nvarchar(30) primary key not null
)
go

create table NHAXUATBAN
(
	TENNHAXUATBAN nvarchar(50) primary key not null
)
go

create table SACH
(
	MASACH char(13) primary key not null,
	TENSACH nvarchar(100),
	MATG int,
	TENLINHVUC nvarchar(30),
	TENLOAISACH nvarchar(30),
	GIAMUA int,
	GIABIA int,
	LANTAIBAN int,
	TENNHAXUATBAN nvarchar(50),
	NAMXUATBAN datetime
)
go


create table TACGIA
(
    MATG int identity primary key not null,
	TENTG nvarchar(40),
	NAMSINH date,
	NAMMAT date,
	QUEQUAN nvarchar(20)
)
go

create table TAIKHOAN
(
    USERNAME nvarchar(20) primary key not null,
	PASS_WORD nvarchar(100)
)
go


--Thêm khóa ngoại
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_HOADON foreign key(MAHOADON) references HOADON(MAHOADON)
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_SACH foreign key(MASACH) references SACH(MASACH)
alter table KHO add constraint FK_KHO_SACH foreign key(MASACH) references SACH(MASACH)
alter table SACH add constraint FK_SACH_LOAISACH foreign key(TENLOAISACH) references LOAISACH(TENLOAISACH)
alter table SACH add constraint FK_SACH_TACGIA foreign key(MATG) references TACGIA(MATG)
alter table SACH add constraint FK_SACH_LINHVUC foreign key(TENLINHVUC) references LINHVUC(TENLINHVUC)
alter table SACH add constraint FK_SACH_NHAXUATBAN foreign key(TENNHAXUATBAN) references NHAXUATBAN(TENNHAXUATBAN)

