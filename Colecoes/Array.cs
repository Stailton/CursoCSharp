using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (string s in alunos)
            {
                Console.WriteLine(s);
            }

            double somatoria = 0;
            double[] notas = { 9.5, 4.8, 8.5, 8.3, 7 + 0 };

            foreach (double d in notas) { somatoria += d; }

            double media = somatoria / (double)notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'b', };
            string palavras = new string(letras);
            Console.WriteLine(palavras);
        }
    }
}
