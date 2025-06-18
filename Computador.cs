using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class Computador
    {
        string placaMae = "B550M";
        int ram = 16;
        string processador = "Ryzen 5500GT";
        int fonte = 800;
        int ssdNvme = 1;

        public static void Main(string[] args)
        {
            Computador pecas = new Computador();

            Console.WriteLine($"A placa-Mãe é a {pecas.placaMae}");
            Console.WriteLine($"A memória RAM tem {pecas.ram}GB");
            Console.WriteLine($"O processador é um AMD {pecas.processador}");
            Console.WriteLine($"A fonte é de {pecas.fonte}W");
            Console.WriteLine($"O SSDNvme é de {pecas.ssdNvme}TB");
        }
    }
}
