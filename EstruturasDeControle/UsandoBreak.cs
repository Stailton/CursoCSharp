using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1,33);
            Console.WriteLine("O é o número que queremos é {0}",numero);

            for (int i = 0; i < 33; i++) { 
            Console.WriteLine("{0} é o número que queremos?", i);
                if (i == numero)
                {
                    Console.WriteLine("sim");
                }
                else { Console.WriteLine("não");
                }
            }
        }
    }
}
