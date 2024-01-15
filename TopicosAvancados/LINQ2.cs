using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public class Aluno
        {
            public string Nome;
            public int Idade;
            public double Nota;
        }
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre",Idade = 14, Nota =6.9},
                new Aluno() {Nome = "Ana", Idade = 25, Nota =9.9},
                new Aluno() {Nome = "Jorge", Idade = 40, Nota = 9.5},
                new Aluno() {Nome = "Ana", Idade = 18, Nota = 7.7},
            };

            var pedro = alunos.Single(alunos => alunos.Nome.Equals("Pedro"));
            Console.WriteLine($" o aluno {pedro.Nome} tem a nota {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"a aluna {ana.Nome} tem a nota { ana.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if(sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(2);
            foreach (var aluno in exemploSkip)
            {
                Console.WriteLine(aluno.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatoriaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatoriaNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaDosAlunoosAprovados = alunos.Where(a => a.Nota >=7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDosAlunoosAprovados);
        }
    }
}
