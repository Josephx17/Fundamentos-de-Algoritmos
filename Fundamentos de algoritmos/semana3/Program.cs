using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio4();
            Console.ReadKey();
        }
        static void ejercicio01()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre + " Bienvenido al curso de Fundamento De Algoritmos");
        }
        static void ejercicio4()
        {
            int num1, num2;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es : " + (num1 + num2));
            Console.WriteLine("La resta es : " + (num1 - num2));
            Console.WriteLine("La multiplicacion es : " + (num1 * num2));
            Console.WriteLine("La multiplicacion es :" + (num1 / num2));
            Console.ReadKey();
        }
                            
    }
}
