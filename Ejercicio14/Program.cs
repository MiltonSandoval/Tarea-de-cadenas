using System;
using System.Threading.Channels;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[4];

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}:");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El numeros menor es:{Numeros.Min()}");
            Console.WriteLine($"El numeros mayor es:{Numeros.Max()}");
            Console.ReadKey();
        }
    }
}
