﻿CREATE DATABASE DB_CashFlowManagement;

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
    Email CHAR(255) UNIQUE,
    Password NVARCHAR(255) NOT NULL,
	Role NVARCHAR(20) DEFAULT N'User',
    Available_Money DECIMAL(18, 2) DEFAULT 0, -- Tiền mặc định = 0 (nếu không nhập)
	CONSTRAINT PK_Users PRIMARY KEY (ID)
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

	CONSTRAINT PK_Transactions PRIMARY KEY (ID),
    CONSTRAINT FK_Transactions_Users_ID FOREIGN KEY (User_ID) REFERENCES Users(ID),
    CONSTRAINT FK_Transactions_Category_ID FOREIGN KEY (Category_ID) REFERENCES Categories(ID), 
	CONSTRAINT CHECK_Transactions_Amount CHECK(Amount > 0), -- Lượng tiền chi cho mỗi giao dịch > 0 
	CONSTRAINT CHECK_Transactions_Type CHECK(Transaction_Type IN ('Income', 'Expenditure')), -- Loại giao dịch là Thu hoặc Chi
	CONSTRAINT CHECK_Transaction_Date CHECK (Transaction_Date <= GETDATE()) -- Ngày giao dịch phải là hiện tại hoặc quá khứ
);
CREATE TABLE Languages (
    Language_Code CHAR(2) PRIMARY KEY,
    Language_Name NVARCHAR(255) NOT NULL
);

CREATE TABLE Currency (
    Currency_Code CHAR(3) PRIMARY KEY,
    Currency_Name NVARCHAR(255) NOT NULL,
	ExchangeRateUSD decimal(18, 2) NOT NULL
);
-- Tạo bảng Setting
CREATE TABLE Setting (
	User_ID INT NOT NULL,
    Language_Code CHAR(2) NOT NULL,
    TimeFormat CHAR(10) DEFAULT 'dd/mm/yyyy',
    Currency_Code CHAR(3) NOT NULL,
	OverviewDisplayMode NVARCHAR(100) DEFAULT N'beginning/ending balance',
	CONSTRAINT PK_Setting PRIMARY KEY (User_ID),
	CONSTRAINT FK_Settings_Users_ID FOREIGN KEY (User_ID) REFERENCES Users(ID),
	CONSTRAINT FK_Settings_Users_Currency FOREIGN KEY (Currency_Code) REFERENCES Currency(Currency_Code),
	CONSTRAINT FK_Settings_Users_Language FOREIGN KEY (Language_Code) REFERENCES Languages(Language_Code),
	CONSTRAINT CHK_TimeFormat CHECK (TimeFormat IN ('dd/mm/yyyy', 'mm/dd/yyyy', 'yyyy/mm/dd')),
	CONSTRAINT CHK_OverviewDisplayMode CHECK (OverviewDisplayMode IN (N'beginning/ending balance', N'money in/money out'))
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
INSERT INTO Languages
VALUES ('EN', N'English'),
('VN', N'Vietnamese')
--
INSERT INTO Currency
VALUES ('USD', N'United State Dollar', 1),
('VND', N'Việt Nam Đồng', 23.585)

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

--
INSERT INTO Setting(User_ID, Language_Code, Currency_Code)
VALUES (3, 'EN', 'VND'),
(2, 'EN', 'USD')


INSERT INTO Transactions
VALUES(1,'TTN','Income',1000000,'2023/8/10',N'Lương Tháng 8');
INSERT INTO Transactions
VALUES(3,'TTN','Income',150000,'2023/8/19',N'Lương Tháng 8');
INSERT INTO Transactions
VALUES(2,'TKK','Income',3000000,'2023/9/1',N'Mẹ Gửi');
INSERT INTO Transactions
VALUES(1,'CTT','Expenditure',500000,GETDATE(),N'Đóng Trọ Tháng 9');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',15000,'2023/9/1',N'Mua Đồ ăn');
INSERT INTO Transactions
VALUES(2,'CTD','Expenditure',200000,GETDATE(),N'Điện Tháng 8');
GO

SELECT* FROM Users
SELECT* FROM Setting
SELECT* FROM Categories
SELECT* FROM Transactions
SELECT* FROM Languages
SELECT* FROM Currency

--EXEC DeleteCategory @Category_ID = 'CTP';


--Drop table Transactions
--Drop table Categories
--Drop table Users
--Drop table Setting
--Drop table Currency

SELECT * FROM Setting WHERE User_ID = 3