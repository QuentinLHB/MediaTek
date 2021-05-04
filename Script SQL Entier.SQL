DROP DATABASE IF EXISTS MediaTek;

CREATE DATABASE IF NOT EXISTS MediaTek;
CREATE USER 'admin'@'%' IDENTIFIED BY 'mdpadmin';
GRANT USAGE ON *.* TO 'admin'@'%';
GRANT ALL PRIVILEGES ON `mediatek`.* TO 'admin'@'%';
USE MediaTek;
# -----------------------------------------------------------------------------
#       TABLE : ABSENCE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ABSENCE
 (
   IDPERSONNEL INTEGER(2) NOT NULL  ,
   DATEDEBUT DATETIME NOT NULL  ,
   IDMOTIF INTEGER(2) NOT NULL  ,
   DATEFIN DATETIME NULL  
   , PRIMARY KEY (IDPERSONNEL,DATEDEBUT) 
 ) ENGINE = InnoDB
 comment = "";



# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ABSENCE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ABSENCE_MOTIF
     ON ABSENCE (IDMOTIF ASC);

CREATE  INDEX I_FK_ABSENCE_PERSONNEL
     ON ABSENCE (IDPERSONNEL ASC);



# -----------------------------------------------------------------------------
#       TABLE : MOTIF
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MOTIF
 (
   IDMOTIF INTEGER(2) NOT NULL AUTO_INCREMENT ,
   LIBELLE VARCHAR(128) NULL  
   , PRIMARY KEY (IDMOTIF) 
 ) ENGINE = InnoDB
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SERVICE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SERVICE
 (
   IDSERVICE INTEGER(2) NOT NULL AUTO_INCREMENT ,
   NOM VARCHAR(50) NULL  
   , PRIMARY KEY (IDSERVICE) 
 ) ENGINE = InnoDB
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PERSONNEL
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERSONNEL
 (
   IDPERSONNEL INTEGER(2) NOT NULL AUTO_INCREMENT ,
   IDSERVICE INTEGER(2) NOT NULL  ,
   NOM VARCHAR(50) NULL  ,
   PRENOM VARCHAR(50) NULL  ,
   TEL VARCHAR(15) NULL  ,
   MAIL VARCHAR(128) NULL  
   , PRIMARY KEY (IDPERSONNEL) 
 ) ENGINE = InnoDB
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE PERSONNEL
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_PERSONNEL_SERVICE
     ON PERSONNEL (IDSERVICE ASC);

# -----------------------------------------------------------------------------
#       TABLE RESPONSABLE
# -----------------------------------------------------------------------------
CREATE TABLE responsable(
    login varchar(64),
    pwd varchar(64)
    ) ENGINE = InnoDB ;

# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE ABSENCE 
  ADD FOREIGN KEY FK_ABSENCE_MOTIF (IDMOTIF)
      REFERENCES MOTIF (IDMOTIF) ;


ALTER TABLE ABSENCE 
  ADD FOREIGN KEY FK_ABSENCE_PERSONNEL (IDPERSONNEL)
      REFERENCES PERSONNEL (IDPERSONNEL) ;


ALTER TABLE PERSONNEL 
  ADD FOREIGN KEY FK_PERSONNEL_SERVICE (IDSERVICE)
      REFERENCES SERVICE (IDSERVICE) ;


# -----------------------------------------------------------------------------
#       REMPLISSAGE DES TABLES
# -----------------------------------------------------------------------------

INSERT INTO responsable (login, pwd)
VALUES ("quentinlhb", SHA2("pwdbdd", 256)) ;

INSERT INTO motif(libelle) 
VALUES ("Vacances"), ("Maladie"), ("Motif familial"), ("Congé parental") ;

INSERT INTO service (nom)
VALUES ("Administratif"), ("Médiation culturelle"), ("Prêt") ;

INSERT INTO `personnel` (`nom`,`prenom`,`tel`,`mail`, `idservice`)  
VALUES ("Dale","Philip","01 01 89 33 57","natoque.penatibus.et@erat.net", 1),("Shepherd","Xavier","07 99 58 47 70","dolor@cubiliaCuraeDonec.org", 1),("Patton","Ryan","08 32 26 02 30","In.condimentum.Donec@Vivamuseuismod.edu", 3),("Justice","Yuli","08 62 25 96 98","orci.Donec@Sednulla.org", 1),("Bryant","Todd","03 45 54 97 31","sociis.natoque.penatibus@arcuCurabiturut.edu", 2),("Levy","Wayne","05 81 60 54 38","ipsum.Suspendisse@ascelerisque.net", 2),("Soto","Adam","02 61 87 52 59","sagittis@odio.org", 2),("Simmons","Odysseus","08 88 77 15 91","hendrerit.id@Aeneangravida.ca", 2),("Garrett","Lyle","01 70 77 07 45","Duis@sodalesMaurisblandit.org", 3),("Wolfe","Lance","09 18 26 42 07","non.arcu@facilisis.com", 3);

INSERT INTO `absence` (`datedebut`,`datefin`,`idpersonnel`,`idmotif`) 
VALUES ("2020-09-16","2021-06-20","1","1"),("2020-03-26","2022-03-20","1","1"),("2019-07-25","2020-10-04","1","1"),("2019-08-23","2021-11-08","2","1"),("2020-07-13","2021-09-14","2","2"),("2019-01-15","2021-03-29","2","2"),("2019-07-21","2021-10-15","3","2"),("2021-02-22","2020-09-10","3","2"),("2021-01-02","2021-01-23","3","3"),("2020-07-10","2022-03-27","4","3"),("2020-01-31","2020-06-08","4","3"),("2020-11-12","2020-04-25","4","3"),("2020-06-17","2020-12-03","5","4"),("2020-07-21","2020-10-15","5","4"),("2020-01-24","2022-03-24","5","4"),("2019-01-19","2021-03-29","6","4"),("2021-01-25","2020-09-01","6","1"),("2020-11-29","2020-12-16","6","1"),("2019-10-22","2021-10-01","7","1"),("2020-12-06","2020-06-23","7","1"),("2019-08-15","2021-06-04","7","2"),("2019-03-19","2020-08-19","8","2"),("2019-11-09","2021-01-15","8","2"),("2020-09-10","2021-03-24","8","2"),("2021-01-25","2022-02-27","9","3"),("2019-04-08","2022-03-28","9","3"),("2019-10-20","2020-12-12","9","3"),("2020-08-25","2022-03-02","10","3"),("2020-06-27","2021-06-07","10","4"),("2021-03-12","2021-02-12","10","4");

