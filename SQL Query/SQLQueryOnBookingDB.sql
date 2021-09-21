/* Create DB */
create database bookingDB;
use bookingDB;


/* View all tables*/
SELECT * FROM sys.tables;


/* Create table */
Create table BookingDetails(
id int PRIMARY KEY IDENTITY(100,1),
userName varchar(30),
phone varchar(30),
dose int,
vaccineID int,
);

 

Create table Vaccine(
id int Primary key,
vaccine_name varchar(30),
min_age int NULL,
max_age int NULL,
cost int,
modifiedDate datetime DEFAULT GETDATE()
);

 

/* Insert values */
INSERT INTO Vaccine(id,vaccine_name,min_age,max_age,cost,modifiedDate)
VALUES(1,'Covishield',18,45,780,DEFAULT);
INSERT INTO Vaccine(id,vaccine_name,min_age,max_age,cost,modifiedDate)
VALUES(2,'Covishield',46,90,600,DEFAULT);
INSERT INTO Vaccine(id,vaccine_name,min_age,max_age,cost,modifiedDate)
VALUES(3,'Covaccine',18,45,1300,DEFAULT);
INSERT INTO Vaccine(id,vaccine_name,min_age,max_age,cost,modifiedDate)
VALUES(4,'Covaccine',46,90,1100,DEFAULT);
INSERT INTO Vaccine(id,vaccine_name,cost,modifiedDate)
VALUES(4,'Covaccine_Def',1100,DEFAULT);

 

INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('DJ',9205977313,2,1);
INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('Sam',9870577313,2,1);

INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('Diwakar Jaiswal',9344977313,2,3);
INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('Sangam',9870577313,2,1);

INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('DkJ',9205977313,2,1);
INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('Samsul',9870577313,2,1);

INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('Diwakar ',9344977313,2,3);
INSERT INTO BookingDetails(userName,phone,dose,vaccineID)
VALUES('Sangam singh',9870577313,2,1);

 

Select * FROM BookingDetails WHERE userName LIKE 'D%';

 

/* JOINS */
Select userName b, vaccine_name v, cost v 
FROM BookingDetails b INNER JOIN Vaccine v ON b.vaccineID = v.id;

 

Select userName b, vaccine_name v, cost v 
FROM BookingDetails b FULL OUTER JOIN Vaccine v ON b.vaccineID = v.id;

 

Select userName b, vaccine_name v, cost v 
FROM BookingDetails b LEFT JOIN Vaccine v ON b.vaccineID = v.id;

 

Select userName b, vaccine_name v, cost v 
FROM BookingDetails b RIGHT JOIN Vaccine v ON b.vaccineID = v.id;

 

SELECT count(b.userName) AS [Registered Members], v.vaccine_name, v.min_age AS [Min Age], v.max_age AS [Max Age]
FROM BookingDetails b JOIN Vaccine v ON b.vaccineID=v.id
GROUP BY v.vaccine_name, v.min_age,v.max_age;

 

/* sp_help - System stored procedure*/
EXEC dbo.sp_help BookingDetails;
EXEC dbo.sp_help Vaccine;

 

/* Catalog views */
SELECT name,type_desc FROM sys.objects ORDER BY name;
SELECT * FROM sys.tables ORDER BY name;
SELECT * FROM sys.columns;
SELECT * FROM sys.identity_columns;
SELECT * FROM sys.key_constraints;
SELECT * FROM sys.foreign_key_columns;

 

/* INDEXING & ORDERING */
SELECT TOP(10) count(userName), vaccineID FROM BookingDetails GROUP BY vaccineID;

 

SELECT count(userName) AS [Registered Members], vaccineID FROM BookingDetails 
GROUP BY vaccineID 
ORDER BY [Registered Members]
OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY;

 

SELECT * FROM BookingDetails
ORDER BY id
OFFSET 0 ROWS FETCH NEXT 50 ROWS ONLY;

 

SELECT * FROM BookingDetails
ORDER BY id
OFFSET 51 ROWS FETCH NEXT 50 ROWS ONLY;