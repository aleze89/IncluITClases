//1) Pida 10 números al usuario.  *INGRESO DE DATOS (FOR ?)  +++
//2) Obtener la suma de todos los números ingresados.  *PROCESO +++ 
//3) Obtener cual es el mayor de todos los números.  *PROCESO (IF ?)  +++ 
//4) Obtener cual es el menor de todos los números.  *PROCESO (IF ?) +++
//5) Obtener el promedio de todos los números.  *PROCESO +++
//6) Mostrar todos los números ingresados por pantalla.  *SALIDA DE DATOS  +++
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.  *SALIDA DE DATOS  +++


var mayor = 0;
var menor = 0;
int[] numerosIngresados = new int[10];

for (int i = 0;i<numerosIngresados.Length;i++)
{
    Console.WriteLine($"Ingrese 10 numeros, le faltan {numerosIngresados.Length - i}");
    numerosIngresados[i] = int.Parse(Console.ReadLine());
}

var suma = 0f;   
for (int i = 0; i < numerosIngresados.Length; i++)
{
    suma += numerosIngresados[i];
}
    Console.WriteLine($"La suma de los numeros ingresados es:{suma}");

//mayor

for (int i = 0; i < numerosIngresados.Length; i++)
{
    if (i == 0)
    {
        mayor = numerosIngresados[i];

    }
    else if (numerosIngresados[i] > mayor)
    {
        mayor = numerosIngresados[i];
    }

}

Console.WriteLine($"El maximo es: {mayor}");

//menor

for (int i = 0; i < numerosIngresados.Length; i++)
{
    if (i == 0)
    {
        menor = numerosIngresados[i];

    }
    else if (numerosIngresados[i] < menor)
    {
        menor = numerosIngresados[i];
    }

}

Console.WriteLine($"El minimo es: {menor}");

//promedio 

var promedio = suma / numerosIngresados.Length;
Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");

//muestra de valores ingresados
Console.WriteLine($"Los valores ingresados son: ");
for (int i = 0; i < numerosIngresados.Length; i++)
{
    Console.Write($" - {numerosIngresados[i]} - ");
}

