using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosComRetorno
    {
        class CalculadoraComum
        { 
            public int Somar(int c, int d) { return c + d; }// Método Soma com 2 parametros int
            public int Somar(int e, int f, int g) { return e + f + g; }
            public int Somar(double h, int j) { return (int)h + j; }
            public int Somar(int k, double l) { return k + (int)l; }
        }
        class Calculadora
        {
            public int Somar(int a, int b) { return a + b; }
            public int Subtrair(int a, int b) { return a - b; }
            public int Multiplicar(int a, int b) { return a * b; }

           
        }
        public static void Executar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Somar(1, 2);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadora.Subtrair(2, 3));
            Console.WriteLine(calculadora.Multiplicar(4, 4));
            // chamei o CalculadoraCadeia
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().limpar().Imprimir();
            
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
        class CalculadoraCadeia
        {
            int memoria;

            public CalculadoraCadeia Somar ( int a)
            {
                memoria += a;
                return this;// this que dizer a instancia atual que voce esta fazendo
            }
            public CalculadoraCadeia Multiplicar ( int a)
            {
                memoria *= a;
                return this;
            }
            public CalculadoraCadeia limpar()
            {
                memoria = 0;
                return this;
            }
            public CalculadoraCadeia Imprimir ()
            {
                Console.WriteLine(memoria);
                return this;
            }
            public int Resultado() { return memoria; }
        }
    }
}
