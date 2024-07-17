using System;

namespace Ejercicio8
{
    class program
    {
        static void Main(string[] args)
        {
            string Frase, Letra;
            Console.Write("Ingresa una frase:");
            Frase = Console.ReadLine();

            Console.Write("Ingresa una letra:");
            Letra = Console.ReadLine();

            if (Frase.Contains(Letra))
            {
                Console.WriteLine($"La letra: {Letra} forma parte de la frase {Frase}");
            }
            else
            {
                Console.WriteLine($"La letra no forma parte de la frase {Frase}");
            }
            Console.ReadKey();
        }
    }
}