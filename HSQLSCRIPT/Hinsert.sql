SET foreign_key_checks = 0;

#------------------------------------------------------------
# Table: UTILISATEUR
#------------------------------------------------------------

#Commercial
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPorteFeuille, version) values 
(1, 'Sailly', 'Axelle', '2 allée de St Genouf', 91360, 'Villemoisson-sur-Orge', '0665564696', 'saillyaxelle@hotmail.fr', 0, 'axelles', MD5('14.08.1997'), 20170424, 0, 3, 1, 1,0);
#Commercial
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPorteFeuille, version) values 
(2, 'Canavaggio', 'Lorenzo', '9 rue Joliot Curie', 91160, 'Saulx-les-Chartreux', '0665564669', 'abc.xyz@hotmail.fr', 0, 'lorenzoc', MD5(12345), 20170326, 0, 3, 2, 2,0);
#Gestionnaire
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPorteFeuille, version) values 
(3, 'Roberto', 'Benedicte', '2 rue Lacaze', 75014, 'Paris', '0656564696', 'bene75@gmail.com', 0, 'benedicter', MD5('abcdefg'), 20170416, 0, 2, null, null,0);
#Administrateur
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPorteFeuille, version) values 
(4, 'Lhullier', 'Jesse', '16 avenue Morane Saulnier', 78140, 'Vélizy-Villacoublay', '0756564696', 'jesse.lhullier@yahoo.com', 0, 'jessel', MD5('jessebox'), 20170215, 0, 1, null, null,0);

SELECT * FROM UTILISATEUR;

#------------------------------------------------------------
# Table: TYPE_RDV
#------------------------------------------------------------
insert into TYPE_RDV (idTypeRdv, libelleTypeRdv, version) values
(1,'Premiere Rencontre' , 0);
insert into TYPE_RDV (idTypeRdv, libelleTypeRdv, version) values
(2,'Rendez vous telephonique' , 0);
insert into TYPE_RDV (idTypeRdv, libelleTypeRdv, version) values
(3,'Presentation' , 0);
insert into TYPE_RDV (idTypeRdv, libelleTypeRdv, version) values
(4,'Visite de courtoisie' , 0);
insert into TYPE_RDV (idTypeRdv, libelleTypeRdv, version) values
(5,'Visiste technique' , 0);
insert into TYPE_RDV (idTypeRdv, libelleTypeRdv, version) values
(6,'Conclusion' , 0);

SELECT * FROM TYPE_RDV;

#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(1,'Organisation' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(2,'Association' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(3,'Ligue' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(4,'PME' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(5,'Grande entreprise' , 0);

SELECT * FROM TYPE_STRUCTURE;

#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------
insert into STRUCTURE (numStructure, denominationSociale, adresseStructure ,  cpStructure , villeStructure, distanceSiege, infoSupplementaire, codeTypeStructure, version) values 
(1,'POL plongee', '13 rue de l`Ormeteau', '91420', 'Morangis', 15,'Association de plongee', 3, 0);

insert into STRUCTURE (numStructure, denominationSociale, adresseStructure ,  cpStructure , villeStructure, distanceSiege, infoSupplementaire, codeTypeStructure, version) values 
(2,'Natixis', '4 allee de St Genouf', '91360', 'Villemoisson-sur-Orge', 25, 'Société boursière', 5, 0);

insert into STRUCTURE (numStructure, denominationSociale, adresseStructure ,  cpStructure , villeStructure, distanceSiege, infoSupplementaire, codeTypeStructure, version) values 
(3,'EDF', '3 rue de la Garenne', '91360', 'Villemoisson-sur-Orge', 25, '', 5, 0);

insert into STRUCTURE (numStructure, denominationSociale, adresseStructure ,  cpStructure , villeStructure, distanceSiege, infoSupplementaire, codeTypeStructure, version) values 
(4,'30 millions de copains', '18 rue des Martyrs', '75009', 'Paris', 25, 'Association de rencontre de vieux copains', 2, 0);

SELECT * FROM STRUCTURE;

#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------

