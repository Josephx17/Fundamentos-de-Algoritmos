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
            ejercicio01();
            Console.ReadKey();
        }
        static void ejercicio01()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre+" Bienvenido al curso de Fundamento De Algoritmos");


        }
    }
}
