using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploMetodoConstrutor
    {
        public string modelo;

        public ExemploMetodoConstrutor()
        {
            modelo = "Opala 6 CC";
        }

        public static void Main(string[] args)
        {
            ExemploMetodoConstrutor Chevrolet = new ExemploMetodoConstrutor();

            Console.WriteLine($"Você tem um Chevrolet {Chevrolet.modelo}");
        }
    }
}
