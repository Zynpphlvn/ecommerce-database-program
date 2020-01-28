CREATE TABLE User_(
	user_id int NOT NULL,
	user_name nvarchar(50),
	user_surname nvarchar(50),
	identifier_number nvarchar(11) unique,
	age int check(age >= 16),
	gender nchar(1),
	email nvarchar(50),
	phone_number nvarchar(50),
	registration_date date,
	number_of_order int not null default(0),
	PRIMARY KEY (user_id),
);

CREATE TABLE Address_(
	address_id int NOT NULL,
	user_id int NOT NULL,
	address_type_id int,
	country_name nvarchar(50),
	city_name nvarchar(50),
	district_name nvarchar(50),
	zip_code nvarchar(5),
	PRIMARY KEY (address_id),
	FOREIGN KEY (user_id) REFERENCES User_(user_id)
);

CREATE TABLE Address_types(
	address_type_id int NOT NULL,
	address_type_name nvarchar(50),
	PRIMARY KEY (address_type_id)
);


CREATE TABLE Admin_(
	admin_id int identity(1,1) check((@@IDENTITY)<11) NOT NULL,
	username nvarchar(50),
	email nvarchar(50),
	PRIMARY KEY (admin_id)
);

CREATE TABLE Category(
	category_id int NOT NULL,
	category_name nvarchar(50),
	PRIMARY KEY (category_id)
);

CREATE TABLE Brand(
	brand_id int NOT NULL,
	brand_name nvarchar(50),
	PRIMARY KEY (brand_id)
);

CREATE TABLE Color(
	color_id int NOT NULL,
	color_name nvarchar(50),
	PRIMARY KEY (color_id)
);

CREATE TABLE Product(
	product_id int NOT NULL,
	serial_number nvarchar(50) unique,
	price float,
	category_id int,
	brand_id int,
	screen_size nvarchar(50),
	color_id int,
	bluetooth int,
	warranty nvarchar(50),
	origin nvarchar(50),
	PRIMARY KEY (product_id),
	FOREIGN KEY (category_id) REFERENCES Category(category_id),
	FOREIGN KEY (brand_id) REFERENCES Brand(brand_id),
	FOREIGN KEY (color_id) REFERENCES Color(color_id)
);

CREATE TABLE Bank(
	bank_id int NOT NULL,
	bank_name nvarchar(50),
	PRIMARY KEY (bank_id)
);

CREATE TABLE Invoice(
	invoice_id int NOT NULL,
	bank_id int,
	address_id int, 
	cost float ,
	number_of_installment int,
	PRIMARY KEY (invoice_id),
	FOREIGN KEY (bank_id) REFERENCES Bank(bank_id),
	FOREIGN KEY (address_id) REFERENCES Address_(address_id)
);

ALTER TABLE Invoice  
ADD monthly_payment AS (cost/number_of_installment);

CREATE TABLE Cargo(
	cargo_id int NOT NULL,
	cargo_name nvarchar(50) DEFAULT 'PTT Kargo',
	delivery_date date,
	address_id int,
	PRIMARY KEY (cargo_id),
	FOREIGN KEY (address_id) REFERENCES Address_(address_id)
);

CREATE TABLE Order_(
	order_id int NOT NULL,
	user_id int,
	order_date date,
	invoice_id int,
	cargo_id int,
	PRIMARY KEY (order_id),
	FOREIGN KEY (user_id) REFERENCES User_(user_id),
	FOREIGN KEY (invoice_id) REFERENCES Invoice(invoice_id),
	FOREIGN KEY (cargo_id) REFERENCES Cargo(cargo_id)
);

CREATE TABLE OrderLine(
	order_id int NOT NULL,
	product_id int,
	quantity int,
	PRIMARY KEY (order_id, product_id),
	FOREIGN KEY (product_id) REFERENCES Product(product_id),
	FOREIGN KEY (order_id) REFERENCES Order_(order_id)
);

CREATE TABLE OperatingSystem(
	opsys_id int NOT NULL,
	opsys_name nvarchar(50),
	PRIMARY KEY (opsys_id)
);
	
CREATE TABLE Phone(
	phone_id int NOT NULL,
	memory nvarchar(50),
	gps int,
	opsys_id int,
	touchpad int,
	back_cam_res nvarchar(50),
	front_cam_res nvarchar(50),
	PRIMARY KEY (phone_id),
	FOREIGN KEY (opsys_id) REFERENCES OperatingSystem(opsys_id)
);

