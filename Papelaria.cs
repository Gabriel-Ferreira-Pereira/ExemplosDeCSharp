using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class Papelaria
    {
        public static void Main(string[] args)
        {
            Caderno capa = new Caderno();
            Caderno folhas = new Caderno();
            Caderno aviso = new Caderno();

            capa.cor = "Verde";
            folhas.paginas = 200;

            Console.WriteLine($"O caderno tem a cor {capa.cor}");
            Console.WriteLine($"E possui {folhas.paginas} páginas");
            aviso.Mensagem();
        }
    }
}
