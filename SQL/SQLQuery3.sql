--ALTER FUNCTIONS
--Modifying a table - You can add, modify, or delete columns, change column data types, set or modify constraints, and modify table properties.
-- TO ADD A COLUMN
-- TO MODIFY A COLUMN
-- DELETING A COLUMN USING ALTER
-- ADDING A COLUMN TO SET A DEFAULT VALUES
-- ADDING A CONSTRAINT PRIMARY KEY
-- ADDING A CONSTRAINT NOT NULL TO THE COLUMN

-- TO ADD A COLUMN
--SYNTAX
alter table stud1 
add Marks int;
--column Marks will be added

select * from stud1;
--To modify a column
--Syntax
Alter table table_name
Alter column column_name new_data_type;

-------------------------------
Alter table stud1 
Alter column marks int
select * from stud1
insert into stud1(Marks)values(23);
insert into stud1(Marks)values(78),
(89),
(90),
(45),
(23),
(27),
(56),
(12),
(34),
(12),
(78);
--DELETING A COLUMN USING ALTER
--SYNTAX
ALTER TABLE TABLE_NAME
DROP COLUMN COLUMN_NAME
--column 'F6' is deleted using drop in alter

ALTER TABLE stud1
add Address varchar(23);
ALTER TABLE stud1
drop column 
