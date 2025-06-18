using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class VetorMatriz
    {
        public static void Main(string[] args)
        {
            string[] jogos = { "FNAF", "Call Of Duty", "Hollow Knight" };

            jogos[2] = "Sonic Generations";

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(jogos[i]);
            }

            int[] nums = { 18, 78, 34, 54 };

            nums[1] = 48;

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }

            /* Console.WriteLine(jogos[0]);

            Console.WriteLine(nums[0]); */
        }
    }
}
