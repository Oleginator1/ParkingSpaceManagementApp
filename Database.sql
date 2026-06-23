CREATE DATABASE ParcariDB;
GO
USE ParcariDB;
GO

CREATE TABLE Vehicul (
    IdVehicul INT IDENTITY(1,1) PRIMARY KEY,
    NumarInmatriculare NVARCHAR(20) NOT NULL UNIQUE,
    Marca NVARCHAR(50) NOT NULL,
    Model NVARCHAR(50) NOT NULL,
    Proprietar NVARCHAR(100) NOT NULL
);

CREATE TABLE Parcare (
    IdParcare INT IDENTITY(1,1) PRIMARY KEY,
    Zona NVARCHAR(50) NOT NULL,
    NumarLocuri INT NOT NULL CHECK (NumarLocuri > 0),
    PretLunar DECIMAL(10,2) NOT NULL CHECK (PretLunar > 0),
    Tip NVARCHAR(30) NOT NULL
);

CREATE TABLE Abonament (
    IdAbonament INT IDENTITY(1,1) PRIMARY KEY,
    IdVehicul INT NOT NULL,
    IdParcare INT NOT NULL,
    DataIncepere DATETIME NOT NULL,
    LuniAchitate INT NOT NULL CHECK (LuniAchitate > 0),
    CONSTRAINT FK_Abonament_Vehicul FOREIGN KEY (IdVehicul) REFERENCES Vehicul(IdVehicul),
    CONSTRAINT FK_Abonament_Parcare FOREIGN KEY (IdParcare) REFERENCES Parcare(IdParcare)
);

-- Date de test
INSERT INTO Vehicul (NumarInmatriculare, Marca, Model, Proprietar) VALUES
('CB12ABC', 'Dacia', 'Logan', 'Popescu Ion'),
('CB34DEF', 'Toyota', 'Corolla', 'Ionescu Maria'),
('CB56GHI', 'Volkswagen', 'Golf', 'Rusu Andrei'),
('CB78JKL', 'Ford', 'Focus', 'Munteanu Elena'),
('CB90MNO', 'Renault', 'Clio', 'Cebotari Vasile'),
('MD11PQR', 'BMW', '320i', 'Ciobanu Ana'),
('MD22STU', 'Audi', 'A4', 'Lupu Mihai'),
('MD33VWX', 'Mercedes', 'C200', 'Stratan Olga'),
('MD44YZA', 'Skoda', 'Octavia', 'Botezatu Dan'),
('MD55BCD', 'Hyundai', 'Tucson', 'Gherman Irina');

INSERT INTO Parcare (Zona, NumarLocuri, PretLunar, Tip) VALUES
('Centru', 50, 500.00, 'Subterană'),
('Botanica', 100, 300.00, 'Stradală'),
('Râșcani', 80, 350.00, 'Stradală'),
('Ciocana', 60, 250.00, 'Stradală'),
('Buiucani', 70, 320.00, 'Stradală'),
('Centru-Mall', 200, 600.00, 'Subterană'),
('Aeroport', 150, 450.00, 'Acoperită'),
('Gara de Nord', 90, 280.00, 'Stradală'),
('Universitate', 40, 200.00, 'Stradală'),
('Stadion', 120, 400.00, 'Acoperită');

INSERT INTO Abonament (IdVehicul, IdParcare, DataIncepere, LuniAchitate) VALUES
(1, 1, '2026-01-01', 6),
(2, 2, '2026-02-01', 3),
(3, 3, '2026-01-15', 12),
(4, 4, '2026-03-01', 6),
(5, 5, '2026-02-15', 4),
(6, 6, '2026-01-10', 12),
(7, 7, '2026-04-01', 3),
(8, 8, '2026-02-01', 6),
(9, 9, '2026-03-15', 2),
(10, 10, '2026-01-20', 6),
(1, 6, '2026-08-01', 3),
(3, 1, '2027-02-01', 3);