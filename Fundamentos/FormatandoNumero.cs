using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.478;
            Console.WriteLine(valor.ToString("F1"));//Formata valor numerico com uma casa descimal para 15.2
            Console.WriteLine(valor.ToString("C")); //Formata para valor monetario como R$15
            Console.WriteLine(valor.ToString("P")); //usa o simbole de % e calcula 1.512.50%
            Console.WriteLine(valor.ToString("#.##"));// Faz o mesmo que o F1
            CultureInfo culture = new CultureInfo("en-US");//usa o simbolo monetario de um país
            Console.WriteLine(valor.ToString("C0", culture));// usa o simbolo do dolar
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //coloca zeros a direita em 10 caracteres. 0000000256
        }
    }
}
