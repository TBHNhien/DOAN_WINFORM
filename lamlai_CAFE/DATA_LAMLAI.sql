﻿CREATE DATABASE QLBH
GO

USE QLBH
GO


--FoodCategory
--Food
--Table
--Account
--BILL (1 HÓA ĐƠN CÓ NHIỀU MÓN (BILLINFO))
--BILLINFO


CREATE TABLE TABLEFOOD
(
	IDTABLEFOOD INT IDENTITY(1,1) PRIMARY KEY ,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'BÀN CHƯA ĐẶT TÊN',
	STATUSTABLE NVARCHAR (100) NOT NULL DEFAULT N'Trống'-- Trống || Có Người
)
GO




CREATE TABLE ACCOUNT 
(
	USERNAME NVARCHAR(100) PRIMARY KEY ,
	DISPLAYNAME NVARCHAR (100) NOT NULL ,	
	PASSWORDACCOUNT NVARCHAR(100) NOT NULL DEFAULT '0' ,
	TYPE INT NOT NULL DEFAULT 0 -- 1 ADMIN , 0 STAFF
)
GO

INSERT INTO ACCOUNT VALUES (N'b1' , N'Thien','1',0)
INSERT INTO ACCOUNT VALUES (N'a1' , N'Nhien','1',1)


select * from ACCOUNT

CREATE TABLE FOODCATEGORY 
(
	IDFOODCATEGORY INT IDENTITY(1,1) PRIMARY KEY ,
	NAMECATEGORYFOOD NVARCHAR(100) NOT NULL DEFAULT N'CHƯA ĐẶT TÊN MÓN' 
)
GO


CREATE TABLE FOOD
(
	IDFOOD INT IDENTITY(1,1) PRIMARY KEY ,
	NAMEFOOD NVARCHAR(100) NOT NULL DEFAULT N'CHƯA ĐẶT TÊN MÓN' ,
	IDFOODCATEGORY INT NOT NULL FOREIGN KEY REFERENCES FOODCATEGORY(IDFOODCATEGORY) ,
	PRICE FLOAT NOT NULL  DEFAULT 0  ,
)
GO

CREATE TABLE BILL
(
	IDBILL INT IDENTITY(1,1) PRIMARY KEY ,
	DATECHECKIN DATE NOT NULL DEFAULT GETDATE() ,
	DATECHECKOUT DATE,
	IDTABLEFOOD INT NOT NULL FOREIGN KEY REFERENCES TABLEFOOD (IDTABLEFOOD) ,
	STATUS INT NOT NULL  DEFAULT 0  --1 LÀ ĐÃ THANH TOÁN , 0 LÀ CHƯA THANH TOÁN

)
GO


CREATE TABLE BILLINFO
(
	IDBILLINFO INT IDENTITY(1,1) PRIMARY KEY ,
	USERNAME NVARCHAR(100) NOT NULL,
	IDBILL INT NOT NULL FOREIGN KEY REFERENCES BILL (IDBILL) ,
	IDFOOD INT NOT NULL FOREIGN KEY REFERENCES FOOD(IDFOOD) ,
	COUNTFOOD INT NOT NULL DEFAULT 0 ,

	FOREIGN KEY (USERNAME) REFERENCES ACCOUNT(USERNAME)
)
GO



create Table Store
(
	UserName NVARCHAR(100) NOT NULL,
	Material NVARCHAR(100) NOT NULL ,
	DateIn date NOT NULL DEFAULT GETDATE(),
	Dateexpired date ,--ngày hết hạn
	priceIn float NOT NULL,
	amount int NOT NULL DEFAULT 1,
	category NVARCHAR(100) 
	
	primary key (username , material , datein),
	FOREIGN KEY (username) REFERENCES dbo.account(username)
)
GO


create table salary
(
	UserName NVARCHAR(100),
	Type INT NOT NULL,
	WORKDAY int,
	restday int,
	wagelevel float,
	bonus float,

	punish float,
	total float,
	
	primary key (username , Type),
	foreign key (username) references dbo.account(username)
)
GO


CREATE PROC USP_GETACCOUNTBYUSERNAME
@USERNAME NVARCHAR(100)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME = @USERNAME
END
GO

EXEC USP_GETACCOUNTBYUSERNAME @USERNAME = "A1" 

SELECT * FROM ACCOUNT WHERE USERNAME = N'A1' AND PASSWORDACCOUNT = '1'

CREATE STORE

























