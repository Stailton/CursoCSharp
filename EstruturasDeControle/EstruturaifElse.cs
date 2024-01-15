using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaifElse
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do Alune: ");
            double nota = double.Parse(Console.ReadLine());
            if(nota >= 7.0)
            {
                Console.WriteLine("Aprovado com nota {0}!", nota);
                Console.WriteLine("Fez mais que sua obrigação...");
            } else { Console.WriteLine("recuperação com nota {0}!", nota); }
        }
    }
}
