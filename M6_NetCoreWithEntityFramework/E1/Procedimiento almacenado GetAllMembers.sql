CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllMembers`()
BEGIN
	select * from Members where FechaRegistro >= curdate() - interval 7 day;
END