/*Inserción de 5 registros de la tabla MEMBERSHIPTYPES***************************/
INSERT INTO `gymmanager`.`membershiptypes`(`idmemberShipType`,`memberShipType`)
VALUES(1,'Basica');
INSERT INTO `gymmanager`.`membershiptypes`(`idmemberShipType`,`memberShipType`)
VALUES(2,'Premium');
INSERT INTO `gymmanager`.`membershiptypes`(`idmemberShipType`,`memberShipType`)
VALUES(3,'Elite');
INSERT INTO `gymmanager`.`membershiptypes`(`idmemberShipType`,`memberShipType`)
VALUES(4,'Familiar');
INSERT INTO `gymmanager`.`membershiptypes`(`idmemberShipType`,`memberShipType`)
VALUES(5,'Estudiante');

/*Inserción de 5 registros de la tabla ROLES**************/
INSERT INTO `gymmanager`.`roles`(`idRole`,`role_name`)VALUES(1,'Administrador');
INSERT INTO `gymmanager`.`roles`(`idRole`,`role_name`)VALUES(2,'Entrenador');
INSERT INTO `gymmanager`.`roles`(`idRole`,`role_name`)VALUES(3,'Personal de limpieza');
INSERT INTO `gymmanager`.`roles`(`idRole`,`role_name`)VALUES(4,'Asistentes de ventas');
INSERT INTO `gymmanager`.`roles`(`idRole`,`role_name`)VALUES(5,'Nutricionista');
INSERT INTO `gymmanager`.`roles`(`idRole`,`role_name`)VALUES(6,'Clientes');

/*Inserción de 5 registros de la tabla cities***********************/
INSERT INTO `gymmanager`.`cities`(`idcities`,`citi_name`)VALUES(1,'CDMX');
INSERT INTO `gymmanager`.`cities`(`idcities`,`citi_name`)VALUES(2,'PUEBLA');
INSERT INTO `gymmanager`.`cities`(`idcities`,`citi_name`)VALUES(3,'LONDRES');
INSERT INTO `gymmanager`.`cities`(`idcities`,`citi_name`)VALUES(4,'CHICAGO');
INSERT INTO `gymmanager`.`cities`(`idcities`,`citi_name`)VALUES(5,'LOS ÁNGELES');

/*Inserción de 5 registros de la tabla MEMBERS***********/
INSERT INTO `gymmanager`.`members`(`name`,`lastname`,`email`,`telefono`,`direccion`,`cities_idcities`,`memberShipTypes_idmemberShipType`)
VALUES('JENNIFER MICHELLE','RIOS','marquezmichel282@gmail.com','4811234567','Av. Insurgentes Sur 1234, Colonia Roma Norte, Del. Miguel Hidalgo',1,1);

INSERT INTO `gymmanager`.`members`(`name`,`lastname`,`email`,`telefono`,`direccion`,`cities_idcities`,`memberShipTypes_idmemberShipType`)
VALUES('MIGUEL ANGEL','RIOS','miguel11@gmail.com','4817895942','Av. Insurgentes Norte No. 240 Int., Colonia Centro',2,2);

INSERT INTO `gymmanager`.`members`(`name`,`lastname`,`email`,`telefono`,`direccion`,`cities_idcities`,`memberShipTypes_idmemberShipType`)
VALUES('ISRAEL','MENDEZ','ohmamendez@gmail.com','4811487956','Calle 5 de Mayo 123, Colonia Centro',3,3);

INSERT INTO `gymmanager`.`members`(`name`,`lastname`,`email`,`telefono`,`direccion`,`cities_idcities`,`memberShipTypes_idmemberShipType`)
VALUES('DAVID','ZUÑIGA MORAN','david123@gmail.com','4811026523','221B Baker Street, Marylebone',4,4);

INSERT INTO `gymmanager`.`members`(`name`,`lastname`,`email`,`telefono`,`direccion`,`cities_idcities`,`memberShipTypes_idmemberShipType`)
VALUES('MELANIA','MORAN','melania2@gmail.com','4812015976','871 North Michigan Avenue, Suite 4444',5,5);

