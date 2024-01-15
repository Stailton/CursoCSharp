using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Stela";
            sicrano.Idade = 21;
            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");
            sicrano.ApresentarNoConsole();
            

            var fulano = new Pessoa();
            fulano.Nome = "Ana";
            fulano.Idade = 22;
            var apresentacaoDoFulano = fulano.Apresentar();
            fulano.ApresentarNoConsole();
        }
    }
}
