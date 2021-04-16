--Drop tables
DROP TABLE Hero;
DROP TABLE Team;
DROP TABLE Employees
DROP TABLE IceCream;
DROP TABLE Topping;

--Create tables Team and Hero
CREATE TABLE Team(
	TeamID int NOT NULL,
	TeamName VARCHAR(255) NOT NULL,
	Location VARCHAR(255),
	PRIMARY KEY(TeamID)
);

CREATE TABLE Hero(
	HeroID int NOT NULL,
	HeroName VARCHAR(255) NOT NULL,
	SuperPower VARCHAR(255),
	TeamID int,
	PRIMARY KEY(HeroID),
	FOREIGN KEY(TeamID) REFERENCES Team
);

--Create table Employees
CREATE TABLE Employees(
	EmpID int NOT NULL,
	EmpName VARCHAR(255) NOT NULL,
	ManagerID int,
	PRIMARY KEY(EmpID)
);

--Create tables IceCream and Topping
CREATE TABLE IceCream(
	Flavor varchar(50)
	PRIMARY KEY(Flavor)
);

CREATE TABLE Topping(
	Topping varchar(50)
	PRIMARY KEY(Topping)
);

--Insert values into Team
INSERT INTO Team VALUES (1, 'Avengers', 'New York City - Avengers Mansion');
INSERT INTO Team VALUES (2, 'Justice League', 'Washington, D.C. - Hall of Justice');
INSERT INTO Team VALUES (3, 'X-Men', 'Salem Center, New York - X-Mansion');
INSERT INTO Team VALUES (4, 'Fantastic Four', 'Manhattan, New York City - Baxter Building');
INSERT INTO Team VALUES (5, 'Teen Titans', 'New York City - Titans Tower');
INSERT INTO Team VALUES (6, 'Watchmen', null);

--Insert values into Hero
INSERT INTO Hero VALUES (1, 'Spiderman', 'Spider powers', 1);
INSERT INTO Hero VALUES (2, 'Wolverine', 'Enhanced physical abilities, super healing, claws', 3);
INSERT INTO Hero VALUES (3, 'Hulk', 'Super strength, super healing', 1);
INSERT INTO Hero VALUES (4, 'Captain America', 'Enhanced physical abilities and healing', 1);
INSERT INTO Hero VALUES (5, 'Iron Man', 'Super suit', 1);
INSERT INTO Hero VALUES (6, 'Cyclops', 'Laser vision', 3);
INSERT INTO Hero VALUES (7, 'Magneto', 'Controls metal', 3);
INSERT INTO Hero VALUES (8, 'Storm', 'Controls weather', 3);
INSERT INTO Hero VALUES (9, 'Professor X', 'Telepathy', 3);
INSERT INTO Hero VALUES (10, 'Robin', null, 5);
INSERT INTO Hero VALUES (11, 'Captain Underpants', 'Superhuman strength and durability, flight', null);
INSERT INTO Hero VALUES (12, 'Beast Boy', 'Transform into any animal', 5);

--Insert values into Employees
INSERT INTO Employees VALUES (1, 'John Smith', 5);
INSERT INTO Employees VALUES (2, 'Joe Schmoe', 5);
INSERT INTO Employees VALUES (3, 'John Doe', 4);
INSERT INTO Employees VALUES (4, 'Jane Smith', 2);
INSERT INTO Employees VALUES (5, 'Miles Plurad', null);

--Insert values into IceCream
INSERT INTO IceCream VALUES ('Chocolate');
INSERT INTO IceCream VALUES ('Vanilla');
INSERT INTO IceCream VALUES ('Strawberry');

--Insert values into Topping
INSERT INTO Topping VALUES ('Oreo');
INSERT INTO Topping VALUES ('Brownie');
INSERT INTO Topping VALUES ('Fudge');
INSERT INTO Topping VALUES ('Twix');

--View data within tables
SELECT * FROM Hero;
SELECT * FROM Team;
SELECT * FROM Employees;
SELECT * FROM IceCream;
SELECT * FROM Topping;