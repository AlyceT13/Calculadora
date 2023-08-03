# Calculadora
Una calculadora que realiza varias operaciones con matrices y resolución de determinantes y sistemas de ecuaciones lineales.

# Funciones dentro del proyecto y su funcionamiento:

# *Menú del programa:*

El programa tiene una función menú con todas las opciones de cálculos entre las que se
puede elegir. En esa misma función se pide que el usuario introduzca un número (El
número de la opción que quiera escoger), con un bucle do while se mirá que el valor
introducido sea numérico y esté dentro de los valores de opciones posibles.
Si el número introducido es válido, con un switch se pasará a la función que tenga la
operación matemática elegida.

# *Suma y resta de matrices:*

La función de suma y la función de resta de matrices dentro del código funcionan de
manera similar, ambas piden al usuario que introduzca el tamaño que tendrán las dos
matrices a sumar y después pide que se introduzcan los datos dentro de la matriz uno a
uno.
Una vez se introducen los datos, si estos son validos (son datos numéricos, y en el caso
del orden de la matriz es mayor que cero) mediante dos bucles for anidados se van
sumando o restando los elementos de la matriz uno a uno, hasta llegar a la matriz
resultado.
Cuando se obtiene la matriz resultante, esta es mostrada al usuario por pantalla.

# *Multiplicación de matrices:*

La función de multiplicación de matrices, al igual que las anteriores, pide al usuario que se
introduzcan las dimensiones de las dos matrices a multiplicar, después comprueba que
con esas dimensiones la multiplicación es posible de realizar.
Si las dimensiones de las matrices permiten la multiplicación de estas, el programa pedirá
al usuario que introduzca el valor de cada elemento de ambas matrices.
Una vez las matrices están inicializadas, el programa las recorre con dos bucles for
anidados las matrices y va realizando la multiplicación, de forma que cada elemento de
una fila se multiplica con el elemento de la columna correspondiente de la otra matriz y
después se suman para dar el elemento resultante en esa posición de la matriz.
Cuando el programa termina de realizar las operaciones, muestra el resultado de la
función por pantalla al usuario.

# *Resolución de determinantes de cualquier orden:*

La función de resolución de matrices funciona de forma recursiva.
Esta función primero calcula el orden de la matriz. En caso de ser 1 devuelve el mismo
número como determinante. En caso de ser 2 multiplica en cruz (cálculo determinantes de
orden 2) [0,0] x [1,1] - [0,1]x [1,0]
En caso de ser superior a 2, calcula por los menores del número. Según su posición (i+j par
o impar) multiplica o no el valor por -1. Acto seguido crea una matriz que es el adjunto de
esa posición y calcula su determinante. Quedando el valor * +/- 1 * determinante del
adjunto de la posición.
De esta forma cada vez que siga calculando un determinante del menor, tendrá el mismo
orden que el padre -1. Hasta que el orden llegue a ser 2 y multiplica en cruz.
Finalmente el resultado de los menores se suma hasta dar un valor. Dicho valor es el
determinante.

# *Rango de cualquier matriz*

Para calcular el rango de cualquier matriz primero hay que comprobar si la matriz es
cuadrada o no.
En el caso en el que sea cuadrada se hace el determinante de la matriz al completo.
Existen 2 posibilidades
1. Si el determinante de la matriz da un número diferente a 0, el rango de la matriz es
el orden de esta.
2. Si el determinante da 0, entonces se compara el rango de cada uno de los adjuntos
de la matriz. Es decir que se hace la recursividad y llama a la función con un orden
menor. De todas las posibilidades (orden2 adjuntos). La que tenga mayor rango de
todas ellas será el rango de la matriz.
En el caso de que filas y columnas no sean iguales, se ejecuta lo siguiente. Para este
ejemplo pongo que hay más filas que columnas pero si hubiera más columnas sería lo
mismo.
1. Si existen más filas que columnas se crea una matriz que es idéntica que la de
origen solo que elimina una fila. Este proceso se hace para crear tantas matrices
como filas haya. cada matriz elimina una fila diferente.
2. Se calcula el rango por recursividad de cada matriz creada, se guarda el rango de la
mayor como el rango de la matriz padre.
El objetivo de esto es crear todas las posibles matrices cuadradas de base a la
matriz. Y quedarse con el mayor rango posible.