#Commercial numéro 1
insert into INTERLOCUTEUR (idInterlocuteur, nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, idPorteFeuille, version) values 
(1,'Coutrot', 'Sylvain', '0665654696', 'yahoo@gmail.com', 1, 0);
insert into INTERLOCUTEUR (idInterlocuteur, nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, idPorteFeuille, version) values 
(2,'Delbe', 'Sebastien', '0665566496', 'delbe@outlook.fr', 1, 0);
insert into INTERLOCUTEUR (idInterlocuteur, nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, idPorteFeuille, version) values 
(3,'Dulong', 'Raphael', '0665566469', 'd.raph@hotmail.com', 1, 0);

#Commercial numéro 2
insert into INTERLOCUTEUR (idInterlocuteur, nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, idPorteFeuille, version) values 
(4,'Duparc', 'Alexandre', '0665578469', 'alexduparc@free.fr', 2, 0);
insert into INTERLOCUTEUR (idInterlocuteur, nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, idPorteFeuille, version) values 
(5,'Patry', 'Lisa', '0675578469', 'lisap@wanadoo.fr', 2, 0);
insert into INTERLOCUTEUR (idInterlocuteur, nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, idPorteFeuille, version) values 
(6,'Barbotin', 'Victor', '0665878469', 'victorc75@outlook.fr', 2, 0);

SELECT * FROM INTERLOCUTEUR;

#------------------------------------------------------------
# Table: INDIVIDU
#------------------------------------------------------------

#Interlocuteur numéro 1
insert into INDIVIDU (numIndividu, adresseIndividu, cpIndividu, villeIndividu, distanceSiege, infosSupplementaire, idInterlocuteur, version) values 
(1, '4 rue Lacaze','75014', 'Paris', 22, 'Digicode : 1234', 1, 0);

#Interlocuteur numéro 4
insert into INDIVIDU (numIndividu, adresseIndividu, cpIndividu, villeIndividu, distanceSiege, infosSupplementaire, idInterlocuteur, version) values 
(2, '4 rue Lacaze','75014', 'Paris', 22, 'Digicode : 1234', 4, 0);

SELECT * FROM INDIVIDU;

#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------

#Commercial numéro 1
insert into RDV (idRdv, dateRdv, heureDebut, heureFin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, idInterlocuteur, idTypeRdv , idPlanning,idRdvPrecedent, version) values 
(1, '20170420','2017-04-20 10:00', '2017-04-20 12:00', null,null, null, null, 2, 1, 1,null, 0);
insert into RDV (idRdv, dateRdv, heureDebut, heureFin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, idInterlocuteur, idTypeRdv , idPlanning,idRdvPrecedent, version) values 
(2, '20170425','2017-04-25 10:00', '2017-04-25 12:00', null,null, null, null, 2, 5, 1,1, 0);
insert into RDV (idRdv, dateRdv, heureDebut, heureFin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, idInterlocuteur, idTypeRdv , idPlanning,idRdvPrecedent, version) values 
(3, '20170512','2017-05-12 10:00', '2017-05-12 12:00', '3 rue du Fort 92130 Issy-les-Moulineaux','Issy-les-Moulineaux', '17896', null, 3, 1, 1,null, 0);

#Commercial numéro 2
insert into RDV (idRdv, dateRdv, heureDebut, heureFin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, idInterlocuteur, idTypeRdv , idPlanning,idRdvPrecedent, version) values 
(4, '20170502','2017-05-02 8:30', '2017-05-02 10:00', null,null, null, null, 4, 1, 2,null, 0);
insert into RDV (idRdv, dateRdv, heureDebut, heureFin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, idInterlocuteur, idTypeRdv , idPlanning,idRdvPrecedent, version) values 
(5, '20170505','2017-05-05 8:30', '2017-05-05 10:00', null,null, null, null, 4, 5, 2,4, 0);
insert into RDV (idRdv, dateRdv, heureDebut, heureFin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, idInterlocuteur, idTypeRdv , idPlanning,idRdvPrecedent, version) values 
(6, '20170507','2017-05-02 8:30', '2017-05-02 10:00', '24 rue de Sèvres 75007 Paris','Paris', null, 'Appeler à votre arrivée', 6, 1, 2,null, 0);

SELECT * FROM RDV;

#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------
insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(1, '20170605', '20170515', 0);

insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(2, '20170101', '20170201', 0);

SELECT * FROM CONGES;

