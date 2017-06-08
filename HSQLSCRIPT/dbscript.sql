-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Lun 22 Mai 2017 à 13:26
-- Version du serveur :  10.1.13-MariaDB
-- Version de PHP :  5.5.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gepev`
--
CREATE DATABASE IF NOT EXISTS `gepev` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `gepev`;

-- --------------------------------------------------------

--
-- Structure de la table `conges`
--

CREATE TABLE `conges` (
  `numConge` int(11) NOT NULL,
  `dateDebutConge` date DEFAULT NULL,
  `dateFinConge` date DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `conges`
--

INSERT INTO `conges` (`numConge`, `dateDebutConge`, `dateFinConge`, `version`) VALUES
(1, '2017-06-05', '2017-05-15', 0),
(2, '2017-01-01', '2017-02-01', 0),
(3, '2017-08-01', '2017-09-01', 0);

-- --------------------------------------------------------

--
-- Structure de la table `conges_utilisateur`
--

CREATE TABLE `conges_utilisateur` (
  `idCongesUtilisateur` int(11) NOT NULL,
  `numUtilisateur` int(11) NOT NULL,
  `numConge` int(11) NOT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `conges_utilisateur`
--

INSERT INTO `conges_utilisateur` (`idCongesUtilisateur`, `numUtilisateur`, `numConge`, `version`) VALUES
(1, 1, 1, 0),
(2, 2, 2, 0),
(3, 2, 3, 0);

-- --------------------------------------------------------

--
-- Structure de la table `individu`
--

CREATE TABLE `individu` (
  `numIndividu` int(11) NOT NULL,
  `adresseIndividu` varchar(25) COLLATE utf8_bin NOT NULL,
  `cpIndividu` varchar(25) COLLATE utf8_bin NOT NULL,
  `villeIndividu` varchar(25) COLLATE utf8_bin NOT NULL,
  `distanceSiege` float NOT NULL,
  `infosSupplementaire` varchar(100) COLLATE utf8_bin NOT NULL,
  `idInterlocuteur` int(11) NOT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `individu`
--

INSERT INTO `individu` (`numIndividu`, `adresseIndividu`, `cpIndividu`, `villeIndividu`, `distanceSiege`, `infosSupplementaire`, `idInterlocuteur`, `version`) VALUES
(1, '4 rue Lacaze', '75014', 'Paris', 22, 'Digicode : 1234', 1, 0),
(2, '4 rue Lacaze', '75014', 'Paris', 22, 'Digicode : 1234', 4, 0),
(3, '45 Avenue Marx Dormoy', '92220', 'Bagneux', 22, '', 7, 0),
(4, '1 Rue du Dr le Savoureux', '92290', 'Châtenay-Malabry', 22, 'Etage : 3', 9, 0),
(5, '280 Avenue Jean Jaurès', '92290', 'Châtenay-Malabry', 22, '', 11, 0),
(6, '6 Rue du Luxembourg', '94320', 'Thiais', 22, '', 13, 0);

-- --------------------------------------------------------

--
-- Structure de la table `interlocuteur`
--

CREATE TABLE `interlocuteur` (
  `idInterlocuteur` int(11) NOT NULL,
  `nomInterlocuteur` varchar(25) COLLATE utf8_bin NOT NULL,
  `prenomInterlocuteur` varchar(25) COLLATE utf8_bin NOT NULL,
  `telInterlocuteur` varchar(25) COLLATE utf8_bin NOT NULL,
  `mailInterlocuteur` varchar(40) COLLATE utf8_bin NOT NULL,
  `idPorteFeuille` int(11) DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `interlocuteur`
--

INSERT INTO `interlocuteur` (`idInterlocuteur`, `nomInterlocuteur`, `prenomInterlocuteur`, `telInterlocuteur`, `mailInterlocuteur`, `idPorteFeuille`, `version`) VALUES
(1, 'Coutrot', 'Sylvain', '0665654696', 'yahoo@gmail.com', 1, 0),
(2, 'Delbe', 'Sebastien', '0665566496', 'delbe@outlook.fr', 1, 0),
(3, 'Dulong', 'Raphael', '0665566469', 'd.raph@hotmail.com', 1, 0),
(4, 'Duparc', 'Alexandre', '0665578469', 'alexduparc@free.fr', 2, 0),
(5, 'Patry', 'Lisa', '0675578469', 'lisap@wanadoo.fr', 2, 0),
(6, 'Barbotin', 'Victor', '0665878469', 'victorc75@outlook.fr', 2, 0),
(7, 'Dore', 'Louis', '0796578469', 'dorelouis@gmail.fr', 3, 0),
(8, 'Belliat', 'Eliot', '0674638469', 'eliotb@outlook.fr', 3, 0),
(9, 'Rodrigues', 'Damien', '0664968469', 'damienrodri@gmail.fr', 4, 0),
(10, 'Paka', 'Loic', '0675124469', 'pakaloic@outlook.fr', 4, 0),
(11, 'Goindin', 'Julien', '0785578464', 'juliengoindin@gmail.fr', 5, 0),
(12, 'Roussin', 'Christopher', '0685563469', 'chrisroussin@outlook.fr', 5, 0),
(13, 'Siba', 'Obertrant', '066514469', 'bilooby@gmail.fr', 6, 0),
(14, 'Mahloub', 'Rewan', '0678941257', 'rewan.m@outlook.fr', 6, 0);

-- --------------------------------------------------------

--
-- Structure de la table `interlocuteur_structure`
--

CREATE TABLE `interlocuteur_structure` (
  `idInterlocuteurStructure` int(11) NOT NULL,
  `idInterlocuteur` int(11) NOT NULL,
  `numStructure` int(11) NOT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `interlocuteur_structure`
--

INSERT INTO `interlocuteur_structure` (`idInterlocuteurStructure`, `idInterlocuteur`, `numStructure`, `version`) VALUES
(1, 2, 1, 0),
(2, 3, 2, 0),
(3, 5, 3, 0),
(4, 6, 4, 0),
(5, 8, 5, 0),
(6, 10, 6, 0),
(7, 12, 7, 0),
(8, 14, 8, 0);

-- --------------------------------------------------------

--
-- Structure de la table `mail`
--

CREATE TABLE `mail` (
  `numMail` int(11) NOT NULL,
  `contenuMail` varchar(10000) COLLATE utf8_bin DEFAULT NULL,
  `objetMail` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `numUtilisateur` int(11) NOT NULL,
  `idInterlocuteur` int(11) NOT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `mail`
--

INSERT INTO `mail` (`numMail`, `contenuMail`, `objetMail`, `numUtilisateur`, `idInterlocuteur`, `version`) VALUES
(1, 'Rappel de votre rendez-vous du 20/04/2017 à 10h00', 'Votre Rendez-vous', 1, 2, 0),
(2, 'Compte rendu de la réunion de ce jour, tout à été vu et clarifié.', 'Compte Rendu', 1, 2, 0),
(3, 'Rappel de votre rendez-vous du 25/04/2017 à 10h00', 'Votre Rendez-vous', 1, 2, 0),
(4, 'Rappel de votre rendez-vous du 12/05/2017 à 10h00', 'Votre Rendez-vous', 1, 3, 0),
(5, 'Rappel de votre rendez-vous du 02/05/2017 à 8h30', 'Votre Rendez-vous', 2, 4, 0),
(6, 'Compte rendu de la réunion de ce jour, tout à été vu et clarifié.', 'Compte Rendu', 2, 4, 0),
(7, 'Rappel de votre rendez-vous du 05/05/2017 à 8h30', 'Votre Rendez-vous', 2, 4, 0),
(8, 'Rappel de votre rendez-vous du 07/05/2017 à 8h30', 'Votre Rendez-vous', 2, 6, 0),
(9, 'Rappel de votre rendez-vous du 30/04/2017 à 8h00', 'Votre Rendez-vous', 5, 7, 0),
(10, 'Rappel de votre rendez-vous du 30/04/2017 à 16h00', 'Votre Rendez-vous', 5, 8, 0),
(11, 'Rappel de votre rendez-vous du 10/05/2017 à 14h30', 'Votre Rendez-vous', 6, 9, 0),
(12, 'Rappel de votre rendez-vous du 10/06/2017 à 8h00', 'Votre Rendez-vous', 6, 10, 0),
(13, 'Rappel de votre rendez-vous du 02/05/2017 à 8h30', 'Votre Rendez-vous', 7, 11, 0),
(14, 'Rappel de votre rendez-vous du 03/05/2017 à 8h30', 'Votre Rendez-vous', 7, 12, 0),
(15, 'Rappel de votre rendez-vous du 20/05/2017 à 8h30', 'Votre Rendez-vous', 8, 13, 0),
(16, 'Rappel de votre rendez-vous du 25/05/2017 à 14h30', 'Votre Rendez-vous', 8, 14, 0);

-- --------------------------------------------------------

--
-- Structure de la table `planning`
--

CREATE TABLE `planning` (
  `idPlanning` int(11) NOT NULL,
  `numUtilisateur` int(11) DEFAULT NULL,
  `libellePlanning` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `planning`
--

INSERT INTO `planning` (`idPlanning`, `numUtilisateur`, `libellePlanning`, `version`) VALUES
(1, 1, 'secteur 1', 0),
(2, 2, 'secteur 2', 0),
(3, 5, 'secteur 3', 0),
(4, 6, 'secteur 4', 0),
(5, 7, 'secteur 5', 0),
(6, 8, 'secteur 6', 0);

-- --------------------------------------------------------

--
-- Structure de la table `portefeuille`
--

CREATE TABLE `portefeuille` (
  `idPorteFeuille` int(11) NOT NULL,
  `libellePorteFeuille` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  `numUtilisateur` int(11) DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `portefeuille`
--

INSERT INTO `portefeuille` (`idPorteFeuille`, `libellePorteFeuille`, `numUtilisateur`, `version`) VALUES
(1, 'unportefeuille 1', 1, 0),
(2, 'unportefeuille 2', 2, 0),
(3, 'unportefeuille 3', 5, 0),
(4, 'unportefeuille 4', 6, 0),
(5, 'unportefeuille 5', 7, 0),
(6, 'unportefeuille 6', 8, 0);

-- --------------------------------------------------------

--
-- Structure de la table `rdv`
--

CREATE TABLE `rdv` (
  `idRdv` int(11) NOT NULL,
  `ObjetRdv` varchar(500) COLLATE utf8_bin,
  `DateDebut` datetime NOT NULL,
  `DateFin` datetime NOT NULL,
  `adresseDerogatoire` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `villeDerogatoire` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  `codeEntreeDerogatoire` int(11) DEFAULT NULL,
  `infoDerogatoire` varchar(500) COLLATE utf8_bin DEFAULT NULL,
  `idInterlocuteur` int(11) NOT NULL,
  `idTypeRdv` int(11) NOT NULL,
  `idPlanning` int(11) NOT NULL,
  `idRdvPrecedent` int(11) DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `rdv`
--

INSERT INTO `rdv` (`idRdv`, `ObjetRdv`, `DateDebut`, `DateFin`, `adresseDerogatoire`, `villeDerogatoire`, `codeEntreeDerogatoire`, `infoDerogatoire`, `idInterlocuteur`, `idTypeRdv`, `idPlanning`, `idRdvPrecedent`, `version`) VALUES
(1, 'Un RDV', '2017-06-20 10:00:00', '2017-06-20 12:00:00', '2 avenue de la Sibelle', 'Paris', NULL, NULL, 2, 1, 1, NULL, 0),
(2, 'Un RDV', '2017-06-25 10:00:00', '2017-06-25 12:00:00', '12 avenue de la Sibelle', 'Paris', NULL, NULL, 2, 5, 1, 1, 0),
(3, 'Un RDV', '2017-06-12 10:00:00', '2017-06-12 12:00:00', '3 rue du Fort 92130 Issy-les-Moulineaux', 'Issy-les-Moulineaux', 17896, NULL, 3, 1, 1, NULL, 0),
(4, 'Un RDV', '2017-06-02 10:00:00', '2017-06-02 12:00:00', '14 avenue de la Sibelle', 'Paris', NULL, NULL, 4, 1, 2, NULL, 0),
(5, 'Un RDV', '2017-06-05 10:00:00', '2017-06-05 12:00:00', '2 avenue rene coty', 'Paris', NULL, NULL, 4, 5, 2, 4, 0),
(6, 'Un RDV', '2017-06-07 10:00:00', '2017-06-07 12:00:00', '24 rue de Sèvres 75007 Paris', 'Paris', NULL, 'Appeler à votre arrivée', 6, 1, 2, NULL, 0),
(7, 'Un RDV', '2017-06-10 10:00:00', '2017-06-10 12:00:00', '4 rue de la glaciere', 'Paris', NULL, NULL, 9, 3, 4, NULL, 0),
(8, 'Un RDV', '2017-06-30 10:00:00', '2017-06-30 12:00:00', '8 rue du pere corentin', 'Paris', NULL, NULL, 8, 2, 3, NULL, 0),
(9, 'Un RDV', '2017-06-02 10:00:00', '2017-06-02 12:00:00', '2 rue lacaze', 'Paris', NULL, NULL, 11, 2, 5, NULL, 0),
(10, 'Un RDV', '2017-06-03 10:00:00', '2017-06-03 12:00:00', '5 rue alesia', 'Paris', NULL, NULL, 12, 3, 5, NULL, 0),
(11, 'Un RDV', '2017-06-20 10:00:00', '2017-06-20 12:00:00', '3 boulevard jourdan', 'Paris', NULL, NULL, 13, 1, 6, NULL, 0),
(12, 'Un RDV', '2017-06-25 10:00:00', '2017-06-25 12:00:00', '6 rue des plantes', 'Paris', NULL, NULL, 14, 4, 6, NULL, 0);

-- --------------------------------------------------------

--
-- Structure de la table `structure`
--

CREATE TABLE `structure` (
  `numStructure` int(11) NOT NULL,
  `denominationSociale` varchar(25) COLLATE utf8_bin NOT NULL,
  `adresseStructure` varchar(25) COLLATE utf8_bin NOT NULL,
  `cpStructure` varchar(25) COLLATE utf8_bin NOT NULL,
  `villeStructure` varchar(25) COLLATE utf8_bin NOT NULL,
  `distanceSiege` float NOT NULL,
  `infoSupplementaire` varchar(100) COLLATE utf8_bin NOT NULL,
  `codeTypeStructure` int(11) NOT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `structure`
--

INSERT INTO `structure` (`numStructure`, `denominationSociale`, `adresseStructure`, `cpStructure`, `villeStructure`, `distanceSiege`, `infoSupplementaire`, `codeTypeStructure`, `version`) VALUES
(1, 'POL plongee', '13 rue de l`Ormeteau', '91420', 'Morangis', 15, 'Association de plongee', 3, 0),
(2, 'Natixis', '4 allee de St Genouf', '91360', 'Villemoisson-sur-Orge', 25, 'Société boursière', 5, 0),
(3, 'EDF', '3 rue de la Garenne', '91360', 'Villemoisson-sur-Orge', 13, '', 5, 0),
(4, '30 millions de copains', '18 rue des Martyrs', '75009', 'Paris', 27, 'Association de rencontre de vieux copains', 2, 0),
(5, 'Créteil Soleil', 'Avenue de la France libre', '94000', 'Créteil', 8, 'Centre Commercial', 1, 0),
(6, 'Decathlon Creteil', 'Carrefour Pompadour', '94000', 'Créteil', 16, 'Magasin de sport', 1, 0),
(7, 'Université Paris-Est Marn', '5 Boulevard Descartes', '77420', 'Champs-sur-Marne', 40, 'Université', 2, 0),
(8, 'Hotel du Chateau', '1 Rue Robert Giraudineau', '94300', 'Vincennes', 19, '', 4, 0);

