DROP database bestbuy;
CREATE database bestbuy;
USE bestbuy;

CREATE TABLE cliente(
    id_cliente int NOT NULL PRIMARY KEY,
    nombre_cliente char(30),
    nombre_usuario char(30),
    pssw_usuario char(30)
);

CREATE TABLE compra(
    id_compra int NOT NULL PRIMARY KEY,
    id_cliente int,
    fecha_compra datetime
);

CREATE TABLE detcompra(
    id_compra int NOT NULL PRIMARY KEY,
    id_producto int,
    cantidad_producto int
);

CREATE TABLE producto(
    id_producto int NOT NULL PRIMARY KEY,
    id_categoria int,
    nombre_producto char(30),
    precio_producto float,
    stock_producto int
);

CREATE TABLE categoria(
    id_categoria int NOT NULL PRIMARY KEY,
    nombre_categoria char(30)
);
    
CREATE TABLE empleado(
    id_empleado int NOT NULL PRIMARY KEY,
    id_cargo int,
    nombre_empleado char(30),
    pssw_empleado char(30)
);

CREATE TABLE cargo(
    id_cargo int NOT NULL PRIMARY KEY,
    nombre_cargo char(30)
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