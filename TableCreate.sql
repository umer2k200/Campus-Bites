use FinalProj
--------------------------------------

select * from users
select * from CurrentUser
select * from userContact
select* from Cust_Order
select * from inventory
select * from MenuItems
select * from Orders
select * from has
select * from Coupon
--------------------------------------
create table Users
(
	id int primary key  IDENTITY(1,1),
	username varchar(255) unique,
	password varchar(255),
	name varchar(255),
	contact varchar(255),
	address varchar(255),

	user_type int,
	-- 1 for cafe manager,2 for inv manager, 3 for customer, 4 for cashier

	loyaltyP int,
	mgr_id int, --8 for cafe manager, 10 for inv manager

	-- This is for the cashier and inv manager who are managed by cafe manager (1 for managed 0 for not managed)
	foreign key(mgr_id) references Users(id) ,
	credcard_accno varchar(255),
	credcard_pass varchar(255),
	cvv_code varchar(255)

);
alter table Users add constraint check_len4
check(contact like '+92__________')

create table CurrentUser(
    id int ,
	username varchar(255) unique,
	password varchar(255),
	name varchar(255),
	contact varchar(255),
	address varchar(255),

	user_type int,
	-- 1 for cafe manager,2 for inv manager, 3 for customer, 4 for cashier

	loyaltyP int,
	mgr_id int, --8 for cafe manager, 10 for inv manager
	credcard_accno varchar(255),
	credcard_pass varchar(255),
	cvv_code varchar(255)
);

create table userContact
(
	username varchar(255) unique,
	Contact varchar(255) primary key,
	address varchar(255)
);

alter table userContact add constraint check_len3
check(Contact like '+92__________')


create table Cust_Order
(
	id int,
	quantity int,
	price float,
	itemId int,
	CurruserId int,

	foreign key(itemId) references MenuItems(id)
);
create table Inventory
(
	id int primary key IDENTITY(1,1),
	quantity int,
	supplier varchar(255),
	mgr_id int,
	itemId int,
	itemName varchar(255),
	category varchar(255),
	foreign key(mgr_id) references Users(id) ,
	foreign key(itemId) references Menuitems(id)
);

-- Menu items

create table MenuItems
(
	id int primary key IDENTITY(1,1),
	name varchar(255),
	descrpt varchar(255),
	nut_info varchar(255),
	price float,
	category varchar(255),
	mgr_id int,
	foreign key(mgr_id) references Users(id),
);

-- Orders table

create table Orders
(
	id int primary key IDENTITY(1,1),
	stat varchar(255),
	dTime datetime,
	pay_type varchar(255),
	Tamount float,
	cashRet float,
	cashierId int,
	cust_id int,
	custOrderID int,

	foreign key(cust_id) references Users(id),
	foreign key(cashierId) references Users(id),
);



create table has 
(
	itemId int,
	OrderId int,
	foreign key(itemId) references MenuItems(id),
	foreign key(OrderId) references Orders(id),
);

CREATE TABLE Coupon (
    id INT PRIMARY KEY identity(1,1),
    code VARCHAR(255) UNIQUE NOT NULL,
    descrpt varchar(255),
    disc_amt int NOT NULL
);


create table  log
(
	Activity varchar(255),
	Ddate date
);

-----Triggers

create or alter trigger Inserted
on Users
after insert,update
as
begin
--print 'Table Updated'
if (select count(*) from Users u inner join inserted d on u.id=d.id )>1--inserted is the row that has been inserted
rollback;
else
print 'Successfully inserted'
end

create or alter trigger InsertedTo
on CurrentUser
after insert,update
as
begin
--print 'Table Updated'
if (select count(*) from CurrentUser u inner join inserted d on u.id=d.id )>1--inserted is the row that has been inserted
rollback;
else
print 'Successfully inserted'
end

create or alter trigger InsertedOrder
on Orders
after insert,update
as
begin
--print 'Table Updated'
if (select count(*) from Orders o inner join inserted d on o.id=d.id )>1--inserted is the row that has been inserted
rollback;
else
print 'Successfully inserted'
end


create or alter trigger DInserted
on Users
after insert
as 
begin

insert into log values('Data inserted',GETDATE())

end

create or alter trigger DInsertedone
on CurrentUser
after insert
as 
begin

insert into log values('Data inserted into CurrentUser',GETDATE())

end

create or alter trigger DInserteorder
on Orders
after insert
as 
begin

insert into log values('Data inserted into Order',GETDATE())

end

--INSERTION 
insert into users(id,username,password,name,contact,address,user_type,loyaltyP,mgr_id,credcard_accno,credcard_pass,cvv_code) 
values (1,'admin123','imcafemanager','Umer Zeeshan','+923336745933','Rawalpindi',1,NULL,NULL,NULL,NULL,NULL),
       (2,'ahsan_inv','iminvmanager','Ahsan Latif','+923334570493','street 60',2,NULL,1,NULL,NULL,NULL),
	   (3,'cashier123','imcashier','Ammar Ali','+923365597840','street 63',3,NULL,1,NULL,NULL,NULL);
insert into userContact values ('admin123','+923336745933','Rawalpindi'),('ahsan_inv','+923334570493','Islamabad'),
                               ('Cashier','+923345413033','Street 2, Lalazar, Rawalpindi');
INSERT INTO Inventory (id,quantity, supplier, mgr_id, itemId, itemName, category)
VALUES
(1,100, 'NURPUR', 10, 1,'Protein Shake','Drinks'),
(2,70, 'PepsiCo', 10, 2,'Lays','Snacks' ),
(3,50, 'KN&NS', 10, 4,'Sandwitch','Snacks');
INSERT INTO MenuItems ( id,name, descrpt, nut_info, price, category, mgr_id)
VALUES
( 1,'Pizza', 'Cheese Lovers Pizza', '15g Proteins, 2g Fibre', 14.99, 'Fast Food', 8),
( 2,'Pasta', 'Creamy Alfredo Pasta', '10g Proteins, 3g Fibre', 9.99, 'Fast Food', 8),
( 3,'Ice Cream', 'Chocolate Chip Ice Cream', '5g Proteins, 10g Fibre', 5.99, 'Desserts', 8),
( 4,'Coffee', 'Hot Brewed Coffee', '1g Proteins, 0g Fibre', 3.99, 'Drinks', 8),
( 5,'Cheesecake', 'Classic New York Cheesecake', '8g Proteins, 4g Fibre', 7.99, 'Desserts', 8);
insert into Coupon(id,code,descrpt,disc_amt) values
(1,'umer123','off 20',20),
(2,'momo23','off 50',50);