using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametroPadrao
    {
        public static int Soma (int a = 1, int b  = 2) {  return a + b; }
        public static void Executar()
        {
            Console.WriteLine(Soma(10, 23));
            Console.WriteLine(Soma(50));
            Console.WriteLine();
            Console.WriteLine(Soma(b: 7));
        }
    }
}
