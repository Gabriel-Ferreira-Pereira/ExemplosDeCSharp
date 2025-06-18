using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class Professor2
    {
        string nome = "Guanabara";
        string nacionalidade = "Brasileira";

        public static void Main(string[] args)
        {
            Professor2 professor = new Professor2();

            Console.WriteLine($"O nome do novo professor é {professor.nome}");
            Console.WriteLine($"A nacionalidade dele é {professor.nacionalidade}");
        }
    }
}
