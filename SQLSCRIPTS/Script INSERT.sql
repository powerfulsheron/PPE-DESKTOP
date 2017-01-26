#------------------------------------------------------------
# Table: COMMERCIAL
#------------------------------------------------------------
insert into COMMERCIAL (id_salarie, nom_salarie, prenom_salarie, adresse_salarie, cp_salarie, ville_salarie, tel_salarie, mail_salarie, distanceParcourueSemaine, numUtilisateur, idPortefeuille) values 
(null, 'Jimmy', 'Clark', '32598 Melvin Point', 7500, 'Sāqayn', '967-(798)407-8439', 'jclark0@amazonaws.com', 10, 1, 1);
insert into COMMERCIAL (id_salarie, nom_salarie, prenom_salarie, adresse_salarie, cp_salarie, ville_salarie, tel_salarie, mail_salarie, distanceParcourueSemaine, numUtilisateur, idPortefeuille) values 
(null, 'Patricia', 'Griffin', '5301 Oak Parkway', 7500, 'Jiwei', '86-(792)136-2859', 'pgriffin1@kickstarter.com', 15, 2, 2);
insert into COMMERCIAL (id_salarie, nom_salarie, prenom_salarie, adresse_salarie, cp_salarie, ville_salarie, tel_salarie, mail_salarie, distanceParcourueSemaine, numUtilisateur, idPortefeuille) values 
(null, 'Jack', 'Robinson', '8 Roth Parkway', 7500, 'Veselynove', '380-(969)729-3321', 'jrobinson2@twitpic.com', 10, 3, 3);
insert into COMMERCIAL (id_salarie, nom_salarie, prenom_salarie, adresse_salarie, cp_salarie, ville_salarie, tel_salarie, mail_salarie, distanceParcourueSemaine, numUtilisateur, idPortefeuille) values 
(null, 'Jack', 'Lopez', '82 5th Lane', 7500, 'Lingmen', '86-(743)835-5499', 'jlopez3@independent.co.uk', 15, 4, 4);
insert into COMMERCIAL (id_salarie, nom_salarie, prenom_salarie, adresse_salarie, cp_salarie, ville_salarie, tel_salarie, mail_salarie, distanceParcourueSemaine, numUtilisateur, idPortefeuille) values 
(null, 'Gregory', 'Cunningham', '7897 Acker Plaza', 7500, 'Qianjin', '86-(881)556-5418', 'gcunningham4@hatena.ne.jp', 10, 5, 5);

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

#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 1', '97701 Nova Circle', '46900-000', 'Seabra', 1, '3 Prairieview Terrace', 'Ergonomic multimedia encoding', 1);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 2', '0850 Kenwood Hill', '13140-000', 'Paulínia', 2, '266 Dawn Alley', 'Synchronised needs-based superstructure', 2);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 3', '14272 Elka Plaza', '75000', 'Jiaoxie', 3, '04 Vernon Alley', 'Configurable multi-state concept', 3);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 4', '97194 Fairfield Hill', '75000', 'Fengshan', 4, '685 Michigan Lane', 'Networked coherent contingency', 4);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 5', '9366 Orin Lane', '75000', 'Baipenzhu', 5, '16066 Holmberg Pass', 'Public-key content-based knowledge base', 5);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 6', '400 Kingsford Pass', '75000', 'Goubétto', 6, '3 Monument Parkway', 'Future-proofed impactful projection', 1);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 7', '393 Steensland Point', '2110', 'Red Hill', 7, '089 Farmco Parkway', 'Multi-lateral 4th generation data-warehouse', 2);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 8', '6 Monica Road', '2508', 'Nanyo', 8, '04092 Kinsman Way', 'Function-based national local area network', 3);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 9', '4513 Fairfield Junction', '75000', 'Parungjawa', 9, '030 Pleasure Trail', 'Visionary asynchronous forecast', 4);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(null, 'structure 10', '0076 Blaine Drive', '75000', 'Nanning', 10, '51 Manufacturers Drive', 'Automated asynchronous matrix', 5);

#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------
insert into INTERLOCUTEUR (nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
('Bouze', 'Camélia', '33-(390)653-6256', 'jjackson0@sciencedaily.com', 1, 1);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
('Alaki', 'Crééz', '30-(294)242-7802', 'ppowell1@ameblo.jp', 2, 2);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
('Kogu', 'Mégane', '972-(623)893-2322', 'dhudson2@joomla.org', 3, 3);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
('pistali', 'Ruì', '30-(938)455-3301', 'palvarez3@baidu.com', 4, 4);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille) values 
('Papoom', 'Cécilia', '967-(562)366-2705', 'srice4@goo.ne.jp', 5, 5);

