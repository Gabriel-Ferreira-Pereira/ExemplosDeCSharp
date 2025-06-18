using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploSystemLinq
    {
        public static void Main(string[] args)
        {
            int[] num = { 5, 18, 31, 7 };

            Console.WriteLine(num.Max());

            Console.WriteLine(num.Min());

            Console.WriteLine(num.Sum());
        }
    }
}
