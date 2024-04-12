CREATE TABLE Schedule (
ModuleID nvarchar(50) NOT NULL,
ModuleName nvarchar(50),
ClassLevel nvarchar(50),
Charges int,
Day varchar(50),
Duration nvarchar(50),
Intake nvarchar(50),
Trainer varchar(50),
TrainerID nvarchar(50));

CREATE TABLE Requests(
ID int NOT NULL IDENTITY(1,1),
Name varchar(50),
ClassLevel nvarchar(50),
ModuleName nvarchar(50),
StudentID nvarchar(50),
Intake nvarchar(50));

CREATE TABLE Login(
ID int NOT NULL IDENTITY(1,1),
Username nvarchar(50),
Name varchar(50),
Password nvarchar(50),
Role varchar(50),
Email nvarchar(50),
Contact nvarchar(10),
Description nvarchar(150));

CREATE TABLE Payment(
ID int NOT NULL IDENTITY(1,1),
Name varchar(50),
ClassLevel nvarchar(50),
ModuleName varchar(50),
Status varchar(50),
StudentID nvarchar(50),
Charges int,
ModuleID nvarchar(50),
TrainerID nvarchar(50));

CREATE TABLE Trainer(
TrainerID nvarchar(50),
Income int,
Trainer varchar(50),
Feedback nvarchar(100),
Level varchar(50));

CREATE TABLE Enroll(
ID int NOT NULL IDENTITY(1,1),
StudentID nvarchar(50),
Name varchar(50),
Email nvarchar(50),
Contact nvarchar(10),
Address nvarchar(50),
ClassLevel varchar(50),
Module varchar(50),
Intake nvarchar(50),
Origin varchar(50));

INSERT INTO Requests (Name, ClassLevel, ModuleName, StudentID, Intake)
VALUES ('Chia', 'Advanced', 'C++ Programming', 'S0001', '2023A'),
('Wong', 'Intermediate', 'Python Programming', 'S0002', '2023A'),
('Lai', 'Beginner', 'C# Programming', 'S0003', '2023B'),
('Liew', 'Advanced', 'C Programming', 'S0004', '2023B');

INSERT INTO Schedule
VALUES ('M001', 'C# Programming', 'Beginner', '5000', 'Every Monday', '8am to 10am', '2023B', 'Mr. Lee', 'T001'),
('M002','Python Programming','Intermediate','8000','Every Tuesday','10am to 12pm','2023A','Mr. Leong','T002'),
('M003','C Programming', 'Advanced', '10000', 'Every Friday', '2pm to 4pm', '2023B', 'Ms. Fara', 'T003'),
('M004', 'C++ Programming', 'Advanced', '10000', 'Every Wednesday', '4pm to 6pm', '2023A', 'Ms. Wu', 'T004');

INSERT INTO Login (Username, Name, Password, Role, Email, Contact, Description)
VALUES('T001', 'Mr. Lee', 'T1', 'trainer', 'T001@apu.edu.my', '0123456111', 'I love C# Programming!'),
('T002', 'Mr. Leong', 'T2', 'trainer', 'T002@apu.edu.my', '0123456222', 'I love Python Programming!'),
('T003', 'Ms. Fara', 'T3', 'trainer', 'T003@apu.edu.my', '0123456333', 'I love C Programming!'),
('T004', 'Ms. Wu', 'T4', 'trainer', 'T004@apu.edu.my', '0123456444', 'I love C++ Programming!'),
('S0001', 'Chia', 'S1', 'student', 'S0001@apu.edu.my', '0123456555', 'I am very blurred rn'),
('S0002', 'Wong', 'S2', 'student', 'S0002@apu.edu.my', '0123456666', 'I am obsessed with apex'),
('S0003', 'Lai', 'S3', 'student', 'S0003@apu.edu.my', '0123456777', 'I need some tea'),
('S0004', 'Liew', 'S4', 'student', 'S0004@apu.edu.my', '0123456888', 'I need movie'),
('L001', 'Lin', 'L1', 'lecturer', 'L001@apu.edu.my', '0123456999', 'I need a break'),
('A001', 'Alin', 'A1', 'admin', 'A001@apu.edu.my', '0123456000', 'I am sick rn');

INSERT INTO Payment (Name, ClassLevel, ModuleName, Status, StudentID, Charges, ModuleID, TrainerID)
VALUES('Chia', 'Beginner', 'C# Programming', 'PAID', 'S0001', '5000', 'M001', 'T001'),
('Wong', 'Advanced', 'C Programming', 'UNPAID', 'S0002', '10000', 'M003', 'T003'),
('Lai', 'Intermediate', 'Python Programming', 'PAID', 'S0003', '8000', 'M002', 'T002'),
('Liew', 'Advanced', 'C++ Programming', 'UNPAID', 'S0004', '10000', 'M004', 'T004');

INSERT INTO Trainer 
VALUES('T001', '3000', 'Mr. Lee', 'Why my wage never rise in so long', 'Beginner'),
('T002', '4000', 'Mr. Leong', 'No feedback', 'Intermediate'),
('T003', '5000', 'Ms. Fara', 'I ll request for leave soon', 'Advanced'),
('T004', '5000', 'Ms. Wu', 'I love my bed', 'Advanced');

INSERT INTO Enroll (StudentID, Name, Email, Contact, Address, ClassLevel, Module, Intake, Origin)
VALUES('S0001', 'Chia', 'S0001@apu.edu.my', '0123456555', 'Kuala Lumpur', 'Beginner', 'C# Programming', '2023B', 'Malaysia'),
('S0002', 'Wong', 'S0002@apu.edu.my', '0123456666', 'Sarawak', 'Advanced', 'C Programming', '2023B', 'Vietnam'),
('S0003', 'Lai', 'S0003@apu.edu.my', '0123456777', 'Puchong', 'Intermediate', 'Python Programming', '2023A', 'Brunei'),
('S0004', 'Liew', 'S0004@apu.edu.my', '0123456888', 'OUG', 'Advanced', 'C++ Programming', '2023A', 'Singapore');
