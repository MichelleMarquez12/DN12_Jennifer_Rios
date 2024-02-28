CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateCompany`(in _companyName varchar(100), in _location char(2), in _adminEmail varchar(500),
in _userEmail varchar(500),
out _idcompany int, out _idadmin int, out _iduser int)
BEGIN
	declare _companyId int;
    declare _adminId int;
    declare _userId int;
    
    select max(idcompany) + 1 into _companyId from company;
    
	insert into users(iduser, username, email, idcompany)
    values (_adminId, 'admin', _adminEmail, _companyId);
    
    insert into users(iduser, username, email, idcompany)
    values (_userId, 'user', _userEmail, _companyId);
    
    set _idcompany = _companyId;
    set _idadmin = _adminId;
    set _iduser = _userId;
END