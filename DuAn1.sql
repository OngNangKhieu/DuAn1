use master
go

create database DUAN_ShopQA
go
use DUAN_ShopQA
go
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = off
go
create table NHANVIEN( 
	STT int identity (1,1),
	MaNV varchar (5) PRIMARY KEY,
	TenNV nvarchar (30) NOT NULL,
	DiaChi nvarchar (50)NOT NULL,
	SDT varchar (15)NOT NULL,
	Email varchar (100)NOT NULL,
	MatKhau varchar (255)NOT NULL default '418515815641305135230215920295153463',
	GioiTinh bit NOT NULL,
	VaiTro bit NOT NULL,
	HinhAnh varchar (150) NOT NULL,
	isDelete bit default 0
	)
go
create table PHANLOAISP(
	MaLoai varchar (5) PRIMARY KEY,
	TenLoai nvarchar (30) NOT NULL
	)
go

create table SANPHAM(
	MaSP varchar (5) PRIMARY KEY,
	TenSP nvarchar (30) NOT NULL,
	DonGiaNhap float NOT NULL,
	DonGiaBan float NOT NULL,
	TongSoLuong int not null default 0,
	DoiTuong int NOT NULL,
	HinhAnhTrc varchar (150) NOT NULL,
	HinhAnhSau varchar (150) NOT NULL,
	Giamgia int NOT NULL,
	MaLoai varchar (5) references PHANLOAISP (MaLoai)
)
ALTER TABLE SANPHAM
ADD CONSTRAINT fk_Size
  FOREIGN KEY (MaSize)
  REFERENCES KICHCO (MaSize);
go
create table MAUSAC(
	MaMau int identity(1,1) primary key,
	tenmau nvarchar(10) NOT NULL
)
go
create table KICHCO(
	MaSize int identity(1,1) primary key,
	TenSize nvarchar(3) NOT NULL
)
go
create table CHITIETSANPHAM(
	MaSP varchar(5) references SANPHAM(MaSP),
	SoLuong int NOT NULL,
	Size int NOT NULL references KICHCO(MaSize),
	MaMau int references MAUSAC(MaMau) not null
)
go

create table DONVANCHUYEN(
	MaDonNhap int identity PRIMARY KEY,
	NgayNhapHang datetime NOT NULL
	)
go

create table CHITIETDONVANCHUYEN(
	MaDonNhap int references DONVANCHUYEN (MaDonNhap),
	MaSP varchar (5) references SANPHAM (MaSP),
	MaNV varchar(5) references NHANVIEN(MANV),
	Size int NOT NULL references KICHCO(MaSize),
	MaMau int NOT NULL references MAUSAC(MaMau),
	SoLuong int NOT NULL,
	)
go


create table KHACHHANG(
	 SDT varchar (15) PRIMARY KEY,
	 TenKH nvarchar (30) NOT NULL,
	 DiemTichLuy int NOT NULL,
	 isDelete bit default 0
	 )
go
create table HOADON(
	MaDonMua int identity(1,1) PRIMARY KEY,
	NgayMua datetime NOT NULL ,
	TinhTrang bit NOT NULL default 0 -- 0 là chưa thanh toán , 1 là đã thanh toán
	)
go

create table HOADONCHITIET(
	MaDonMua int identity(1,1) references HOADON (MaDonMua),
	MaSP varchar (5) references SANPHAM (MaSP),
	MaNV varchar (5) references NHANVIEN (MaNV),
	SDT varchar (15) references KHACHHANG (SDT),
	SoLuong int NOT NULL,
	GiamGiaDTL int NOT NULL check(GIAMGIADTL <= 20), -- Giảm giá bằng DTL, tối đa chỉ giảm 20%
	ThanhTien float NOT NULL,
	primary key(MaDonMua, MaSP, MaNV,SDT)
	)
go
	-- Procedure
	-- Nhân viên
-- kiểm tra có phải admin ko
select * from NHANVIEN
create proc sp_isAdmin @email varchar(100)
as
	declare @status int
begin
	if (@email = 'admin')
		set @status = 1
	else
		set @status = 0
	select @status
end
go
-- kiểm tra có thay đổi sdt hay không
create proc sp_SamePhoneNumber @email varchar(100),@sdtht varchar(15)
as
	declare @status int
begin
	if exists(select * from NHANVIEN where Email = @email and SDT = @sdtht)
		set @status = 1
	else
		set @status = 0
	select @status
