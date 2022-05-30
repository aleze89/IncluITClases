//1)  Pedir al usuario la longitud de un vector.  **INGRESO DE DATOS    +++
//2)  Crear el vector del tamaño ingresado.  **CREACION DEL ARRAY   +++
//3)  Llenar el mismo con datos aleatorios.  **PROCESO  +++
//4)  Mostrar el vector por pantalla.  **MUESTRA DE DATOS   +++
//5)  Invertir el vector, de manera que el primer elemento quede al último 
//    y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el 
//    segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones 
//    y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe 
//    quedar así: 50, 40, 30, 20, 10.
//    @Se debe usar solo lo visto en clase hasta ahora y 
//    no los métodos que trae C# para estas cuestiones.
//    @Tampoco se debe crear un vector 
//    nuevo o auxiliar para realizar el ejercicio. 
//6)  Mostrar el vector nuevamente.  **MUESTRA DE DATOS MODIFICADO


//      Ingreso longitud Array

Console.WriteLine("Ingrese la cantidad de numeros a ingresar: ");
var cantidad = int.Parse(Console.ReadLine());
var posicion = 0;

int[] vector = new int[cantidad];
Random numAleatorios = new Random();

Console.WriteLine(" ");
Console.WriteLine("========Ingreso de Datos========");
Console.WriteLine(" ");

for (posicion = 0;posicion < vector.Length;posicion++)
{
    vector[posicion]=numAleatorios.Next(100);
    //Console.WriteLine(i); Acá me muestra el indice del array, con el foreach veo el elemento q hay en esa posicion.
}

var contador = 0;

foreach (var i in vector)
{
    contador++;
    Console.WriteLine("Posición " + contador + ", elemento : " + i + " ");
}

Console.WriteLine(" ");
Console.WriteLine("========Datos Invertidos========");
Console.WriteLine(" ");

int aux = 0;

for (cantidad = vector.Length;cantidad == 0;cantidad--)  // Funciona igual si intercambio Cantidad por Posicion. Con Cantidad queda mejor.
{
    //aux = posicion;
    aux = vector[cantidad];
}

foreach (var i in vector)
{
    contador--;
    Console.WriteLine($"Posición  {contador + 1} , elemento : {i} ");
}

Console.ReadKey();
