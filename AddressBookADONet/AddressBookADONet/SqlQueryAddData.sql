create procedure InsertDataIntoDB
@first_Name varchar(150),
@last_Name varchar(150),
@address varchar(250),
@city varchar(100),
@state varchar(200),
@zip int,
@phoneNumber bigint,
@email varchar(250)
As
Insert into ADDRESS_BOOK(first_Name,last_Name,address,city ,state,zip,phoneNumber,email)Values(@first_Name,@last_Name,@address,@city,@state,@zip,@phoneNumber,@email);

EXEC [dbo].[InsertDataIntoDB]
@first_Name="virat",
@last_Name="kohali",
@address="Mumbai",
@city="Mumbai",
@state="Maharashtra",
@zip=876543,
@phoneNumber=8765432190,
@email="hjg43@gmail.com";
