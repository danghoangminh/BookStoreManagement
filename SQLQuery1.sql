create database QLNS
go

use QLNS
set dateformat DMY
go

create table CHITIETHOADON
(
	MAHOADON char(7) not null,
	MASACH char(7),
	SOLUONG int,
	GIATIEN int,
	THANHTIEN int
)
go
select * from CHITIETHOADON

create table HOADON
(
	MAHOADON char(7) primary key not null,
	TENKHACHHANG nvarchar(50),
	NGAYLAP datetime,
	TONGTIEN decimal(10, 2) 
)
go
Select * From HOADON
Select SUM(TONGTIEN) AS [DOANH THU] From HOADON
Select CHITIETHOADON.MASACH, TENSACH, SUM(SOLUONG) AS [SỐ LƯỢNG BÁN RA], GIAMUA, GIABIA From CHITIETHOADON RIGHT JOIN SACH 
ON CHITIETHOADON.MASACH = SACH.MASACH Group By CHITIETHOADON.MASACH, SACH.TENSACH, GIAMUA, GIABIA


create table KHO
(
	MASACH char(7) primary key not null,
	SOLUONG int
)
go
Select * From KHO

create table LINHVUC
(
	TENLINHVUC nvarchar(30) primary key not null
)
go
Select * from LINHVUC

create table LOAISACH
(
	TENLOAISACH nvarchar(30) primary key not null
)
go
Select * from LOAISACH

create table NHAXUATBAN
(
	TENNHAXUATBAN nvarchar(50) primary key not null
)
go
Select * from NHAXUATBAN

create table SACH
(
	MASACH char(7) primary key not null,
	TENSACH nvarchar(100),
	MATG char(7) not null,
	TENLINHVUC nvarchar(30),
	TENLOAISACH nvarchar(30),
	GIAMUA int,
	GIABIA int,
	LANTAIBAN int,
	TENNHAXUATBAN nvarchar(50),
	NAMXUATBAN datetime
)
go
Select * From SACH

create table TACGIA
(
    MATG char(7) primary key not null,
	TENTG nvarchar(40),
	NAMSINH date,
	NAMMAT date,
	QUEQUAN nvarchar(20)
)
go
Select * from TACGIA

create table TAIKHOAN
(
    USERNAME nvarchar(20) primary key not null,
	PASS_WORD nvarchar(100)
)
go
INSERT INTO TAIKHOAN VALUES ('uit', 'uit');
Select * from TAIKHOAN Where USERNAME = 'uit' and PASS_WORD = 'uit'

CREATE PROC USP_Login
@username nvarchar(20), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS_WORD = @password
END
GO



--Thêm khóa ngoại
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_HOADON foreign key(MAHOADON) references HOADON(MAHOADON)
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_SACH foreign key(MASACH) references SACH(MASACH)
alter table KHO add constraint FK_KHO_SACH foreign key(MASACH) references SACH(MASACH)
alter table SACH add constraint FK_SACH_LOAISACH foreign key(TENLOAISACH) references LOAISACH(TENLOAISACH)
alter table SACH add constraint FK_SACH_TACGIA foreign key(MATG) references TACGIA(MATG)
alter table SACH add constraint FK_SACH_LINHVUC foreign key(TENLINHVUC) references LINHVUC(TENLINHVUC)
alter table SACH add constraint FK_SACH_NHAXUATBAN foreign key(TENNHAXUATBAN) references NHAXUATBAN(TENNHAXUATBAN)
