-- Producto: [ID, DESCRIPCION, CODIGO];
-- Descuento: [ID, ID_PRODUCTO, FECHA_INICIO, FECHA_FIN, PORCENTAJE]


-- Obtener todos los productos que hayan tenido o tendrán en el futuro un descuento mayor al 60%. 
-- Hacer que se muestre la descripción del producto y su código 
SELECT P.DESCRIPCION, P.CODIGO
FROM Producto P
JOIN Descuento D ON P.ID = D.ID_PRODUCTO
WHERE D.PORCENTAJE > 60;

-- Obtener todos los productos que tengan un descuento entre el primero de enero del 2021 y el primero de marzo del 2021. 
-- Hacer que se muestre la descripción del producto, su código, las fechas del descuento, y el porcentaje 
SELECT P.DESCRIPCION, P.CODIGO, D.FECHA_INICIO, D.FECHA_FIN, D.PORCENTAJE
FROM Producto P
JOIN Descuento D ON P.ID = D.ID_PRODUCTO
WHERE D.FECHA_FIN   >= '2021-01-01'
AND D.FECHA_INICIO <= '2021-03-01';

-- Obtener todos los descuentos registrados para los productos cuyo código sea uno de los siguientes: ADF32, POP79, LLE51. 
SELECT D.*
FROM Descuento D
JOIN Producto P ON D.ID_PRODUCTO = P.ID
WHERE P.CODIGO IN ('ADF32', 'POP79', 'LLE51');