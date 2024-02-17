/*Union de ambos resultados max y min*/
select 
		'Menor cantidad' query_type,
		sub2.total_films,
		a.actor_id,
        a.first_name,
        a.last_name
from
(
	select min(total_films) max_films
	from (
		SELECT count(*) total_films, actor_id FROM film_actor
		GROUP BY actor_id
	) sub
) sub_max
inner join 
(
	SELECT count(*) total_films, actor_id FROM film_actor
	GROUP BY actor_id
)sub2 on sub_max.max_films = sub2.total_films
inner join actor a on a.actor_id = sub2.actor_id
union
select 
		'Mayor cantidad' query_type,
		sub2.total_films,
		a.actor_id,
        a.first_name,
        a.last_name
from
(
	select max(total_films) max_films
	from (
		SELECT count(*) total_films, actor_id FROM film_actor
		GROUP BY actor_id
	) sub
) sub_max
inner join 
(
	SELECT count(*) total_films, actor_id FROM film_actor
	GROUP BY actor_id
)sub2 on sub_max.max_films = sub2.total_films
inner join actor a on a.actor_id = sub2.actor_id