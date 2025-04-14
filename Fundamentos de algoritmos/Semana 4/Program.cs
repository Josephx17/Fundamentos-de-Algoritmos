    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio3();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            int num1;

            Console.WriteLine("Ingrese un numero entero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("\nEl numero es par: ");
            }
            else
            {
                Console.WriteLine("\nEl numero es impar");
            }
        }
        static void ejercicio2()
        {
            int edad;
            Console.Write("Ingrese una edad : ");
            edad = int.Parse(Console.ReadLine());

            if (edad <0)
            {
                Console.Write("\nEdad Invalida!!!!!!!");
            }
            else if (edad < 18)
            {
                Console.WriteLine("\nEs menor de Edad");
            }
            else 
            {
                Console.WriteLine("\nEs mayor de edad");
            }
        }
        static void ejercicio3()
        {

        }
    }
}

