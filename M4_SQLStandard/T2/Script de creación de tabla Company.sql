/*Creación de tabla company*/
CREATE TABLE company 
(
	idcompany int not null,
    companyname varchar(100) not null,
    createdon datetime,
    location char(2),
    primary key(idcompany)    
)