CREATE DEFINER=`root`@`localhost` PROCEDURE `GetMembersWeek`()
BEGIN
    
	DECLARE InicioSemana DATE;
	DECLARE FinSemana DATE;
    
	SET InicioSemana := DATE_SUB(CURDATE(), INTERVAL WEEKDAY(CURDATE()) DAY);
	SET FinSemana := DATE_ADD(InicioSemana, INTERVAL 6 DAY);

    SELECT u.idusers, m.FechaRegistro, mt.memberShipType
    FROM members m
    INNER JOIN users u ON m.Users_idusers = u.idusers
    INNER JOIN membershiptypes mt ON m.MemberShipTypes_idmemberShipType = mt.idmemberShipType
    WHERE m.FechaRegistro BETWEEN InicioSemana AND FinSemana;
	  
END