CREATE TABLE Tv(
	tv_id int NOT NULL,
	screen_resolution nvarchar(50),
	_3D int,
	type_ nvarchar(50),
	PRIMARY KEY (tv_id),
);

CREATE TABLE Computer(
	pc_id int NOT NULL,
	opsys_id int,
	ram_capacity nvarchar(50),
	disc_capacity nvarchar(50),
	screen_resolution nvarchar(50),
	processor_speed nvarchar(50),
	PRIMARY KEY (pc_id),
	FOREIGN KEY (opsys_id) REFERENCES OperatingSystem(opsys_id),
);

INSERT INTO User_
	Values (0, 'Ceyda', 'Polat', '45011706511', 20, 'K', 'humcey@gmail.com', '05375876948' ,'2018-10-20',0),
		   (1, 'Zeynep', 'Pehlivan', '74011650432', 22, 'K', 'zzp@gmail.com', '05469753614' , '2014-09-11',0),
		   (2, 'Betül', 'Sevinç', '15014875925', 21, 'K', 'betulsevinc@hotmail.com', '05374789547' ,'2018-05-16',0),
	       (3, 'Enes', 'Günler', '14758296484', 19, 'E', 'enes.gunler@gmail.com', '05344712546' ,'2015-04-05',0),
		   (4, 'Burak', 'Yýldýrým', '87549614725', 35, 'E', 'burakyildirim@hotmail.com', '05375876948' ,'2017-02-13',0),
		   (5, 'Pelin', 'Kýzýl', '35641728459', 30, 'K', 'pelinkizil@gmail.com', '05354176859' ,'2016-05-25',0),
		   (6, 'Ahmet', 'Akýn', '47581258964', 26, 'E', 'ahmet.akin@gmail.com', '05497854835' ,'2013-08-20',0),
		   (7, 'Kerem', 'Iþýk', '31547958426', 31, 'E', 'keremisik@hotmail.com', '05436548574' ,'2013-11-17',0),
		   (8, 'Sena', 'Gökmen', '57486841239', 23, 'K', 'sena_gokmen@gmail.com', '05426584796' ,'2017-05-06',0),
		   (9, 'Fatih', 'Balcý', '45718957426', 33, 'E', 'fatihbalci@gmail.com', '05495874569' ,'2018-08-16',0);
		   
INSERT INTO Address_(address_id, user_id, country_name, city_name, district_name, zip_code)
	VALUES  (0 , 0, 0,'Turkey','Istanbul', 'Beylikduzu', '34528'), 
			(1, 1, 1, 'Turkey','Istanbul', 'Pendik', '34912'), 
			(2, 2, 0, 'Holland','Amsterdam', 'Zeeburg', '1001'), 
			(3, 3, 0,'Turkey','Bursa', 'Osmangazi', '16320'), 
			(4, 4, 0, 'Turkey','Bursa', 'Nilufer', '16265'), 
			(5, 5, 0, 'France','Paris', 'Ýle de la Cite', '75013'), 
			(6, 6, 0, 'Turkey','Erzurum', 'Ispir', '25080'), 
			(7, 7, 0, 'Turkey','Tokat', 'Zile', '60040'), 
			(8, 8, 1, 'Turkey','Istanbul', 'Kadikoy', '34734'), 
			(9, 9, 1, 'Turkey','Istanbul', 'USkudar', '34660');

INSERT INTO Admin_
	Values ('admin', 'admin@gmail.com'),
		   ('admin1', 'admin1@gmail.com'),
		   ('admin2', 'admin2@gmail.com'),
		   ('admin3', 'admin3@gmail.com'),
		   ('admin4', 'admin4@gmail.com'),
		   ('admin5', 'admin5@gmail.com'),
		   ('admin6', 'admin6@gmail.com'),
		   ('admin7', 'admin7@gmail.com'),
		   ('admin8', 'admin8@gmail.com'),
		   ('admin9', 'admin9@gmail.com');

INSERT INTO Category
	VALUES (0, 'TV'),
		   (1, 'Phone'),
		   (2, 'Computer');

INSERT INTO Address_Types
	VALUES (0, 'Home'),
		   (1, 'Work');

INSERT INTO Brand
	values (0, 'ASUS'), (1, 'ACER'), (2, 'DELL'), (3, 'HP'), (4, 'LENOVA'), (5, 'MSI'), 
			(6, 'IPHONE'), (7, 'SAMSUNG') , (8, 'HUAWEI'),(9, 'PANASONIC'), (10, 'ARCELIK'), 
			(11,'VESTEL'), (12,'SONY'), (13, 'APPLE'), (14, 'LENOVA'), (15, 'XIAOMI'), (16, 'LG'), (17, 'HTC');

