using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;  


            }
            public override bool Equals(object? obj)
            {
                Produto outro = (Produto)obj;
                bool mesmoNome = Nome == outro.Nome;
                bool mesmoPreco = Preco == outro.Preco;
                return mesmoNome && mesmoPreco;
            }

            //public override int GetHashCode()
            //{
              //  return Nome.Length();
            //}
        }
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;// por referencia
            Console.WriteLine(p1 ==  p2);
            Console.WriteLine(p2 == p3);
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
