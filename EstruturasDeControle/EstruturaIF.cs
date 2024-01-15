using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N):");
            entrada = Console.ReadLine();
            if (entrada == "S" ||  entrada == "s")
                bomComportamento = true;
            if( nota >= 9.0 && bomComportamento )
            {
                Console.WriteLine("Quadro de honra!");
            }

            string entrada1;
            Console.WriteLine("Digite a nota do aluno");
            entrada1 = Console.ReadLine();
            double.TryParse(entrada1, out double nota1);
            bomComportamento = entrada1 == "S" || entrada1 =="s";
            bomComportamento = entrada1.ToLower() == "S";
        }
    }
}
