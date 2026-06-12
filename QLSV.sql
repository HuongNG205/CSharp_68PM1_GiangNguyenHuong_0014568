CREATE DATABASE QLSV
GO

USE QLSV
GO

-- Tạo bảng LopHoc
CREATE TABLE LopHocs (
    id INT IDENTITY(1,1) PRIMARY KEY,
    MaLop NVARCHAR(20) NOT NULL UNIQUE,
    TenLop NVARCHAR(100) NOT NULL,
	Note NVARCHAR(255)
)
GO

-- Tạo bảng SinhVien
CREATE TABLE SinhViens (
    MaSV VARCHAR(8) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    Birth DATE,
    MaLop NVARCHAR(20),

    CONSTRAINT FK_SinhVien_LopHoc
        FOREIGN KEY (MaLop)
        REFERENCES LopHocs(MaLop)
)
GO

-- Nhập dữ liệu cho bảng LopHoc
INSERT INTO LopHocs (MaLop, TenLop)
VALUES
(N'68PM1',  N'Lớp 68PM1'),
(N'68PM2',  N'Lớp 68PM2'),
(N'68MHT1', N'Lớp 68MHT1'),
(N'68MHT2', N'Lớp 68MHT2'),
(N'NONE',  N'Chưa phân lớp')
GO

-- Nhập dữ liệu cho bảng SinhVien
-- Gender: 1 = Nam, 0 = Nữ

INSERT INTO SinhViens (MaSV, HoTen, Gender, Birth, MaLop)
VALUES
('SV0001', N'Nguyễn Văn An',   N'Nam', '2005-01-12', N'68PM1'),
('SV0002', N'Trần Thị Bình',   N'Nữ',  '2005-03-25', N'68PM1'),
('SV0003', N'Lê Hoàng Long',   N'Nam', '2004-11-05', N'68PM1'),
('SV0004', N'Phạm Minh Tuấn',  N'Nam', '2005-07-19', N'68PM2'),
('SV0005', N'Đỗ Thị Lan',      N'Nữ',  '2005-02-14', N'68PM2'),
('SV0006', N'Vũ Quốc Huy',     N'Nam', '2004-09-09', N'68PM2'),
('SV0007', N'Nguyễn Thu Hà',   N'Nữ',  '2005-06-30', N'68MHT1'),
('SV0008', N'Bùi Anh Đức',     N'Nam', '2004-12-21', N'68MHT1'),
('SV0009', N'Hoàng Mai Anh',   N'Nữ',  '2005-05-18', N'68MHT1'),
('SV0010', N'Phan Nhật Minh',  N'Nam', '2005-08-10', N'68MHT2'),
('SV0011', N'Trịnh Khánh Ly',  N'Nữ',  '2004-10-27', N'68MHT2'),
('SV0012', N'Ngô Văn Nam',     N'Nam', '2005-04-15', N'68MHT2'),
('SV0013', N'Đặng Gia Bảo',    N'Nam', '2005-01-01', N'68PM1'),
('SV0014', N'Lý Thảo Nhi',     N'Nữ',  '2005-09-12', N'68PM2'),
('SV0015', N'Chu Minh Khang',  N'Nam', '2004-06-06', N'68MHT1')
GO

ALTER TABLE SinhViens DROP CONSTRAINT FK_SinhVien_LopHoc;
GO

ALTER TABLE SinhViens
ADD CONSTRAINT FK_SinhVien_LopHoc
    FOREIGN KEY (MaLop)
    REFERENCES LopHocs(MaLop)
    ON UPDATE CASCADE;
GO