INSERT INTO Color
	values (0, 'white'), (1, 'ivory'), (2, 'pink'), (3, 'black'), (4, 'green'), (5, 'yellow'), (6, 'red'), (7, 'blue'),(8, 'grey'), (9, 'brown'), (10, 'purple');

INSERT INTO Product
	VALUES (0,'15247', 5.400, 1,  6, '5.7 inch', 8, 0 , '24 mounths', 'Turkey'),
		   (1, '12784', 5.400 , 1, 7, '4 inch', 4, 1, '24 mounths', 'Japan'),
		   (2, '47521',  5.400, 1, 11, '5.5 inch, ', 6, 1, '24 mounths', 'China'),
		   (3, '21474', 5.400, 1, 12, '4 inch', 0, 1, '24 mounths', 'USA'),
		   (4, '10485', 5.400, 1, 13, '5.7 inch', 1, 0, '24 mounths', 'Turkey'),
		   (5, '17852', 5.400, 1, 14, '5.5 inch', 2, 1, '24 mounths', 'USA'),
		   (6, '47547', 5.400, 1, 15, '4 inch', 10, 1, '24 mounths', 'Turkey'),
		   (7, '24782', 5.400, 1, 16, '5.5 inch', 1, 1, '24 mounths', 'China'),
		   (8, '21778', 5.400, 1, 17, '5.7 inch', 5, 1, '24 mounths', 'China'),
		   (9, '34727', 5.400, 1, 6, '4 inch', 5, 1, '24 mounths', 'Turkey'),
		   (10, '58796', 3.795, 0, 7, '50 inch', 2, 0, '36 months', 'South Korea'),
		   (11, '12546',  4.200 ,0, 10, '24 inch', 8, 1, '24 mounths', 'USA'),	
		   (12, '54218', 2.300, 0, 7, '50 inch', 2, 1, '36 months', 'South Korea'),
		   (13, '54723', 4.750, 0, 10, '55 inch', 1, 1, '24 mounths', 'USA'), 
		   (14, '24578', 1.175, 0, 11, '65 inch', 5, 0, '60 months', 'Germany'),
		   (15, '47849', 1.600 ,0, 9, '40 inch', 3, 0, '48 months', 'Chinese'),
		   (16, '39475', 13.300, 0, 7,'50 inch', 2, 1, '36 months', 'South Korea'),
		   (17, '78429', 6.200, 0, 11, '40 inch', 5, 1, '60 months', 'Germany'),
		   (18, '65994', 4.200, 0, 10, '65 inch', 8, 1, '36 months', 'USA'),
		   (19, '48651', 5.400 ,0, 9, '50 inch', 7, 1, '24 mounths', 'China'),
		   (20, '84579', 6.500 ,2, 0, '15 inch', 3, 1, '24 mounths', 'Turkey'),
		   (21, '15248', 7.400 ,2, 0, '17 inch', 5, 0, '24 mounths', 'Turkey'),
		   (22, '24876', 5.400 ,2, 1, '15 inch', 2, 0, '24 mounths', 'USA'),
		   (23, '22796',  5.200 ,2, 1, '13.6 inch', 0, 1, '24 mounths', 'USA'),
		   (24, '14876', 5.100 ,2, 5, '13.6 inch', 1, 1, '24 mounths', 'Germany'),
		   (25, '20148', 3.200 ,2, 4, '14 inch', 4, 0, '24 mounths', 'Germany'),
		   (26, '67895', 5.900 ,2, 3, '15 inch', 6, 1, '24 mounths', 'Turkey'),
		   (27, '25486', 6.400 ,2, 7, '17.6 inch', 7, 1, '24 mounths', 'Japan'),
		   (28, '12789', 7.400 ,2, 8, '14 inch', 9, 1, '24 mounths', 'China'),
		   (29, '20481', 8.400 ,2, 2, '17.6 inch', 7, 1, '24 mounths', 'USA');

SELECT * FROM Product

INSERT INTO OperatingSystem
	values  (0, 'Mac OS X'), (1, 'Unix'), (2, 'BeOS') , (3 , 'Windows 10') , (4, 'IRIX'), (5 , 'MS-DOS'), 
			(6 , 'UBUNTU'), (7 , 'NeXTSTEP'), (8 , 'iOS'), (9 , 'Debian'), (10, 'Android'), (11, 'Symbian'), (12, 'BlackBerry OS');

