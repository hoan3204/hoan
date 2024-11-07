CREATE DATABASE SimThe;
USE SimThe;
CREATE TABLE Mang (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    TenMang VARCHAR(50) NOT NULL
);
CREATE TABLE Sim (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    SoSim VARCHAR(15) NOT NULL,
    MangID INT,
    NgayKichHoat DATE,
    NgayHetHan DATE,
    FOREIGN KEY (MangID) REFERENCES Mang(ID)
);
-- Thêm dữ liệu vào bảng Mang
INSERT INTO Mang (TenMang) VALUES ('Viettel'), ('Mobifone'), ('Vinaphone');

-- Thêm dữ liệu vào bảng Sim
INSERT INTO Sim (SoSim, MangID, NgayKichHoat, NgayHetHan)
VALUES 
    ('0981234567', 1, '2024-01-01', '2025-01-01'),
    ('0971234568', 2, '2023-02-01', '2024-02-01'),
    ('0961234569', 3, '2023-03-01', '2024-03-01');
