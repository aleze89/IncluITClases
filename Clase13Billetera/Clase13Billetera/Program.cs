using Clase13Billetera.Modelo;

namespace Clase13Billetera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

            //BilletesDe10
            //BilletesDe20
            //BilletesDe50
            //BilletesDe100
            //BilletesDe200
            //BilletesDe500
            //BilletesDe1000

            //*Agregar un método que se llame Total del tipo decimal, 
            //y que devuelva el Importe Total en la billetera teniendo 
            //en cuenta la cantidad de billetes que se tenga de cada tipo.

            //*Agregar un metodo que se llame Combinar, que reciba como 
            //parámetro otra billetera y que devuelva una nueva Billetera con la suma o 
            //combinacion del dinero de ambas billeteras.  
            //*Una vez combinadas las 2 billeteras(y creada la tercera), 
            //las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
            
            Console.WriteLine("Ingrese la denominacion del billete q posee!");
            var denominacionBillete = int.Parse(Console.ReadLine());
            var miValorBillete = new Billetera();
            miValorBillete.BilleteraDe10 = denominacionBillete;

            var miCantidadBillete = new Billetera();
            if (miValorBillete.BilleteraDe10 != 0 )
            {
                Console.WriteLine("Ingrese la cantidad de billetes q posee!");
                var cantidadBillete = int.Parse(Console.ReadLine());
                miCantidadBillete.BilleteraDe10 = cantidadBillete;
            }
            //else if (true)
            //{

            //}

            //var sumarBilletes = new Billetera();
            Console.WriteLine($"Usted posee:{miCantidadBillete.BilleteraDe10} billetes de $10");
        }
    }
}