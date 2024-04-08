CREATE DEFINER=`root`@`localhost` PROCEDURE `Sales`(
	IN fecha DATE,
    IN cantidad INT,
    IN idMiembro INT,
    IN idProducto INT
)
BEGIN
	INSERT INTO Sales (Date, Cantidad, Members_idMembers, Products_idProducts)
    VALUES (fecha, cantidad, idMiembro, idProducto);
END