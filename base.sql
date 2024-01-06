psql -U postgres
postgresl2

CREATE USER dentiste WITH PASSWORD 'dentiste';
CREATE DATABASE dentiste;
GRANT ALL PRIVILEGES ON DATABASE dentiste to dentiste;

/* Table dent */
CREATE TABLE Dent(
   idDent VARCHAR(15) PRIMARY KEY,
   position numeric,
   emplacement VARCHAR(20));

/* Table client */
CREATE TABLE Client(
 idClient VARCHAR(20) PRIMARY KEY);

/* Table dentClient */
CREATE TABLE DentClient(
 idDentClient VARCHAR(25) PRIMARY KEY,
 idDent VARCHAR(15),
 idClient VARCHAR(20),
 noteIndividuel numeric,
 FOREIGN KEY(idDent) REFERENCES Dent(idDent),
 FOREIGN KEY(idClient) REFERENCES Client(idClient));

/* Table tarif */
CREATE TABLE Tarif(
 idTarif VARCHAR(20) PRIMARY KEY,
 idDent VARCHAR(15),
 tarifOperation REAL,
 tarifRemplacement REAL,
 FOREIGN KEY(idDent) REFERENCES Dent(idDent));

/* Table TypeOperation */
CREATE TABLE TypeOperation(
 idTypeOperation VARCHAR(20) PRIMARY KEY,
 nomTypeOperation VARCHAR(50));

/* Table Operation */
CREATE TABLE Operation(
 idOperation VARCHAR(20) PRIMARY KEY,
 idTypeOperation VARCHAR(20),
 idClient VARCHAR(20),
 dateOperation DATE,
 prixTotalOperation REAL,
 FOREIGN KEY(idClient) REFERENCES Client(idClient),
 FOREIGN KEY(idTypeOperation) REFERENCES TypeOperation(idTypeOperation));

