use master

IF DB_ID('BookRegistration') IS NOT NULL
	DROP DATABASE BookRegistration
GO

CREATE DATABASE BookRegistration
GO

USE BookRegistration
GO

CREATE TABLE Customer
(
	CustomerID	int	PRIMARY KEY IDENTITY
	,DateOfBirth	date	NOT NULL
	,FirstName	varchar(30)	NOT NULL
	,LastName	varchar(35)	NOT NULL
	,Title		varchar(30)	NOT NULL
)
GO

INSERT INTO Customer(DateOfBirth, FirstName,LastName,Title)
	VALUES('Jan 01, 1980', 'Charles', 'Babbage', 'Mr.')
	,('April 12, 1987', 'E.F.', 'Codd', 'Dr.')
	,('May 1, 1950', 'Ada', 'Lovelace', 'Ms.')

CREATE TABLE Book
(
	ISBN	char(13)	PRIMARY KEY
	,Price	smallmoney	NOT NULL
	,Title	varchar(100)	NOT NULL
)
GO

INSERT INTO Book (ISBN, Price, Title)
	VALUES ('1234567890ABC', 9.99, 'Intro to databases')
		,('IEHBMEIUS1234', 12.35, 'Learning Programming')
		--,('9780143039433', 12.94, 'The Grapes of Wrath')
		--,('9780399501487', 5.99, 'Lord of the Flies')
		--,('9780451524935', 793.44, 'nineteen eight-four (1984)')
		--,('9780679420392', 10.54, 'Animal Farm')
		--,('9781451673319', 8.29, 'Fahrenheit 451')
		

drop table if exists Registration

CREATE TABLE Registration
(
	CustomerID	int	REFERENCES Customer(CustomerID)
	,ISBN		char(13) REFERENCES Book(ISBN)
	,RegDate	smalldatetime	NOT NULL
	,PRIMARY KEY(CustomerID, ISBN)
)

INSERT INTO Registration (CustomerID, ISBN, RegDate)
	VALUES(3, 'IEHBMEIUS1234', GETDATE() - 1)
		,(2, '1234567890ABC', GETDATE() - 7)