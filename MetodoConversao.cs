using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class MetodoConversao
    {
        public static void Main(string[] args)
        {
            int num1 = 18;

            double num2 = 168.495D;

            bool teste = true;

            Console.WriteLine(Convert.ToString($"Virei string: {num1}"));

            Console.WriteLine(Convert.ToDouble(num1)); // Não pode colocar string(texto)

            Console.WriteLine(Convert.ToInt32(num2)); // Não pode colocar string(texto)

            Console.WriteLine(Convert.ToString($"Virei string: {teste}"));
        }
    }
}
