CREATE DATABASE mabase;

USE mabase;

CREATE TABLE utilisateur (
	nom VARCHAR(30),
	prenom VARCHAR(30),
	email VARCHAR(50)	
	);
	
INSERT INTO utilisateur (nom, prenom, email)
	VALUES
	('Sailly', 'Axelle', 'vivelescupcake@gmail.com'),
	('Canavagio', 'Lorzenzo4', 'Lo.renzo@bangbros.com'),
	('Delbe', 'Seb', 'Seb.Delbe@gaycontact.com'),
	('Coutrot', 'Sylvain', 'Sylvaint.Coutrot@gaycontact.com'),
	('Duparc', 'Alex', 'Alex@minuit-midi.com');