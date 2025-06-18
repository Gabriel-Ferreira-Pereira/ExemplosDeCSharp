using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploParametroConstrutor
    {
        public string modelo;

        public ExemploParametroConstrutor(string nomeModelo)
        {
            modelo = nomeModelo;
        }

        public static void Main(string[] args)
        {
            ExemploParametroConstrutor Chervrolet = new ExemploParametroConstrutor("Opala 6 CC");

            Console.WriteLine($"Você tem um Chervrolet {Chervrolet.modelo}");
        }
    }
}
