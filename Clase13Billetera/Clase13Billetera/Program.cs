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
            var denominacionBilleteInicial = int.Parse(Console.ReadLine());
            var miValorBillete = new Billetera();
            miValorBillete.BilleteraDe10 = denominacionBilleteInicial;

            var miValorBilleteSiguienteVuelta = new Billetera();

            var miCantidadBillete = new Billetera();
            for (int i = 0; i < 3; i++)
            {

                miValorBillete.BilleteraDe10 = denominacionBilleteInicial;

                if (miValorBillete.BilleteraDe10 == 10 && miValorBillete.BilleteraDe10 != 0 )
                {
                    Console.WriteLine("Ingrese la cantidad de billetes q posee!");
                    var cantidadBillete = int.Parse(Console.ReadLine());
                    miCantidadBillete.BilleteraDe10 = cantidadBillete;
                }
                else if (miValorBillete.BilleteraDe100 == 100 && miValorBillete.BilleteraDe100 != 0)
                {
                    Console.WriteLine("Ingrese la cantidad de billetes q posee!");
                    var cantidadBillete = int.Parse(Console.ReadLine());
                    miCantidadBillete.BilleteraDe100 = cantidadBillete;
                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad de billetes q posee!");
                    var cantidadBillete = int.Parse(Console.ReadLine());
                    miCantidadBillete.BilleteraDe1000 = cantidadBillete;
                }

                if (miValorBillete.BilleteraDe10 == 10)
                {
                    miValorBilleteSiguienteVuelta.BilleteraDe10 = miValorBillete.BilleteraDe10 * 10;
                }

                if (miValorBillete.BilleteraDe10 == 100)
                {
                    miValorBilleteSiguienteVuelta.BilleteraDe10 = miValorBillete.BilleteraDe10 * 10;

                }

                if (denominacionBilleteInicial == 1000)
                {
                    continue;
                }
            }

            //for (int j = 0; j < 2; j++)
            //{


            //    if (miValorBillete.BilleteraDe20 == 20 && miValorBillete.BilleteraDe20 != 0)
            //    {
            //        Console.WriteLine("Ingrese la cantidad de billetes q posee!");
            //        var cantidadBillete = int.Parse(Console.ReadLine());
            //        miCantidadBillete.BilleteraDe20 = cantidadBillete;
            //    }
            //    else (miValorBillete.BilleteraDe200 == 200 && miValorBillete.BilleteraDe200 != 0)
            //    {
            //        Console.WriteLine("Ingrese la cantidad de billetes q posee!");
            //        var cantidadBillete = int.Parse(Console.ReadLine());
            //        miCantidadBillete.BilleteraDe200 = cantidadBillete;
            //    }

                
            //}

            //for (int k = 0; k < 2; k++)
            //{
            //    if (miValorBillete.BilleteraDe50 == 50 && miValorBillete.BilleteraDe50 != 0)
            //    {
            //        Console.WriteLine("Ingrese la cantidad de billetes q posee!");
            //        var cantidadBillete = int.Parse(Console.ReadLine());
            //        miCantidadBillete.BilleteraDe50 = cantidadBillete;
            //    }
            //    else (miValorBillete.BilleteraDe500 == 500 && miValorBillete.BilleteraDe500 != 0)
            //    {
            //        Console.WriteLine("Ingrese la cantidad de billetes q posee!");
            //        var cantidadBillete = int.Parse(Console.ReadLine());
            //        miCantidadBillete.BilleteraDe500 = cantidadBillete;
            //    }

            //}

            //var sumarBilletes = new Billetera();
            
            Console.WriteLine($"Usted posee:{miCantidadBillete.BilleteraDe10} billetes de $10");
                       
            
        }
    }
}