using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Struct
    {
        interface Ponto
        {
            void MoverNaDiagonal(int delta);
        }

        struct Coordenada: Ponto {
            public int x;
            public int y;

            public Coordenada (int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void MoverNaDiagonal(int delta)
            {
                this.x += delta;
                this.y += delta;
            }
        }
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.x =2;
            coordenadaInicial.y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("x = {0}", coordenadaInicial.x);
            Console.WriteLine("y = {0}", coordenadaInicial.y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1) ;
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("x = {0}", coordenadaFinal.x);
            Console.WriteLine("y = {0}", coordenadaFinal.y);

        }
    }
}
