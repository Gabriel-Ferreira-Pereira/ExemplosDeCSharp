using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploParametroPadrao
    {
        static void Paises(string paises = "Brasil")
        {
            Console.WriteLine($"País: {paises}");
        }

        public static void Main(string[] args)
        {
            Paises();
            Paises("EUA");
        }
    }
}