#------------------------------------------------------------
# Table: PARTICULIER
#------------------------------------------------------------
insert into PARTICULIER (num_individu, adresse_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(null, '77257 Larry Alley', 'Masaki-chō', 55, '2930 Bobwhite Hill', 'Progressive dedicated application', 1);
insert into PARTICULIER (num_individu, adresse_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(null, '582 Lyons Street', 'Srostki', 21, '2117 Jenifer Point', 'Optimized hybrid interface', 2);
insert into PARTICULIER (num_individu, adresse_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(null, '8897 Ridgeway Point', 'Seres', 78, '2323 Superior Terrace', 'Universal bifurcated function', 3);
insert into PARTICULIER (num_individu, adresse_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(null, '4 Clove Terrace', 'Lescar', 47, '7 Stone Corner Center', 'Expanded responsive task-force', 4);
insert into PARTICULIER (num_individu, adresse_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur) values 
(null, '0 Pleasure Plaza', 'Jinzhou', 27, '63872 David Junction', 'Devolved system-worthy application', 5);


#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------
insert into RDV (id_rdv, date_rdv, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(null, '6/1/2016', '10:19 PM', '73 Hoard Circle', 'San Sebastian', 94, null, 1, 1, 1);
insert into RDV (id_rdv, date_rdv, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(null, '4/3/2016', '7:48 AM', '14 Sullivan Street', 'Sertânia', 81, null, 2, 2, 2);
insert into RDV (id_rdv, date_rdv, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(null, '3/26/2016', '6:54 AM', '3 Doe Crossing Pass', 'Podebłocie', 5, null, 3, 3, 3);
insert into RDV (id_rdv, date_rdv, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(null, '6/10/2016', '1:51 AM', '78528 Orin Street', 'Alcoy', 99, null, 4, 4, 4);
insert into RDV (id_rdv, date_rdv, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning) values 
(null, '5/10/2016', '10:33 PM', '023 Butternut Court', 'Banī Suwayf', 56, null, 5, 5, 5);


#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------
insert into CONGES (numConge, dateDebutConge, dateFinConge, id_salarie) values 
(1, '4/27/2016', '1/25/2018', 1);
insert into CONGES (numConge, dateDebutConge, dateFinConge, id_salarie) values 
(2, '6/27/2016', '12/20/2017', 2);
insert into CONGES (numConge, dateDebutConge, dateFinConge, id_salarie) values 
(3, '12/13/2016', '10/10/2017', 3);
insert into CONGES (numConge, dateDebutConge, dateFinConge, id_salarie) values 
(4, '5/19/2016', '3/15/2017', 4);
insert into CONGES (numConge, dateDebutConge, dateFinConge, id_salarie) values 
(5, '11/5/2016', '1/7/2018', 5);


#------------------------------------------------------------
# Table: UTILISATEUR
#------------------------------------------------------------
insert into UTILISATEUR (numUtilisateur , loginUtilisateur , passwordUtilisateur , dateDernierLogin , nbTentatives , codeTypeUtilisateur ) values 
(1, 'pwillis0', MD5('kGkQwOSS'), '6/30/2016', null, 1);
insert into UTILISATEUR (numUtilisateur , loginUtilisateur , passwordUtilisateur , dateDernierLogin , nbTentatives , codeTypeUtilisateur ) values 
(2, 'jevans1', MD5('SVUDDGwx'), '7/11/2016', null, 2);
insert into UTILISATEUR (numUtilisateur , loginUtilisateur , passwordUtilisateur , dateDernierLogin , nbTentatives , codeTypeUtilisateur ) values 
(3, 'rcampbell2', MD5('eVjn0bm6XbOv'), '4/19/2016', null, 3);
insert into UTILISATEUR (numUtilisateur , loginUtilisateur , passwordUtilisateur , dateDernierLogin , nbTentatives , codeTypeUtilisateur ) values 
(4, 'triley3', MD5('qsMfaA3bG'), '10/23/2016', null, 2);
insert into UTILISATEUR (numUtilisateur , loginUtilisateur , passwordUtilisateur , dateDernierLogin , nbTentatives , codeTypeUtilisateur ) values 
(5, 'ehudson4', MD5('7M28avnE'), '9/13/2016', null, 2);


#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur) values 
(1, 'administrateur');
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur) values 
(2, 'Gestionnaire');
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur) values 
(3, 'Commercial');


#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------
insert into MAIL (numMail , contenuMail, objetMail, id_salarie ,  id_interlocuteur   ) values 
(1, 'Vous êtes virés', 'sale con', 1, 1);
insert into MAIL (numMail , contenuMail, objetMail, id_salarie ,  id_interlocuteur   ) values 
(2, 'Je veux ta thune', 'Coucou toi', 2, 2);
insert into MAIL (numMail , contenuMail, objetMail, id_salarie ,  id_interlocuteur   ) values 
(3, 'Deux employes sont gays', 'probleme', 3, 3);


#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------
insert into PLANNING (idPlanning  , id_salarie) values 
(1, 1);
insert into PLANNING (idPlanning  , id_salarie) values 
(2, 2);
insert into PLANNING (idPlanning  , id_salarie) values 
(3, 3);
insert into PLANNING (idPlanning  , id_salarie) values 
(4, 4);
insert into PLANNING (idPlanning  , id_salarie) values 
(5, 5);

#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, id_salarie) values 
(1, 'unportefeuille', 1);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, id_salarie) values 
(2, 'unportefeuille', 2);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, id_salarie) values 
(3, 'unportefeuille', 3);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, id_salarie) values 
(4, 'unportefeuille', 4);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, id_salarie) values 
(5, 'unportefeuille', 5);

#------------------------------------------------------------
# Table: APPARTENIR
#------------------------------------------------------------
insert into APPARTENIR (id_interlocuteur , num_structure) values 
(1, 1);
insert into APPARTENIR (id_interlocuteur , num_structure) values 
(2, 2);
insert into APPARTENIR (id_interlocuteur , num_structure) values 
(3, 3);

#------------------------------------------------------------
# Table: SUIVRE
#------------------------------------------------------------
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(1, 1);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(2, 2);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(3, 3);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(4, 4);
insert into SUIVRE (id_rdv  , id_rdv_RDV) values 
(5, 5);