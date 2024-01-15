using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(int numero)
        {
            numero = numero + 15;
        }
        public static void AlterarRef1(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut1(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(a);
            Console.WriteLine(a);

            int b = 2;
            AlterarOut(b); Console.WriteLine(b);

            int c = 3;
            AlterarRef1(ref c);
            Console.WriteLine(c);

            
            AlterarOut1(out int d);
            Console.WriteLine(d);
        }
    }
}
