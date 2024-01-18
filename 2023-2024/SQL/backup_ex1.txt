INSERT INTO medecin (medNom, medPrenom, medNumInami)
VALUES 
('Truc', 'Pierre', 'A5X9RIT79G2'),
('Bidule', 'Paul', 'A5X9RIT79G3'),
('Machin', 'Jack', 'A5X9RIT79G4');

INSERT INTO patient (patientNom,patientPrenom)
VALUES 
('Dupond', 'Jean'),
('Dupont', 'Marc'),
('Dupon', 'Michel'),
('Du Pont', 'Philippe'),
('Du Pond', 'Marrie');

INSERT INTO medicaments (medicamentsNom,medicamentsType)
VALUES
('Ibuprofen 200', 'anti inflamatoire'),
('Ibuprofen 400', 'anti inflamatoire'),
('Ibuprofen 600', 'anti inflamatoire'),
('Ibuprofen 800', 'anti inflamatoire');

INSERT INTO consultation (consultationDate,consultationHeure,medecinID,patientID)
VALUES
('2023-10-06', '09:00:00', 1 , 3),
('2023-10-06', '09:15:00', 1 , 1),
('2023-10-06', '09:30:00', 2 , 5),
('2023-10-06', '09:45:00', 2 , 2),
('2023-10-06', '10:00:00', 3 , 4),
('2023-10-06', '10:15:00', 3 , 1);

INSERT INTO prescription (prescriptionPosologie,consultationID,medicamentsID)
VALUES
('2 fois par jours MAX', 