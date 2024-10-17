CREATE DATABASE InsuranceDB;
GO

USE InsuranceDB;
GO

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL
);

CREATE TABLE Clients (
    ClientId INT PRIMARY KEY IDENTITY(1,1),
    ClientName VARCHAR(100) NOT NULL,
    ContactInfo VARCHAR(200)
);

CREATE TABLE Policies (
    PolicyId INT PRIMARY KEY IDENTITY(1,1),
    PolicyNumber VARCHAR(50) NOT NULL
);

CREATE TABLE Claims (
    ClaimId INT PRIMARY KEY IDENTITY(1,1),
    ClaimNumber VARCHAR(50) NOT NULL,
    DateFiled DATE NOT NULL,
    ClaimAmount DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL,
    ClientId INT FOREIGN KEY REFERENCES Clients(ClientId),
    PolicyId INT FOREIGN KEY REFERENCES Policies(PolicyId)
);

CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    PaymentDate DATE NOT NULL,
    PaymentAmount DECIMAL(10,2) NOT NULL,
    ClientId INT FOREIGN KEY REFERENCES Clients(ClientId)
);


SELECT * FROM Policies;