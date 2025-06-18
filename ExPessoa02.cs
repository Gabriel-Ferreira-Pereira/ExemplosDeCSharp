using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExPessoa02
    {
        public static void Main(string[] args)
        {
            ExPessoa01 gabriel = new ExPessoa01();

            gabriel.Nome = "Gabriel";

            Console.WriteLine(gabriel.Nome);
        }
    }
}
