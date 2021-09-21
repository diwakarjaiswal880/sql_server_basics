use Diwakar;
create table course(id int,name varchar(50));
insert into course values(1,'Math');
insert into course values(2,'Physics');
insert into course values(3,'Chemistry');
insert into course values(4,'Computer');

select * from course;

create database sample2;
use sample2;

create table student( s_name varchar(100),
s_class varchar(100),
s_father_name varchar(100),
mobile int);

select * from student;

insert into student values('ram','high school','shyam','1234567890');

insert into student values('shyam','high school','mohan','1234567890');

insert into student values('lucy','high school','sohan','1234567890');
insert into student values('asj','high school','shyam','1234567890');
insert into student values('ramdskn','high school','shylksdnam','1234567890');
insert into student values('rajdnlafm','high school','shfdsknyam','1234567890');

select * from student;