end
go
-- kiểm tra email có tồn tại không
create proc sp_isEmailExists @email varchar(100)
as
	declare @status int
begin
	if exists (select * from NHANVIEN where Email = @email)
	set @status = 1
	else 
	set @status = 0
	select @status
end
go
-- Thay đổi thông tin nhân viên
create proc sp_changeTTNV @email varchar(100), @hoten nvarchar(30), @diachi nvarchar(50), @sdt varchar(15), @gioitinh bit, @anh varchar(150)
as
begin
	if exists (select * from NHANVIEN where Email = @email and SDT = @sdt)
		update NHANVIEN set TenNV = @hoten , DiaChi=@diachi, GioiTinh = @gioitinh, HinhAnh = @anh where Email = @email
	if not exists(select * from NHANVIEN where SDT = @sdt)
		update NHANVIEN set TenNV = @hoten , DiaChi=@diachi, SDT = @sdt, GioiTinh = @gioitinh, HinhAnh = @anh where Email = @email
end
go
-- Quên mật khẩu
create proc sp_QuenMK @email varchar(100) , @randompass varchar(255)
as
begin
	if exists(select * From NHANVIEN where Email = @email)
		update NHANVIEN set MatKhau = @randompass where email = @email
end
go

-- Đổi mật khẩu
create proc sp_changePW @email varchar(100),@curPass varchar(255) , @newpass varchar(255) , @rePass varchar(255)
as
begin
	if exists (select * from NHANVIEN where MatKhau = @curPass)
		begin
			update NHANVIEN set MatKhau = @newpass where Email = @email
		end
end
select * from NHANVIEN
go
-- Xem danh sách nhân viên hoặc 1 NV
create proc sp_getListStaff @email varchar(100) = null
as
	if (@email is null)
		select MaNV,TenNV,DiaChi,SDT,Email,GioiTinh,VaiTro,HinhAnh from NHANVIEN where isDelete = 0
	else
		select MaNV,TenNV,DiaChi,SDT,Email,GioiTinh,VaiTro,HinhAnh from NHANVIEN where Email = @email and isDelete = 0
go

--Tìm kiếm nv
create  proc sp_TimkiemNV @tennv nvarchar(30)
as
begin
	select  MaNV,TenNV,DiaChi,sdt,Email,GioiTinh,VaiTro,HinhAnh from NHANVIEN
	where tennv like '%' +@tennv +'%'
end
go
--Nhập nhân viên
create  proc sp_insertNV
@tennv nvarchar(30), @diachi nvarchar(50), @sdt varchar(15),
@email varchar(100),@gioitinh bit,@vaitro bit,
@hinhanh varchar(50)
as	
	declare		@id int,
				@manv varchar(5)
begin
	select @id = isnull(MAX(STT),0) + 1 from NHANVIEN
	if(@vaitro = 1)
	 SELECT @manv = 'QL' + RIGHT('00' + CAST(@Id AS VARCHAR(3)), 3)
	else
	 SELECT @manv = 'NV' + RIGHT('00' + CAST(@Id AS VARCHAR(3)), 3)
	if not exists(select * from NHANVIEN where Email = @email)
	begin
		if not exists(select * from NHANVIEN where SDT = @sdt)
		insert into NHANVIEN values (@manv,@tennv,@diachi,@sdt,@email,default,@gioitinh,@vaitro,@hinhanh,default)
	end
end
go
--Đăng nhập nhân viên
create proc sp_loginNV @email varchar(100), @matkhau varchar(255)
as
	declare @status int
begin
	if exists (select * from NHANVIEN where Email = @email and MatKhau = @matkhau and isDelete = 0)
		set @status = 1
	else
		set @status = 0
	select @status
end
go
--Cập nhật nhân viên
create  proc sp_updateNV 
@tennv nvarchar(30), @diachi nvarchar(50), @sdt varchar(15),
@email varchar(100),@gioitinh bit,@vaitro bit,
@hinhanh varchar(50)
as
begin 
	if(@vaitro =1 )
		begin
			if exists (select * from NHANVIEN where Email = @email and VaiTro = 0)
			update NHANVIEN set MaNV = REPLACE(MaNV,'NV','QL') where Email = @email
		end
	else
		begin
			if exists (select * from NHANVIEN where Email = @email and VaiTro = 1)
			update NHANVIEN set MaNV = REPLACE(MaNV,'QL','NV') where Email = @email
		end
	if exists(select * from NHANVIEN where Email = @email and SDT = @sdt)
		update NHANVIEN set TenNV = @tennv, DiaChi = @diachi , GioiTinh = @gioitinh ,VaiTro= @vaitro, HinhAnh=  @hinhanh 
		where EMAIL = @email
	if not exists(select * from NHANVIEN where SDT = @sdt)
		update NHANVIEN set TenNV = @tennv, DiaChi = @diachi , SDT = @sdt, GioiTinh = @gioitinh ,VaiTro= @vaitro, HinhAnh=  @hinhanh 
		where EMAIL = @email
