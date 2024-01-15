using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;
            
            public Cliente(string nome, DateTime nascimento) {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            var novoClient = new Cliente("Ana Luiza", new DateTime(1989, 5, 22));
            Console.WriteLine(novoClient.Nome);
            Console.WriteLine(novoClient.GetDataDeNascimento());
        }
    }
}