INSERT INTO `gymmanager`.`members`(`name`,`lastname`,`email`,`telefono`,`direccion`,`cities_idcities`,`memberShipTypes_idmemberShipType`)
VALUES('DULCE GABRELA','RIOS','dulceg12@gmail.com','4815069741','6801 Hollywood Boulevard, Los Ángeles',1,5);

/*Inserción de 5 registros de la tabla USERS***********/
INSERT INTO `gymmanager`.`users`(`idusers`,`user_name`,`password`,`members_cities_idcities`)
VALUES(1,'Jennifer1','jennmr1',1);
INSERT INTO `gymmanager`.`users`(`idusers`,`user_name`,`password`,`members_cities_idcities`)
VALUES(2,'Miguel2','miguer2',2);
INSERT INTO `gymmanager`.`users`(`idusers`,`user_name`,`password`,`members_cities_idcities`)
VALUES(3,'IsraelM3','isramg3',3);
INSERT INTO `gymmanager`.`users`(`idusers`,`user_name`,`password`,`members_cities_idcities`)
VALUES(4,'DavidZ4','davizm4',4);
INSERT INTO `gymmanager`.`users`(`idusers`,`user_name`,`password`,`members_cities_idcities`)
VALUES(5,'MelaniaM5','melaM5',5);
INSERT INTO `gymmanager`.`users`(`idusers`,`user_name`,`password`,`members_cities_idcities`)
VALUES(6,'DulceG6','dulcegr6',1);

/*Inserción de 5 registros de la tabla EQUIPEMENTTYPE*/
INSERT INTO `gymmanager`.`equipementtype`(`idEquipementType`,`EquipementType`)VALUES(1,'PESAS');
INSERT INTO `gymmanager`.`equipementtype`(`idEquipementType`,`EquipementType`)VALUES(2,'MANCUERNAS');
INSERT INTO `gymmanager`.`equipementtype`(`idEquipementType`,`EquipementType`)VALUES(3,'DISCO');
INSERT INTO `gymmanager`.`equipementtype`(`idEquipementType`,`EquipementType`)VALUES(4,'BARRA');
INSERT INTO `gymmanager`.`equipementtype`(`idEquipementType`,`EquipementType`)VALUES(5,'CAMINADORA');
INSERT INTO `gymmanager`.`equipementtype`(`idEquipementType`,`EquipementType`)VALUES(6,'LIGAS');

/*Inserción de 5 registros de la tabla SALES*/
INSERT INTO `gymmanager`.`sales`(`idSales`,`date`,`cantidad`)
VALUES(1,'2024-02-20',300);
INSERT INTO `gymmanager`.`sales`(`idSales`,`date`,`cantidad`)
VALUES(2,'2023-12-21',200);
INSERT INTO `gymmanager`.`sales`(`idSales`,`date`,`cantidad`)
VALUES(3,'2024-11-02',1000);
INSERT INTO `gymmanager`.`sales`(`idSales`,`date`,`cantidad`)
VALUES(4,'2023-02-03',400);
INSERT INTO `gymmanager`.`sales`(`idSales`,`date`,`cantidad`)
VALUES(5,'2023-08-25',100);
INSERT INTO `gymmanager`.`sales`(`idSales`,`date`,`cantidad`)
VALUES(6,'2023-12-25',10);

/*Inserción de 5 registros de la tabla USERINROLES*/
INSERT INTO `gymmanager`.`userinroles` (`roles_idRole`, `users_idusers`) VALUES (1,1);
INSERT INTO `gymmanager`.`userinroles` (`roles_idRole`, `users_idusers`) VALUES (6,2);
INSERT INTO `gymmanager`.`userinroles` (`roles_idRole`, `users_idusers`) VALUES (6,3);
INSERT INTO `gymmanager`.`userinroles` (`roles_idRole`, `users_idusers`) VALUES (6,4);
INSERT INTO `gymmanager`.`userinroles` (`roles_idRole`, `users_idusers`) VALUES (6,5);
INSERT INTO `gymmanager`.`userinroles` (`roles_idRole`, `users_idusers`) VALUES (6,6);