end

--
select * from phanloaisp
go
select * from NHANVIEN
	--Xóa nhân viên
create proc sp_deleteNV @emailBixoa  varchar(100), @emailXoa  varchar(100)
as
begin
	if(@emailBixoa != @emailXoa)
	update NHANVIEN set isDelete = 1 where Email = @emailBixoa
end
select * from KHACHHANG
go
		-- danh mục sản phẩm
-- thêm danh mục sp
create proc sp_insertDMSP
@maloai varchar(5),@tenloai nvarchar(30)
as
begin
	if not exists(select * from PHANLOAISP where TenLoai like @tenloai)
	insert into PHANLOAISP values(@maloai,@tenloai)
end
go
-- Cập nhật danh mục sp
create proc sp_updateDMSP
@maloai varchar(5),@tenloai nvarchar(30)
as
begin
	if not exists(select * from PHANLOAISP where TenLoai like @tenloai)
	update PHANLOAISP set TenLoai = @tenloai where MaLoai = @maloai
end
go
-- Xóa danh mục sp
create proc sp_deleteDMSP
@maloai varchar(5)
as
begin
	delete PHANLOAISP where MaLoai = @maloai
end
go

-- Tìm kiếm danh mục
CREATE PROC sp_DanhMuc
	@maLoai VARCHAR(100)
	AS
	BEGIN
		SET NOCOUNT ON
		SELECT MaLoai, TenLoai
		FROM PHANLOAISP
		WHERE MaLoai LIKE '%' + @maLoai + '%'
	END
	GO
	-- Khách hàng
-- Thêm danh sách khách hàng
create proc sp_insertKh @sdt varchar(15),@tenkh nvarchar(30)
as
begin
	if not exists(select * from KHACHHANG where SDT = @sdt)
	begin
		insert into KHACHHANG values(@sdt,@tenkh,0,default)
	end
end	
select * from SANPHAM
select * from DONVANCHUYEN
select * from CHITIETDONVANCHUYEN
go
-- cập nhật danh sách khách hàng
create  proc sp_updateKh @sdt varchar(15),@tenkh nvarchar(30)
as
begin
	update KHACHHANG set TenKH = @tenkh where SDT = @sdt
end	
go
-- xóa khách hàng
CREATE PROC sp_XoaKH
@DIENTHOAI VARCHAR(15)
AS
BEGIN
	DELETE FROM KHACHHANG
	WHERE SDT = @DIENTHOAI
END
GO
-- NHẬP LIỆU PHÂN LOẠI
INSERT INTO PHANLOAISP VALUES('AN01',N'Áo ngắn tay'),
							('AD01',N'Áo dài tay'),
							('HW01',N'Hoodies & Sweatshirts'),
							('QN01',N'Quần ngắn'),
							('P01',N'Quần'),
							('VA01',N'Váy'),
							('J01',N'Áo Jacket')
go
-- NHẬP LIỆU MÀU SẮC
INSERT INTO MAUSAC VALUES(N'Đen'),
						(N'Trắng'),
						(N'Vàng'),
						(N'Đỏ'),
						(N'Xám'),	
						(N'Tím'),
						(N'Hồng'),
						(N'Cam'),
						(N'Xanh')
select * from MAUSAC
go
-- NHẬP LIỆU KÍCH CỠ
INSERT INTO KICHCO VALUES('S'),
						('M'),
						('L'),
						('XL')
						
