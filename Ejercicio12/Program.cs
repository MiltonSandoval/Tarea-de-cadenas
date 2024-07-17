using System;

namespace Ejercicio12
{
    class Programa
    {
        static void Main(string[] args)
        {
            string Nombre;
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();

            for (int i = 1; i <= Nombre.Length; i++)
            {
                Console.WriteLine(Nombre.Substring(0,i));
            }
            Console.ReadKey();
        }
    }
}