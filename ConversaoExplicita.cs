using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ConversaoExplicita
    {
        public static void Main(string[] args)
        {
            double num1 = 4.58D;

            int num2 = (int)num1;

            Console.WriteLine(num1);

            Console.WriteLine(num2);
        }
    }
}
