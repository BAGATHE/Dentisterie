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

INSERT INTO Dent (idDent, position, emplacement) VALUES
   ('DH_1', 1, 'haut'),('DH_2', 2, 'haut'),('DH_3', 3, 'haut'),('DH_4', 4, 'haut'),
   ('DH_5', 5, 'haut'),('DH_6', 6, 'haut'),('DH_7', 7, 'haut'),('DH_8', 8, 'haut'),
   ('DH_9', 9, 'haut'),('DH_10', 10, 'haut'),('DH_11', 11, 'haut'),('DH_12', 12, 'haut'),
   ('DH_13', 13, 'haut'),('DH_14', 14, 'haut'),('DH_15', 15, 'haut'),('DH_16', 16, 'haut'),
   ('DB_1', 1, 'bas'),('DB_2', 2, 'bas'),('DB_3', 3, 'bas'),('DB_4', 4, 'bas'),
   ('DB_5', 5, 'bas'),('DB_6', 6, 'bas'),('DB_7', 7, 'bas'),('DB_8', 8, 'bas'),
   ('DB_9', 9, 'bas'),('DB_10', 10, 'bas'),('DB_11', 11, 'bas'),('DB_12', 12, 'bas'),
   ('DB_13', 13, 'bas'),('DB_14', 14, 'bas'),('DB_15', 15, 'bas'),('DB_16', 16, 'bas');

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

