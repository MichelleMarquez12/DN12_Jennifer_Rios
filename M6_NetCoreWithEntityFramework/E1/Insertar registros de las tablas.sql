/*Miembros*/

INSERT INTO `ejerciciouno`.`members` (`idMembers`, `Name`, `LastName`, `FechaRegistro`) VALUES ('1', 'Michelle', 'Marquez', '2024-04-04 13:30:05 ');
INSERT INTO `ejerciciouno`.`members` (`idMembers`, `Name`, `LastName`, `FechaRegistro`) VALUES ('2', 'Israel', 'Mendez', '2024-04-05 17:30:00 ');
INSERT INTO `ejerciciouno`.`members` (`idMembers`, `Name`, `LastName`, `FechaRegistro`) VALUES ('3', 'David', 'Zuñiga', '2024-04-06 20:00:00');

/*Products*/

INSERT INTO `ejerciciouno`.`products` (`idProducts`, `Product`, `ProductType`) VALUES ('1', 'Creatina', 'Suplemento');
INSERT INTO `ejerciciouno`.`products` (`idProducts`, `Product`, `ProductType`) VALUES ('2', 'Short Deportivo', 'Ropa Deportiva');
INSERT INTO `ejerciciouno`.`products` (`idProducts`, `Product`, `ProductType`) VALUES ('3', 'Glutamina', 'Suplemento');

/*Sales*/
INSERT INTO `ejerciciouno`.`sales` (`idSales`, `Date`, `Cantidad`, `Members_idMembers`, `Products_idProducts`) VALUES ('1', '2024-04-14 13:30:05', '10', '1', '1');
INSERT INTO `ejerciciouno`.`sales` (`idSales`, `Date`, `Cantidad`, `Members_idMembers`, `Products_idProducts`) VALUES ('2', '2024-04-15 17:30:00', '5', '2', '2');
INSERT INTO `ejerciciouno`.`sales` (`idSales`, `Date`, `Cantidad`, `Members_idMembers`, `Products_idProducts`) VALUES ('3', '2024-04-08 20:00:00', '20', '3', '3');
