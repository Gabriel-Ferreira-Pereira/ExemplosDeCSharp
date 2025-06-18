using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploParametroRetorno
    {
        /*
        static int Valor(int num)
        {
            return 5 + num;
        }
        */

        /*
        static int Valor(int num1, int num2)
        {
            return num1 + num2;
        }
        */

        static int Valor(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Main(string[] args)
        {
            int numTotal = Valor(5, 5);
            Console.WriteLine(numTotal);
        }
    }
}
