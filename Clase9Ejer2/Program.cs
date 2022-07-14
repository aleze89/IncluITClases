//      Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla.

//1)    Cartón de 3 filas por 9 columnas.  +++
//2)    El cartón debe tener 15 números y 12 espacios en blanco.
//3)    Cada fila debe tener 5 números.
//4)    Cada columna debe tener 1 o 2 números.
//5)    Ningún número puede repetirse.
//6)    La primer columna contiene los números del 1 al 9,
//      la segunda del 10 al 19, la tercera del 20 al 29,
//      así sucesivamente hasta la última columna la cual contiene del 80 al 90.
//7)    Mostrar el carton por pantalla. +++

    // Variables

    var fila = 3;
    var columna = 9;
    var contador = 1;

    var cartonBingo = new int[fila,columna];
    var aleatorio = new Random();

    //  Creacion valores de carton discriminando columnas

    for (int c = 0; c < columna; c++)
    {
        for (int f = 0; f < fila; f++)
        {
            int numeroCarton = 0;
            bool numeroRepetido = false;

            while (!numeroRepetido)
            {
                if (c==0) // Columna 1
                {
                    numeroCarton = aleatorio.Next(1, 10); // 1 al 9
                }
                else if (c==8) //Columna 9
                {
                    numeroCarton = aleatorio.Next(80, 91); // 80 al 90
                }
                else // Todas las demas Columnas
                {
                    numeroCarton = aleatorio.Next(c * 10, c * 10 + 10);
                }

                // Buscamos si el nuemroCarton existe en la columna

                numeroRepetido = true;
                for (int f2 = 0; f2 < 3; f2++)
                {
                    if (cartonBingo[f2,c]==numeroCarton)
                    {
                        numeroRepetido = false;
                        break;
                    }
                }
                // Si salio del bucle y no encontro repetidos,
                //numeroRepetido = true y sale del bucle while

            }

            cartonBingo[f, c] = numeroCarton;
        }
    
    }

    // Ordeno de menor a mayor los valores de cada columna

    for (int c = 0; c < columna; c++)
    {
        for (int f = 0; f < fila; f++)
        {
            for (int k = f + 1; k < fila; k++)
            {
                if (cartonBingo[f,c] > cartonBingo[k,c])
                {
                    int aux = cartonBingo[f, c];
                    cartonBingo[f, c] = cartonBingo[k, c];  // Ordenamiento por burbuja.
                    cartonBingo[k, c] = aux;
                }
            }
        }
    }

    // Rellenar con espacios los lugares con ceros

    var espaciosBorrados= 0;
    while (espaciosBorrados < 12)
    {
        var filaBorrar = aleatorio.Next(0, fila);
        var columnaBorrar = aleatorio.Next(0, columna);

        if (cartonBingo[filaBorrar,columnaBorrar] == 0)
        {
            continue;
        }

        // Contamos cuantos ceros hay en esta fila.

        var cerosEnFila = 0;
        for (int c = 0;c < columna; c++) 
        {
            if (cartonBingo[filaBorrar,c] == 0)
            {
                cerosEnFila++;
            }
        }

        // Contamos cuantos ceros hay en esta columna

        var cerosEnColumna = 0;
        for (int f = 0; f < fila; f++)
        {
            if (cartonBingo[f,columnaBorrar] == 0)
            {
                cerosEnFila++;
            }
        }

        // Contamos cuantos elementos tengo en cada columna.

        var elementosPorColumna = new int[columna];
        for (int c = 0; c < columna; c++)
        {
            for (int f = 0; f < fila; f++)
            {
                if (cartonBingo[f,c] != 0 )
                {
                    elementosPorColumna[c]++;
                }
            }
        }

        // Contamos cuantas columnas hay con un solo numero
        var columnasConUnSoloNumero = 0;
        for (int c = 0; c < columna; c++)
        {
            if (elementosPorColumna[c] == 1)
            {
                columnasConUnSoloNumero++;
            }
        }

        // Si hay 4 ceros en la fila o si hay 2 ceros en la columna no hago nada.

        if(cerosEnFila == 4 || cerosEnColumna == 2)
            continue;

        // Si hay 3 columnas con un solo numero, a partir de ahora debo borrar las columnas q tienen 3 elementos.

        if(columnasConUnSoloNumero == 3 && elementosPorColumna[columnaBorrar] != 3)
        {
            continue;
        }

        // Si no entró por las opciones anteriores borrar el numero.

        cartonBingo[filaBorrar,columnaBorrar] = 0;
        espaciosBorrados++;
    }

    //  Mostrar valores de carton

    //Console.WriteLine(" ----------------------------------------------- ");
    for (int f = 0; f < fila; f++)
    {
        Console.WriteLine(" ----------------------------------------------- ");

        for (int c = 0; c < columna; c++)
        {
            if (c==0)
            {
                Console.Write(" | ");
            }

            if (cartonBingo[f,c]==0) // Si es cero, mostramos un espacio.
            {
                Console.Write("    |");
            }
            else
            {
                Console.Write($" {cartonBingo[f, c]:00} |");
            }
        }
        Console.WriteLine();

    }
    Console.WriteLine(" ----------------------------------------------- ");
    Console.WriteLine();


