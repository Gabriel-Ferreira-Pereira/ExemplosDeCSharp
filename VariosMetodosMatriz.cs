using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class VariosMetodosMatriz
    {
        public static void Main(string[] args)
        {
            string[] teste = new string[4];

            for(int i = 0; i < teste.Length; i++)
            {
                Console.WriteLine("Digite o teste: ");

                teste[i] = Console.ReadLine();
            }

            for(int i = 0; i < teste.Length ; i++)
            {
                Console.WriteLine(teste[i]);
            }

            int[] teste2 = new int[4] { 1, 2, 3, 4 };

            string[] teste3 = new string[] { "teste", "Teste" };

            string[] teste4 = { "Teste", "teste" };
        }
    }
}
