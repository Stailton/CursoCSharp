using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaifElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do Aluno:");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota > 9.0)
            {
                Console.WriteLine("Quadro de honra com nota {0}", entrada);
            }else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado com nota {0}", entrada);
            }else { Console.WriteLine("Te vejo na proxima..."); }

            Console.WriteLine("FIM!");
        }
    }
}
