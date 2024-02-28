/*call CreateCompany ('My company', 'NW', 'admin@myxompany.com', 'employee@mycompany.com');*/

call CreateCompany ('Ford', 'SW', 'admin@ford.com', 'employee@ford.com', @companyId, @adminId , @userid);
select @companyId, @adminId, @userid;