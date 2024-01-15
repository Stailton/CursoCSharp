using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada1;

            Console.WriteLine("Informe o tamanho da turma:");
            entrada1 = Console.ReadLine();
            double.TryParse(entrada1, out double tamanhoTurma);

            for (int c = 1; c <= tamanhoTurma; c++)
            {
                Console.WriteLine("Informe a nota do aluno {0}:", c);
                entrada1 = Console.ReadLine();
                double.TryParse(entrada1, out double notaAtual);
                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);

            
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"O valor de i é {i}.");
                i++;
            }

            for (int a = 1 ; a <= 10 ; a++)
            {
                Console.WriteLine($"O valor de i é {a}.");
            } 
        }
    }
}
