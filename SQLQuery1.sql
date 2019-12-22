create database BoardApp
use BoardApp

create table Board
(
	Board_ID int identity(1,1) not null primary key,
	Board_Name nvarchar(max) not null,
)

insert into Board(Board_Name) values('Monday')
select * from Board

---------------------------------------------
---------------------------------------------

create table List
(
	List_ID int identity(1,1) not null primary key,
	Board_ID int not null,
	List_Name nvarchar(max) not null,
	List_Observing bit  not null,
	List_Position int not null,

	foreign key(Board_ID) references Board(Board_ID),
)
insert into List(Board_ID, List_Name, List_Observing, List_Position)
values(1, 'Have to do',0,0)
select * from List

---------------------------------------------
---------------------------------------------

create table Card
(
	Card_ID int identity(1,1) not null primary key,
	List_ID int not null,
	Card_Name nvarchar(max) not null,
	Card_Observing bit not null,
	Card_Position int not null,
	Card_Description nvarchar(max),
	DueDate_ID int,
	foreign key(List_ID) references List(List_ID),
	foreign key(DueDate_ID) references DueDate(DueDate_ID),
)

insert into Card(List_ID, Card_Name, Card_Observing, Card_Position, Card_Description, DueDate_ID)
values(1,'Complete assignment', 1, 0, 'Give it all', 1)
select * from Card

---------------------------------------------
---------------------------------------------

create table DueDate
(
	DueDate_ID int identity(1,1) not null primary key,
	DueDate_DateTime datetime not null,
	DueDate_Reminder int not null,
)

insert into DueDate(DueDate_DateTime, DueDate_Reminder)
values ('2019/12/22 14:00:00',0)
select * from DueDate

---------------------------------------------
---------------------------------------------

create table CheckList
(
	CheckList_ID int identity(1,1) not null primary key,
	Card_ID int not null,
	CheckList_Name nvarchar(max) not null,
	CheckList_Position int not null,
	foreign key(Card_ID) references Card(Card_ID),
)
insert into CheckList(Card_ID, CheckList_Name, CheckList_Position)
values(1, 'Section 1', 0)
select * from CheckList
---------------------------------------------
---------------------------------------------

create table Item
(
	Item_ID int identity(1,1) not null primary key,
	CheckList_ID int not null,
	Item_Description nvarchar(max) not null,
	Item_Checked bit not null,
	Item_Position int not null,

	foreign key(CheckList_ID) references CheckList(CheckList_ID),
)

insert into Item(CheckList_ID, Item_Description, Item_Checked, Item_Position)
values (1, 'Math', 1, 0)
insert into Item(CheckList_ID, Item_Description, Item_Checked, Item_Position)
values (1, 'Chemistry', 0, 1)