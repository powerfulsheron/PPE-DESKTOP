#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

DROP DATABASE GEPEV;

CREATE DATABASE GEPEV;

USE GEPEV;

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
        idPortefeuille           Int ,
        version Int,
        PRIMARY KEY (numUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------

CREATE TABLE TYPERDV(
        id_type_rdv int (11) Auto_increment NOT NULL ,
        type_rdv    Varchar (40) NOT NULL ,
        version Int,
        PRIMARY KEY (id_type_rdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------

CREATE TABLE STRUCTURE(
        num_structure        int (11) Auto_increment  NOT NULL ,
        denomination_sociale Varchar (25) NOT NULL ,
        adresse_structure    Varchar (25) NOT NULL ,
        cp_structure         Varchar (25) NOT NULL ,
        ville_structure      Varchar (25) NOT NULL ,
        distance_siege       Float NOT NULL ,
        plan_accees          Varchar (25) NOT NULL ,
        infos_supplementaire Varchar (100) NOT NULL ,
        codeTypeStructure    Int NOT NULL ,
        version Int,
        PRIMARY KEY (num_structure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------

CREATE TABLE INTERLOCUTEUR(
        id_interlocuteur     int (11) Auto_increment  NOT NULL ,
        nom_interlocuteur    Varchar (25) NOT NULL ,
        prenom_interlocuteur Varchar (25) NOT NULL ,
        tel_interlocuteur    Varchar (25) NOT NULL ,
        mail_interlocuteur   Varchar (40) NOT NULL ,
        num_individu         Int ,
        idPortefeuille       Int ,
        version Int,
        PRIMARY KEY (id_interlocuteur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INDIVIDU
#------------------------------------------------------------

CREATE TABLE INDIVIDU(
        num_individu         int (11) Auto_increment  NOT NULL ,
        adresse_individu     Varchar (25) NOT NULL ,
        cp_individu          Varchar (25) NOT NULL ,
        ville_individu       Varchar (25) NOT NULL ,
        distance_siege       Float NOT NULL ,
        plan_accees          Varchar (25) NOT NULL ,
        infos_supplementaire Varchar (100) NOT NULL ,
        id_interlocuteur     Int NOT NULL ,
        version Int,
        PRIMARY KEY (num_individu )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------

CREATE TABLE RDV(
        id_rdv                int (11) Auto_increment  NOT NULL ,
        date_rdv              Date NOT NULL ,
        heure_debut           Time NOT NULL ,
        heure_fin             Time NOT NULL ,
        adresseDerogatoire    Varchar (50) ,
        villeDerogatoire      Varchar (30) ,
        codeEntreeDerogatoire Int ,
        infoDerogatoire       Varchar (500) ,
        id_interlocuteur      Int NOT NULL ,
        id_type_rdv           Int NOT NULL ,
        idPlanning            int NOT NULL ,
        version Int,
        PRIMARY KEY (id_rdv )
)ENGINE=InnoDB;


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
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------

CREATE TABLE TYPE_UTILISATEUR(
        codeTypeUtilisateur    int (11) Auto_increment NOT NULL ,
        libelleTypeUtilisateur Varchar (25) ,
        version Int,
        PRIMARY KEY (codeTypeUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------

CREATE TABLE MAIL(
        numMail          int (11) Auto_increment NOT NULL ,
        contenuMail      Varchar (10000) ,
        objetMail        Varchar (50) ,
        numUtilisateur   Int NOT NULL ,
        id_interlocuteur Int NOT NULL ,
        version Int,
        PRIMARY KEY (numMail )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------

CREATE TABLE PLANNING(
        idPlanning     int (11) Auto_increment NOT NULL ,
        numUtilisateur Int NOT NULL ,
        libellePlanning varchar(50),
        version Int,
        PRIMARY KEY (idPlanning)
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
# Table: PORTEFEUILLE
#------------------------------------------------------------

CREATE TABLE PORTEFEUILLE(
        idPortefeuille      int (11) Auto_increment NOT NULL ,
        libellePortefeuille Varchar (30) ,
        numUtilisateur      Int NOT NULL ,
        version Int,
        PRIMARY KEY (idPortefeuille )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR_STRUCTURE
#------------------------------------------------------------

CREATE TABLE INTERLOCUTEUR_STRUCTURE(
        id_interlocuteur int (11) Auto_increment NOT NULL ,
        num_structure    Int NOT NULL ,
        version Int,
        PRIMARY KEY (id_interlocuteur ,num_structure )
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
# Table: SUIVRE
#------------------------------------------------------------

CREATE TABLE SUIVRE(
        id_rdv     int (11) Auto_increment NOT NULL ,
        id_rdv_RDV Int NOT NULL ,
        version Int,
        PRIMARY KEY (id_rdv ,id_rdv_RDV )
)ENGINE=InnoDB;

ALTER TABLE CONGES_UTILISATEUR ADD CONSTRAINT FK_CONGES_UTILISATEUR_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE CONGES_UTILISATEUR ADD CONSTRAINT FK_CONGES_UTILISATEUR_numConge FOREIGN KEY (numConge) REFERENCES CONGES(numConge);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_codeTypeUtilisateur FOREIGN KEY (codeTypeUtilisateur) REFERENCES TYPE_UTILISATEUR(codeTypeUtilisateur);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_idPlanning FOREIGN KEY (idPlanning) REFERENCES PLANNING(idPlanning);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_idPortefeuille FOREIGN KEY (idPortefeuille) REFERENCES PORTEFEUILLE(idPortefeuille);
ALTER TABLE STRUCTURE ADD CONSTRAINT FK_STRUCTURE_codeTypeStructure FOREIGN KEY (codeTypeStructure) REFERENCES TYPE_STRUCTURE(codeTypeStructure);
ALTER TABLE INTERLOCUTEUR ADD CONSTRAINT FK_INTERLOCUTEUR_num_individu FOREIGN KEY (num_individu) REFERENCES INDIVIDU(num_individu);
ALTER TABLE INTERLOCUTEUR ADD CONSTRAINT FK_INTERLOCUTEUR_idPortefeuille FOREIGN KEY (idPortefeuille) REFERENCES PORTEFEUILLE(idPortefeuille);
ALTER TABLE INDIVIDU ADD CONSTRAINT FK_INDIVIDU_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_id_type_rdv FOREIGN KEY (id_type_rdv) REFERENCES TYPERDV(id_type_rdv);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_idPlanning FOREIGN KEY (idPlanning) REFERENCES PLANNING(idPlanning);
ALTER TABLE MAIL ADD CONSTRAINT FK_MAIL_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE MAIL ADD CONSTRAINT FK_MAIL_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE PLANNING ADD CONSTRAINT FK_PLANNING_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE PORTEFEUILLE ADD CONSTRAINT FK_PORTEFEUILLE_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE INTERLOCUTEUR_STRUCTURE ADD CONSTRAINT FK_INTERLOCUTEUR_STRUCTURE_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE INTERLOCUTEUR_STRUCTURE ADD CONSTRAINT FK_INTERLOCUTEUR_STRUCTURE_num_structure FOREIGN KEY (num_structure) REFERENCES STRUCTURE(num_structure);
ALTER TABLE CONGES_UTILISATEUR ADD CONSTRAINT FK_CONGES_UTILISATEUR_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE CONGES_UTILISATEUR ADD CONSTRAINT FK_CONGES_UTILISATEUR_numConge FOREIGN KEY (numConge) REFERENCES CONGES(numConge);
ALTER TABLE SUIVRE ADD CONSTRAINT FK_SUIVRE_id_rdv FOREIGN KEY (id_rdv) REFERENCES RDV(id_rdv);
ALTER TABLE SUIVRE ADD CONSTRAINT FK_SUIVRE_id_rdv_RDV FOREIGN KEY (id_rdv_RDV) REFERENCES RDV(id_rdv);