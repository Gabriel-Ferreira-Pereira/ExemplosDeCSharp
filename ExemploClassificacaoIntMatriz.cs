using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploClassificacaoIntMatriz
    {
        public static void Main(string[] args)
        {
            int[] num = { 14, 2, 95, 714, 33, 6 };

            Array.Sort(num);

            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
