using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploMatriz2D
    {
        public static void Main(string[] args)
        {
            int[,] num = { { 2, 6, 8 }, { 3, 7, 9 } };

            Console.WriteLine(num[0, 1]);

            Console.WriteLine(num[1, 2]);
        }
    }
}