#------------------------------------------------------------
# Table: CONGES_UTILISATEUR
#------------------------------------------------------------
insert into CONGES_UTILISATEUR (idCongesUtilisateur, numUtilisateur, numConge, version) values 
(1, 1, 1, 0);

insert into CONGES_UTILISATEUR (idCongesUtilisateur, numUtilisateur, numConge, version) values 
(2, 2, 2, 0);

SELECT * FROM CONGES_UTILISATEUR;

#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur, version) values 
(1, 'administrateur', 0);
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur, version) values 
(2, 'Gestionnaire', 0);
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur, version) values 
(3, 'Commercial', 0);

SELECT * FROM TYPE_UTILISATEUR;

#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------

#Commercial numéro 1
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(1, 'Rappel de votre rendez-vous du 20/04/2017 à 10h00', 'Votre Rendez-vous', 1, 2, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(2, 'Compte rendu de la réunion de ce jour, tout à été vu et clarifié.', 'Compte Rendu', 1, 2, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(3, 'Rappel de votre rendez-vous du 25/04/2017 à 10h00', 'Votre Rendez-vous', 1, 2, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(4, 'Rappel de votre rendez-vous du 12/05/2017 à 10h00', 'Votre Rendez-vous', 1, 3, 0);

#Commercial numéro 2
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(5, 'Rappel de votre rendez-vous du 02/05/2017 à 8h30', 'Votre Rendez-vous', 2, 4, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(6, 'Compte rendu de la réunion de ce jour, tout à été vu et clarifié.', 'Compte Rendu', 2, 4, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(7, 'Rappel de votre rendez-vous du 05/05/2017 à 8h30', 'Votre Rendez-vous', 2, 4, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  idInterlocuteur, version   ) values 
(8, 'Rappel de votre rendez-vous du 07/05/2017 à 8h30', 'Votre Rendez-vous', 2, 6, 0);

SELECT * FROM MAIL;

#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------
insert into PLANNING (idPlanning  , numUtilisateur,libellePlanning, version) values 
(1, 1,'secteur 1', 0);

insert into PLANNING (idPlanning  , numUtilisateur,libellePlanning, version) values 
(2, 2,'secteur 2', 0);

SELECT * FROM PLANNING;

#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------
insert into PORTEFEUILLE (idPorteFeuille  , libellePorteFeuille, numUtilisateur, version) values 
(1, 'unportefeuille 1', 1, 0);

insert into PORTEFEUILLE (idPorteFeuille  , libellePorteFeuille, numUtilisateur, version) values 
(2, 'unportefeuille 2', 2, 0);

SELECT * FROM PORTEFEUILLE;

#------------------------------------------------------------
# Table: INTERLOCUTEUR_STRUCTURE
#------------------------------------------------------------
insert into INTERLOCUTEUR_STRUCTURE (idInterlocuteurStructure, idInterlocuteur, numStructure, version) values 
(1, 2, 1, 0);

insert into INTERLOCUTEUR_STRUCTURE (idInterlocuteurStructure, idInterlocuteur, numStructure, version) values 
(2, 3, 2, 0);

insert into INTERLOCUTEUR_STRUCTURE (idInterlocuteurStructure, idInterlocuteur, numStructure, version) values 
(3, 5, 3, 0);

insert into INTERLOCUTEUR_STRUCTURE (idInterlocuteurStructure, idInterlocuteur, numStructure, version) values 
(4, 6, 4, 0);

SELECT * FROM INTERLOCUTEUR_STRUCTURE;


SET foreign_key_checks = 1;


#------------------------------------------------------------
# EVENEMENT: Efface la DistanceParcourueSemaine Tous les lundis
#------------------------------------------------------------
DELETE FROM mysql.event WHERE db = 'gepev'
	
CREATE EVENT resetDistanceParcourueSemaine
    ON SCHEDULE
      EVERY 1 WEEK
	  STARTS CURRENT_DATE + INTERVAL 0 - WEEKDAY(CURRENT_DATE) DAY
    DO
      UPDATE gepev.utilisateur SET DistanceParcourueSemaine = 0;
	  
	  
	
	/* http://stackoverflow.com/questions/25548379/schedule-mysql-event-to-run-every-chosen-day-of-the-week */
