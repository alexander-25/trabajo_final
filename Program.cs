using System;

namespace miprograma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nombre: Jose Delio Gonzales Aracena");
            Console.WriteLine("Matricula: 17-EIIN-1-108");
            Console.WriteLine();

	        Console.Write("Este programa imprime los cuadrados de los primeros n enteros.");
            Console.WriteLine(" y un numero elegido por el usario.");

            int maximo = 100;
            string mensaje = "Por favor introduzca un numero entre 1 y " + maximo + " : ";
	        int numero;
	        Console.Write(mensaje);
	        numero = int.Parse(Console.ReadLine());

            
            if (numero < 1 ) {
                Console.WriteLine("El numero no puede ser menor que 1.");
                Environment.Exit(1);
            }


            if (numero > maximo ) {
                Console.WriteLine("El numero no puede ser mayor que {0}.", maximo);
                Environment.Exit(1);
            } 

            for (int i = 1; i <= numero; i++) {
                Console.WriteLine("{0}*{1}={2}", i,i,i*i);
            }
            
        }
    }
}
