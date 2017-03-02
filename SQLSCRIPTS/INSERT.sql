SET foreign_key_checks = 0;

#------------------------------------------------------------
# Table: UTILISATEUR
#------------------------------------------------------------
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille) values 
(1, 'Jimmy', 'Clark', '32598 Melvin Point', 7500, 'Sāqayn', '967-(798)407-8439', 'jclark0@amazonaws.com', 0, 'jclark', MD5(12345), 20160326,  0, 1, null, null);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille) values 
(2, 'Patricia', 'Griffin', '5301 Oak Parkway', 7500, 'Jiwei', '86-(792)136-2859', 'pgriffin1@kickstarter.com', 0, 'pgriffin', MD5(12345), 20160326, 0, 2, null, null);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille) values 
(3, 'Jack', 'Robinson', '8 Roth Parkway', 7500, 'Veselynove', '380-(969)729-3321', 'jrobinson2@twitpic.com', 0, 'jrobinson', MD5(12345), 20160326, 0, 3, null, null);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille) values 
(4, 'Jack', 'Lopez', '82 5th Lane', 7500, 'Lingmen', '86-(743)835-5499', 'jlopez3@independent.co.uk', 0, 'jlopez', MD5(12345), 20160326, 0, 1, null, null);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille) values 
(5, 'Gregory', 'Cunningham', '7897 Acker Plaza', 7500, 'Qianjin', '86-(881)556-5418', 'gcunningham4@hatena.ne.jp', 0, 'gcunningham', MD5(12345), 20160326, 0, 2, null, null);

SELECT * FROM UTILISATEUR;

#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------
insert into TYPERDV (id_type_rdv, type_rdv) values
(1,'Premiere Rencontre');
insert into TYPERDV (id_type_rdv, type_rdv) values
(2,'Rendez vous telephonique');
insert into TYPERDV (id_type_rdv, type_rdv) values
(3,'Presentation');
insert into TYPERDV (id_type_rdv, type_rdv) values
(4,'Visite de courtoisie');
insert into TYPERDV (id_type_rdv, type_rdv) values
(5,'Visiste technique');
insert into TYPERDV (id_type_rdv, type_rdv) values
(6,'Conclusion');

SELECT * FROM TYPERDV;

#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure) values
(1,'Organisation');
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure) values
(2,'Association');
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure) values
(3,'Ligue');
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure) values
(4,'PME');
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure) values
(5,'Grande entreprise');

SELECT * FROM TYPE_STRUCTURE;

#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(1,'structure 1', '97701 Nova Circle', '46900-000', 'Seabra', 1, '3 Prairieview Terrace', 'Ergonomic multimedia encoding', 1);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(2,'structure 2', '0850 Kenwood Hill', '13140-000', 'Paulínia', 2, '266 Dawn Alley', 'Synchronised needs-based superstructure', 2);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(3,'structure 3', '14272 Elka Plaza', '75000', 'Jiaoxie', 3, '04 Vernon Alley', 'Configurable multi-state concept', 3);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(4,'structure 4', '97194 Fairfield Hill', '75000', 'Fengshan', 4, '685 Michigan Lane', 'Networked coherent contingency', 4);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(5,'structure 5', '9366 Orin Lane', '75000', 'Baipenzhu', 5, '16066 Holmberg Pass', 'Public-key content-based knowledge base', 5);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(6,'structure 6', '400 Kingsford Pass', '75000', 'Goubétto', 6, '3 Monument Parkway', 'Future-proofed impactful projection', 1);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(7,'structure 7', '393 Steensland Point', '2110', 'Red Hill', 7, '089 Farmco Parkway', 'Multi-lateral 4th generation data-warehouse', 2);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(8,'structure 8', '6 Monica Road', '2508', 'Nanyo', 8, '04092 Kinsman Way', 'Function-based national local area network', 3);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(9,'structure 9', '4513 Fairfield Junction', '75000', 'Parungjawa', 9, '030 Pleasure Trail', 'Visionary asynchronous forecast', 4);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(10,'structure 10', '0076 Blaine Drive', '75000', 'Nanning', 10, '51 Manufacturers Drive', 'Automated asynchronous matrix', 5);

SELECT * FROM STRUCTURE;

#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
(1,'Bouze', 'Camélia', '33-(390)653-6256', 'jjackson0@sciencedaily.com', 1, null);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
(2,'Alaki', 'Crééz', '30-(294)242-7802', 'ppowell1@ameblo.jp', 2, null);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
(3,'Kogu', 'Mégane', '972-(623)893-2322', 'dhudson2@joomla.org', 3, null);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
(4,'pistali', 'Ruì', '30-(938)455-3301', 'palvarez3@baidu.com', 4, null);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
(5,'Papoom', 'Cécilia', '967-(562)366-2705', 'srice4@goo.ne.jp', 5, null);

