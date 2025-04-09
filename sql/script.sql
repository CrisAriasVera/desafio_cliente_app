CREATE TABLE Clientes (
    Id INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Telefono VARCHAR(15),
    Pais VARCHAR(100)
);

INSERT INTO Clientes VALUES
(1, 'Carlos Perez', '56912345678', 'Chile'),
(2, 'Maria Gomez', '56998765432', 'Chile');