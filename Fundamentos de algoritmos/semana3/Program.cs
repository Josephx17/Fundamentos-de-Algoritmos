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
            ejercicio8();
            Console.ReadKey();
        }
        static void ejercicio01()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre + " Bienvenido al curso de Fundamento De Algoritmos");
        }
        static void ejercicio2()
        {
            Console.WriteLine("Fabrizzio 19 Ing De Sistemas");
        }

        static void ejercicio3()
        {
            Console.WriteLine("\"Fabrizzio\"");
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

        static void ejercicio5()
        {
            int bs, alt, area;
            Console.WriteLine("Ingrese la base del triangulo: ");
            bs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo: ");
            alt = int.Parse(Console.ReadLine());

            area = (bs * alt) / 2;

            Console.WriteLine($"\nEl area del triangulo es: " + area);
        }

        static void ejercicio6()
        {
            double num1, num2, num3, prom;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = double.Parse(Console.ReadLine());

            prom = num1 + num2 + num3 / 3;

            Console.WriteLine("\n El promedio es: " + Math.Round(prom, 2));
        }
        static void ejercicio7()
        {
            int radio;
            double area;

            Console.WriteLine("Ingrese el radio del circulo: ");
            radio = Convert.ToInt32(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("\nEl area del circulo es: " + Math.Round(area, 2));
        }
        static void ejercicio8()
        {
            double num1;

            Console.Write("Ingrese un numero decimal: ");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nLa raiz cuadrada es : " + Math.Sqrt(num1));
            Console.WriteLine("La potencia a 3 es: " + Math.Pow(num1, 3));

        }
    }                   
}