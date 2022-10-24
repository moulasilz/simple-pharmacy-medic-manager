create database qlthuoc_02_HTLongNVDucPDHoang
use qlthuoc_02_HTLongNVDucPDHoang

CREATE TABLE [dbo].[thuoc] ( 

[mathuoc] VARCHAR(10) NOT NULL ,
[tenthuoc] NVARCHAR(255) NOT NULL ,
[soluong] INT NOT NULL , 
[dongia] MONEY NOT NULL ,
[thanhtien] MONEY DEFAULT '0' ,
[gioithieu] NTEXT NOT NULL ,
[macuahang] VARCHAR(10) NOT NULL ,

PRIMARY KEY ([mathuoc]) 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[cuahang] ( 
    [macuahang] VARCHAR(10) NOT NULL ,
    [tencuahang] NVARCHAR(255) NOT NULL ,
    [diachi] NTEXT NOT NULL ,
    [dienthoai] VARCHAR(10) NOT NULL ,
    [email] VARCHAR(255) NOT NULL ,

PRIMARY KEY ([macuahang]) 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[dangnhap](
    [username] VARCHAR(255) NOT NULL ,
    [password] VARCHAR(255) NOT NULL ,
    [fullname] NVARCHAR(255) NOT NULL ,
    [email] VARCHAR(255) NOT NULL ,
    [mod] BIT NOT NULL ,
    [state] BIT NOT NULL ,

PRIMARY KEY ([username]) 
) ON [PRIMARY]
GO

-- Tạo liên kết khoá ngoại

ALTER TABLE [dbo].[thuoc]
ADD FOREIGN KEY (macuahang) REFERENCES [dbo].[cuahang](macuahang);

-- Tạo Trigger tính thành tiền cho bảng thuốc

 CREATE TRIGGER trigger_suathuoc on [dbo].[thuoc] AFTER UPDATE AS
 BEGIN
    UPDATE [dbo].[thuoc] 
    SET [thanhtien] = [thuoc].[soluong] * [thuoc].[dongia]
    FROM [dbo].[thuoc] JOIN inserted ON [thuoc].[mathuoc] = inserted.[mathuoc]
 END

CREATE TRIGGER trigger_themthuoc on [dbo].[thuoc] AFTER INSERT AS
 BEGIN
    UPDATE [dbo].[thuoc] 
    SET [thanhtien] = [thuoc].[soluong] * [thuoc].[dongia]
    FROM [dbo].[thuoc] JOIN inserted ON [thuoc].[mathuoc] = inserted.[mathuoc]
 END

-- INSERT dữ liệu vào bảng

-- Insert rows into table '[dbo].[cuahang]'

INSERT INTO [dbo].[cuahang] ( [macuahang], [tencuahang], [diachi], [dienthoai], [email] )
VALUES
( 'HN01', N'Nhà Thuốc Lĩnh Nam 218', N'Số 218, Lĩnh Nam, Hoàng Mai, Hà Nội', '0123456789', 'nhathuoclinhnam218.hn01@nhathuoc.vn'),
( 'HN02', N'Nhà Thuốc Yên Sở', N'Đối diện uỷ ban phường Yên Sở, Yên Sở, Hoàng Mai, Hà Nội', '0123456789', 'nhathuocyenso.hn02@nhathuoc.vn'),
( 'HN03', N'Nhà Thuốc Minh Khai 456', N'456 P. Minh Khai, Vĩnh Tuy, Hai Bà Trưng, Hà Nội', '0123456789', 'nhathuocminhkhai456.hn03@nhathuoc.vn'),
( 'HN04', N'Nhà Thuốc ĐH Bách Khoa', N'1 Đại Cồ Việt, Bách Khoa, Hai Bà Trưng, Hà Nội', '0123456789', 'nhathuocdhbkhn.hn04@nhathuoc.vn'),
( 'HN05', N'Nhà Thuốc ĐH Kinh tế Quốc Dân', N'207 Giải Phóng, Đồng Tâm, Hai Bà Trưng, Hà Nội', '0123456789', 'nhathuocdhktqd.hn05@nhathuoc.vn')
GO

-- Insert rows into table '[dbo].[thuoc]'

INSERT INTO [dbo].[thuoc]
([mathuoc], [tenthuoc], [soluong], [dongia], [gioithieu], [macuahang])
VALUES
('1', N'Decolgen Forte vỉ 4 viên', '25', '129000', N'Thuốc Decolgen là một loại thuốc thuộc nhóm thuốc giảm đau, hạ sốt, chống viêm không steroid tốt và phổ biến nhất hiện nay. Thuốc có tác dụng chủ yếu là điều trị các bệnh cảm cúm và các triệu chứng liên quan như hắt hơi, đau đầu, sổ mũi, ho,…', 'HN01' ),
('2', N'hạ sốt Efferalgan 500mg', '16', '48000', N'Thuốc Efferalgan 500mg là loại thuốc giảm đau hạ sốt phổ biến có mặt hầu hết trong các tủ thuốc gia đình để có thể sử dụng tại nhà', 'HN01' ),
('3', N'Partamol 500mg VNE', '42', '54000', N'Thuốc giảm đau - hạ sốt. Dùng trong các cơn đau từ nhẹ đến vừa và sốt, đặc biệt đối với những bệnh nhân bị chống chỉ định hay không dung nạp salicylat', 'HN02'),
('4', N'Acemol Enfant 100mg (Chai 100 viên)', '10', '16000', N'Acetaminophen (Paracetamol) là thuốc giảm đau hạ sốt không steroid.', 'HN03'),
('5', N'Tatanol 250 mg', '32', '63000', N'Hạ sốt. Giảm đau do: cảm lạnh, cảm cúm, nhức đầu, đau họng, mọc răng, chích ngừa, cắt Amiđan', 'HN04')
GO

-- Insert rows into table '[dbo].[dangnhap]'

INSERT INTO [dbo].[dangnhap]
( [username], [password], [fullname], [email], [mod], [state])
VALUES
('thuthuy', 'asd123456', N'Vũ Thu Thuỷ', 'admin.thuthuy@nhathuoc.vn', '0', '1'),
('thanhlong', 'asd123456', N'Hầu Thành Long', 'admin.thanhlong@nhathuoc.vn', '0', '1'),
('nguyenduc', 'asd123456', N'Nguyễn Văn Đức', 'admin.ngvanduc@nhathuoc.vn', '0', '1'),
('huyhoang', 'asd123456', N'Phạm Huy Hoàng', 'admin.ngvanduc@nhathuoc.vn', '0', '1'),
( 'thanhduy', 'asd123456', N'Nguyễn Phạm Thanh Duy', 'user.thanhduy@nhathuoc.vn', '1', '1')
GO


-- drop database qlthuoc_02_HTLongNVDucPDHoang

