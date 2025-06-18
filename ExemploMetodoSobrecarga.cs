using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExemploMetodoSobrecarga
    {
        /*
        static int MetodoSomaComNumerosInteiros(int num1, int num2)
        {
            return num1 + num2;
        }

        static float MetodoSomaComNumerosFlutuantes(float num1, float num2)
        {
            return num1 + num2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"A soma deu: {MetodoSomaComNumerosInteiros(5, 5)}");

            Console.WriteLine($"A soma deu: {MetodoSomaComNumerosFlutuantes(5.55F, 5.5F)}");
        }
        */

        static int MetodoSoma(int num1,  int num2)
        {
            return num1 + num2;
        }

        static float MetodoSoma(float num1, float num2)
        {
            return num1 + num2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"A soma deu: {MetodoSoma(5, 5)}");

            Console.WriteLine($"A soma deu: {MetodoSoma(5.55F, 5.5F)}");
        }
    }
}
