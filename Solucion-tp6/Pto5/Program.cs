using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pto5
{
    class Program
    {
        static void Main(string[] args)
        {
            string contenido;
            string Condicion_1 = @"\A[w]{3}(\.){a-z0-9}+(\.)(com|net|info|org)\Z";//Expresión regular: dirección web
            string Condicion_2 = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";//Expresión regular: correo electrónico
            contenido = Console.ReadLine();
            if (Regex.IsMatch(contenido, Condicion_1))
            {
                Console.WriteLine("Escribio una dirección web correcta.");
            }
            if (Regex.IsMatch(contenido, Condicion_2))
            {
                Console.WriteLine("Escribió una dirección de e-mail correcta.");
            }
        }
    }
}
