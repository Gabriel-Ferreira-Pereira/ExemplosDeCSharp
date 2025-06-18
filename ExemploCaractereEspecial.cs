using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class ExemploCaractereEspecial
    {
        public static void Main(string[] args)
        {
            string aspasSimples = "O \'Teste\' tá funcionando";

            string aspasDuplas = "O \"Teste\" tá funcionando";

            string barraInvertida = "O \\Teste\\ tá funcionando";

            string novaLinha = "O Teste\n tá funcionando";

            string tabulacao = "O teste\t tá funcionando";

            string apagar = "O Teste\b tá funcionando";

            Console.WriteLine(aspasSimples);

            Console.WriteLine(aspasDuplas);

            Console.WriteLine(barraInvertida);

            Console.WriteLine(novaLinha);

            Console.WriteLine(tabulacao);

            Console.WriteLine(apagar);
        }
    }
}
