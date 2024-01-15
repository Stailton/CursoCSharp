using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

            var nota1 = 8.0;
            bool bomComportamento = true;
            string novoResultado = nota1 >= 7.0 && bomComportamento ? "bom" : "mau";
            Console.WriteLine(novoResultado);
        }
    }
}
