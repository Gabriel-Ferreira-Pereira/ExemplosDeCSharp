using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploForEach
    {
        public static void Main(string[] args)
        {
            string[] nomes = { "Gabriel", "Caio", "Rose", "José", "Douglas" };

            foreach(string i in nomes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
