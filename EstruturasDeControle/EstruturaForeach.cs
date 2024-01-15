using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var item in palavra)
            {
                Console.WriteLine(item);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}
