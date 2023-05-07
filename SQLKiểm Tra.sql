create table KhachHang
(
	MaKH int identity(1,1) primary key,
	Ten nvarchar(30),
	SDT varchar(20)
)

Insert into KhachHang values (N'Tiến', '0123456789')