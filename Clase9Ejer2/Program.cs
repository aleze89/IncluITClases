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

        if (cartonBingo[f,c]==0)
        {
            Console.Write("| ");
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


