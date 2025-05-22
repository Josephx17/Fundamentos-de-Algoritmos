using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            char continuar;
            do
            {
                do
                {
                    Console.WriteLine("1. Suma ");
                    Console.WriteLine("2. Resta ");
                    Console.WriteLine("3. Multiplicacion ");
                    Console.WriteLine("4. Division ");
                    Console.WriteLine("0. Salir ");

                    Console.WriteLine("\nIngrese una opcion : ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                } while (opcion < 0 || opcion >= 5);

                Console.Write("Ingrese x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Ingrese y: ");
                int y = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0: Console.WriteLine("Cerrando Sistema "); return;
                    case 1:
                        Suma(x, y);
                        break;
                    case 2:
                        Resta(x, y);
                        break;
                    case 3:
                        Multi(x, y);
                        break;
                    case 4:
                        Divi(x, y);
                        break;
                }
                Console.WriteLine("\n¿Desea regresar al menú? (S/N): ");
                continuar = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continuar == 's');
        }
                static void Suma(int x, int y){
                Console.WriteLine("La suma es: " + (x + y));
                }

                static void Resta(int x, int y){
                Console.WriteLine("La resta es: " + (x - y));
                }
                static void Multi(int x, int y){
                Console.WriteLine("La Multiplicación es: " + (x * y));
                }
                static void Divi(int x, int y){
                 if (y != 0)
                Console.WriteLine("La división es: " + (x / y));
                else Console.WriteLine("No se puede dividir entre 0");
                }
    }
}
