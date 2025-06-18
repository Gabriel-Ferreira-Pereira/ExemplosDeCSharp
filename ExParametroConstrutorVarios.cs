using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosDeAula
{
    internal class ExParametroConstrutorVarios
    {
        public string modelo;
        public string cor;
        public int ano;
        public string marca;
        public int preco;

        public ExParametroConstrutorVarios(string nomeModelo, string modeloCor, int modeloAno, string modeloMarca, int modeloPreco)
        {
            modelo = nomeModelo;
            cor = modeloCor;
            ano = modeloAno;
            marca = modeloMarca;
            preco = modeloPreco;
        }

        public static void Main(string[] args)
        {
            ExParametroConstrutorVarios Chevrolet = new ExParametroConstrutorVarios("Opala 6 CC", "Preto", 1988, "Chevrolet", 1000);

            Console.WriteLine($"Você tem um {Chevrolet.marca} {Chevrolet.modelo} de cor {Chevrolet.cor} do ano {Chevrolet.ano}, avaliado a {Chevrolet.preco}");
        }
    }
}
