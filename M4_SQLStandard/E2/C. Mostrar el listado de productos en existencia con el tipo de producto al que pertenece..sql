/******Mostrar el listado de productos en existencia con el tipo de producto al que pertenece.********/
USE gymmanager; 
SELECT pt.product, pt.producttypes
FROM producttypes AS pt