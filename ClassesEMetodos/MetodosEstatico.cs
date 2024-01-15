using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstatico
    {
        
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}",resultado);
            Console.WriteLine(CalculadoraEstatica.Somar(2, 2));
            
            CalculadoraEstatica calc = new CalculadoraEstatica();// criei um construtor para usar a instancia
            Console.WriteLine(calc.Divide(6, 2));// esse metodo aque é acessivel pela instancia
        }
        public class CalculadoraEstatica
        {
            public static int Somar(int a, int b) { return a + b; }
            // quando eu coloco static que dizer que esse metodo não pertence ao objeto e sim pertence a classe
            public static int Multiplicar(int a, int b) { return a * b; }//Metodo de classe ou Metodo de estatico

            public int Divide(int a, int b) { return a / b; }// Metodo de instancia
        }
    }
}
