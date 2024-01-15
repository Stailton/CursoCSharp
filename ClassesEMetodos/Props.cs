using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Props
    {
        public class CarroOpicional
        {
            private double desconto = 0.1;
            private string nome;
            public string Nome {
                get
                {
                    return " Opicional:" + nome;
                }
                set { nome = value; }
            }
            // Propriedade auto implementada
            public double Preco { get; set; }

            // somente leitura
            public double PrecoComDesconto { get => Preco - (desconto * Preco); }//LAMBDA
            public CarroOpicional() { }
            public CarroOpicional(string nome, double preco) { 
                this.nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var op1 = new CarroOpicional("Ar Condicionado", 3999.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpicional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2000.9;
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
