/*Creación de tabla Users*/
CREATE TABLE Users 
(
	iduser int not null,
    username varchar(100) not null,
    email varchar(500),
    idcompany int not null,
    primary key(iduser)
)

alter TABLE Users
ADD CONSTRAINT company_users
	FOREIGN KEY (idcompany)
	REFERENCES company(idcompany);
    
ALTER TABLE Users
ADD INDEX company_users_idx (idcompany ASC) VISIBLE;