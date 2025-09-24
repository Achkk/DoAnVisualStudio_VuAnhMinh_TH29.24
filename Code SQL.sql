-- TẠO CSDL (nếu chưa tồn tại)
IF DB_ID(N'quanlybanhang') IS NULL
    CREATE DATABASE [quanlybanhang];
GO
USE [quanlybanhang];
GO

/* Xóa bảng theo thứ tự chống vướng khóa ngoại */
IF OBJECT_ID(N'dbo.Diem',      N'U') IS NOT NULL DROP TABLE dbo.Diem;
IF OBJECT_ID(N'dbo.SinhVien',  N'U') IS NOT NULL DROP TABLE dbo.SinhVien;
IF OBJECT_ID(N'dbo.TaiKhoan',  N'U') IS NOT NULL DROP TABLE dbo.TaiKhoan;
IF OBJECT_ID(N'dbo.Lop',       N'U') IS NOT NULL DROP TABLE dbo.Lop;
GO

/* ===================== BẢNG LOP ===================== */
CREATE TABLE dbo.Lop
(
    MaLop  VARCHAR(10)  NOT NULL PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    Nganh  NVARCHAR(20) NOT NULL
        CHECK (Nganh IN (N'CNTT', N'KD', N'NA', N'NT')),
    CONSTRAINT UQ_Lop_MaLop_Nganh UNIQUE (MaLop, Nganh) -- để SV có thể FK theo (MaLop,Nganh)
);
GO

/* ===================== BẢNG SINHVIEN ===================== */
CREATE TABLE dbo.SinhVien
(
    MaSV     CHAR(3)         NOT NULL PRIMARY KEY,     -- 001..010
    HoTen    NVARCHAR(100)   NOT NULL,
    NgaySinh DATE            NULL,
    GioiTinh NVARCHAR(3)     NULL  CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Nu')),
    HinhAnh  NVARCHAR(255)   NULL,  -- đường dẫn ảnh (để NULL như ảnh chụp)
    MaLop    VARCHAR(10)     NOT NULL,
    Nganh    NVARCHAR(20)    NOT NULL
        CHECK (Nganh IN (N'CNTT', N'KD', N'NA', N'NT')),
    CONSTRAINT FK_SV_Lop
        FOREIGN KEY (MaLop, Nganh) REFERENCES dbo.Lop(MaLop, Nganh)
            ON UPDATE CASCADE ON DELETE NO ACTION
);
GO

/* ===================== BẢNG DIEM ===================== */
CREATE TABLE dbo.Diem
(
    MaSV    CHAR(3)        NOT NULL,
    MonHoc  NVARCHAR(50)   NOT NULL,
    LanThi  TINYINT        NOT NULL CHECK (LanThi >= 1),
    Diem    DECIMAL(4,1)   NOT NULL CHECK (Diem BETWEEN 0 AND 10),
    CONSTRAINT PK_Diem PRIMARY KEY (MaSV, MonHoc, LanThi),
    CONSTRAINT FK_Diem_SV FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV)
        ON DELETE CASCADE ON UPDATE CASCADE
);
GO

/* ===================== BẢNG TAIKHOAN ===================== */
CREATE TABLE dbo.TaiKhoan
(
    TenDangNhap NVARCHAR(50)  NOT NULL PRIMARY KEY,
    MatKhau     NVARCHAR(255) NOT NULL,
    VaiTro      NVARCHAR(20)  NULL CHECK (VaiTro IN (N'GiaoVien', N'SinhVien'))
);
GO

/* ===================== DỮ LIỆU MẪU (đúng như ảnh) ===================== */
SET DATEFORMAT YMD;

-- Lop
INSERT INTO dbo.Lop (MaLop, TenLop, Nganh) VALUES
(N'KD29.24', N'KD29.24', N'KD'),
(N'NA29.29', N'NA29.29', N'NA'),
(N'NT29.01', N'NT29.01', N'NT'),
(N'TH29.24', N'TH29.24', N'CNTT');

-- SinhVien
INSERT INTO dbo.SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, HinhAnh, MaLop, Nganh) VALUES
('001', N'Nguyễn Thành An',      '2006-03-04', N'Nam', NULL, N'TH29.24', N'CNTT'),
('002', N'Vương Đình Duy An',    '2006-10-12', N'Nam', NULL, N'TH29.24', N'CNTT'),
('003', N'Nguyễn Linh Chi',      '2006-05-03', N'Nữ',  NULL, N'TH29.24', N'CNTT'),
('004', N'Đặng Thị Thu Huyền',   '2006-05-24', N'Nữ',  NULL, N'TH29.24', N'CNTT'),
('005', N'Trần Thảo Phương',     '2006-09-01', NULL,   NULL, N'KD29.24', N'KD'),
('006', N'Nguyễn Huy Vũ',        '2006-11-09', NULL,   NULL, N'KD29.24', N'KD'),
('007', N'Nguyễn Vũ Trường',     '2006-08-29', NULL,   NULL, N'NA29.29', N'NA'),
('008', N'Nguyễn Quốc Khánh',    '2006-02-02', NULL,   NULL, N'NA29.29', N'NA'),
('009', N'Nguyễn Huy Minh',      '2005-02-12', NULL,   NULL, N'NT29.01', N'NT'),
('010', N'Trần Đức Minh',        '2005-02-22', NULL,   NULL, N'NT29.01', N'NT');

-- Diem
INSERT INTO dbo.Diem (MaSV, MonHoc, LanThi, Diem) VALUES
('001', N'Excel',       1, 9),
('002', N'Excel',       1, 10),
('003', N'SQL',         1, 7),
('004', N'SQL',         1, 9),
('005', N'Kinh Doanh',  2, 6),
('006', N'Kinh Doanh',  1, 5),
('007', N'Tiếng Anh',   2, 10),
('008', N'Tiếng Anh',   2, 10),
('009', N'Tiếng Trung', 1, 8),
('010', N'Tiếng Trung', 1, 8);

-- TaiKhoan
INSERT INTO dbo.TaiKhoan (TenDangNhap, MatKhau, VaiTro) VALUES
(N'admin',   N'1234',  N'GiaoVien'),
(N'SinhVien',N'12345', N'SinhVien');
GO

/* Một vài truy vấn test nhanh giống ảnh */
SELECT TOP (1000) MaSV, MonHoc, LanThi, Diem FROM dbo.Diem;
SELECT TOP (1000) MaLop, TenLop, Nganh        FROM dbo.Lop;
SELECT TOP (1000) MaSV, HoTen, NgaySinh, GioiTinh, HinhAnh, MaLop, Nganh FROM dbo.SinhVien;
SELECT TOP (1000) TenDangNhap, MatKhau, VaiTro FROM dbo.TaiKhoan;
