using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploClassificacaoStringMatriz
    {
        public static void Main(string[] args)
        {
            string[] pecas = { "Placa-Mâe", "Processador", "Memoria RAM", "HDD", "SSD" };

            Array.Sort(pecas);

            foreach(string i in pecas)
            {
                Console.WriteLine(i);
            }
        }
    }
}
