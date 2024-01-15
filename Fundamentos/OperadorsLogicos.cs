using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorsLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comproTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Compro a Tv 50? {0}", comproTv50);

            bool comproSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Cmprou o sorvete? {0}", comproSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}",comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comproSorvete);
        }
    }
}
