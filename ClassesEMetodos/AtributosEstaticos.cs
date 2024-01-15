using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class AtributosEstaticos
    {
        public class Produto
        {
            public string Nome;
            public double Preco;
            public double Descoonto = 0.1;

            public Produto(string nome, double preco, double descoonto)// Construtor padrão public Produto
            {
                Nome = nome;
                Preco = preco;
                Descoonto = descoonto;
            }

            public Produto() { }// Construtor vazio


            public double CalcularDesconto()
            {
                return Preco - Preco * Descoonto;
            }



        }
        public static void Executar()
        {

            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Descoonto = 0.1

            };
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());


        }
    }
}
