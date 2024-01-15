using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7; // atribui um novo valor a num1 7
            num1 += 10;// num1 = num1 + 10 adição
            num1 -= 3;// num1 = num1 - 3 subtração
            num1 *= 5;// num1 = num1 * 5 multiplicação
            num1 /= 2;// num1 = num1 / 2 divisão

            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            a++;// a = a + 1 incrementa
            b--;// b = b - 1 decrementa
            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine(c.nome);
        
        }
    }
}
