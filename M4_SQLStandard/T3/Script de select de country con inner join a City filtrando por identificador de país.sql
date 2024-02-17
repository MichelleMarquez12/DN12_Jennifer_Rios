/*muestra ambas columnas de las tablas country y city*/
SELECT * FROM country co
inner join city ci on co.country_id = ci.country_id;

/*muestra las columnas de la tabla de city */
SELECT ci.city_id, ci.country_id, ci.last_update FROM country co
inner join city ci on co.country_id = ci.country_id;

/*muestra las columnas de la tabla de city filtrado solo por el id del pais en especifico*/
SELECT ci.city_id, ci.country_id, ci.last_update FROM country co
inner join city ci on co.country_id = ci.country_id
where co.country_id = 2;

/*muestra las columnas de la tabla de city filtrado solo por el id del pais en especifico mostrando igual el nombre del pais*/
SELECT ci.city_id, ci.city, ci.last_update, co.country FROM country co
inner join city ci on co.country_id = ci.country_id
where co.country_id = 2;