using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é "+ area);
            // soma na contanenação
            Console.WriteLine("Área é " + (area + 1000));

            // tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);
            // tipos numericos
            byte idade = 45;
            Console.WriteLine("idade " + idade);
            // tipos internos
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario " + salario);

            int menorValorInt = int.MinValue; // mais usado em valores inteiros!
            Console.WriteLine("menor valor int " +  menorValorInt);

            uint populacaoBrasileira = 207_000_000;
            Console.WriteLine("População Brasileira " +  populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_000_000_000;
            Console.WriteLine("população mundial " + populacaoMundial);

            float precoComputador = 122.99f; // pode usar 122.33F ou 122.22f
            Console.WriteLine("preço do computador " +  precoComputador);

            double valorDeMercadoDaApple = 10000000000000000.99;
            Console.WriteLine("valor de mercado da apple " +  valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("distancia entre as estrelas " +  distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " +  letra);

            string texto = "seja bem vindo ao curso de csharp";
            Console.WriteLine(texto);
        }
    }
}
