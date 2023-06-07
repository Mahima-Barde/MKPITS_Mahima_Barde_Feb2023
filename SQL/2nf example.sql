create database tea
create table teachers(
teachers_id int primary key,
age int
)

create table subject(
teacher_id int,
subject varchar(20)
constraint t1 foreign key(teacher_id)
references teachers(teachers_id))

Insert into teachers values(1,30),
(2,31),
(3,32);

Insert into subject values(1,'Maths'),
(2,'PT'),
(3,'Chemistry'),
(2,'Biology'),
(3,'Physics')


select * from teachers
select * from subject