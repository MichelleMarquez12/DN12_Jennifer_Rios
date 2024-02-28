CREATE DEFINER=`root`@`localhost` PROCEDURE `Sales`(IN _ProductTypes_idProductTypes INT, IN _Users_idusers INT)
BEGIN
    DECLARE _idSales INT;

    SELECT MAX(idSales) + 1 INTO _idSales FROM sales;
    
    INSERT INTO sales (idSales, date, cantidad, Users_idusers, ProductTypes_idProductTypes)
    VALUES(_idSales, CURRENT_DATE(), 10, _Users_idusers, _ProductTypes_idProductTypes);
	
    SET _ProductTypes_idProductTypes = _ProductTypes_idProductTypes;
    SET _Users_idusers = _Users_idusers;
END