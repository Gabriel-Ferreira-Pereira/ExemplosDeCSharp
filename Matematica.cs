using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class Matematica
    {
        public static void Main(string[] args)
        {
            // Mostra o número maximo entre dois
            Console.WriteLine(Math.Max(2, 78));

            // Mostra o número minimo entre dois
            Console.WriteLine(Math.Min(234, 18));

            // Mostra a raiz quadrada
            Console.WriteLine(Math.Sqrt(25));

            // Converte o número negativo em positivo
            Console.WriteLine(Math.Abs(-57.48));

            // Arredonda o valor
            Console.WriteLine(Math.Round(17.98));
        }
    }
}
