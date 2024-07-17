using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre,Dia, Mes;
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa tu dia de nacimiento:");
            Dia = Console.ReadLine();

            Console.Write("Ingresa tu mes de nacimiento:");
            Mes = Console.ReadLine();
            Console.WriteLine($"{Nombre}, nacido el {Dia}/{Mes}");
            Console.ReadKey();
        }
    }
}