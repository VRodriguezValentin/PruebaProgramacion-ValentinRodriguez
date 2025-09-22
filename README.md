# Prueba de Programación

A continuación se presentan una serie de preguntas básicas de programación y SQL con el objetivo de medir la experiencia laboral del/la postulante.  
No hay límite de tiempo para entregar las respuestas, pero tené en cuenta que hay otros candidatos realizando la prueba y los puestos disponibles son limitados.

---

## Pregunta 1

Escribí una función en **C#** que reciba tres variables:  
- **int**  
- **string**  
- **object**

Dentro de la función:

- Si la variable de tipo `object` es un número, sumarla a la variable de tipo `int` y mostrar el resultado en la consola.  
- Si la variable de tipo `object` es una cadena de caracteres, adjuntarla a la variable de tipo `string` y mostrar el resultado en la consola.  
- Si la variable de tipo `object` no cumple con los requisitos anteriores, arrojar una excepción.

---

## Pregunta 2

Escribí una función en **C#** que reciba como parámetro un `Dictionary<int, string>`.  
Dentro de la función, recorrer el diccionario y separar sus registros en dos listas:

- Una lista con todos los **valores** del diccionario cuya **llave sea un número par**.  
- Otra lista con todos los **valores** del diccionario cuya **llave sea un número impar**.

---

## Pregunta 3

Suponé que tenés dos tablas en SQL:

- **Producto**: `[ID, DESCRIPCION, CODIGO]`  
- **Descuento**: `[ID, ID_PRODUCTO, FECHA_INICIO, FECHA_FIN, PORCENTAJE]`

Armá una query para cada requerimiento:

1. Obtener todos los productos que hayan tenido o tendrán en el futuro un **descuento mayor al 60%**.  
   - Mostrar la **descripción** del producto y su **código**.

2. Obtener todos los productos que tengan un descuento **entre el 1 de enero de 2021 y el 1 de marzo de 2021**.  
   - Mostrar la **descripción**, **código**, las **fechas del descuento** y el **porcentaje**.

3. Obtener todos los descuentos registrados para los productos cuyo código sea uno de los siguientes:  
   `ADF32`, `POP79`, `LLE51`.

---
