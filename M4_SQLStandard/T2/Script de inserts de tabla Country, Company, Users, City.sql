/*Inserción de datos en tabla country*/
insert into country(idcountry, name) values(1, 'USA');
insert into country(idcountry, name) values(2, 'ARGENTINA');
insert into country(idcountry, name) values(3, 'COLOMBIA');
insert into country(idcountry, name) values(4, 'MÉXICO');
insert into country(idcountry, name) values(5, 'CUBA');

/*Inserción de datos en tabla company*/
insert into company(idcompany, companyname, location) values(1, 'COMPANY TEST', 'SU');
insert into company(idcompany, companyname, location) values(2, 'COSTOSO', 'NO');
insert into company(idcompany, companyname, location) values(3, 'TESLA', 'AM');

/*Inserción de datos en tabla users*/
insert into users(iduser, username, email, idcompany) values(1, 'admin', 'admin@test.com', 1);
insert into users(iduser, username, email, idcompany) values(2, 'admin', 'admin@costoso.com', 2);
insert into users(iduser, username, email, idcompany) values(3, 'admin', 'admin@tesla.com', 3);

/*Inserción de datos en tabla city*/
insert into city(idcity, name, idcountry) values(1, 'CDMX', 4);
insert into city(idcity, name, idcountry) values(2, 'GUADALAJARA', 4);
insert into city(idcity, name, idcountry) values(3, 'MONTERREY', 4);
insert into city(idcity, name, idcountry) values(12, 'REYNOSA', 4);

insert into city(idcity, name, idcountry) values(4, 'LOS ÁNGELES', 1);
insert into city(idcity, name, idcountry) values(5, 'NEW YORK', 1);
insert into city(idcity, name, idcountry) values(6, 'WASHINGTON DC', 1);

insert into city(idcity, name, idcountry) values(7, 'BUENOS AIRES', 2);

insert into city(idcity, name, idcountry) values(8, 'LA HABANA', 5);

insert into city(idcity, name, idcountry) values(9, 'CARTAGENA', 3);
insert into city(idcity, name, idcountry) values(10, 'BARRANQUILLA', 3);
insert into city(idcity, name, idcountry) values(11, 'MEDELLÍN', 3);