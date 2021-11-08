using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero y te dire si es multiplo de 2 o 3");
            int n = Convert.ToInt32(Console.ReadLine());

            //ejercicios 1 y 2
            /*if (n % 2 == 0 && n % 3 == 0)
                {
                    Console.WriteLine("Es multiplo de 2 y de 3");

                }
            else if (n % 2 == 0)
                {
                    Console.WriteLine("Es multiplo de 2");

                }
            else if (n % 3 == 0)
                {
                    Console.WriteLine("Es multiplo de 3");

                }
            else
                {
                    Console.WriteLine("No es multiplo ni de 2 ni de 3");
                }
            */

            //ejercicios 3 y 4
            /*
            if (!(n % 2 == 0) && !(n % 3 == 0))
            {
                Console.WriteLine("No es multiplo ni de 2 ni de 3");

            }
            else if (!(n % 2 == 0))
            {
                Console.WriteLine("Es multiplo de 3, pero no de 2");

            }
            else if (!(n % 3 == 0))
            {
                Console.WriteLine("Es multiplo de 2, pero no de 3");

            }
            else
            {
                Console.WriteLine("Es múltiplo de 3 y de 2");
            }
            */

            // ejercios 5, 6 y 7
            Console.WriteLine("Dame otro numero");
            int n2 = Convert.ToInt32(Console.ReadLine());
            /*
         

            if (n % 2 == 0 && n2 % 2 == 0)
            {
                Console.WriteLine("Ambos son pares");
            }
            else if (n % 2 == 0 || n2 % 2 == 0)
            {
                Console.WriteLine("Uno es par");
            }
            else Console.WriteLine("Ninguno es par");
            */
            // ejercicio 8
            /*
            if (n > 0 && n2 > 0)
            {
                Console.WriteLine("Ambos son positivos");
            }
            else if (n >0 || n2 > 0)
            {
                Console.WriteLine("Solo 1 es positivo");
            }
            else Console.WriteLine("Ninguno es positivo");
            */
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n3 >= n2 && n3 >= n)
            {
                Console.WriteLine(n3 + " Es el mayor");
            }
            else if (n2 >= n)
            {
                Console.WriteLine(n2 + " Es el mayor");
            }
            else Console.WriteLine(n + " Es el mayor");

        }
    }
}
