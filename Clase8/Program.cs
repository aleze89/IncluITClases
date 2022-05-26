﻿//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,  +++
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla *INGRESO DE DATOS  +++
//3) Declarar un vector de tipo double llamado promedios  +++
//4) Recorrer la matriz para su carga con elementos de tipo int *BUCLE (FOR ?)
//5) Recorrer la matriz para mostrar cada valor de la matriz *BUCLE (FOR ?)
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios *PROCESO
//7) Mostrar los promedios recorriendo el vector promedios *MUESTRA DE DATOS

//   Filas

Console.WriteLine("Ingrese la cantidad de Filas de la matriz :");
int cantidadFilas = int.Parse(Console.ReadLine());

//   Columnas

Console.WriteLine("Ingrese la cantidad de Columnas de la matriz :");
int cantidadColumnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas, cantidadColumnas]; 

//  tamanio filas
int lengthFilas = numeros.GetUpperBound(0) + 1;
//  tamanio columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;

double[] promedios = new double[lengthFilas];  // PENDIENTE

for (int columna= 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"-----Te encuentras en la columna n°: {columna + 1 }-----");
    Console.WriteLine();

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Ingresa los valores correspondientes a la fila n° : {fila + 1}");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}




