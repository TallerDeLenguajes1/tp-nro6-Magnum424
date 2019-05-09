using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, aux;
            string op;
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Producto");
            Console.WriteLine("4.Division");
            Console.WriteLine("Ingrese la operacion a realizar:");
            op = Console.ReadLine();
            Console.WriteLine("Ingrese los numeros a operar:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            switch (op)
            {
                case "Suma":
                    aux = num1 + num2;
                    Console.WriteLine("La suma es:" + aux);
                    Console.ReadKey();
                    break;
                case "Resta":
                    aux = num1 - num2;
                    Console.WriteLine("La resta es:" + aux);
                    Console.ReadKey();
                    break;
                case "Producto":
                    aux = num1 * num2;
                    Console.WriteLine("El producto es:" + aux);
                    Console.ReadKey();
                    break;
                case "Division":
                    aux = num1 / num2;
                    Console.WriteLine("La division es:" + aux);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("NO");
                    break;
            }
        }
    }
}
