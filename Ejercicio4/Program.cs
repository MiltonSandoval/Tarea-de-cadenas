using System;


namespace Ejercicio4
{
    class Programa
    {
        static void Main(string[] args) 
        {
           
            double Numero1, Numero2;
            string Opcion;
            string Controlador;
            
            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("Bienvenido al programa de operaciones de 2 numeros");
               
                Console.Write("Ingrese el primer numero:");
                Numero1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero:");
                Numero2 = double.Parse(Console.ReadLine());

               
                Opcion = Menu();
               
                Console.WriteLine(Operaciones(Opcion, Numero1, Numero2));
               
                Console.WriteLine(
                    "\n ¿Desea hacer otra operacion? \n" +
                    "1. Otra operacion\n" +
                    "2. Salir \n");
                Console.Write("Ingrese su opcion:");
                Controlador = Console.ReadLine();
                if (Controlador == "2")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
        
        static string Menu()
        {
            Console.WriteLine(
                "\n Menu de operaciones \n" +
                "1.Sumar (+)\n" +
                "2.Restar (-)\n" +
                "3.Multiplicar (*)\n" +
                "4.Dividir (/)\n");
            Console.Write("Ingrese su opcion:");
            return Console.ReadLine();
        }

        static string Operaciones(string Opcio, double num1, double num2)
        {
            switch (Opcio)
            {
                case "1":
                case "+":
                    return $"El resultado es: {num1 + num2}";

                case "2":
                case "-":
                    return $"El resultado es: {num1 - num2}";

                case "3":
                case "*":
                case "x":
                case "X":
                    return $"El resultado es: {num1 * num2}";

                case "4":
                case "/":
                    if (num2 == 0)
                        return "Error: no se puede dividir entre 0";
                    return $"El resultado es: {num1 / num2}";

                default:
                    return $"Error: opción inválida: {Opcio}";
            }
        }

    }
}