-- --------------------------------------------------------

--
-- Structure de la table `type_rdv`
--

CREATE TABLE `type_rdv` (
  `idTypeRdv` int(11) NOT NULL,
  `libelleTypeRdv` varchar(40) COLLATE utf8_bin NOT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `type_rdv`
--

INSERT INTO `type_rdv` (`idTypeRdv`, `libelleTypeRdv`, `version`) VALUES
(1, 'Premiere Rencontre', 0),
(2, 'Rendez vous telephonique', 0),
(3, 'Presentation', 0),
(4, 'Visite de courtoisie', 0),
(5, 'Visiste technique', 0),
(6, 'Conclusion', 0);

-- --------------------------------------------------------

--
-- Structure de la table `type_structure`
--

CREATE TABLE `type_structure` (
  `codeTypeStructure` int(11) NOT NULL,
  `libelleTypeStructure` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `type_structure`
--

INSERT INTO `type_structure` (`codeTypeStructure`, `libelleTypeStructure`, `version`) VALUES
(1, 'Organisation', 0),
(2, 'Association', 0),
(3, 'Ligue', 0),
(4, 'PME', 0),
(5, 'Grande entreprise', 0);

-- --------------------------------------------------------

--
-- Structure de la table `type_utilisateur`
--

CREATE TABLE `type_utilisateur` (
  `codeTypeUtilisateur` int(11) NOT NULL,
  `libelleTypeUtilisateur` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `type_utilisateur`
--

INSERT INTO `type_utilisateur` (`codeTypeUtilisateur`, `libelleTypeUtilisateur`, `version`) VALUES
(1, 'administrateur', 0),
(2, 'Gestionnaire', 0),
(3, 'Commercial', 0);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `numUtilisateur` int(11) NOT NULL,
  `nomUtilisateur` varchar(25) COLLATE utf8_bin NOT NULL,
  `prenomUtilisateur` varchar(25) COLLATE utf8_bin NOT NULL,
  `adresseUtilisateur` varchar(25) COLLATE utf8_bin NOT NULL,
  `cpUtilisateur` varchar(25) COLLATE utf8_bin NOT NULL,
  `villeUtilisateur` varchar(25) COLLATE utf8_bin NOT NULL,
  `telUtilisateur` varchar(25) COLLATE utf8_bin NOT NULL,
  `mailUtilisateur` varchar(40) COLLATE utf8_bin NOT NULL,
  `distanceParcourueSemaine` int(11) DEFAULT NULL,
  `loginUtilisateur` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  `passwordUtilisateur` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `dateDernierLogin` datetime DEFAULT NULL,
  `nbTentatives` int(11) DEFAULT NULL,
  `codeTypeUtilisateur` int(11) NOT NULL,
  `idPlanning` int(11) DEFAULT NULL,
  `idPorteFeuille` int(11) DEFAULT NULL,
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`numUtilisateur`, `nomUtilisateur`, `prenomUtilisateur`, `adresseUtilisateur`, `cpUtilisateur`, `villeUtilisateur`, `telUtilisateur`, `mailUtilisateur`, `distanceParcourueSemaine`, `loginUtilisateur`, `passwordUtilisateur`, `dateDernierLogin`, `nbTentatives`, `codeTypeUtilisateur`, `idPlanning`, `idPorteFeuille`, `version`) VALUES
(1, 'Sailly', 'Axelle', '2 allée de St Genouf', '91360', 'Villemoisson-sur-Orge', '0665564696', 'saillyaxelle@hotmail.fr', 0, 'axelles', '827ccb0eea8a706c4c34a16891f84e7b', '2017-04-24 00:00:00', 0, 3, 1, 1, 0),
(2, 'Canavaggio', 'Lorenzo', '9 rue Joliot Curie', '91160', 'Saulx-les-Chartreux', '0665564669', 'abc.xyz@hotmail.fr', 0, 'lorenzoc', '827ccb0eea8a706c4c34a16891f84e7b', '2017-03-26 00:00:00', 0, 3, 2, 2, 0),
(3, 'Roberto', 'Benedicte', '2 rue Lacaze', '75014', 'Paris', '0656564696', 'bene75@gmail.com', 0, 'benedicter', '827ccb0eea8a706c4c34a16891f84e7b', '2017-04-16 00:00:00', 0, 2, NULL, NULL, 0),
(4, 'Lhullier', 'Jesse', '16 avenue Morane Saulnier', '78140', 'Vélizy-Villacoublay', '0756564696', 'jesse.lhullier@yahoo.com', 0, 'jessel', '827ccb0eea8a706c4c34a16891f84e7b', '2017-02-15 00:00:00', 0, 1, NULL, NULL, 0),
(5, 'Morel', 'Hugo', '8 Place Charost', '78000', 'Versailles', '0665936694', 'xyz.abc@outlook.fr', 0, 'hugom', '827ccb0eea8a706c4c34a16891f84e7b', '2017-04-11 00:00:00', 0, 3, 3, 3, 0),
(6, 'Caillet', 'Quentin', '41 Rue Pasteur', '92210', 'Saint-Cloud', '0665567649', 'caillet.quentin@outlook.fr', 0, 'quentinc', '827ccb0eea8a706c4c34a16891f84e7b', '2017-04-25 00:00:00', 0, 3, 4, 4, 0),
(7, 'Charrier', 'Sebastien', '24 Rue du Commandant Guil', '75016', 'Paris', '0765567869', 'sebcharrier@yahoo.com', 0, 'sebastienc', '827ccb0eea8a706c4c34a16891f84e7b', '2017-03-30 00:00:00', 0, 3, 5, 5, 0),
(8, 'Bihich', 'Yosra', '6 Avenue de la République', '92320', 'Châtillon', '0664631669', 'yosra92@gmail.com', 0, 'yosrab', '827ccb0eea8a706c4c34a16891f84e7b', '2017-04-24 00:00:00', 0, 3, 6, 6, 0);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `conges`
--
ALTER TABLE `conges`
  ADD PRIMARY KEY (`numConge`);

--
-- Index pour la table `conges_utilisateur`
--
ALTER TABLE `conges_utilisateur`
  ADD PRIMARY KEY (`idCongesUtilisateur`),
  ADD KEY `FK_CONGES_UTILISATEUR_numUtilisateur` (`numUtilisateur`),
  ADD KEY `FK_CONGES_UTILISATEUR_numConge` (`numConge`);

--
-- Index pour la table `individu`
--
ALTER TABLE `individu`
  ADD PRIMARY KEY (`numIndividu`),
  ADD KEY `FK_INDIVIDU_idInterlocuteur` (`idInterlocuteur`);

--
-- Index pour la table `interlocuteur`
--
ALTER TABLE `interlocuteur`
  ADD PRIMARY KEY (`idInterlocuteur`),
  ADD KEY `FK_INTERLOCUTEUR_idPorteFeuille` (`idPorteFeuille`);

--
-- Index pour la table `interlocuteur_structure`
--
ALTER TABLE `interlocuteur_structure`
  ADD PRIMARY KEY (`idInterlocuteurStructure`),
  ADD KEY `FK_INTERLOCUTEUR_STRUCTURE_idInterlocuteur` (`idInterlocuteur`),
  ADD KEY `FK_INTERLOCUTEUR_STRUCTURE_numStructure` (`numStructure`);

--
-- Index pour la table `mail`
--
ALTER TABLE `mail`
  ADD PRIMARY KEY (`numMail`),
  ADD KEY `FK_MAIL_numUtilisateur` (`numUtilisateur`),
  ADD KEY `FK_MAIL_idInterlocuteur` (`idInterlocuteur`);

--
-- Index pour la table `planning`
--
ALTER TABLE `planning`
  ADD PRIMARY KEY (`idPlanning`),
  ADD KEY `FK_PLANNING_numUtilisateur` (`numUtilisateur`);

--
-- Index pour la table `portefeuille`
--
ALTER TABLE `portefeuille`
  ADD PRIMARY KEY (`idPorteFeuille`),
  ADD KEY `FK_PORTEFEUILLE_numUtilisateur` (`numUtilisateur`);

--
-- Index pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD PRIMARY KEY (`idRdv`),
  ADD KEY `FK_RDV_idInterlocuteur` (`idInterlocuteur`),
  ADD KEY `FK_RDV_idTypeRdv` (`idTypeRdv`),
  ADD KEY `FK_RDV_idPlanning` (`idPlanning`),
  ADD KEY `FK_RDV_idRdvPrecedent` (`idRdvPrecedent`);

--
-- Index pour la table `structure`
--
ALTER TABLE `structure`
  ADD PRIMARY KEY (`numStructure`),
  ADD KEY `FK_STRUCTURE_codeTypeStructure` (`codeTypeStructure`);

--
-- Index pour la table `type_rdv`
--
ALTER TABLE `type_rdv`
  ADD PRIMARY KEY (`idTypeRdv`);

--
-- Index pour la table `type_structure`
--
ALTER TABLE `type_structure`
  ADD PRIMARY KEY (`codeTypeStructure`);

--
-- Index pour la table `type_utilisateur`
--
ALTER TABLE `type_utilisateur`
  ADD PRIMARY KEY (`codeTypeUtilisateur`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`numUtilisateur`),
  ADD KEY `FK_UTILISATEUR_codeTypeUtilisateur` (`codeTypeUtilisateur`),
  ADD KEY `FK_UTILISATEUR_idPlanning` (`idPlanning`),
  ADD KEY `FK_UTILISATEUR_idPorteFeuille` (`idPorteFeuille`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `conges`
--
ALTER TABLE `conges`
  MODIFY `numConge` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `conges_utilisateur`
--
ALTER TABLE `conges_utilisateur`
  MODIFY `idCongesUtilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `individu`
--
ALTER TABLE `individu`
  MODIFY `numIndividu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `interlocuteur`
--
ALTER TABLE `interlocuteur`
  MODIFY `idInterlocuteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT pour la table `interlocuteur_structure`
--
ALTER TABLE `interlocuteur_structure`
  MODIFY `idInterlocuteurStructure` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `mail`
--
ALTER TABLE `mail`
  MODIFY `numMail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT pour la table `planning`
--
ALTER TABLE `planning`
  MODIFY `idPlanning` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `portefeuille`
--
ALTER TABLE `portefeuille`
  MODIFY `idPorteFeuille` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `rdv`
--
ALTER TABLE `rdv`
  MODIFY `idRdv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT pour la table `structure`
--
ALTER TABLE `structure`
  MODIFY `numStructure` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `type_rdv`
--
ALTER TABLE `type_rdv`
  MODIFY `idTypeRdv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `type_structure`
--
ALTER TABLE `type_structure`
  MODIFY `codeTypeStructure` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT pour la table `type_utilisateur`
--
ALTER TABLE `type_utilisateur`
  MODIFY `codeTypeUtilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `numUtilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `conges_utilisateur`
--
ALTER TABLE `conges_utilisateur`
  ADD CONSTRAINT `FK_CONGES_UTILISATEUR_numConge` FOREIGN KEY (`numConge`) REFERENCES `conges` (`numConge`),
  ADD CONSTRAINT `FK_CONGES_UTILISATEUR_numUtilisateur` FOREIGN KEY (`numUtilisateur`) REFERENCES `utilisateur` (`numUtilisateur`);

--
-- Contraintes pour la table `individu`
--
ALTER TABLE `individu`
  ADD CONSTRAINT `FK_INDIVIDU_idInterlocuteur` FOREIGN KEY (`idInterlocuteur`) REFERENCES `interlocuteur` (`idInterlocuteur`);

--
-- Contraintes pour la table `interlocuteur`
--
ALTER TABLE `interlocuteur`
  ADD CONSTRAINT `FK_INTERLOCUTEUR_idPorteFeuille` FOREIGN KEY (`idPorteFeuille`) REFERENCES `portefeuille` (`idPorteFeuille`);

--
-- Contraintes pour la table `interlocuteur_structure`
--
ALTER TABLE `interlocuteur_structure`
  ADD CONSTRAINT `FK_INTERLOCUTEUR_STRUCTURE_idInterlocuteur` FOREIGN KEY (`idInterlocuteur`) REFERENCES `interlocuteur` (`idInterlocuteur`),
  ADD CONSTRAINT `FK_INTERLOCUTEUR_STRUCTURE_numStructure` FOREIGN KEY (`numStructure`) REFERENCES `structure` (`numStructure`);

--
-- Contraintes pour la table `mail`
--
ALTER TABLE `mail`
  ADD CONSTRAINT `FK_MAIL_idInterlocuteur` FOREIGN KEY (`idInterlocuteur`) REFERENCES `interlocuteur` (`idInterlocuteur`),
  ADD CONSTRAINT `FK_MAIL_numUtilisateur` FOREIGN KEY (`numUtilisateur`) REFERENCES `utilisateur` (`numUtilisateur`);

--
-- Contraintes pour la table `planning`
--
ALTER TABLE `planning`
  ADD CONSTRAINT `FK_PLANNING_numUtilisateur` FOREIGN KEY (`numUtilisateur`) REFERENCES `utilisateur` (`numUtilisateur`);

--
-- Contraintes pour la table `portefeuille`
--
ALTER TABLE `portefeuille`
  ADD CONSTRAINT `FK_PORTEFEUILLE_numUtilisateur` FOREIGN KEY (`numUtilisateur`) REFERENCES `utilisateur` (`numUtilisateur`);

--
-- Contraintes pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD CONSTRAINT `FK_RDV_idInterlocuteur` FOREIGN KEY (`idInterlocuteur`) REFERENCES `interlocuteur` (`idInterlocuteur`),
  ADD CONSTRAINT `FK_RDV_idPlanning` FOREIGN KEY (`idPlanning`) REFERENCES `planning` (`idPlanning`),
  ADD CONSTRAINT `FK_RDV_idRdvPrecedent` FOREIGN KEY (`idRdvPrecedent`) REFERENCES `rdv` (`idRdv`),
  ADD CONSTRAINT `FK_RDV_idTypeRdv` FOREIGN KEY (`idTypeRdv`) REFERENCES `type_rdv` (`idTypeRdv`);

--
-- Contraintes pour la table `structure`
--
ALTER TABLE `structure`
  ADD CONSTRAINT `FK_STRUCTURE_codeTypeStructure` FOREIGN KEY (`codeTypeStructure`) REFERENCES `type_structure` (`codeTypeStructure`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `FK_UTILISATEUR_codeTypeUtilisateur` FOREIGN KEY (`codeTypeUtilisateur`) REFERENCES `type_utilisateur` (`codeTypeUtilisateur`),
  ADD CONSTRAINT `FK_UTILISATEUR_idPlanning` FOREIGN KEY (`idPlanning`) REFERENCES `planning` (`idPlanning`),
  ADD CONSTRAINT `FK_UTILISATEUR_idPorteFeuille` FOREIGN KEY (`idPorteFeuille`) REFERENCES `portefeuille` (`idPorteFeuille`);

#------------------------------------------------------------
# EVENEMENT: Efface la DistanceParcourueSemaine Tous les lundis
#------------------------------------------------------------
SET GLOBAL event_scheduler = 1 ;
DELETE FROM mysql.event WHERE db = 'gepev';
	
CREATE EVENT resetDistanceParcourueSemaine
    ON SCHEDULE
      EVERY 1 WEEK
	  STARTS CURRENT_DATE + INTERVAL 0 - WEEKDAY(CURRENT_DATE) DAY
    DO
      UPDATE gepev.utilisateur SET DistanceParcourueSemaine = 0;
	  
	  
	
	/* http://stackoverflow.com/questions/25548379/schedule-mysql-event-to-run-every-chosen-day-of-the-week */
  
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
