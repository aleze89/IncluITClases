//1) Generar un número secreto
//aleatorio con la siguiente instruccion: *PROCESO

//// Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que
//intente adivinar el número que eligió la computadora. *INGRESO DE DATOS

//3) Si el numero ingresado por el usuario es mayor
//al número secreto, avisarle que es muy grande y que intente de nuevo y que *BUCLE (IF ?)
//vuelva al paso 2.

//4) Si el numero ingresado es menor al número
//secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2. *BUCLE (IF ?)

//5) Si el número ingresado coincide con el número *BUCLE (IF ?)
//secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número
//secreto que era:  [numeroSecreto]"
//"Lo has logrado en [n] intentos!!" *CONTADOR!!!

//Y finalizar el programa.

//Nota:
//Obviamente hay que hacer un bucle y crear un contador de intentos.
//Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante es intentarlo.

Console.Clear();
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
var contador = 0;
var numeroIngresado = 0;

do
{
    
    Console.WriteLine("Ingrese un numero, tiene q coincidir con el Número Secreto!!!");
    numeroIngresado = int.Parse(Console.ReadLine());
    Console.Clear();

    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("Muy grande, intentelo de nuevo!!!");
        contador++;
        //Console.Clear();
    }
    else if (numeroIngresado < numeroSecreto)
    {
        Console.WriteLine("Muy chico, intentelo de nuevo!!!");
        contador++;
        //Console.Clear();
    }
    else
    {
        Console.WriteLine($"Felicitaciones!!! Has adivinado el numero secreto q era : {numeroSecreto} en {contador} intentos!!!");
    }


} while (numeroIngresado != numeroSecreto);



