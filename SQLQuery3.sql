
create table Registration( UId int primary key identity, UName varchar(50),UPass varchar(50),ConfirmPass varchar(50),EmailAdd varchar(50) unique,ContactNum varchar (50) unique,)
select * from RegisterTab