# *Análisis de sistemas de ecuaciones lineales:*

Para analizar un sistema de ecuaciones se necesita saber el número de ecuaciones y el
número de incógnitas. Una vez conocemos eso, se tiene la matriz con filas = núm
ecuaciones y columnas = num incógnitas +1.
Acto seguido se guarda el rango de la matriz [num ecuaciones, num incógnitas] y el rango
de la ampliada [num ecuaciones, num incógnitas +1]
Cuando se tenga toda esta información, puede ocurrir que el rango de ambas matrices
sea diferente, siendo un sistema incompatible.
Si el rango de las 2 es coincidente pero inferior al número de incógnitas, significa que hay
dependencia lineal y por ende es un sistema compatible indeterminado.
Finalmente si los 3 datos coinciden, rango de las 2 matrices y número de incógnitas, se
trata de un Sistema Compatible Determinado.
El programa devuelve 0 para SCD 1 para SCI y 2 para SI

# *Resolución de sistemas compatibles determinados:*

Cuando tenemos una ecuación, lo primero es averiguar de qué tipo es, mediante rangos.
Para eso se llama al análisis de sistemas de ecuaciones lineales.
Una vez se tenga, se escala la matriz, se va desde abajo (z) hacia arriba resolviendo, se
pasa al término independiente la resta de los valores hallados, y al resultado se lo divide
por el producto que multiplica el valor que se quiere hallar.

# *Escalonamiento de matrices:*

En la función para escalonar matrices por el método de Gauss, el usuario solo tiene que
introducir las dimensiones y los elementos de una sola matriz, una vez estos datos son
introducidos y la matriz es inicializada se pasa a escalonar.
Para escalonar la matriz primero recorremos todas las filas de la matriz, y dividiendo los
elementos para encontrar un factor por el que después podremos multiplicar para crear
los ceros y escalonar.
Cuando tenemos ese factor, las filas se irán restando, se resta una fila con otra
multiplicada por el factor obtenido anteriormente, y de esta forma la matriz queda
escalonada al final de la función y es mostrada al usuario por pantalla.

# *Obtención de la matriz inversa mediante el método de reducción:*

En la función para obtener la matriz inversa mediante el método de reducción de
Gauss-Jordan, la inicialización de la matriz funciona de la misma forma que en la función
para escalonar la matriz.
Antes de empezar a hacer los cálculos para sacar la matriz inversa, hacemos una
comprobación con el cálculo de determinantes para comprobar que el determinante no es
cero y se puede obtener la matriz inversa.
Una vez la matriz es inicializada, la convertimos en una matriz ampliada, posicionando la
matriz identidad a la derecha de la matriz introducida por el usuario.
Con la matriz ampliada, vamos tomando los elementos de la diagonal principal como
pivote, y vamos convirtiendo en ceros, primero los elementos debajo de la diagonal
principal y después los de encima, creando así la matriz escalonada reducida, con eso
después se dividen los elementos de las filas para obtener la matriz identidad a la
izquierda y la inversa resultante a la derecha.
Esa matriz ampliada que tiene en su interior la matriz inversa que queríamos hallar, es
mostrada al usuario por pantalla.

# Cómo utilizar el programa:
Utilizar el programa para poder realizar las operaciones dentro de él es muy sencillo, el
usuario nada más empezar el programa verá un menú de opciones en el que están
especificadas todas las operaciones que puede realizar el programa. El usuario solo tiene
que seleccionar una y será dirigido a la parte del código donde se define esa operación.
Una vez se ha seleccionado una opción y ha sido redirigido, el programa le pedirá al
usuario que vaya introduciendo los datos necesarios para realizar los cálculos. Cuando los
datos son introducidos por el usuario el código realiza la operación correspondiente y
muestra al usuario el resultado obtenido por pantalla.
