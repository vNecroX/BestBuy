DROP database bestbuy;
CREATE database bestbuy;
USE bestbuy;

CREATE TABLE cliente(
    id_cliente int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_cliente char(50),
    nombre_usuario char(50),
    pssw_usuario char(50)
);

CREATE TABLE compra(
    id_compra int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_cliente int,
    fecha_compra datetime
);

CREATE TABLE detcompra(
    id_compra int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_producto int,
    cantidad_producto int
);

CREATE TABLE producto(
    id_producto int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_categoria int,
    nombre_producto char(50),
    precio_producto float,
    stock_producto int
);

CREATE TABLE categoria(
    id_categoria int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_categoria char(50)
);
    
CREATE TABLE empleado(
    id_empleado int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_cargo int,
    nombre_empleado char(50),
    pssw_empleado char(50)
);

CREATE TABLE cargo(
    id_cargo int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_cargo char(50)
);

ALTER TABLE compra
ADD FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente);

ALTER TABLE detcompra
ADD FOREIGN KEY (id_compra) REFERENCES compra(id_compra);

ALTER TABLE detcompra
ADD FOREIGN KEY (id_producto) REFERENCES producto(id_producto);

ALTER TABLE producto
ADD FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria);

ALTER TABLE empleado
ADD FOREIGN KEY (id_cargo) REFERENCES cargo(id_cargo);

INSERT INTO cargo
    (nombre_cargo)
VALUES 
    ('Administrador'),
    ('Almacenista');

INSERT INTO empleado
    (id_cargo, nombre_empleado, pssw_empleado)
VALUES
    (1, 'G_GOD', 'estoeslaonda'),
    (2, 'E_NOOB', 'hahasi');

INSERT INTO categoria 
    (nombre_categoria)
VALUES
    ('Equipo'),
    ('Accesorio');

INSERT INTO producto 
    (id_categoria, nombre_producto, precio_producto, stock_producto)
VALUES
    (1, 'Macbook Air', 19932.31, 10),
    (1, 'HP Spectre X360 14', 25339.37, 10),
    (1, 'LG Gram 17', 35894.12, 10),
    (2, 'Estante de enfriamiento plegable', 487.92, 10),
    (2, 'Mouse alambrico Steren COM-566', 62.30, 10),
    (2, 'HDD externo Adata 1TB Hd770g', 1197.99, 10);
    