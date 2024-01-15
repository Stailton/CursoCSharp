using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filme = new Dictionary<int,string>();

            filme.Add(2000,"gladiador");
            filme.Add(2003,"homwm-Aranha");
            filme.Add(2004,"os incriveis");
            filme.Add(2005, "O grande truque");

            if (filme.ContainsKey(2004))
            {
                Console.WriteLine("2004:" + filme[2004]);
                Console.WriteLine("2004:" + filme.GetValueOrDefault(2004));
            }
            Console.WriteLine(filme.ContainsValue("Amnésia"));
            Console.WriteLine($"Removeu? {filme.Remove(2004)}");

            filme.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme{filme2006}!");

            foreach (var chave in filme.Keys)
            {
                Console.WriteLine(chave);
            }
            foreach(var valor in filme.Values)
            {
                Console.WriteLine(valor);
            }
            foreach(KeyValuePair<int, string> filmes in filme) { Console.WriteLine($"{filmes.Value} é de {filmes.Key}.");}

            foreach (var filmes in filme) { Console.WriteLine($"{filme.Values} é de {filme.Keys}."); }
        }
    }
}
