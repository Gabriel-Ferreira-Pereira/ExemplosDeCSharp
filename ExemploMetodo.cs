using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploMetodo
    {
        static void MeuTesteString()
        {
            string testeSting = "Olha o teste";
            Console.WriteLine(testeSting);
        }

        static void MeuTesteInt()
        {
            int testeInt = 17 + 1;
            Console.WriteLine(testeInt);

        }

        public static void Main(string[] args)
        {
            MeuTesteString();
            MeuTesteInt();
        }
    }
}
