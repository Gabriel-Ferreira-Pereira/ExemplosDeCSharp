using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class Fruta2
    {
        public static void Main(string[] args)
        {
            Fruta fruta = new Fruta();
            Fruta texto = new Fruta();

            Console.WriteLine($"A fruta é {fruta.nome} e custa {fruta.preco}");
            texto.OlhaOAviso();
        }
    }
}
