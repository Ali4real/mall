create database Mall


create table product(
pid int not null,
pname varchar(45),
price int,
Vname varchar(45) primary key,

)

create table vendor(
vid int,
vname varchar(45),
adr varchar(45),

)


create table employee(
Eid int,
Ename varchar(45),
Edesig varchar(45),
Esell varchar(45),
)

create table finance(
tsales varchar(45),

)