El algoritmo de Luhn, también conocido como algoritmo de «módulo 10» o «mod 10», es una fórmula de suma de verificación sencilla que se 
utiliza para validar números de identificación. El algoritmo, desarrollado por el ingeniero de IBM Hans Peter Luhn, se puede utilizar para
validar números de tarjetas de crédito, números de identidad internacional de equipos móviles (IMEI) y otros datos numéricos. Actualmente, 
las empresas lo utilizan con frecuencia para aumentar la precisión y fiabilidad de sus procesos de entrada de datos, sobre todo cuando manejan 
información confidencial, como los datos de pago.


FORMULA

El algoritmo de Luhn no tiene una fórmula en el sentido matemático convencional. Más bien, consta de una serie de pasos.

Paso 1: empezando por la derecha, duplica el valor del penúltimo dígito y continúa haciendo lo mismo para cada segundo dígito. Si el resultado de cualquier operación de duplicación es mayor que 9, suma los dígitos del resultado para obtener un número de un solo dígito.
Ejemplo: 6 × 2 = 12; 1 + 2 = 3

Paso 2: suma todos los dígitos que no has duplicado y los nuevos valores obtenidos de la duplicación.

Paso 3: determina si la suma total es múltiplo de 10. El número se considera válido según el algoritmo de Luhn si el total termina en 0.

Para explicarlo, vamos a verificar el número 79927398713 con la fórmula del algoritmo de Luhn.

Duplica cada segundo dígito empezando por la derecha:

1 x 2 = 2

8 x 2 = 16 (1 + 6 = 7)

3 × 2 = 6

2 × 2 = 4

9 x 2 = 18 (1 + 8 = 9)

Suma todos los dígitos, incluidos los dígitos no duplicados:

7 + 9 + 9 + 4 + 7 + 6 + 9 + 7 + 7 + 2 + 3 = 70

El número 79927398713 es válido según el algoritmo de Luhn porque el resultado es 70, que es un múltiplo de 10.

Estos pasos forman la «fórmula» o el procedimiento que sigue el algoritmo de Luhn para validar o generar números.




