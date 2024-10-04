----------------- WEEK-2 ----------------------- DAY-4 -------------
------------------------------ * SQL * ----------------------------
							--------------

CREATE DATABASE week2

DROP  DATABASE week2 -- If we want to drop or delete the database we should be on master and not using it.

USE week2 -- To use the database

CREATE TABLE Customers
(
	_ID int Primary Key IDENTITY(101,1),  -- PRIMARY KEY = NOT NULL UNIQUE,   IDENTITY -> COUNTER
	_Name varchar(255) NOT NULL,
	_ContactName varchar(255) UNIQUE, -- BY DEFAULT CAN BE NULL 
	_Address varchar(255),
	_City varchar(255),
	_PostalCode varchar(50),
	_Country varchar(255),
	CONSTRAINT UQ_C UNIQUE (_Name),
);

DROP TABLE Customers

CREATE TABLE Persons
(
	PersonID INT PRIMARY KEY,
	FirstName VARCHAR(255),
	LastName VARCHAR(255),
	Age INT,
	-- CHECK(AGE >= 18)
);

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY,
	OrderNumber INT,
	-- OrderDate DEFAULT CURRENT_DATE()
    PersonID int FOREIGN KEY REFERENCES Persons(PersonID) -- FOREIGN KEY (PersonID) REFERENCES Persons(PersonID)
);

-- USE 'ANYTHIN' INSTEAD OF "ANYTHING"
-- IF U R USING THE IDENTITY YOU CAN NOT ADD THE ID IN THE INSERT

INSERT INTO Customers
VALUES('White Clover Markets' ,'Karl', 'GG - 14th Ave S.', 'Seatl', '98128', 'USA');

DROP TABLE Persons
DROP TABLE Orders

INSERT INTO Customers
VALUES('Clover Markets' ,'mmmmm', 'TT - 14th Ave S.', 'SERTR', '8656', 'EGY');

UPDATE Customers
SET _City = 'Cairo'
WHERE _ID = 1; -- IF NOT EXIST, ALL COL WILL BE UPDATED

SELECT * FROM Customers

SELECT DISTINCT _City FROM Customers 

SELECT COUNT(_ID), _City FROM Customers -- Invalid, we can do this using GROUP BY
SELECT COUNT(_ID) FROM Customers -- Valid