INSERT INTO Phone
values (0 , '32 gb', 0 , 8, 0, '12.0 MP', '5.0 MP'),
		(1 , '64 gb', 1 , 10, 1, '7.5 MP', '6.0 MP'),
		(2 , '128 gb', 1 , 11, 1, '5.0 MP', '5.6 MP'),
		(3 , '16 gb', 1 , 12, 1, '6.2 MP', '9.0 MP'),
		(4 , '32 gb', 1 , 8, 0, '7.0 MP', '8.5 MP'),
		(5 , '64 gb', 1 , 8, 1, '4.5 MP', '7.2 MP'),
		(6 , '128 gb', 0 , 10, 0, '10.2 MP', '4.8 MP'),
		(7 , '16 gb', 1 , 11, 1, '11.0 MP', '5.2 MP'),
		(8 , '32 gb', 0 , 11, 1, '14.1 MP', '6.3 MP'),
		(9 , '32 gb', 1 , 12, 0, '16.0 MP', '7.9 MP');

INSERT INTO Bank
	VALUES (0, 'Garanti Bankasý'),
		   (1, 'Ýþ Bankasý'),
		   (2, 'TEB'),
		   (3, 'Ziraat Bankasý'),
		   (4, 'VakýfBank'),
		   (5, 'DenizBank'),
		   (6, 'Yapý ve Kredi Bankasý'),
		   (7, 'Þekerbank'),
		   (8, 'QNB Finansbank'),
		   (9, 'ING Bank');

INSERT INTO Invoice
	VALUES (0, 5, 4, 10400, 8),
		   (1, 9, 7, 7050, 5),
		   (2, 3, 1, 8950, 3),
		   (3, 4, 2, 11600, 4),
		   (4, 8, 9, 2775, 2),
		   (5, 1, 6, 23700, 10),
		   (6, 6, 8, 4750, 1),
		   (7, 2, 5, 5400, 3),
		   (8, 7, 3, 13300, 5),
		   (9, 0, 0, 3795, 1);

INSERT INTO Cargo(cargo_id, delivery_date, address_id)
	VALUES (0, '2018-05-05', 5),
		   (1, '2015-11-08', 3),
		   (2, '2019-03-28', 1),
		   (3, '2018-07-23', 0),
		   (4, '2015-12-05', 8),
		   (5, '2018-04-06', 2),
		   (6, '2016-06-24', 6),
		   (7, '2015-10-09', 9),
		   (8, '2016-11-13', 4),
		   (9, '2019-05-14', 7);
				
INSERT INTO Order_
	VALUES (0, 5, '2018-07-18', 7, 3),
		   (1, 6, '2016-06-17', 2, 6),
		   (2, 1, '2016-11-09', 4, 8),
		   (3, 8, '2019-03-24', 5, 2),
		   (4, 0, '2018-04-01', 9, 5),
		   (5, 4, '2015-11-30', 0, 4),
		   (6, 9, '2018-05-01', 3, 0),
		   (7, 2, '2015-11-04', 8, 1),
		   (8, 7, '2015-10-06', 1, 7),
		   (9, 3, '2019-05-09', 6, 9);

INSERT INTO OrderLine
	VALUES (0, 3, 1),
		   (1, 8, 1),
		   (2, 4, 1),
		   (3, 7, 1),
		   (4, 0, 1),
		   (5, 1, 1),
		   (6, 2, 1),
		   (7, 5, 1),
		   (8, 9, 1),
		   (9, 6, 1);

INSERT INTO Tv
	VALUES (0, 'UHD 4K', 0, 'UHD TV'),
		   (1, 'HD-ready', 0, 'LED TV'),
		   (2, 'HD-ready', 1, 'LED TV'),
		   (3, 'UHD 4K', 1, 'LED TV'),
		   (4, 'UHD 4K', 1, 'UHD TV'),
		   (5, 'FULL-HD', 0, 'LED TV'),
		   (6, 'UHD 4K', 0, 'LED TV'),
		   (7, 'FULL-HD', 1, 'LED TV'),
		   (8, 'FULL-HD+', 1, 'UHD TV'),
		   (9, 'FULL HD', 0, 'LED TV');

