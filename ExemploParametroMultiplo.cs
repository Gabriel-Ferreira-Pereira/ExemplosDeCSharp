using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploParametroMultiplo
    {
        static void Nome(string primeiroNome, string segundoNome, int idade)
        {
            Console.WriteLine($"{primeiroNome} {segundoNome} e tenho {idade}");
        }

        public static void Main(string[] args)
        {
            Nome("Gabriel", "Ferreira", 18);
            Nome("Junior", "Robson", 21);
        }
    }
}
