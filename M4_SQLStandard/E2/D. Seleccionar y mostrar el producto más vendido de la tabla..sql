/******Seleccionar y mostrar el producto más vendido de la tabla.*****/
USE gymmanager; 
SELECT pt.Product, SUM(s.cantidad) AS max_sales
FROM producttypes AS pt
JOIN sales AS s ON pt.idProducttypes = s.idSales
GROUP BY pt.product
ORDER BY max_sales DESC
LIMIT 1;
