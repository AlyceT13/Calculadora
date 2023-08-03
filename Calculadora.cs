using System;

namespace CalculadoraII
{
    //Código creado por: Alicia Touris y Jose Antonio Reyes
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = Menu();
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Determinante();
                    break;

                case 5:
                    AnalizadorSistemas();
                    break;

                case 6:
                    ResolucionSCD();
                    break;

                case 7:
                    Escalonamiento();
                    break;

                case 8:
                    Reduccion();
                    break;

                case 9:
                    Rango();
                    break;
                case 10: //Opción para finalizar el programa
                    Console.WriteLine("Fin del programa");
                    break;
            }

        }

        static string[] diccionarioIncognitas = { "x", "y", "z", "a" };
        static int Menu() //Función para mostrar en pantalla el menu
        {
            int opcion;
            bool numOpcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Elige una opción:");
                Console.WriteLine(" 1. Suma de matrices.");
                Console.WriteLine(" 2. Resta de matrices.");
                Console.WriteLine(" 3. Multiplicación de matrices.");
                Console.WriteLine(" 4. Determinates de cualquier orden.");
                Console.WriteLine(" 5. Analizar sistemas de ecuaciones líneales."); //Programa que te dice si el sistema de ecuaciones es SI, SCD o SCI
                Console.WriteLine(" 6. Resolución de sistemas compatibles determinados de ecuaciones lineales.");
                Console.WriteLine(" 7. Escalonamiento de matrices.");
                Console.WriteLine(" 8. Sacar la matiz inversa por reducción de matrices.");
                Console.WriteLine(" 9. Rango de una matriz");
                Console.WriteLine(" 10. Salir"); //Opción para salir del programa
                numOpcion = int.TryParse(Console.ReadLine(), out opcion);
                if (numOpcion == false || opcion < 1 || opcion > 10) //Comando para que el jugador no se pase del limite de opciones en el menu
                {
                    Console.WriteLine("Opción no válida, inserte un valor entre 1 y 3. \n Pulse una tecla para continuar");
                    Console.ReadKey();
                }
            } while (!numOpcion || opcion < 1 || opcion > 9);
            return opcion;
        }
        static void Suma()
        {
            int filas;
            int columnas;
            int[,] Matriz;
            int[,] Matriz2;

            int[,] resultado;
            Console.WriteLine("Suma de matrices: ");
            Console.WriteLine("¿Cuántas filas tendrán las matrices?");
            bool filasPosibles = int.TryParse(Console.ReadLine(), out filas);
            if (filasPosibles == false || filas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("¿Cuántas columnas tendrán las matrices?");
            bool cantidadPosible = int.TryParse(Console.ReadLine(), out columnas);
            if (cantidadPosible == false || columnas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Matriz = new int[filas, columnas];
            Matriz2 = new int[filas, columnas];
            resultado = new int[filas, columnas];

            Console.WriteLine("Ingresando datos a la primera matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz[i, j] = num;
                }
            }

            Console.WriteLine("Ingresando datos a la segunda matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz2[i, j] = num;
                }
            }

            //Sumamos las dos matrices
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = Matriz[i, j] + Matriz2[i, j];
                }
            }
            RepresentarMatriz(filas, columnas, resultado);
        }
        static void Resta()
        {
            int filas;
            int columnas;
            int[,] Matriz;
            int[,] Matriz2;

            int[,] resultado;
            Console.WriteLine("Resta de matrices: ");
            Console.WriteLine("¿Cuántas filas tendrán las matrices?");
            bool filasPosibles = int.TryParse(Console.ReadLine(), out filas);
            if (filasPosibles == false || filas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("¿Cuántas columnas tendrán las matrices?");
            bool cantidadPosible = int.TryParse(Console.ReadLine(), out columnas);
            if (cantidadPosible == false || columnas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Matriz = new int[filas, columnas];
            Matriz2 = new int[filas, columnas];
            resultado = new int[filas, columnas];

            Console.WriteLine("Ingresando datos a la primera matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz[i, j] = num;
                }
            }

            Console.WriteLine("Ingresando datos a la segunda matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz2[i, j] = num;
                }
            }

            //Restamos las dos matrices
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = Matriz[i, j] - Matriz2[i, j];
                }
            }
            RepresentarMatriz(filas, columnas, resultado);
        }
        static void Multiplicacion()
        {
            int filas, filas2;
            int columnas, columnas2;
            int[,] Matriz;
            int[,] Matriz2;

            int[,] resultado;
            Console.WriteLine("Multiplicación de matrices: ");
            do
            {
                #region Ingresar dimensiones de la primera matriz
                Console.WriteLine("¿Cuántas filas tendrá la primera matriz?");
                bool filasPosibles = int.TryParse(Console.ReadLine(), out filas);
                if (filasPosibles == false || filas < 1)
                {
                    Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                    Console.ReadKey();
                }

                Console.WriteLine("¿Cuántas columnas tendrá la primera matriz?");
                bool cantidadPosible = int.TryParse(Console.ReadLine(), out columnas);
                if (cantidadPosible == false || columnas < 1)
                {
                    Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                    Console.ReadKey();
                }
                #endregion
                #region Ingresar dimensiones de la segunda matriz
                Console.WriteLine("¿Cuántas filas tendrá la segunda matriz?");
                bool filasPosibles2 = int.TryParse(Console.ReadLine(), out filas2);
                if (filasPosibles2 == false || filas < 1)
                {
                    Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                    Console.ReadKey();
                }

                Console.WriteLine("¿Cuántas columnas tendrá la segunda matriz?");
                bool cantidadPosible2 = int.TryParse(Console.ReadLine(), out columnas2);
                if (cantidadPosible2 == false || columnas < 1)
                {
                    Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                    Console.ReadKey();
                }
                #endregion
            } while (columnas != filas2);
            if (columnas != filas2)
            {
                resultado = null;
                Console.WriteLine("La multiplicación no se puede realizar. \n El número de columnas de la primera matriz es " +
                "diferente al número de filas de la segunda matriz");
            }
            else
            {
                Matriz = new int[filas, columnas];
                Matriz2 = new int[filas, columnas];
                resultado = new int[filas, columnas2];

                #region Ingresar datos de las matrices
                Console.WriteLine("Ingresando datos a la primera matriz");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                        int num;
                        bool numPosible = int.TryParse(Console.ReadLine(), out num);
                        if (numPosible == false)
                        {
                            Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                            Console.ReadKey();
                        }
                        Matriz[i, j] = num;
                    }
                }

                Console.WriteLine("Ingresando datos a la segunda matriz");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                        int num;
                        bool numPosible = int.TryParse(Console.ReadLine(), out num);
                        if (numPosible == false)
                        {
                            Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                            Console.ReadKey();
                        }
                        Matriz2[i, j] = num;
                    }
                }
                #endregion

                //Multiplicamos las matrices
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas2; j++)
                    {
                        resultado[i, j] = 0;

                        for (int k = 0; k < columnas; k++)
                        {
                            resultado[i, j] += Matriz[i, k] * Matriz2[k, j];
                        }
                    }
                }

                Console.WriteLine("El resultado de la multiplicacción de las matrices es: ");
                RepresentarMatriz(filas, columnas2, resultado);
            }
        }
        static void AnalizadorSistemas()
        {
            int numEcuaciones;
            int Incognitas;

            #region creacion de la matriz/ sistema
            Console.WriteLine("Numero de ecuaciones: ");
            bool filasPosibles = int.TryParse(Console.ReadLine(), out numEcuaciones);
            if (filasPosibles == false || numEcuaciones < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("¿Cuántas incognitas tendrán las matrices?");
            bool cantidadPosible = int.TryParse(Console.ReadLine(), out Incognitas);
            if (cantidadPosible == false || Incognitas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }
            int[,] Matriz = new int[numEcuaciones, Incognitas + 1];
            Console.WriteLine("Ingresando datos a la primera matriz");
            for (int i = 0; i < numEcuaciones; i++)
            {
                for (int j = 0; j < Incognitas + 1; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz[i, j] = num;
                }
            }
            #endregion
            switch (AnalizadorSistemas(Matriz, Incognitas, numEcuaciones)) //Paso el sistema para que se analize
            {
                case 0:
                    Console.WriteLine("Es un S.C.D");
                    break;
                case 1:
                    Console.WriteLine("Es un S.C.I");
                    break;
                case 2:
                    Console.WriteLine("Es un S.I");
                    break;

            }

        }


        static int AnalizadorSistemas(int[,] Matriz, int incognitas, int numEcuaciones)
        {
            #region codigo antiguo
            ////la matriz tiene dimensiones [numEcuaciones, incognitas +1] por lo que lo primero de todo es comprobar si existen mas incogintas que ecuaciones

            //if(numEcuaciones < incognitas)
            //{
            //    //En este caso existen infinitas soluciones al necesitar al menos el numero de incognitas. Por lo que es un S.C.I o un S.I. 

            //    int[,] MatrizTemp = new int[numEcuaciones, numEcuaciones]; //Hacemos una matriz cuadrada y comprobamos para los valores de la simple

            //    for(int i = 0; i < numEcuaciones; i++)
            //    {
            //        for (int j = 0; j < numEcuaciones; j++)
            //        {
            //            MatrizTemp[i, j] = Matriz[i, j]; 

            //        }

            //    }
            //    //Guardamos el valor del determinante 
            //    int determinateSimple = CalcularDeterminante(numEcuaciones, MatrizTemp);
            //    //Ahora hacemos lo mismo con la ampliada
            //    for (int i = 0; i < numEcuaciones; i++)
            //    {
            //        for (int j = incognitas ; j > incognitas - numEcuaciones ; j--)
            //        {
            //            MatrizTemp[i, j - numEcuaciones] = Matriz[i, j];

            //        }
            //    }
            //    int determinanteAmpliada = CalcularDeterminante(numEcuaciones, MatrizTemp);
            //    if (determinateSimple != 0) {  //Sistema compatible indetermintado
            //        return 1;
            //    } 
            //    else if(determinanteAmpliada != 0) //El normal valen 0 pero la ampliada no vale 0, por lo que no tiene solucion.
            //    {
            //        return 2;
            //    }
            //    else return 1; //Si ambos determinantes valen 0 entonces son linealmente dependientes, pero el sistema tiene solución.
            //}
            #endregion
            int rangoNormal = Rango(numEcuaciones, incognitas, Matriz);
            int rangoAmpliada = Rango(numEcuaciones, incognitas + 1, Matriz); //Rango de la matriz ampliada

            if (rangoNormal < rangoAmpliada) return 2; //Ampliada de mayor rango
            else if (rangoAmpliada < incognitas) return 1; //No hay suficientes ecuacioenes
            else return 0; //Ambos rangos es igual que el numero de incognitas y por tanto tiene solución

            //0 es SCD, 1 SCI, 2 SI
        }
        static int Rango(int filas, int columnas, int[,] Matriz)
        {
            int max = 0;
            bool filasEsMayor = false;
            if (filas > columnas) { max = columnas; filasEsMayor = true; }
            else max = filas; //Determina el rango maximo de la matriz;
            int rangoActual = 1;


            if (filas != columnas)
            {
                int[,] MatrizA; //La matriz creada a la cual se intente hacer cuadrada
                if (filasEsMayor)
                {
                    MatrizA = new int[filas - 1, columnas];
                    for (int i = 0; i < filas; i++) // veces que se va a ejecutar el calcular la nueva matriz hija
                    {
                        for (int j = 0; j < i; j++)
                        {
                            for (int k = 0; k < columnas; k++) //La posición de la columna de la matriz hija
                            {
                                MatrizA[j, k] = Matriz[j, k];


                            }
                        }
                        for (int j = i; j < filas - 1; j++)
                        {
                            for (int k = 0; k < columnas; k++) //La posición de la columna de la matriz hija
                            {
                                MatrizA[j, k] = Matriz[j + 1, k];


                            }
                        }
                        //Aqui ya se a creado la matriz A o uno de sus casos. Ahora se guarda el valor del rango de esa matriz.
                        int rangoTemp = Rango(filas - 1, columnas, MatrizA);
                        //Se comprueba con el maximo hasta el momento y se sobrescribe.
                        if (rangoTemp > rangoActual) rangoActual = rangoTemp;
                    }

                }
                else //Las columnas son mas que las fulas
                {
                    MatrizA = new int[filas, columnas - 1];
                    for (int i = 0; i < columnas; i++) // veces que se va a ejecutar el calcular la nueva matriz hija
                    {
                        for (int j = 0; j < filas; j++)
                        {
                            for (int k = 0; k < i; k++) //La posición de la columna de la matriz hija
                            {
                                MatrizA[j, k] = Matriz[j, k];


                            }
                            for (int k = i; k < columnas - 1; k++) //La posición de la columna de la matriz hija
                            {
                                MatrizA[j, k] = Matriz[j, k + 1];


                            }
                        }

                        //Aqui ya se a creado la matriz A o uno de sus casos. Ahora se guarda el valor del rango de esa matriz.
                        int rangoTemp = Rango(filas, columnas - 1, MatrizA);
                        //Se comprueba con el maximo hasta el momento y se sobrescribe.
                        if (rangoTemp > rangoActual) rangoActual = rangoTemp;
                    }


                }

            }
            else //La matriz es cuadrada
            {
                if (CalcularDeterminante(columnas, Matriz) != 0)
                {

                    return columnas; //Calcula con el determinante cuadrado completo


                } //Cualquier otro caso ya mira achica la función y reduce

                for (int j = 0; j < max; j++)
                {
                    for (int k = 0; k < max; k++)
                    {
                        if (CalcularDeterminante(max - 1, CalcularAdjunto(max, j, k, Matriz)) != 0) //Si el determinante del adjunto es diferente de 0 devuelve la actual;
                        {
                            return max - 1;

                        }


                    }

                }
                //Si no ha salido el determinante calculo el rango como el maximo de cada adjunto
                for (int j = 0; j < max; j++)
                {
                    for (int k = 0; k < max; k++)
                    {
                        int[,] MatrizA = CalcularAdjunto(max, j, k, Matriz); //Para cada caso crea la matriz adjunta
                        int rangoTemp = Rango(max - 1, max - 1, MatrizA);
                        if (rangoTemp > rangoActual) rangoActual = rangoTemp; //Guarda el subrango mas grande


                    }

                }





            }


            return rangoActual;
        }
        static void Rango()
        {
            int filas;
            int columnas;
            int[,] Matriz;
            #region creacion Matriz
            Console.WriteLine("¿Cuántas filas tendrá la matriz?");
            bool filasPosibles = int.TryParse(Console.ReadLine(), out filas);
            if (filasPosibles == false || filas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("¿Cuántas columnas tendrá la matriz?");
            bool cantidadPosible = int.TryParse(Console.ReadLine(), out columnas);
            if (cantidadPosible == false || columnas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Matriz = new int[filas, columnas];
            Console.WriteLine("Ingresando datos a la matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz[i, j] = num;
                }
            }

            #endregion
            Console.WriteLine("El rango es: " + Rango(filas, columnas, Matriz));
        }
        static void ResolucionSCD()
        {
            int filas;
            int columnas;
            int[,] Matriz;
            #region creacion Matriz
            Console.WriteLine("¿Cuántas filas tendrá la matriz?");
            bool filasPosibles = int.TryParse(Console.ReadLine(), out filas);
            if (filasPosibles == false || filas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("¿Cuántas inconitas tendrá la matriz?");
            bool cantidadPosible = int.TryParse(Console.ReadLine(), out columnas);
            columnas++;
            if (cantidadPosible == false || columnas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Matriz = new int[filas, columnas];
            Console.WriteLine("Ingresando datos a la matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz[i, j] = num;
                }
            }

            #endregion
            RepresentarMatriz(filas, columnas, Matriz);
            //Ahora se comprueba si es SCO
            if (AnalizadorSistemas(Matriz, columnas - 1, filas) == 0)
            {
                Console.WriteLine("Sistema Compatible determinado");
                float[,] matrizDecimal = new float[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matrizDecimal[i, j] = Matriz[i, j]; //Trasformo los valores en float.

                    }

                }

                float[,] matrizEscalonada = Escalonamiento(filas, columnas, matrizDecimal);//Escalona la matriz y la guarda 
                float[] soluciones = new float[columnas];
                float sumaTemp = 0;
                RepresentarMatriz(filas, columnas, matrizEscalonada); //Solo para control de errores y estetica
                for (int i = columnas - 2; i > -1; i--)
                {
                    sumaTemp = 0; //Reseteo el contador
                    for (int j = columnas - 2; j > i; j--)
                    {
                        sumaTemp += soluciones[j] * matrizEscalonada[i, j];
                    }

                    soluciones[i] = (matrizEscalonada[i, columnas - 1] - sumaTemp) / matrizEscalonada[i, i]; //EL final - los resultados  todo entre el valor de la incognita
                    Console.WriteLine(diccionarioIncognitas[i] + " = " + soluciones[i]);
                }


            }
            else
            {
                Console.WriteLine("No es un sistema compatible determinado");

            }
        }
        static void Escalonamiento()
        {
            int filas;
            int columnas;
            int[,] Matriz;

            #region Marcar el orden que tendrá la matriz
            Console.WriteLine("¿Cuántas filas tendrá la matriz?");
            bool filasPosibles = int.TryParse(Console.ReadLine(), out filas);
            if (filasPosibles == false || filas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("¿Cuántas columnas tendrá la matriz?");
            bool cantidadPosible = int.TryParse(Console.ReadLine(), out columnas);
            if (cantidadPosible == false || columnas < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }

            Matriz = new int[filas, columnas];
            #endregion

            Matriz = new int[filas, columnas];

            #region Ingresando valores de la matriz
            Console.WriteLine("Ingresando datos a la matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    Matriz[i, j] = num;
                }
            }
            #endregion

            Console.WriteLine("La matriz actual es: ");
            RepresentarMatriz(filas, columnas, Matriz);

            #region Escalonamos la matriz por el método de Gauss
            for (int i = 0; i < filas - 1; i++)//Primero recorremos todas las filas de la matriz
            {
                for (int j = i + 1; j < filas; j++)
                {
                    int factor = Matriz[j, i] / Matriz[i, i];//Al recorrer todas las filas vamos dividiendo los elementos por un factor.
                    //Este factor es el número por el que deberemos múltiplicar la fila en la que se encuentra el pivote para después poder hacer ceros al restar
                    for (int k = i; k < columnas; k++)
                    {
                        Matriz[j, k] -= factor * Matriz[i, k];//La matriz resultante se tratará de la resta de filas, una de ellas multiplicada por el factor obtenido anteriormente
                    }
                }
            }
            #endregion

            Console.WriteLine("la matriz resultante es: ");
            RepresentarMatriz(filas, columnas, Matriz);
        }
        static float[,] Escalonamiento(int filas, int columnas, float[,] Matriz)
        {

            for (int i = 0; i < filas - 1; i++)//Primero recorremos todas las filas de la matriz
            {
                for (int j = i + 1; j < filas; j++)
                {
                    float factor = Matriz[j, i] / Matriz[i, i];//Al recorrer todas las filas vamos dividiendo los elementos por un factor.
                    //Este factor es el número por el que deberemos múltiplicar la fila en la que se encuentra el pivote para después poder hacer ceros al restar
                    for (int k = i; k < columnas; k++)
                    {
                        Matriz[j, k] -= factor * Matriz[i, k];//La matriz resultante se tratará de la resta de filas, una de ellas multiplicada por el factor obtenido anteriormente
                    }
                }
            }
            return Matriz;
        }
        static void Reduccion()
        {
            int orden;

            int[,] MatrizA;

            #region Marcar el orden que tendrá la matriz
            Console.WriteLine("¿Cuál va a ser el orden de la matriz?");
            bool ordenPosible = int.TryParse(Console.ReadLine(), out orden);
            if (ordenPosible == false || orden < 1)
            {
                Console.WriteLine("Opción no válida, inserte un valor mayor que 1. \n Pulse una tecla para continuar");
                Console.ReadKey();
            }
            #endregion

            MatrizA = new int[orden, (2 * orden)];

            #region Ingresando valores de la matriz
            Console.WriteLine("Ingresando datos de la matriz");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    int num;
                    bool numPosible = int.TryParse(Console.ReadLine(), out num);
                    if (numPosible == false)
                    {
                        Console.WriteLine("Opción no válida, inserte un valor numérico. \n Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    MatrizA[i, j] = num;
                }
            }
            #endregion

            Console.WriteLine("La matriz actual es: ");
            RepresentarMatriz(orden, orden, MatrizA);

            CalcularDeterminante(orden, MatrizA);

            if (CalcularDeterminante(orden, MatrizA) != 0)
            {
                // Inicializamos la matriz identidad y la matriz ampliada:
                for (int i = 0; i < orden; i++)
                {
                    // Creamos la matriz aumentada
                    for (int j = 0; j < (2 * orden); j++)
                    {
                        if (j == (i + orden))//Creamos la matriz identidad
                        {
                            MatrizA[i, j] = 1;
                        }
                    }
                }

                Console.WriteLine("La matriz aumentada correspondiente es: ");
                RepresentarMatriz(orden, 2 * orden, MatrizA);

                // Realizamos la reducción por el método Gauss-Jordan
                for (int i = 0; i < orden; i++)
                {
                    // Dividimos la fila i (fila en la que estemos actualmente) por el elemento que tomamos como pivote
                    int divisor = MatrizA[i, i];
                    for (int j = i; j < 2 * orden; j++)
                    {
                        MatrizA[i, j] /= divisor;
                    }
                    // Eliminamos los elementos por debajo y por encima del elemento pivote
                    for (int j = 0; j < orden; j++)
                    {
                        if (i != j)
                        {
                            int factor = MatrizA[j, i];
                            for (int k = i; k < 2 * orden; k++)
                            {
                                MatrizA[j, k] -= factor * MatrizA[i, k];
                            }
                        }
                    }
                }
                //Mostramos por pantalla la matriz ampliada con la inversa resultante en la parte izquierda
                Console.WriteLine("La matriz inversa resultante es: ");
                RepresentarMatriz(orden, 2 * orden, MatrizA);
            }
            else
            {
                Console.WriteLine("Al tener determinate 0, no se puede calcular la matriz inversa");
            }

        }
        static void Determinante()
        {
            int orden;

            int[,] Matriz;
            Console.WriteLine("orden: ");
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out orden));
            Matriz = new int[orden, orden];
            Console.WriteLine("Ingresando datos a la primera matriz");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    do
                    {
                        Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    } while (!int.TryParse(Console.ReadLine(), out Matriz[i, j]));
                }
            }
            RepresentarMatriz(orden, orden, Matriz);
            Console.WriteLine("Determinante: " + CalcularDeterminante(orden, Matriz));
        }
        static int CalcularDeterminante(int orden, int[,] Matriz)
        {
            int contador = 0;
            if (orden == 1) return Matriz[0, 0]; //En caso de orden 1
            else if (orden == 2)
            {
                return ((Matriz[0, 0] * Matriz[1, 1]) - (Matriz[1, 0] * Matriz[0, 1])); //Multiplicacion en cruz
            }
            else
            {

                for (int i = 0; i < orden; i++) //Pasa por cada numero de la fila
                {


                    if (i % 2 == 0) //par
                    {
                        //Resuelvo por adjuntos
                        contador += Matriz[0, i] * CalcularDeterminante(orden - 1, CalcularAdjunto(orden, 0, i, Matriz));
                    } //Impar
                    else contador -= Matriz[0, i] * CalcularDeterminante(orden - 1, CalcularAdjunto(orden, 0, i, Matriz));

                }


            }
            return contador;
        }
        static float CalcularDeterminante(int orden, float[,] Matriz)
        {
            float contador = 0;
            if (orden == 1) return Matriz[0, 0]; //En caso de orden 1
            else if (orden == 2)
            {
                return ((Matriz[0, 0] * Matriz[1, 1]) - (Matriz[1, 0] * Matriz[0, 1])); //Multiplicacion en cruz
            }
            else
            {

                for (int i = 0; i < orden; i++) //Pasa por cada numero de la fila
                {


                    if (i % 2 == 0) //par
                    {
                        //Resuelvo por adjuntos
                        contador += Matriz[0, i] * CalcularDeterminante(orden - 1, CalcularAdjunto(orden, 0, i, Matriz));
                    } //Impar
                    else contador -= Matriz[0, i] * CalcularDeterminante(orden - 1, CalcularAdjunto(orden, 0, i, Matriz));
                    Console.WriteLine("Contador" + contador);
                }


            }
            return contador;
        }
        static void RepresentarMatriz(int filas, int columnas, int[,] Matriz)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("[" + Matriz[i, j] + "] ");
                }
                Console.WriteLine();
            }
        }
        static void RepresentarMatriz(int filas, int columnas, float[,] Matriz) //Sobrecarga en float
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("[" + Matriz[i, j] + "] ");
                }
                Console.WriteLine();
            }
        }
        static int[,] CalcularAdjunto(int orden, int filaEliminar, int columnaEliminar, int[,] matriz)
        {
            int[,] MatrizAdjunta = new int[orden - 1, orden - 1]; //Hago la matriz mas pequeña

            for (int i = 0; i < orden - 1; i++) //La parte de las filas de la matriz menor
            {
                if (i < filaEliminar) //Aun no ha llegado a la fila
                {
                    for (int j = 0; j < columnaEliminar; j++) //Columna antes
                    {
                        MatrizAdjunta[i, j] = matriz[i, j];

                    }
                    for (int j = columnaEliminar; j < orden - 1; j++) //Columna después
                    {
                        MatrizAdjunta[i, j] = matriz[i, j + 1];

                    }
                }
                else
                {

                    for (int j = 0; j < columnaEliminar; j++) //Columna antes
                    {
                        MatrizAdjunta[i, j] = matriz[i + 1, j];

                    }
                    for (int j = columnaEliminar; j < orden - 1; j++) //Columna después
                    {
                        MatrizAdjunta[i, j] = matriz[i + 1, j + 1];

                    }
                }
            }
            return MatrizAdjunta;
        }
        static float[,] CalcularAdjunto(int orden, int filaEliminar, int columnaEliminar, float[,] matriz)
        {
            float[,] MatrizAdjunta = new float[orden - 1, orden - 1]; //Hago la matriz mas pequeña

            for (int i = 0; i < orden - 1; i++) //La parte de las filas de la matriz menor
            {
                if (i < filaEliminar) //Aun no ha llegado a la fila
                {
                    for (int j = 0; j < columnaEliminar; j++) //Columna antes
                    {
                        MatrizAdjunta[i, j] = matriz[i, j];

                    }
                    for (int j = columnaEliminar; j < orden - 1; j++) //Columna después
                    {
                        MatrizAdjunta[i, j] = matriz[i, j + 1];

                    }
                }
                else
                {

                    for (int j = 0; j < columnaEliminar; j++) //Columna antes
                    {
                        MatrizAdjunta[i, j] = matriz[i + 1, j];

                    }
                    for (int j = columnaEliminar; j < orden - 1; j++) //Columna después
                    {
                        MatrizAdjunta[i, j] = matriz[i + 1, j + 1];

                    }
                }
            }
            return MatrizAdjunta;
        }
    }
}