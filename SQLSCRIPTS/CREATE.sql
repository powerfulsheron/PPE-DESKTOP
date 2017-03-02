#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


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
        mailUtilisateur          Varchar (25) NOT NULL ,
        distanceParcourueSemaine Int ,
        loginUtilisateur         Varchar (30) ,
        passwordUtilisateur      Varchar (50) ,
        dateDernierLogin         Datetime ,
        nbTentatives             Int ,
        codeTypeUtilisateur      Int NOT NULL ,
        idPlanning               Varchar (25) ,
        idPortefeuille           Int ,
        PRIMARY KEY (numUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------

CREATE TABLE TYPERDV(
        id_type_rdv Int NOT NULL ,
        type_rdv    Varchar (40) NOT NULL ,
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
        infos_supplementaire Varchar (25) NOT NULL ,
        codeTypeStructure    Int NOT NULL ,
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
        mail_interlocuteur   Varchar (25) NOT NULL ,
        num_individu         Int NOT NULL ,
        idPortefeuille       Int ,
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
        infos_supplementaire Varchar (25) NOT NULL ,
        id_interlocuteur     Int NOT NULL ,
        PRIMARY KEY (num_individu )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------

CREATE TABLE RDV(
        id_rdv                int (11) Auto_increment  NOT NULL ,
        date_rdv              Date NOT NULL ,
        heure_debut           Date NOT NULL ,
        heure_fin             Date NOT NULL ,
        adresseDerogatoire    Varchar (50) ,
        villeDerogatoire      Varchar (30) ,
        codeEntreeDerogatoire Int ,
        infoDerogatoire       Varchar (500) ,
        id_interlocuteur      Int NOT NULL ,
        id_type_rdv           Int NOT NULL ,
        idPlanning            Varchar (25) ,
        PRIMARY KEY (id_rdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------

CREATE TABLE CONGES(
        numConge       Int NOT NULL ,
        dateDebutConge Datetime ,
        dateFinConge   Datetime ,
        PRIMARY KEY (numConge )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------

CREATE TABLE TYPE_UTILISATEUR(
        codeTypeUtilisateur    Int NOT NULL ,
        libelleTypeUtilisateur Varchar (25) ,
        PRIMARY KEY (codeTypeUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------

CREATE TABLE MAIL(
        numMail          Int NOT NULL ,
        contenuMail      Varchar (10000) ,
        objetMail        Varchar (50) ,
        numUtilisateur   Int NOT NULL ,
        id_interlocuteur Int NOT NULL ,
        PRIMARY KEY (numMail )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------

CREATE TABLE PLANNING(
        idPlanning     Varchar (25) NOT NULL ,
        numUtilisateur Int NOT NULL ,
        PRIMARY KEY (idPlanning )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------

CREATE TABLE TYPE_STRUCTURE(
        codeTypeStructure    Int NOT NULL ,
        libelleTypeStructure Varchar (30) ,
        PRIMARY KEY (codeTypeStructure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------

CREATE TABLE PORTEFEUILLE(
        idPortefeuille      Int NOT NULL ,
        libellePortefeuille Varchar (30) ,
        numUtilisateur      Int NOT NULL ,
        PRIMARY KEY (idPortefeuille )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR_STRUCTURE
#------------------------------------------------------------

CREATE TABLE INTERLOCUTEUR_STRUCTURE(
        id_interlocuteur Int NOT NULL ,
        num_structure    Int NOT NULL ,
        PRIMARY KEY (id_interlocuteur ,num_structure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: CONGE_UTILISATEUR
#------------------------------------------------------------

CREATE TABLE CONGE_UTILISATEUR(
        numUtilisateur Int NOT NULL ,
        numConge       Int NOT NULL ,
        PRIMARY KEY (numUtilisateur ,numConge )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: SUIVRE
#------------------------------------------------------------

CREATE TABLE SUIVRE(
        id_rdv     Int NOT NULL ,
        id_rdv_RDV Int NOT NULL ,
        PRIMARY KEY (id_rdv ,id_rdv_RDV )
)ENGINE=InnoDB;

ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_codeTypeUtilisateur FOREIGN KEY (codeTypeUtilisateur) REFERENCES TYPE_UTILISATEUR(codeTypeUtilisateur);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_idPlanning FOREIGN KEY (idPlanning) REFERENCES PLANNING(idPlanning);
ALTER TABLE UTILISATEUR ADD CONSTRAINT FK_UTILISATEUR_idPortefeuille FOREIGN KEY (idPortefeuille) REFERENCES PORTEFEUILLE(idPortefeuille);
ALTER TABLE STRUCTURE ADD CONSTRAINT FK_STRUCTURE_codeTypeStructure FOREIGN KEY (codeTypeStructure) REFERENCES TYPE_STRUCTURE(codeTypeStructure);
ALTER TABLE INTERLOCUTEUR ADD CONSTRAINT FK_INTERLOCUTEUR_num_individu FOREIGN KEY (num_individu) REFERENCES PARTICULIER(num_individu);
ALTER TABLE INTERLOCUTEUR ADD CONSTRAINT FK_INTERLOCUTEUR_idPortefeuille FOREIGN KEY (idPortefeuille) REFERENCES PORTEFEUILLE(idPortefeuille);
ALTER TABLE PARTICULIER ADD CONSTRAINT FK_PARTICULIER_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_id_type_rdv FOREIGN KEY (id_type_rdv) REFERENCES TYPERDV(id_type_rdv);
ALTER TABLE RDV ADD CONSTRAINT FK_RDV_idPlanning FOREIGN KEY (idPlanning) REFERENCES PLANNING(idPlanning);
ALTER TABLE MAIL ADD CONSTRAINT FK_MAIL_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE MAIL ADD CONSTRAINT FK_MAIL_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE PLANNING ADD CONSTRAINT FK_PLANNING_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE PORTEFEUILLE ADD CONSTRAINT FK_PORTEFEUILLE_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE APPARTENIR ADD CONSTRAINT FK_APPARTENIR_id_interlocuteur FOREIGN KEY (id_interlocuteur) REFERENCES INTERLOCUTEUR(id_interlocuteur);
ALTER TABLE APPARTENIR ADD CONSTRAINT FK_APPARTENIR_num_structure FOREIGN KEY (num_structure) REFERENCES STRUCTURE(num_structure);
ALTER TABLE POSER ADD CONSTRAINT FK_POSER_numUtilisateur FOREIGN KEY (numUtilisateur) REFERENCES UTILISATEUR(numUtilisateur);
ALTER TABLE POSER ADD CONSTRAINT FK_POSER_numConge FOREIGN KEY (numConge) REFERENCES CONGES(numConge);
ALTER TABLE SUIVRE ADD CONSTRAINT FK_SUIVRE_id_rdv FOREIGN KEY (id_rdv) REFERENCES RDV(id_rdv);
ALTER TABLE SUIVRE ADD CONSTRAINT FK_SUIVRE_id_rdv_RDV FOREIGN KEY (id_rdv_RDV) REFERENCES RDV(id_rdv);
