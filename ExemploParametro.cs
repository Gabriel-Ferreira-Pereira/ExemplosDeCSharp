using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploParametro
    {
        static void Nome(string primeiroNome)
        {
            Console.WriteLine($"{primeiroNome} Ferreira");
        }

        public static void Main(string[] args)
        {
            Nome("Gabriel");
            Nome("Junior");
        }
    }
}