go
-- NHẬP LIỆU NHÂN VIÊN
exec sp_insertNV N'Sáng',N'Quận 8', '01231','SangMan@gmail.com',0,1,'1.png'
go
exec sp_insertNV N'Long',N'Quận 8', '01232','Long@gmail.com',0,1,'1.png'
go
exec sp_insertNV N'Hiển',N'Quận 8', '01233','HienMan@gmail.com',0,1,'1.png'
go
exec sp_insertNV N'Đạt',N'Quận 8', '01234','DatMan@gmail.com',0,1,'1.png'
go
exec sp_insertNV N'Khoa',N'Quận 8', '01235','KhoaMan@gmail.com',0,1,'1.png'
go 
create proc sp_taodonvanchuyen
as
begin
	insert into DONVANCHUYEN values(getdate());
end
go
create proc sp_xoadonvanchuyen
as
begin
	delete DONVANCHUYEN where MaDonNhap not in (select MaDonNhap from CHITIETDONVANCHUYEN)
end
go
-- lấy mã nhân viên bằng email
create proc sp_getIDnvByEmail @email varchar(50)
as
begin
	select MaNV from NHANVIEN where Email = @email
end
go
-- Thêm chi tiết hóa đơn vận chuyển
create proc sp_themCTDVC  @masp varchar(5), @manv varchar(5),@size int,@mamau int,@soluong int
as
	declare @madn int,
			@slht int,
			@slthem int
	select @slht = soluong from CHITIETDONVANCHUYEN where MaSP= @masp and Size = @size and MaMau = @mamau
	set @slthem = @soluong
begin
	if exists(select * from DONVANCHUYEN)
		select @madn = max(MaDonNhap) from DONVANCHUYEN
	else
		begin
			exec sp_taodonvanchuyen
			select @madn = max(MaDonNhap) from DONVANCHUYEN
		end
	if exists(select * from CHITIETDONVANCHUYEN where MaSP = @masp and MaDonNhap = @madn and Size= @size and MaMau = @mamau)
		update CHITIETDONVANCHUYEN set Soluong	= (@slht + @slthem) where MaDonNhap = @madn and MaSP = @masp and Size= @size and MaMau = @mamau
	else
		insert into CHITIETDONVANCHUYEN values(@madn,@masp,@manv,@size,@mamau,@soluong)
end	
go
create proc sp_themSP 
@masp varchar(5),@tensp nvarchar(30),@dgn float , @dgb float,
@doituong int, @hinhanhtrc varchar(50),@hinhanhsau varchar(50),
@maloai varchar(5),@soluong int ,@size int,@mamau int , @manv varchar(5)
as
	declare @slht int,
			@slthem int
	select @slht = soluong from CHITIETSANPHAM where MaSP= @masp and Size = @size and MaMau = @mamau
	set @slthem = @soluong
begin
	if exists (select Masp from SANPHAM where MaSP = @masp and TenSP = @tensp
		and DonGiaNhap = @dgn and DonGiaBan =@dgb and DoiTuong = @doituong   and MaLoai = @maloai and HinhAnhTrc = @hinhanhtrc and HinhAnhSau = @hinhanhsau )
		begin
			if exists(select MaSP from CHITIETSANPHAM where MaSP = @masp )
				begin
					if exists(select Size from CHITIETSANPHAM where MaSP = @masp and Size = @size)
						if exists (select MaMau from CHITIETSANPHAM where MaSP = @masp and Size = @size and MaMau = @mamau)
						begin
							update CHITIETSANPHAM set SoLuong = (@slht + @slthem) where MaSP = @masp and Size = @size and Mamau = @mamau
							exec sp_themCTDVC  @masp , @manv ,@size ,@mamau ,@soluong 
							
						end
						else
							begin
								insert into CHITIETSANPHAM values(@masp,@soluong,@size,@mamau)
								exec sp_themCTDVC  @masp , @manv ,@size ,@mamau ,@soluong 
							end
					else
						begin
								insert into CHITIETSANPHAM values(@masp,@soluong,@size,@mamau)
								exec sp_themCTDVC  @masp , @manv ,@size ,@mamau ,@soluong 
						end
				end
			else
				begin
					INSERT INTO SANPHAM VALUES(@masp,@tensp,@dgn,@dgb,default,@doituong,@hinhanhtrc,@hinhanhsau,0,@maloai) 
					insert into CHITIETSANPHAM values(@masp,@soluong,@size,@mamau)
					exec sp_themCTDVC  @masp , @manv ,@size ,@mamau ,@soluong 
				end
		end

	if not exists (select * from SANPHAM where TenSP = @tensp)
		begin
			if not exists (select Masp from SANPHAM where MaSP = @masp and (TenSP != @tensp
			or DonGiaNhap = @dgn or DonGiaBan =@dgb or DoiTuong = @doituong or MaLoai = @maloai))
				begin
					if not exists(select masp from SANPHAM where MaSP = @masp)
					begin
						INSERT INTO SANPHAM VALUES(@masp,@tensp,@dgn,@dgb,default,@doituong,@hinhanhtrc,@hinhanhsau,0,@maloai)
						insert into CHITIETSANPHAM values(@masp,@soluong,@size,@mamau)
						exec sp_themCTDVC  @masp , @manv ,@size ,@mamau ,@soluong 
					end
					else
					begin
						INSERT INTO SANPHAM VALUES(@masp,@tensp,@dgn,@dgb,default,@doituong,@hinhanhtrc,@hinhanhsau,0,@maloai)
						insert into CHITIETSANPHAM values(@masp,@soluong,@size,@mamau)
						exec sp_themCTDVC  @masp , @manv ,@size ,@mamau ,@soluong 
					end
				end
			
		end