/*Inserción de 5 registros de la tabla PRODUCTTYPES*/
INSERT INTO `gymmanager`.`producttypes`(`idProductTypes`,`Product`,`ProductTypes`,`Sales_idSales`) VALUES (1, 'PROTEINA EN POLVO','SUPLEMENTO',1);
INSERT INTO `gymmanager`.`producttypes`(`idProductTypes`,`Product`,`ProductTypes`,`Sales_idSales`) VALUES (2, 'SUERO DE LECHE','SUPLEMENTO', 2);
INSERT INTO `gymmanager`.`producttypes`(`idProductTypes`,`Product`,`ProductTypes`,`Sales_idSales`) VALUES (3, 'CREATINA','SUPLEMENTO', 3);
INSERT INTO `gymmanager`.`producttypes`(`idProductTypes`,`Product`,`ProductTypes`,`Sales_idSales`) VALUES (4, 'BARRA DE PROTEINA','SUPLEMENTO', 4);
INSERT INTO `gymmanager`.`producttypes`(`idProductTypes`,`Product`,`ProductTypes`,`Sales_idSales`) VALUES (5, 'GLUTAMINA','SUPLEMENTO', 5);
INSERT INTO `gymmanager`.`producttypes`(`idProductTypes`,`Product`,`ProductTypes`,`Sales_idSales`) VALUES (6, 'SHORT DEPORTIVO','ROPA DEPORTIVA', 6);

/*Inserción de 5 registros de la tabla INVENTORY*/
INSERT INTO `gymmanager`.`inventory` (`cantidadProduct`, `cantidadEquipament`, `ProductTypes_idProductTypes`, `ProductTypes_Sales_idSales`, `EquipementType_idEquipementType`) VALUES (500, 100, 1, 1, 1);
INSERT INTO `gymmanager`.`inventory` (`cantidadProduct`, `cantidadEquipament`, `ProductTypes_idProductTypes`, `ProductTypes_Sales_idSales`, `EquipementType_idEquipementType`) VALUES (1000, 200, 2, 2, 2);
INSERT INTO `gymmanager`.`inventory` (`cantidadProduct`, `cantidadEquipament`, `ProductTypes_idProductTypes`, `ProductTypes_Sales_idSales`, `EquipementType_idEquipementType`) VALUES (500, 120, 3, 3, 3);
INSERT INTO `gymmanager`.`inventory` (`cantidadProduct`, `cantidadEquipament`, `ProductTypes_idProductTypes`, `ProductTypes_Sales_idSales`, `EquipementType_idEquipementType`) VALUES (700, 50, 4, 4, 4);
INSERT INTO `gymmanager`.`inventory` (`cantidadProduct`, `cantidadEquipament`, `ProductTypes_idProductTypes`, `ProductTypes_Sales_idSales`, `EquipementType_idEquipementType`) VALUES (200, 6, 5, 5, 5);
INSERT INTO `gymmanager`.`inventory` (`cantidadProduct`, `cantidadEquipament`, `ProductTypes_idProductTypes`, `ProductTypes_Sales_idSales`, `EquipementType_idEquipementType`) VALUES (200, 12, 6, 6, 6);

/*Inserción de 5 registros de la tabla MEASURETYPE*/
INSERT INTO `gymmanager`.`measuretype`(`medida`,`ProductTypes_idProductTypes`)VALUES('907.00',1);
INSERT INTO `gymmanager`.`measuretype`(`medida`,`ProductTypes_idProductTypes`)VALUES('2.270',2);
INSERT INTO `gymmanager`.`measuretype`(`medida`,`ProductTypes_idProductTypes`)VALUES('100.00',3);
INSERT INTO `gymmanager`.`measuretype`(`medida`,`ProductTypes_idProductTypes`)VALUES('500',4);
INSERT INTO `gymmanager`.`measuretype`(`medida`,`ProductTypes_idProductTypes`)VALUES('907.00',5);
INSERT INTO `gymmanager`.`measuretype`(`medida`,`ProductTypes_idProductTypes`)VALUES('MEDIANA',6);
