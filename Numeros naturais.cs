using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros naturais entre 1 a 100");

            int soma = 0;

            for (int x = 1; x <= 100; x++) 
            {
                soma = soma + x;
                Console.WriteLine(x);
            }

            Console.WriteLine("A soma de todos os naturais até 100 é =" +  soma);
           

            Console.ReadKey(); 
        }
    }
}