end
--
go
 CREATE  TRIGGER UTG_ThemSLSanPham
ON CHITIETSANPHAM
AFTER INSERT , UPDATE
AS
	declare @tongslhientai int
	select @tongslhientai = Sum(SoLuong) from CHITIETSANPHAM where MaSP = (select MaSP from inserted)
	print cast(@tongslhientai as varchar)
BEGIN
		update SANPHAM set TongSoLuong = @tongslhientai where MaSP = (select MaSP from inserted)
END

select * from SANPHAM
select * from CHITIETSANPHAM
select * from CHITIETDONVANCHUYEN
update CHITIETSANPHAM set SoLuong = 20 where MaSP = 'a1' and size = 3
go
-- Điều chỉnh số lượng chi tiết đơn vận chuyển khi cập nhật lại
 CREATE TRIGGER UTG_DieuChinhSLCTDVC
ON CHITIETDONVANCHUYEN
AFTER  UPDATE
AS
	declare @sldau int,
			@slsau int
	select @sldau = SoLuong from CHITIETSANPHAM where MaSP = (select MaSP from inserted) and MaMau = (select MaMau from inserted) and Size = (select Size from inserted)
	select @slsau = SoLuong from inserted where MaSP = (select MaSP from inserted) and MaMau = (select MaMau from inserted) and Size = (select Size from inserted)
	print cast(@sldau as varchar) + 'sldau'
	print cast(@slsau as varchar) + 'slsau'
BEGIN
	if(@sldau = @slsau)
		update CHITIETSANPHAM set SoLuong = @sldau where MaSP = (select MaSP from inserted) and MaMau = (select MaMau from inserted) and Size = (select Size from inserted)
	else if (@sldau > @slsau)
		update CHITIETSANPHAM set SoLuong = (@sldau - (@sldau-@slsau)) where MaSP = (select MaSP from inserted) and MaMau = (select MaMau from inserted) and Size = (select Size from inserted)
	else 
		update CHITIETSANPHAM set SoLuong =  (@sldau + (@slsau-@sldau)) where MaSP = (select MaSP from inserted) and MaMau = (select MaMau from inserted) and Size = (select Size from inserted)
END

select * from CHITIETDONVANCHUYEN
select * From CHITIETSANPHAM
update CHITIETDONVANCHUYEN set soluong = 30 where MaSP = 'a1' and Size = 1 and MaMau = 2
--go
-- danh sách chi tiết sản phẩm
create proc sp_danhsachchitietsp
as
	select sp.MaSP,TenSP,DonGiaNhap,DonGiaBan,DoiTuong,Size,tenmau,HinhAnhTrc,HinhAnhSau,SoLuong from SANPHAM sp 
	inner join CHITIETSANPHAM ctsp on sp.MaSP = ctsp.MaSP
	inner join MAUSAC ms on ctsp.MaMau = ms.MaMau
go
-- danh sách sản phẩm
create proc sp_danhsachsp @masp varchar(5) = null
as
begin
	if(@masp is null)
	select * from SANPHAM
	else 
	select * from SANPHAM where MaSP = @masp
end
go
-- xem chi tiết 1 sản phẩm
create proc sp_chitiet1sp @masp varchar(5), @size int , @mamau int
as
begin
	select TenSP,DonGiaBan,SoLuong,MaMau,Size,HinhAnhTrc,HinhAnhSau,Giamgia from CHITIETSANPHAM inner join SANPHAM
	on SANPHAM.MaSP = CHITIETSANPHAM.MaSP
	where SANPHAM.MaSP = @masp and Size = @size and mamau = @mamau
