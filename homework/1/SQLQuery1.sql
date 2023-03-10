
create database test_3;

use test_3;

create table Major
(
	Mid int identity,
	Mname varchar(30),
	Mremark text,
	primary key (Mid)
);
create table Student
(
	Sid varchar(10)not null,
	Mid int,/*这里没必要写自增*/
	Sname varchar(30),
	Sex int,
	Birthday datetime,
	Scores float,
	hobby text,
	Sremark text,
	primary key (Sid),
	foreign key (Mid) references Major(Mid)
);
CREATE TABLE Course
(
	Cid int not null,
	Cname varchar(30),
	Cterm int,
	Class_hours int,
	Score float, 
	primary key (Cid)
);
CREATE TABLE Grade
(
	Sid varchar(10),
	Cid int,
	Grade float, 
	foreign key (Sid) references Student(Sid),
	foreign key (Cid) references Course(Cid)
);

exec sp_columns Major;
/*或者*/
SELECT * FROM information_schema.columns 
WHERE table_name = 'Major';

alter table Major add Tel varchar(11);
alter table Major alter column Tel varchar(10);
exec sp_columns Major;

SELECT NAME from SYS.OBJECTS WHERE TYPE_DESC ='PRIMARY_KEY_CONSTRAINT' AND
	PARENT_OBJECT_ID = (SELECT OBJECT_ID
	FROM SYS.OBJECTS WITH(NOLOCK) WHERE NAME = 'Major');

ALTER TABLE major DROP CONSTRAINT PK__Major__C79638C2EE46080E;
SELECT NAME from SYS.OBJECTS WHERE TYPE_DESC ='FOREIGN_KEY_CONSTRAINT' AND
	PARENT_OBJECT_ID = (SELECT OBJECT_ID
	FROM SYS.OBJECTS WITH(NOLOCK) WHERE NAME = 'student');

ALTER TABLE student DROP CONSTRAINT FK__Student__Mid__267ABA7A;

drop table Major;
create table Major
(
	Mid int identity,
	Mname varchar(30),
	Mremark text,
	primary key (Mid)
);
SELECT NAME from SYS.OBJECTS WHERE TYPE_DESC ='FOREIGN_KEY_CONSTRAINT' AND
	PARENT_OBJECT_ID = (SELECT OBJECT_ID
	FROM SYS.OBJECTS WITH(NOLOCK) WHERE NAME = 'grade');
ALTER TABLE grade DROP CONSTRAINT FK__Grade__Sid__2A4B4B5E;
ALTER TABLE grade DROP CONSTRAINT FK__Grade__Cid__2B3F6F97;
drop table if exists Student;
create table Student
(
	Sid varchar(10) not null,
	Mid int,
	Sname varchar(30),
	Sex int,
	Birthday datetime,
	Scores float,
	hobby text,
	Sremark text,
	primary key (Sid)
);
drop table if exists Course;
CREATE TABLE Course
(
	Cid int not null identity,
	Cname varchar(30),
	Cterm int,
	Class_hours int,
	Score float, 
	primary key (Cid)
);
drop  table if exists Grade;
CREATE TABLE Grade
(
	Sid varchar(10),
	Cid int,
	Grade float
);

alter table Student add constraint Mid foreign key (Mid)
			references Major (Mid);
alter table Grade add constraint Sid foreign key (Sid)
			references Student (Sid);
alter table Grade add constraint Cid foreign key (Cid)
			references Course (Cid);
	



ALTER TABLE student DROP CONSTRAINT Mid;
truncate table major;
insert into Major values('软件工程',NULL);
go
insert into Major values('人工智能',NULL);
go
insert into Major values('计算机科学与技术',NULL);
go
insert into Major values('数学',NULL);
go
insert into Major values('物理',NULL);
go
insert into Major values('电子信息',NULL);
go
insert into Major values('中文',NULL);

delete from Major where mname='中文';
DECLARE @A INT
SET @A=(SELECT TOP 1 Mid FROM Major ORDER BY Mid DESC)
dbcc checkident('Major',reseed,@A)
insert into Major values('中文',NULL);


insert into Student 
	values('20331099',1,'萧遘',1,'2003-01-06',66,'遛狗',NULL);
go
insert into Student 
	values('20331021',2,'李应东',2,'2002-03-01',77,NULL,NULL);
go
insert into Student 
	values('20331055',3,'筱朱',1,'2003-01-06',87,'足球',NULL);
go
insert into Student 
	values('20331033',4,'埜霁',2,'2003-01-06',56,'游泳',NULL);
go
insert into Student 
	values('20331066',5,'倽鲾',1,'2003-01-06',22,'走路',NULL);
go
insert into Student 
	values('20331022',6,'翡庑',2,'2003-01-06',34,'散步',NULL);
go
insert into Student 
	values('20331067',7,'贰兹',1,'2003-01-06',18,'睡觉',NULL);
go
insert into Student 
	values('20331069',1,'肖踌',2,'2003-01-06',160,'游戏',NULL);
go
insert into Student 
	values('20331059',2,'贲薜',1,'2003-01-06',20,'吃饭',NULL);
go
insert into Student 
	values('20331097',3,'萧遘',2,'2003-01-06',11,'排球',NULL);
go
	
insert into Course
	values('数据库系统原理',5,54,3);
go
insert into Course
	values('数据库系统实验',5,36,1);