INSERT INTO Computer
Values 	(0 , 1, '4 gb', '1 tb', '1280 x 1024', '2.5 GHz') ,
		(1 , 1, '16 gb', '500 gb', '1280 x 1024', '2.5 GHz') ,
		(2 , 2, '8 gb', '500 gb', '1366 x 768', '2.3 GHz') ,
		(3 , 2, '16 gb', '500 gb', '1366 x 768', '2.3 GHz'),
		(4 , 6, '4 gb', '1 tb', '1600 x 900', '2.5 GHz'),
		(5 , 7, '16 gb', '2 tb', '1600 x 900', '3.8 GHz'),
		(6 , 0, '8 gb', '500 gb', '1280 x 1024', '3.8 GHz'),
		(7 , 9, '8 gb', '500 gb', '1366 x 768', '2.5 GHz'),
		(8 , 4, '4 gb', '500 gb', '1366 x 768', '2.3 GHz'),
		(9 , 3, '16 gb', '1 tb', '1600 x 900', '3.8 GHz');
	
SELECT * FROM Invoice;

go

-- TRIGGER
CREATE TRIGGER order_details on Invoice
after insert
as
begin
Select Top(1) cost as 'Total Cost' from Invoice order by invoice_id desc
end

select * from Invoice

insert into Invoice
VALUES (10, 5, 4, 9200, 8);
 

 GO

 --TRIGGER
 CREATE TRIGGER max_price on Product
 after insert
 as
 begin
	SELECT TOP(1) * FROM Product ORDER BY price DESC						
 end

 INSERT INTO Product
	VALUES (10,'45852', 6.500, 1,  6, '5.0 inch', 8, 0 , '24 mounths', 'South Korea')

 --TRIGGER
 CREATE TRIGGER show_opsys_name ON Phone
AFTER INSERT
AS
BEGIN
declare @x int;
select @x =(SELECT TOP(1) opsys_id FROM Phone ORDER BY phone_id DESC)	
select TOP 1 opsys_name from Phone, OperatingSystem where OperatingSystem.opsys_id = @x;
END

--TRIGGER
CREATE TRIGGER tv_id_not_update ON Product
AFTER UPDATE
AS BEGIN
IF(EXISTS (SELECT * FROM inserted,deleted WHERE inserted.serial_number = deleted.serial_number AND inserted.product_id !=deleted.product_id))
BEGIN
RAISERROR('YOU CAN NOT UPDATE Product_id',1,1)
ROLLBACK TRANSACTION
END


SELECT * FROM Product Where serial_number = '12546'
UPDATE Product set product_id = '16548' WHERE serial_number = '12546'


INSERT INTO Phone
values (11 , '64 gb', 0 , 7, 0, '14.0 MP', '7.2 MP')

INSERT INTO Order_
	VALUES (12, 6, '2019-12-12', 7, 4)

	select * from Order_
	order_id int NOT NULL,
	user_id int,
	order_date date,
	invoice_id int,
	cargo_id int,
select * from User_


--INDEX
CREATE NONCLUSTERED INDEX product_index 
	ON Product(product_id);

--VIEW
CREATE VIEW phones_with32gb
AS
SELECT 
	product_id, brand_name, memory, gps, back_cam_res, front_cam_res
FROM
    Phone as phone, Product as p, Brand as b
where
	 p.brand_id = b.brand_id AND p.product_id = phone.phone_id AND memory like '32 GB';


select * from phones_with32gb order by gps desc	 

 GO

--VIEW
CREATE VIEW late_deliveries
AS
Select DATEDIFF(day, order_date, delivery_date) as 'Delivary Day', c.delivery_date, o.order_date, cargo_name  from Order_ as o, Cargo as c
	where o.cargo_id = c.cargo_id and DATEDIFF(day, order_date, delivery_date) > 4;

select * from late_deliveries

--PRODECURE
CREATE PROCEDURE update_warranties_
AS
UPDATE Product SET warranty = '2' WHERE warranty = '24 months'
UPDATE Product SET warranty = '2' WHERE warranty = '24 mounths'
UPDATE Product SET warranty = '3' WHERE warranty = '36 months'
UPDATE Product SET warranty = '4' WHERE warranty = '48 months'
UPDATE Product SET warranty = '5' WHERE warranty = '60 months'
GO
 
EXEC update_warranties_


--PRODECURE
CREATE PROCEDURE set_number_of_installment
AS
UPDATE Invoice
SET Invoice.number_of_installment = 1 FROM Invoice WHERE Invoice.cost < 5000

GO


EXEC set_number_of_installment
