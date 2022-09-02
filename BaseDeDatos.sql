#CREATE USER usuarioSorteo@localhost IDENTIFIED BY 'admin';
#GRANT ALL PRIVILEGES ON sorteo.* TO usuarioSorteo@localhost;


USE sorteo;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS participantes;
#Estructura de la tabla usuarios
CREATE TABLE usuarios(
	nombre VARCHAR(50) NOT NULL,
    clave VARBINARY(65000) NOT NULL DEFAULT '',
    privilegio INT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (nombre)
)ENGINE=InnoDB;

#Registros de la tabla usuarios

INSERT INTO usuarios VALUES ('admin',AES_ENCRYPT('admin','*n430J7D4f8L'),0);
INSERT INTO usuarios VALUES ('ingreso',AES_ENCRYPT('utu2022','*n430J7D4f8L'),1);

CREATE TABLE participantes(
	cedula VARCHAR(8) NOT NULL,
    nombre VARCHAR(100) NOT NULL DEFAULT 'N/A',
    apellido VARCHAR(100) NOT NULL DEFAULT 'N/A',
    telefono VARCHAR(15) NOT NULL DEFAULT 'N/A',
    PRIMARY KEY (nombre)
)ENGINE=InnoDB;




