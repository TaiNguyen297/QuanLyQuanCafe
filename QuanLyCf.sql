CREATE DATABASE QUANLYCAFE

USE QUANLYCAFE
Go

CREATE TABLE TableFood
(
	id INT IDENTITY Primary key,
	name nvarchar(100),
	status nvarchar(100) -- Trống || Có người 
)

CREATE TABLE Account
(
	id INT IDENTITY Primary key,
	DisplayName NVARCHAR(100) not Null,
	UserName Nvarchar(100) not Null,
	PassWord Nvarchar(100) not Null,
	Type Int not Null
)

CREATE TABLE FoodCategory
(
	id INT IDENTITY Primary key,
	name nvarchar(100) not null default N'Chưa đặt tên'
)

CREATE TABLE Food
(
	id INT IDENTITY Primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory Int not null,
	price Float not null default 0,

	FOREIGN KEY (idCategory) references dbo.FoodCategory(id)
)

CREATE TABLE Bill
(
	id INT IDENTITY Primary key,
	idTable Int not null,
	status Int not null default 0 -- 1: đã thanh toán || 0: chưa thanh toán 
)

CREATE TABLE BillInfo
(
	id INT IDENTITY Primary key,
	idBill Int not null,
	idFood int not null,
	count Int not null default 0,

	FOREIGN KEY (idBill) references dbo.Bill(id),
	FOREIGN KEY (idFood) references dbo.Food(id)
)

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'K9' , -- UserName - nvarchar(100)
          N'RongK9' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END 
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'K9'
SELECT * FROM dbo.Account where UserName = N'K9' AND PassWord = N'1'

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO