//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,  +++
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla *INGRESO DE DATOS  +++
//3) Declarar un vector de tipo double llamado promedios  +++
//4) Recorrer la matriz para su carga con elementos de tipo int *BUCLE (FOR ?)  +++
//5) Recorrer la matriz para mostrar cada valor de la matriz *BUCLE (FOR ?)   +++
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios *PROCESO
//7) Mostrar los promedios recorriendo el vector promedios *MUESTRA DE DATOS

Console.WriteLine("=========================");
Console.WriteLine("-----Creacion Matriz-----");
Console.WriteLine("=========================");


//   Filas

Console.WriteLine("Ingrese la cantidad de Filas de la matriz :");
var cantidadFilas = int.Parse(Console.ReadLine());

//   Columnas

Console.WriteLine("Ingrese la cantidad de Columnas de la matriz :");
var cantidadColumnas = int.Parse(Console.ReadLine());

//  matriz

var matrizNumeros = new int[cantidadFilas, cantidadColumnas]; 

//  tamanio filas
int lengthFilas = matrizNumeros.GetUpperBound(0) + 1;
//  tamanio columnas
int lengthColumnas = matrizNumeros.GetUpperBound(1) + 1;


//  Ingreso de datos a la matriz
Console.Clear();


Console.WriteLine("=========================");
Console.WriteLine("-----Ingreso de datos-----");
Console.WriteLine("=========================");


for (var fila = 0 ; fila < cantidadFilas; fila++)
{
    Console.WriteLine();
    Console.WriteLine($"-----Te encuentras en la fila n°: {fila + 1 }-----");
    Console.WriteLine();

    for (var columna = 0; columna < cantidadColumnas; columna++)
    {
        Console.WriteLine($"Ingresa los valores correspondientes a la columna n° : {columna + 1}");
        matrizNumeros[fila, columna] = int.Parse(Console.ReadLine());
        
    }
}

//  Muestra de datos de la matriz
Console.Clear();

Console.WriteLine("=========================");
Console.WriteLine("-----Muestra de datos-----");
Console.WriteLine("=========================");

for (var fila = 0; fila < cantidadFilas; fila++)
{
    //Console.WriteLine("");
    //Console.WriteLine($"-----Te encuentras en la fila n°: {fila + 1 }-----");
    //Console.WriteLine("");

    for (var columna = 0; columna < cantidadColumnas; columna++)
    {
        //Console.WriteLine($"Te encuentras en la columna n° : {fila + 1}");
        //Console.WriteLine();
        Console.Write($"{matrizNumeros[fila, columna]:00} ");
        //Console.WriteLine();
        //promedios = typeof(numeros[fila, columna] / cantidadFilas);
    }
    Console.WriteLine();

}

//  Creacion vector


//var promediosCalculados = matrizNumeros[fila,columna] / lengthColumnas;


var promedios = new double[cantidadColumnas];  // PENDIENTE

//Console.WriteLine();
//Console.WriteLine($"========================================");
//Console.WriteLine();

//  Calculamos los promedios

for (var columna = 0; columna < cantidadColumnas; columna++)
{

    double suma = 0;
    for (var fila = 0; fila < cantidadFilas; fila++)
    {

        suma += matrizNumeros[fila, columna]; // Suma toda la matriz completa, tengo q encontrar 
        //la forma de sumar solo las filas para poder hacer el promedio.

    }
    promedios[columna] = suma / cantidadFilas;
}

//for (fila = 0; fila < promedios.Length ; fila++)
//{
//    promedios[fila] = suma / lengthFilas;
//    Console.WriteLine($"El promedio de la columna n° {fila + 1} es : {promedios[fila]}");
//}

// Mostramos los promedios

Console.WriteLine();
Console.WriteLine("Los promedios de cada columna son:");
for (var columna = 0; columna < cantidadColumnas; columna++)
{
    Console.Write($"{promedios[columna]:00.00} ");
}
Console.WriteLine();









