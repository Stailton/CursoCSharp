using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exececoes
{
    internal class PrimeiraExcecao
    {
        public class Conta
        {
            double Saldo;

            public Conta(double Saldo)
            {
                this.Saldo = Saldo;
            }

            public void Sacar (double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo insuficiente");
                }

                Saldo -= valor;
            }
        }
        public static void Executar() {
            var conta = new Conta(1_333.33);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
