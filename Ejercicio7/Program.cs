using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Frase, Reves = "";
            Console.Write("Ingresa la frase:");
            Frase = Console.ReadLine();
            foreach (char letra in Frase)
            {
                Reves = letra + Reves;
            }
            Console.WriteLine($"{Frase} al reves es: {Reves}");
            Console.ReadKey();
        }
    }
}