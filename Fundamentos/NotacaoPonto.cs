using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá_".ToUpper().Insert(3, " world").Replace("world", "_mundo");
            Console.WriteLine(saudacao);
            Console.WriteLine("teste".Length);
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
