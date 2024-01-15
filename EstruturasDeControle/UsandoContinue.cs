using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}!", intervalo);

            for (int i = 0; i < intervalo; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            int intervalo2 = 50;
            Console.WriteLine("Números paraes entre 1 e {0}!", intervalo2);
            for (int i = 2;i < intervalo2; i+= 2) {
                Console.Write(i + " ");
            
            }
        }
    }
}