end
go
-- Load size
create proc sp_loadSize @masp varchar(5)
as
begin
	select masp,size from CHITIETSANPHAM  where masp = @masp
	group by masp,Size
end
go

-- Load màu
create  proc sp_loadColor @masp varchar(5)
as
begin
	select masp,MaMau from CHITIETSANPHAM  where masp = @masp
	group by masp,MaMau
end
go
-- Load   màu sắc theo size
create proc sp_LoadColorBySize @masp varchar(5), @masize int
as
begin
	select masp,mamau,Size,SoLuong from CHITIETSANPHAM where MaSP = @masp and Size = @masize
end
go
-- Load  số lượng theo màu sắc và size
create proc sp_LoadQuantityBySizeAndColor @masp varchar(5), @masize int , @mamau int
as
	select masp,mamau,Size,SoLuong from CHITIETSANPHAM where MaSP = @masp and Size = @masize and MaMau = @mamau
go
--     chưa sử dụng
-- proc show bill vận chuyển
create proc sp_showbillvanchuyen
as
	select MaDonNhap, convert(varchar(10),ngaynhaphang,103) as NgayNhapHang,  convert(varchar(10),ngaynhaphang,108) as ThoiGian from donvanchuyen
-- proc show bill vận chuyển theo mã đơn
go
create proc sp_showbillVanChuyenByID @madonnhap int
as
		select MaDonNhap, convert(varchar(10),ngaynhaphang,103) as NgayNhapHang,  convert(varchar(10),ngaynhaphang,108) as ThoiGian from donvanchuyen 
		where madonnhap = @madonnhap
go

create proc sp_deletedonvanchuyen
as
	declare @madonxoa int
	select @madonxoa = MaDonNhap From DONVANCHUYEN where MaDonNhap  not in (select MaDonNhap from CHITIETDONVANCHUYEN)
begin
	delete DONVANCHUYEN where MaDonNhap = @madonxoa
end
go
-- Load img
create proc sp_loadImage
as
begin
	select MASP,TenSP,DonGiaBan,DoiTuong,HinhAnhTrc,HinhAnhSau,Giamgia from SANPHAM
end
-------------------------- Dữ liệu
 select * from NHANVIEN
-------------------------
--exec sp_taodonvanchuyen
--declare @i int  = 1
--while @i <=5
--begin
--exec sp_themSP 'A',N'AnTA Yallow',150000,230000,3,'atd_den.png','atd_sau_den.png','AN01', 100, 4, 3 ,'QL002'
--	set @i = @i + 1;
--end
exec sp_themSP 'A2',N'Fun And Peace TS',150000,250000,3,'atd_sau_den.png','atd_sau_den.png','AN01', 10, 1, 5,'QL002'

--select * from SANPHAM
--select * from MAUSAC
--SELECT * FROM CHITIETSANPHAM 
--exec sp_loadColor 'A3'
--select * from CHITIETDONVANCHUYEN
--select * from DONVANCHUYEN
--delete CHITIETDONVANCHUYEN
--DELETE CHITIETSANPHAM
--delete DONVANCHUYEN
--DELETE SANPHAM
--select masp,MaMau from CHITIETSANPHAM 
--group by masp,MaMau
--select * from MAUSAC
--select*from khachhang
-- select *,convert(varchar(10),NgayNhapHang,108) from DONVANCHUYEN where   convert(varchar(10),NgayNhapHang,108) like '%10%'
 

select * from NHANVIEN

update NHANVIEN set MatKhau = '418515815641305135230215920295153463' where MaNV = 'QL001'



































































-- test
select * from NHANVIEN where Email like '%@%' or 1=1--', and MatKhau = ''
exec sp_loginNV @email = true , @matkhau = or 1= 1
exec sp_loginNV '', 1=1
select * from NHANVIEN

	--Đăng nhập nhân viên
create  proc sp_loginNV @email varchar(100), @matkhau varchar(255)
as
	declare @status int
begin
	if exists (select * from NHANVIEN where Email = @email and MatKhau = @matkhau)
		set @status = 1
	else
		set @status = 0
	select @status
end
exec sp_loginnv 'long@gmail.com' ,'123' 
select * From NHANVIEN
go