#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

DROP DATABASE GEPEV;

CREATE DATABASE GEPEV;

USE GEPEV;


#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------

CREATE TABLE CONGES(
        numConge       int (11) Auto_increment NOT NULL ,
        dateDebutConge Date ,
        dateFinConge   Date ,
        version Int,
        PRIMARY KEY (numConge )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: CONGES_UTILISATEUR
#------------------------------------------------------------

CREATE TABLE CONGES_UTILISATEUR(
        idCongesUtilisateur int (11) Auto_increment NOT NULL ,
        numUtilisateur int (11) NOT NULL ,
        numConge       Int NOT NULL ,
        version Int,
        PRIMARY KEY (idCongesUtilisateur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INDIVIDU
#------------------------------------------------------------

CREATE TABLE INDIVIDU(
        numIndividu         int (11) Auto_increment  NOT NULL ,
        adresseIndividu     Varchar (25) NOT NULL ,
        cpIndividu          Varchar (25) NOT NULL ,
        villeIndividu       Varchar (25) NOT NULL ,
        distanceSiege       Float NOT NULL ,
        infosSupplementaire Varchar (100) NOT NULL ,
        idInterlocuteur     Int NOT NULL ,
        version Int,
        PRIMARY KEY (numIndividu)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------

CREATE TABLE INTERLOCUTEUR(
        idInterlocuteur     int (11) Auto_increment  NOT NULL ,
        nomInterlocuteur    Varchar (25) NOT NULL ,
        prenomInterlocuteur Varchar (25) NOT NULL ,
        telInterlocuteur    Varchar (25) NOT NULL ,
        mailInterlocuteur   Varchar (40) NOT NULL ,
        idPorteFeuille      Int ,
        version Int,
        PRIMARY KEY (idInterlocuteur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR_STRUCTURE
#------------------------------------------------------------

CREATE TABLE INTERLOCUTEUR_STRUCTURE(
		idInterlocuteurStructure int (11) Auto_increment NOT NULL ,
        idInterlocuteur Int NOT NULL ,
        numStructure    Int NOT NULL ,
        version Int,
        PRIMARY KEY (idInterlocuteurStructure)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------

CREATE TABLE MAIL(
        numMail          int (11) Auto_increment NOT NULL ,
        contenuMail      Varchar (10000) ,
        objetMail        Varchar (50) ,
        numUtilisateur   Int NOT NULL ,
        idInterlocuteur Int NOT NULL ,
        version Int,
        PRIMARY KEY (numMail )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------

CREATE TABLE PLANNING(
        idPlanning     int (11) Auto_increment NOT NULL ,
        numUtilisateur Int ,
        libellePlanning varchar(50),
        version Int,
        PRIMARY KEY (idPlanning)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------

CREATE TABLE PORTEFEUILLE(
        idPorteFeuille      int (11) Auto_increment NOT NULL ,
        libellePorteFeuille Varchar (30) ,
        numUtilisateur      Int ,
        version Int,
        PRIMARY KEY (idPorteFeuille )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------

CREATE TABLE RDV(
        idRdv                int (11) Auto_increment  NOT NULL ,
        dateRdv              Date NOT NULL ,
        heureDebut           Date NOT NULL ,
        heureFin             Date NOT NULL ,
        adresseDerogatoire    Varchar (50) ,
        villeDerogatoire      Varchar (30) ,
        codeEntreeDerogatoire Int ,
        infoDerogatoire       Varchar (500) ,
        idInterlocuteur      Int NOT NULL ,
        idTypeRdv            Int NOT NULL ,
        idPlanning           Int NOT NULL ,
        idRdvPrecedent       Int,
        version Int,
        PRIMARY KEY (idRdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------

CREATE TABLE STRUCTURE(
        numStructure        int (11) Auto_increment  NOT NULL ,
        denominationSociale Varchar (25) NOT NULL ,
        adresseStructure    Varchar (25) NOT NULL ,
        cpStructure         Varchar (25) NOT NULL ,
        villeStructure      Varchar (25) NOT NULL ,
        distanceSiege       Float NOT NULL ,
        infoSupplementaire Varchar (100) NOT NULL ,
        codeTypeStructure    Int NOT NULL ,
        version Int,
        PRIMARY KEY (numStructure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------

CREATE TABLE TYPE_RDV(
        idTypeRdv int (11) Auto_increment NOT NULL ,
        libelleTypeRdv    Varchar (40) NOT NULL ,
        version Int,
        PRIMARY KEY (idTypeRdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------

CREATE TABLE TYPE_STRUCTURE(
        codeTypeStructure    int (11) Auto_increment NOT NULL ,
        libelleTypeStructure Varchar (30) ,
        version Int,
        PRIMARY KEY (codeTypeStructure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------

CREATE TABLE TYPE_UTILISATEUR(
        codeTypeUtilisateur    int (11) Auto_increment NOT NULL ,
        libelleTypeUtilisateur Varchar (25) ,
        version Int,
        PRIMARY KEY (codeTypeUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: UTILISATEUR
#------------------------------------------------------------

CREATE TABLE UTILISATEUR(
        numUtilisateur           int (11) Auto_increment  NOT NULL ,
        nomUtilisateur           Varchar (25) NOT NULL ,
        prenomUtilisateur        Varchar (25) NOT NULL ,
        adresseUtilisateur       Varchar (25) NOT NULL ,
        cpUtilisateur            Varchar (25) NOT NULL ,
        villeUtilisateur         Varchar (25) NOT NULL ,
        telUtilisateur           Varchar (25) NOT NULL ,
        mailUtilisateur          Varchar (40) NOT NULL ,
        distanceParcourueSemaine Int ,
        loginUtilisateur         Varchar (30) ,
        passwordUtilisateur      Varchar (50) ,
        dateDernierLogin         Datetime ,
        nbTentatives             Int ,
        codeTypeUtilisateur      Int NOT NULL ,
        idPlanning               int ,
        idPorteFeuille           Int ,
        version Int,
        PRIMARY KEY (numUtilisateur )
)ENGINE=InnoDB;


ALTER TABLE CONGES_UTILISATEUR ADD CONSTRAINT FK_CONGES_UTILISATEUR_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE CONGES_UTILISATEUR ADD CONSTRAINT FK_CONGES_UTILISATEUR_numConge FOREIGN KEY (numConge) REFERENCES CONGES(numConge);

ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_codeTypeUtilisateur FOREIGN KEY (codeTypeUtilisateur) REFERENCES TYPE_UTILISATEUR(codeTypeUtilisateur);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_idPlanning FOREIGN KEY (idPlanning) REFERENCES PLANNING(idPlanning);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_idPorteFeuille FOREIGN KEY (idPorteFeuille) REFERENCES PORTEFEUILLE(idPorteFeuille);

ALTER TABLE STRUCTURE ADD CONSTRAINT FK_STRUCTURE_codeTypeStructure FOREIGN KEY (codeTypeStructure) REFERENCES TYPE_STRUCTURE(codeTypeStructure);

ALTER TABLE INTERLOCUTEUR ADD CONSTRAINT FK_INTERLOCUTEUR_idPorteFeuille FOREIGN KEY (idPorteFeuille) REFERENCES PORTEFEUILLE(idPorteFeuille);

ALTER TABLE INDIVIDU ADD CONSTRAINT FK_INDIVIDU_idInterlocuteur FOREIGN KEY (idInterlocuteur) REFERENCES INTERLOCUTEUR(idInterlocuteur);

ALTER TABLE RDV ADD CONSTRAINT FK_RDV_idInterlocuteur FOREIGN KEY (idInterlocuteur) REFERENCES INTERLOCUTEUR(idInterlocuteur);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_idTypeRdv FOREIGN KEY (idTypeRdv) REFERENCES TYPE_RDV(idTypeRdv);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_idPlanning FOREIGN KEY (idPlanning) REFERENCES PLANNING(idPlanning);

ALTER TABLE MAIL ADD CONSTRAINT FK_MAIL_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE MAIL ADD CONSTRAINT FK_MAIL_idInterlocuteur FOREIGN KEY (idInterlocuteur) REFERENCES INTERLOCUTEUR(idInterlocuteur);

ALTER TABLE PLANNING ADD CONSTRAINT FK_PLANNING_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);

ALTER TABLE PORTEFEUILLE ADD CONSTRAINT FK_PORTEFEUILLE_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);

ALTER TABLE RDV ADD CONSTRAINT FK_RDV_idRdvPrecedent FOREIGN KEY (idRdvPrecedent) REFERENCES RDV(idRdv);

ALTER TABLE INTERLOCUTEUR_STRUCTURE ADD CONSTRAINT FK_INTERLOCUTEUR_STRUCTURE_idInterlocuteur FOREIGN KEY (idInterlocuteur) REFERENCES INTERLOCUTEUR(idInterlocuteur);
ALTER TABLE INTERLOCUTEUR_STRUCTURE ADD CONSTRAINT FK_INTERLOCUTEUR_STRUCTURE_numStructure FOREIGN KEY (numStructure) REFERENCES STRUCTURE(numStructure);