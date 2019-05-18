using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pto3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, aux;
            string op;
            Console.WriteLine(" 1.Suma\n 2.Resta\n 3.Producto\n 4.Division\n 5.Valor absoluto\n 6.Raíz\n 7.Potencia\n 8.Seno\n 9.Coseno\n 10.Parte entera\n");
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
                case "Valor absoluto":
                    aux = Math.Abs(num1);
                    Console.WriteLine("El valor absoluto del primer número es:" + aux);
                    aux = Math.Abs(num2);
                    Console.WriteLine("El valor absoluto del segundo número es:" + aux);
                    Console.ReadKey();
                    break;
                case "Raíz":
                    aux = (Math.Sqrt(num1));
                    Console.WriteLine("La raíz del primer número es:" + aux);
                    aux = (Math.Sqrt(num2));
                    Console.WriteLine("La raíz del segundo númmero es:" + aux);
                    Console.ReadKey();
                    break;
                case "Potencia":
                    aux = Math.Pow(num1, 2);
                    Console.WriteLine("El primer número elevado al cuadrado es:" + aux);
                    aux = Math.Pow(num2, 2);
                    Console.WriteLine("El segundo número elevado al cuadrado es:" + aux);
                    Console.ReadKey();
                    break;
                case "Seno":
                    aux = Math.Sin(num1);
                    Console.WriteLine("El seno del primer número es:" + aux);
                    aux = Math.Sin(num2);
                    Console.WriteLine("El seno del segundo número es:" + aux);
                    Console.ReadKey();
                    break;
                case "Coseno":
                    aux = Math.Cos(num1);
                    Console.WriteLine("El coseno del primer número es:" + aux); 
                    aux = Math.Cos(num2);
                    Console.WriteLine("El coseno del segundo número es:" + aux);
                    Console.ReadKey();
                    break;
                case "Parte entera":
                    aux = Math.Truncate(num1);
                    Console.WriteLine("La parte entera del primer número es:" + aux);
                    aux = Math.Truncate(num2);
                    Console.WriteLine("La parte entera del segundo número es:" + aux);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("NO");
                    break;
            }
            aux = Math.Max(num1, num2);
            Console.WriteLine("El máximo es:" + aux);
            aux = Math.Min(num1, num2);
            Console.WriteLine("El mínimo es:" + aux);
        }
    }
}
