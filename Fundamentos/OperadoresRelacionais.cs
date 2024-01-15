using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);// maior que
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);// menor que
            Console.WriteLine("Perfeito? {0}", nota == 10.0);// operador de igualdade
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);// dirente de
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);// se é maior ou igual
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte); // se é menor que
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); //se menor ou igual a

            Console.WriteLine("Digite o valor da nota:");
            double.TryParse(Console.ReadLine(), out double nota1);
            Console.WriteLine("O valor da nota é {0}", nota1);
            Console.WriteLine("Nota invalida? {0}", nota1 > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota1 < 0.0);
            Console.WriteLine("Perfeito? {0}", nota1 == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota1 != 10.0);
            Console.WriteLine("Passou por média? {0}", nota1 >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota1 < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota1 <= 3.0);
        }
    }
}
