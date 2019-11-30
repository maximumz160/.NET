use master
go 

create database QLDSinhVien
go

use QLDSinhVien

create table giangvien
(
magv nvarchar(50) primary key ,
tengv nvarchar(50) ,
anh nvarchar(50),
khoa nvarchar(50),
gmail nvarchar(50),
sdt int,
tendangnhap nvarchar(50),
matkhau nvarchar(50)
)

create table lophoc
(
malop int primary key,
tenlop nvarchar(50),
magv nvarchar(50) constraint k1 foreign key (magv) references giangvien(magv) on delete cascade,
siso int ,
chuyennganh nvarchar(50),
nienkhoa nvarchar(50)
)
create table monhoc
(
mamh nvarchar(50) primary key,
tenmh nvarchar(50),
sotclt int,
sotcth int,
)
create table sinhvien
(
masv int primary key,
tensv nvarchar(50),
anh nvarchar(50),
gioitinh nvarchar(50),
malop int constraint k2 foreign key (malop) references lophoc(malop) on delete cascade ,
ngaysinh nvarchar(50),
quequan nvarchar(50),
sdt int ,
gmail nvarchar(50)
)
create table chuongtrinhdaotao
(
constraint k6 primary key (malop, mamh, magv),
malop int constraint k3 foreign key (malop) references lophoc(malop) on delete cascade ,
hocky int,
mamh nvarchar(50) constraint k4 foreign key (mamh) references monhoc(mamh) on delete cascade ,
namhoc int,
magv nvarchar(50) constraint k7 foreign key (magv) references giangvien(magv)
)
create table diem
(
constraint k10 primary key (masv, mamh),
masv int constraint k8 foreign key (masv) references sinhvien(masv) on delete cascade ,
mamh nvarchar(50) constraint k9 foreign key (mamh) references monhoc(mamh) on delete cascade ,
diemghp float,
diembtc float,
diemth float ,
diemkthp float,
diemtb float,
diemghplan2 float,
diembtclan2 float,
diemthlan2 float ,
diemkthplan2 float,
diemtblan2 float,
)