go
insert into Course
	values('软件源代码分析',5,54,3);
go
insert into Course
	values('软件源代码分析实验',5,36,1);
go
insert into Course
	values('软件工程实训（中级）',5,144,4);
go
insert into Course
	values('复杂网络科学导论',5,36,2);
go
insert into Course
	values('3D游戏编程与设计',5,36,2);
go
insert into Course
	values('3D游戏编程与设计实验',5,36,1);
go
insert into Course
	values('Rust语言与内存安全设计',5,36,2);
go
insert into Course
	values('算法设计与分析',5,36,2);
go
insert into Course
	values('算法设计与分析实验',5,36,1);
go
insert into Course
	values('图论及其应用',4,54,3);
go
	
insert into Grade
	values('20331099',1,89);
insert into Grade
	values('20331022',2,26);
insert into Grade
	values('20331022',3,99);
insert into Grade
	values('20331022',4,89);
insert into Grade
	values('20331033',5,67);
insert into Grade
	values('20331097',6,63);
insert into Grade
	values('20331097',7,22);
insert into Grade
	values('20331097',8,59);
insert into Grade
	values('20331097',9,55);
insert into Grade
	values('20331097',10,66);
insert into Grade
	values('20331097',11,87);
insert into Grade
	values('20331097',12,87);
insert into Grade
	values('20331067',1,89);
insert into Grade
	values('20331067',2,37);
insert into Grade
	values('20331066',3,13);
insert into Grade
	values('20331066',4,98);
insert into Grade
	values('20331066',5,60);
insert into Grade
	values('20331066',6,45);
insert into Grade
	values('20331066',7,16);
insert into Grade
	values('20331059',8,65);
	
update student
	set Sremark='三好学生'
	where Sid='20331022';
update student
	set Scores=0;
update student
	set Scores=66
	where Birthday>'2002-12-31';
update student
	set hobby='学习'
	where Mid=1;
update course
	set cterm=6
	where cterm=5;
update course
	set score=10
	where score=3;
update grade
	set grade=100;
update grade
	set grade=0
	where cid=7;
update grade
	set grade=60
	where sid='20331097';
update major
	set mremark='best'
	where mid=1;

alter table student  NOCHECK constraint all;
alter table major  NOCHECK constraint all;
alter table grade  NOCHECK constraint all;
alter table course  NOCHECK constraint all;
delete from student
	where sname='萧遘' and sex=2;
delete from course
	where cterm!=6;
delete from course
	where score<0.5;
delete from course
	where class_hours<18;
delete from major
	where mid=8;
delete from major
	where mname='翻译';
delete from grade
	where grade=NULL;
delete from grade
	where grade<20;
delete from grade
	where cid=12;
delete from grade
	where sid='20331022';
alter table student  CHECK constraint all;
alter table major  CHECK constraint all;
alter table grade  CHECK constraint all;
alter table course  CHECK constraint all;

SELECT Sname
	FROM student;
SELECT Sname,Mname
	FROM student,major
	where student.Mid=major.Mid;
SELECT hobby 
	from student;
SELECT *
	FROM student
	where Year(Birthday)>=1990 and Year(Birthday)<=2022;
SELECT COUNT(*) AS '学生数' 
	FROM student;
SELECT *
	FROM student
	where sid like '%9%';
SELECT *
	FROM student
	where sname like '李%';
SELECT AVG(scores) as '平均学分'
	FROM student;
select * 
	FROM student
	where cast(hobby as varchar(max)) ='学习';
SELECT *
	FROM student
	WHERE student.mid=(
		SELECT mid
			FROM major
			where mname='软件工程');
SELECT SUM(scores) as '人工智能专业所有学生的总学分'
	FROM student
	WHERE student.mid=(
		SELECT mid
			FROM major
			where mname='人工智能');
SELECT mid,SUM(scores)
	FROM student
	GROUP BY mid;
select sname,birthday
	from student
	where YEAR(birthday)=2003 and MONTH(birthday)=1;
SELECT *
	FROM student
	WHERE cast(sremark as varchar(max)) ='三好学生';
SELECT COUNT(*) as '三好学生人数'
	FROM student
	WHERE cast(sremark as varchar(max)) ='三好学生';
SELECT sname
	FROM student
	ORDER BY sname;
SELECT AVG(scores)
	FROM student
	where cast(sremark as varchar(max)) ='三好学生';

select top 3 cname from course;
select top (4) cname from course
where cname not in (
   select top 4 cname from course
)



SELECT cname
		FROM course
		where cterm=5 or cterm=6;
SELECT cname FROM course where cterm=5
UNION
SELECT cname FROM course where cterm=6;
SELECT cname FROM course where cterm=6 and score>4;
SELECT cname FROM course where cterm=6 
intersect
SELECT cname FROM course where score>4;
SELECT cname FROM course where class_hours>40 and score>2;
SELECT cname FROM course where cname like '%软件%';
SELECT * FROM grade where grade>90;
SELECT * FROM grade where sid like'2033109%';
SELECT * FROM grade where cid=8;
select sid,avg(grade)
	FROM grade
	group by(sid);
SELECT sid
	FROM grade
	GROUP BY sid
	having avg(grade)=60;
SELECT sid,sum(grade)
	FROM grade
	GROUP BY sid;
SELECT sid,sum(grade)
	FROM grade
	GROUP BY sid
	HAVING sum(grade)>300;