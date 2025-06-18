using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class ExemploBoleano
    {
        public static void Main(string[] args)
        {
            int num1 = 10;

            int num2 = 20;

            Console.WriteLine(num1 > num2);

            int num3 = 17;

            Console.WriteLine(num3 == 17);

            int minhaIdade = 18;

            int votagemIdade = 16;

            if(minhaIdade >= votagemIdade)
            {
                Console.WriteLine("Pode votar");
            }
            else
            {
                Console.WriteLine("Não pode votar");
            }
        }
    }
}
