using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, inverso, rem;
            inverso = 0;
            a = int.Parse(Console.ReadLine());
            if (a >= 0)
            {
                while (a != 0)
                {
                    rem = a % 10;
                    inverso = inverso * 10 + rem;
                    a = a / 10;
                }
                Console.WriteLine("Número invertido:" + inverso);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Pos no");
            }
        }
    }
}
