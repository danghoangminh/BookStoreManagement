create database QLNS
go

use QLNS
set dateformat DMY
go

--CHITIETHOADONs--
--HOADON--
--KHOes--
--LINHVUCs--
--LOAISACHes--
--NHATKYNHAPSACHes--
--SACHes--
--SACHKHUYENMAIs--
--sysdiagrams--
--TACGIAs--
--TAIKHOANs--
--THONGTINXUATBANs--

create table CHITIETHOADONs
(
	MAHOADON int primary key not null,
	MASACH char(13),
	SOLUONG int,
	MUCGIAMGIA int,
)
go

create table HOADONs
(
	MAHOADON int identity primary key not null, 
	TENKHACHHANG nvarchar(50),
	NGAYLAP datetime,
	TONGTIEN decimal(10,2) 
)
go

create table KHOes
(
	MASACH char(13) primary key not null,
	TONGSOLUONG int,
	SOLUONGCON int,
)
go

create table LINHVUCs
(
	MALINHVUC char(2) primary key not null,
	TENLINHVUC nvarchar(30)
)
go

create table LOAISACHes
(
	MALOAISACH char(2) primary key not null,
	TENLOAISACH nvarchar(20)
)
go

create table NHATKYNHAPSACHes
(
	STT int identity primary key not null,
	MASACH char(13),
	SOLUONG int,
	NGAYNHAP datetime,
)
go

create table SACHes
(
	MASACH char(13) primary key not null,
	TENSACH nvarchar(100),
	MATG int,
	MALOAISACH char(2),
	MALINHVUC char(2),
	GIAMUA int
)
go

create table SACHKHUYENMAIs
(
	MASACH char(13) primary key not null,
	MUCGIAMGIA int
)
go

create table TACGIAs
(
    MATG int identity primary key not null,
	TENTG nvarchar(40),
	NAMSINH date,
	NAMMAT date,
	QUEQUAN nvarchar(20)
)
go

create table TAIKHOANs
(
    USERNAME nvarchar(20) primary key not null,
	PASSWORD nvarchar(100),
	TEN nvarchar(50),
	NGAYLAMVIEC datetime,
	CHUCVU nvarchar(50)
)
go

create table THONGTINXUATBANs
(
    MASACH char(13) primary key not null,
	LANTAIBAN int,
	NHAXUATBAN nvarchar(50),
	NAMXUATBAN datetime,
	GIABIA int
)
go

--Thêm khóa ngoại
alter table CHITIETHOADONs add constraint FK_CHITIETHOADON_HOADON foreign key(MAHOADON) references HOADONs(MAHOADON)
alter table CHITIETHOADONs add constraint FK_CHITIETHOADON_SACH foreign key(MASACH) references SACHes(MASACH)
alter table KHOes add constraint FK_KHO_SACH foreign key(MASACH) references SACHes(MASACH)
alter table NHATKYNHAPSACHes add constraint FK_NHATKINHAPSACH_KHO foreign key(MASACH) references KHOes(MASACH)
alter table SACHes add constraint FK_SACH_LOAISACH foreign key(MALOAISACH) references LOAISACHes(MALOAISACH)
alter table SACHes add constraint FK_SACH_TACGIA foreign key(MATG) references TACGIAs(MATG)
alter table SACHes add constraint FK_SACHes_LINHVUCs foreign key(MALINHVUC) references LINHVUCs(MALINHVUC)
alter table SACHKHUYENMAIs add constraint FK_SACHKHUYENMAI_SACH foreign key(MASACH) references SACHes(MASACH)
alter table THONGTINXUATBANs add constraint FK_THONGTINXUATBAN_SACH foreign key(MASACH) references SACHes(MASACH)