SELECT * FROM INTERLOCUTEUR;

#------------------------------------------------------------
# Table: INDIVIDU
#------------------------------------------------------------
insert into INDIVIDU (num_individu, adresse_individu,cp_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(1, '77257 Larry Alley','75000', 'Masaki-chō', 55, '2930 Bobwhite Hill', 'Progressive dedicated application', 1);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(2, '582 Lyons Street','75000', 'Srostki', 21, '2117 Jenifer Point', 'Optimized hybrid interface', 2);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu,ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(3, '8897 Ridgeway Point','75000', 'Seres', 78, '2323 Superior Terrace', 'Universal bifurcated function', 3);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu,ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(4, '4 Clove Terrace','75000', 'Lescar', 47, '7 Stone Corner Center', 'Expanded responsive task-force', 4);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu,ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(5, '0 Pleasure Plaza','75000', 'Jinzhou', 27, '63872 David Junction', 'Devolved system-worthy application', 5);


SELECT * FROM INDIVIDU;

#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(1, '20160601','08:30', '22:19', '73 Hoard Circle', 'San Sebastian', 94, null, 1, 1, 1);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(2, '20160304','08:30', '7:48', '14 Sullivan Street', 'Sertânia', 81, null, 2, 2, 2);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(3, '20160326','08:30', '6:54', '3 Doe Crossing Pass', 'Podebłocie', 5, null, 3, 3, 3);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(4, '20160610','08:30', '1:51', '78528 Orin Street', 'Alcoy', 99, null, 4, 4, 4);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(5, '20160510','08:30', '22:33', '023 Butternut Court', 'Banī Suwayf', 56, null, 5, 5, 5);

SELECT * FROM RDV;

#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------
insert into CONGES (numConge, dateDebutConge, dateFinConge) values 
(1, '20160427', '20180125');
insert into CONGES (numConge, dateDebutConge, dateFinConge) values 
(2, '20160627', '20171220');
insert into CONGES (numConge, dateDebutConge, dateFinConge) values 
(3, '20161213', '20171010');
insert into CONGES (numConge, dateDebutConge, dateFinConge) values 
(4, '20160519', '20170315');
insert into CONGES (numConge, dateDebutConge, dateFinConge) values 
(5, '20161105', '20180107');

SELECT * FROM CONGES;

#------------------------------------------------------------
# Table: CONGES_UTILISATEUR
#------------------------------------------------------------
insert into CONGES_UTILISATEUR (numUtilisateur, numConge) values 
(1, 1);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge) values 
(1, 2);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge) values 
(1, 3);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge) values 
(1, 4);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge) values 
(1, 5);

SELECT * FROM CONGES_UTILISATEUR;

#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur) values 
(1, 'administrateur');
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur) values 
(2, 'Gestionnaire');
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur) values 
(3, 'Commercial');

SELECT * FROM TYPE_UTILISATEUR;

#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  id_interlocuteur   ) values 
(1, 'Vous êtes virés', 'sale con', 1, 1);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  id_interlocuteur   ) values 
(2, 'Je veux ta thune', 'Coucou toi', 2, 2);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  id_interlocuteur   ) values 
(3, 'Deux employes sont gays', 'probleme', 3, 3);

SELECT * FROM MAIL;

#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------
insert into PLANNING (idPlanning  , numUtilisateur) values 
(1, 1);
insert into PLANNING (idPlanning  , numUtilisateur) values 
(2, 2);
insert into PLANNING (idPlanning  , numUtilisateur) values 
(3, 3);
insert into PLANNING (idPlanning  , numUtilisateur) values 
(4, 4);
insert into PLANNING (idPlanning  , numUtilisateur) values 
(5, 5);

SELECT * FROM PLANNING;

#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur) values 
(1, 'unportefeuille', 1);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur) values 
(2, 'unportefeuille', 2);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur) values 
(3, 'unportefeuille', 3);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur) values 
(4, 'unportefeuille', 4);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur) values 
(5, 'unportefeuille', 5);

SELECT * FROM PORTEFEUILLE;

#------------------------------------------------------------
# Table: INTERLOCUTEUR_STRUCTURE
#------------------------------------------------------------
insert into INTERLOCUTEUR_STRUCTURE (id_interlocuteur , num_structure) values 
(1, 1);
insert into INTERLOCUTEUR_STRUCTURE (id_interlocuteur , num_structure) values 
(2, 2);
insert into INTERLOCUTEUR_STRUCTURE (id_interlocuteur , num_structure) values 
(3, 3);

SELECT * FROM INTERLOCUTEUR_STRUCTURE;

#------------------------------------------------------------
# Table: SUIVRE
#------------------------------------------------------------
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(2, 1);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(3, 2);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(4, 3);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(5, 4);

SELECT * FROM SUIVRE;

SET foreign_key_checks = 1;
