using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }
    public class Cponto
    {
        public int X;
        public int Y;
    }
    internal class StructVsClasses
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto {X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; // Atribuiçao por valor.
            ponto1.X = 2;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X);

            Cponto ponto2 = new Cponto { X = 3, Y = 4};
            Cponto copiaPonto2 = ponto2;// Atribuiçao por Referencia
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X: {0}",copiaPonto2.X);
        }
    }
}
