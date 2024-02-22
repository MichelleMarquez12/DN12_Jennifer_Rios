/******Seleccionar y mostrar el último miembro registrado con el tipo de membresía adquirida.*****/
USE gymmanager; 
SELECT m.name, m.lastname, mt.memberShipType
FROM members AS m
JOIN membershiptypes AS mt ON m.MemberShipTypes_idmemberShipType = mt.idmemberShipType
ORDER BY m.MemberShipTypes_idmemberShipType DESC
LIMIT 1;