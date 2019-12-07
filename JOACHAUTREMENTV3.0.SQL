DROP DATABASE IF EXISTS JoachAutrement;

CREATE DATABASE IF NOT EXISTS JoachAutrement DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE JoachAutrement;
# -----------------------------------------------------------------------------
#       TABLE : TYPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE
 (
   IDT INTEGER NOT NULL AUTO_INCREMENT ,
   LIBELLET CHAR(32) NULL  
   , PRIMARY KEY (IDT) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEUR
 (
   IDU INTEGER NOT NULL AUTO_INCREMENT ,
   IDC INTEGER NULL  ,
   IDP INTEGER NOT NULL  ,
   NOMU CHAR(32) NULL  ,
   PRENOMU CHAR(32) NULL  ,
   LOGINU CHAR(32) NULL  ,
   MDPU CHAR(32) NULL  ,
   VALIDE BOOL NULL  
   , PRIMARY KEY (IDU) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE UTILISATEUR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_UTILISATEUR_CLASSE
     ON UTILISATEUR (IDC ASC);

CREATE  INDEX I_FK_UTILISATEUR_PERMISSION
     ON UTILISATEUR (IDP ASC);

# -----------------------------------------------------------------------------
#       TABLE : DATEJOACH
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DATEJOACH
 (
   IDD INTEGER NOT NULL AUTO_INCREMENT ,
   DATEEVENEMENT DATE NULL  ,
   ESTINSCRITPROF BOOL NOT NULL DEFAULT 0 ,
   ESTINSCRITELEVE BOOL NOT NULL DEFAULT 0  ,
   MATIN BOOL NOT NULL DEFAULT 0  ,
   APRESMIDI BOOL NOT NULL DEFAULT 0  
   , PRIMARY KEY (IDD) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PERMISSION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERMISSION
 (
   IDP INTEGER NOT NULL  ,
   LIBELLEP CHAR(32) NULL  
   , PRIMARY KEY (IDP) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : INTERVENANT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS INTERVENANT
 (
   IDI INTEGER NOT NULL AUTO_INCREMENT ,
   NOMI CHAR(32) NULL  ,
   PRENOMI CHAR(32) NULL  ,
   PROFESSIONI VARCHAR(128) NULL  ,
   EXTERIEUR BOOL NULL  
   , PRIMARY KEY (IDI) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CLASSE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLASSE
 (
   IDC INTEGER NOT NULL AUTO_INCREMENT ,
   LIBELLEC VARCHAR(128) NULL  
   , PRIMARY KEY (IDC) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ACTIVITE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ACTIVITE
 (
   IDA INTEGER NOT NULL AUTO_INCREMENT ,
   IDD INTEGER NULL  ,
   IDT INTEGER NOT NULL  ,
   LIBELLEA VARCHAR(128) NULL  ,
   DESCRIPTIONA TEXT NULL  ,
   HEUREDEBUTA TIME NULL  ,
   HEUREFINA TIME NULL  ,
   NBPLACEA BIGINT(3) NULL  ,
   SALLE VARCHAR(255) NULL  ,
   CODEA CHAR(32) NULL  ,
   ENTETEDESCRIPTIONA TEXT NULL  ,
   RESTRICTION TEXT NULL  
   , PRIMARY KEY (IDA) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ACTIVITE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ACTIVITE_DATEJOACH
     ON ACTIVITE (IDD ASC);

CREATE  INDEX I_FK_ACTIVITE_TYPE
     ON ACTIVITE (IDT ASC);

# -----------------------------------------------------------------------------
#       TABLE : INSCRIT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS INSCRIT
 (
   IDU INTEGER NOT NULL  ,
   IDA INTEGER NOT NULL  
   , PRIMARY KEY (IDU,IDA) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE INSCRIT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_INSCRIT_UTILISATEUR
     ON INSCRIT (IDU ASC);

CREATE  INDEX I_FK_INSCRIT_ACTIVITE
     ON INSCRIT (IDA ASC);

# -----------------------------------------------------------------------------
#       TABLE : ANIME
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ANIME
 (
   IDI INTEGER NOT NULL  ,
   IDA INTEGER NOT NULL  
   , PRIMARY KEY (IDI,IDA) 
 )  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ANIME
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ANIME_INTERVENANT
     ON ANIME (IDI ASC);

CREATE  INDEX I_FK_ANIME_ACTIVITE
     ON ANIME (IDA ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE UTILISATEUR 
  ADD FOREIGN KEY FK_UTILISATEUR_CLASSE (IDC)
      REFERENCES CLASSE (IDC) ;


ALTER TABLE UTILISATEUR 
  ADD FOREIGN KEY FK_UTILISATEUR_PERMISSION (IDP)
      REFERENCES PERMISSION (IDP) ;

ALTER TABLE ACTIVITE 
  ADD FOREIGN KEY FK_ACTIVITE_TYPE (IDT)
      REFERENCES TYPE (IDT) ;


ALTER TABLE INSCRIT 
  ADD FOREIGN KEY FK_INSCRIT_UTILISATEUR (IDU)
      REFERENCES UTILISATEUR (IDU) ;


ALTER TABLE INSCRIT 
  ADD FOREIGN KEY FK_INSCRIT_ACTIVITE (IDA)
      REFERENCES ACTIVITE (IDA) ;


ALTER TABLE ANIME 
  ADD FOREIGN KEY FK_ANIME_INTERVENANT (IDI)
      REFERENCES INTERVENANT (IDI) ;


ALTER TABLE ANIME 
  ADD FOREIGN KEY FK_ANIME_ACTIVITE (IDA)
      REFERENCES ACTIVITE (IDA) ;

CREATE VIEW activite_concat (IDA, IDT, CODEA, LibelleA, DescriptionA,HeureDebutA, HeureFinA, NbPlaceA, Salle, EntetedescriptionA, Restriction) AS
SELECT IDA, IDT, CODEA, LIBELLEA, DESCRIPTIONA,TIMESTAMP(DATEEVENEMENT,HEUREDEBUTA),TIMESTAMP(DATEEVENEMENT,HEUREFINA), NBPLACEA, SALLE, ENTETEDESCRIPTIONA, RESTRICTION
FROM activite as a INNER JOIN DateJoach as d ON a.IDD = d.IDD;

INSERT INTO `type` (`IDT`, `LIBELLET`) VALUES
(1, 'Atelier'),
(2, 'Conférence'),
(3, 'Spectacle'),
(4, 'Exposition');

INSERT INTO `permission` (`IDP`, `LIBELLEP`) VALUES
(1, 'Eleve'),
(2, 'Professeur'),
(3, 'Impression'),
(4, 'Organisateur'),
(5, 'Administrateur');

INSERT INTO  `joachautrement`.`utilisateur` (`IDU` ,`IDC` ,`IDP` ,`NOMU` ,`PRENOMU` ,`LOGINU` ,`MDPU` ,`VALIDE`)
VALUES (NULL , NULL ,  '5',  'admin',  'admin',  'admin',  'P@ssw0rd', NULL);

GRANT ALL PRIVILEGES ON JoachAutrement.* TO 'admin' IDENTIFIED BY 'mot_de_passe';
SET PASSWORD FOR 'admin'@'%' = PASSWORD('10dp100DR');