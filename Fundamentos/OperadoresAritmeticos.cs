using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("o total {0} e o total com desconto {1}", total, totalComDesconto);

            // calculo do IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura); // altura ao quadrado
            Console.WriteLine($"IMC é {imc}.");

            // calculo do IMC
            double peso1 = 91.2;
            double altura1 = 1.82;
            double imc1 = peso1 / Math.Pow(altura1, 2); // altura ao quadrado
            Console.WriteLine($"IMC é {imc1}.");

            // numero par / impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); // o resto da divisão
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); // o resto da divisão
        }
    }
}
