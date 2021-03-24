using System;

namespace Recursion
{
    class Program
    {
        static int sumaRecursiva (int n)
        {
            if (n == 1)
                return 1;
            else
                return n + sumaRecursiva(n-1);

        }

        static void Main (string[] args)
        {
            int n;

            Console.Write(" Ingresar los numeros a sumar: ");
            n = int.Parse(Console.ReadLine() );

            Console.Write(" La suma de los numeros es : " + sumaRecursiva(n) );
           Console.ReadKey();
        }  
    }
}
