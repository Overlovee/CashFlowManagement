CREATE DATABASE DB_CashFlowManagement;

-- Sử dụng cơ sở dữ liệu QuanLyThuChi
USE DB_CashFlowManagement;

-- Tạo bảng Danh mục (Category)
CREATE TABLE Categories (
    ID CHAR(10) NOT NULL,
    Category_Name NVARCHAR(255) UNIQUE NOT NULL,
	Category_Type CHAR(30) NOT NULL,
	Category_Img CHAR(100) DEFAULT 'category_df.png',
	CONSTRAINT PK_Categories PRIMARY KEY (ID),
	CONSTRAINT CK_Category_Type CHECK (Category_Type IN ('Income', 'Expenditure'))
);

-- Tạo bảng Users (User)
CREATE TABLE Users (
    ID INT IDENTITY(1, 1) NOT NULL,
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
	Role NVARCHAR(20) DEFAULT N'User',
    Available_Money DECIMAL(18, 2) DEFAULT 0, -- Tiền mặc định = 0 (nếu không nhập)
	CONSTRAINT PK_Users PRIMARY KEY (ID)
);
-- Tạo bảng Users (User)
CREATE TABLE Setting (
    SettingID INT IDENTITY(1, 1) NOT NULL,
	User_ID INT NOT NULL,
    Languages NVARCHAR(255) NOT NULL,
    TimeFormat NVARCHAR(255) NOT NULL,
    CurrencyUnit NVARCHAR(255) NOT NULL,
	OverviewDisplayMode NVARCHAR(20),
	CONSTRAINT PK_Setting PRIMARY KEY (SettingID),
	CONSTRAINT FK_Settings_Users_ID FOREIGN KEY (User_ID) REFERENCES Users(ID)

);
-- Tạo bảng Giao dịch (Transaction)
CREATE TABLE Transactions (
    ID INT IDENTITY(1, 1) NOT NULL,
    User_ID INT NOT NULL,
    Category_ID CHAR(10) NOT NULL,
    Transaction_Type CHAR(30) NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL,
    Transaction_Date DATE DEFAULT GETDATE(), -- Ngày giao dịch mặc định là ngày hiện tại
    Transaction_Description NVARCHAR(1000) DEFAULT 'Nah', -- Mô tả giao dịch mặc định = Nah
	Transaction_Currency CHAR(4) DEFAULT 'VND', -- Loại tiền tệ giao dịch mặc định = VND

	CONSTRAINT PK_Transactions PRIMARY KEY (ID),
    CONSTRAINT FK_Transactions_Users_ID FOREIGN KEY (User_ID) REFERENCES Users(ID),
    CONSTRAINT FK_Transactions_Category_ID FOREIGN KEY (Category_ID) REFERENCES Categories(ID), 
	CONSTRAINT CHECK_Transactions_Amount CHECK(Amount > 0), -- Lượng tiền chi cho mỗi giao dịch > 0 
	CONSTRAINT CHECK_Transactions_Type CHECK(Transaction_Type IN ('Income', 'Expenditure')), -- Loại giao dịch là Thu hoặc Chi
	CONSTRAINT CHECK_Transaction_Date CHECK (Transaction_Date <= GETDATE()) -- Ngày giao dịch phải là hiện tại hoặc quá khứ
);
--Trigger
CREATE TRIGGER UPDATE_Income_Available_Money
ON Transactions
AFTER INSERT, UPDATE
AS
BEGIN
	IF((SELECT Transaction_Type FROM INSERTED) = 'Income')	
		UPDATE Users
		SET Available_Money += (SELECT Amount FROM INSERTED WHERE inserted.User_ID = Users.ID and inserted.Transaction_Type = 'Income') 
		FROM Users
		INNER JOIN inserted ON Users.ID = inserted.User_ID;
END
GO

CREATE TRIGGER UPDATE_Expenditures_Available_Money
ON Transactions
AFTER INSERT, UPDATE
AS
BEGIN
	IF((SELECT Transaction_Type FROM INSERTED) = 'Expenditure')	
		UPDATE Users
		SET Available_Money -= (SELECT Amount FROM INSERTED WHERE inserted.User_ID = Users.ID and inserted.Transaction_Type = 'Expenditure') 
		FROM Users
		INNER JOIN inserted ON Users.ID = inserted.User_ID;
END
GO

CREATE PROCEDURE DeleteCategory
    @Category_ID CHAR(10)
AS
BEGIN
    BEGIN TRANSACTION; -- Bắt đầu giao dịch

    -- Cập nhật các giao dịch tham chiếu đến danh mục
    UPDATE Transactions
    SET Category_ID = 
        CASE
            WHEN Transaction_Type = 'Income' THEN 'TKK'
            WHEN Transaction_Type = 'Expenditure' THEN 'CKK'
            ELSE Category_ID
        END
    WHERE Category_ID = @Category_ID;

    -- Xoá danh mục
    DELETE FROM Categories
    WHERE ID = @Category_ID;

    COMMIT; -- Kết thúc giao dịch
END;

--
INSERT INTO Categories(ID, Category_Name, Category_Type)
VALUES('CTP',N'Thực Phẩm', 'Expenditure'),
('CSH',N'Sinh Hoạt Phí', 'Expenditure'),
('CTD',N'Tiền Điện', 'Expenditure'),
('CTN',N'Tiền Nước', 'Expenditure'),
('CTT',N'Tiền Trọ', 'Expenditure'),
('TTN',N'Thu nhập', 'Income'),
('CTH',N'Tiền Học', 'Expenditure'),
('TKK',N'Khoảng Thu Khác', 'Income'),
('CKK',N'Khoảng Chi Khác', 'Expenditure');

INSERT INTO Users(Name,Email,Password,Role)
VALUES(N'Nguyễn Huy Hoàng',N'Hoang012@gmail.com',N'admin',N'Admin'),
(N'Nguyễn Minh Thư',N'Thu2123@gmail.com',N'admin',N'Admin');
INSERT INTO Users(Name,Email,Password)
VALUES(N'Trương Quốc Huy',N'Huy5512@gmail.com',N'Huy12445'),
(N'Vương Kim Dinh',N'Dinh0201@gmail.com',N'Din4124'),
(N'Trương Thế Vinh',N'Vinh0111@gmail.com',N'Vinh2217');

INSERT INTO Transactions
VALUES(4,'TTN','Income',1000000,'2023/8/10',N'Lương Tháng 8','VND');
INSERT INTO Transactions
VALUES(3,'TTN','Income',150000,'2023/8/19',N'Lương Tháng 8','VND');
INSERT INTO Transactions
VALUES(5,'TKK','Income',3000000,'2023/9/1',N'Mẹ Gửi','VND');
INSERT INTO Transactions
VALUES(5,'CTT','Expenditure',500000,GETDATE(),N'Đóng Trọ Tháng 9','VND');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',15000,'2023/9/1',N'Mua Đồ ăn','VND');
INSERT INTO Transactions
VALUES(4,'CTD','Expenditure',200000,GETDATE(),N'Điện Tháng 8','VND');
GO

SELECT* FROM Users
SELECT* FROM Categories
SELECT* FROM Transactions

--EXEC DeleteCategory @Category_ID = 'CTP';

--Drop table Users
--Drop table Transactions
--Drop table Categories
