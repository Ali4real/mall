create database mall
use mall

create table product(
pid int not null primary key,
pname varchar(45),
price int,
Vname varchar(45) ,

)


create table vendor(
	V_ID VARCHAR(15) PRIMARY KEY,
	V_NAME VARCHAR(25) NOT NULL,
	V_EMAIL VARCHAR(25) UNIQUE NOT NULL,
	V_ADDRESS VARCHAR(50) NOT NULL,
	V_CONTACT CHAR(11) NOT NULL,
)


create table employee(
EMPLOYEE_ID VARCHAR(15) PRIMARY KEY,
	EMPLOYEE_NAME VARCHAR(25) NOT NULL,
	EMPLOYEE_PASSWORD CHAR(8) NOT NULL,
	EMPLOYEE_CONTACT CHAR(11) NOT NULL,
	EMPLOYEE_ADDRESS VARCHAR(50) NOT NULL,
	EMPLOYEE_EMAIL VARCHAR(25) UNIQUE NOT NULL,
	EMPLOYEE_DESIGNATION VARCHAR(15) NOT NULL,
	EMPLOYEE_HIREDATE DATE NOT NULL,
	EMPLOYEE_FIREDATE DATE,
	EMPLOYEE_STATUS VARCHAR(10) NOT NULL,
	EMPLOYEE_SALES INT,
)

create table finance(
tsales varchar(45),

)

CREATE TABLE CUSTOMER 
(
	CUSTOMER_CNIC CHAR(13) PRIMARY KEY,
	CUSTOMER_NAME VARCHAR(25) NOT NULL,
	CUSTOMER_CONTACT CHAR(13) NOT NULL,
	CUSTOMER_ADDRESS VARCHAR(50) NOT NULL,
)

create table Customer_order(
ORDER_ID VARCHAR(15) PRIMARY KEY,
	EMPLOYEE_ID VARCHAR(15) ,
	CAR_ID VARCHAR(15) ,
	CUSTOMER_CNIC CHAR(13),
	ORDER_DATE DATE NOT NULL,
	BILL INT NOT NULL,
)
