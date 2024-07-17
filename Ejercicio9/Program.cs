using System;
using System.Numerics;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa el primer numero: ");
                string num1 = Console.ReadLine();
                Console.Write("Ingresa el segundo numero: ");
                string num2 = Console.ReadLine();

                BigInteger Numero1 = BigInteger.Parse(num1);
                BigInteger Numero2 = BigInteger.Parse(num2);
                BigInteger Resultado = Numero1 + Numero2;

                Console.WriteLine($"El resultado de la suma es: {Resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: solo se aceptan números enteros. \nTipo de error: {ex}");
            }
            Console.ReadKey();
        }
    }
}
