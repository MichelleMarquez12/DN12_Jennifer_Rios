CREATE DEFINER=`root`@`localhost` PROCEDURE `ListProducts`(ProductTypes VARCHAR(45))
BEGIN
	SELECT IdProducts, Product, ProductType, CantidadProduct
    FROM Products
    WHERE ProductType = ProductTypes;
END