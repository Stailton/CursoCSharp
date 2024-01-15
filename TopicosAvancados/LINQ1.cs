using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ1
    {
        public class Aluno
        {
            public string Nome;
            public int Idade;
            public double Nota;
        }
        public static void Executar() {
            var aluno = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.5 },
                new Aluno() {Nome = "Andre", Idade = 35, Nota =8.0},
                new Aluno() {Nome = "Ana", Idade = 24, Nota =9.0},
                new Aluno() {Nome = "Jorge", Idade = 40, Nota = 10.0},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "julia", Idade = 22, Nota = 7.7},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 7.3},
                new Aluno() {Nome = "Andre", Idade = 13, Nota = 4.3}
                
            };

            Console.WriteLine("=== Aprovados ===");
            var aprovados = aluno.Where(a => true);
            foreach (var alunosX in aprovados)
            {
                Console.WriteLine(alunosX.Nome);
            }

            
            Console.WriteLine("=== Reprovados ===");
            var aprovadoX = aluno.Where(b => false);
            foreach(var b in aprovadoX)
            {
                Console.WriteLine(b.Nome);
            }

            Console.WriteLine("=== Idades 24 ===");
            var aprovadoA = aluno.Where(a => a.Idade > 24);
            foreach(var b in aprovadoA)
            {
                Console.WriteLine(b.Nome);
            }

            Console.WriteLine("=== Lista de Aprovados nivel 2 ===");
            var aprovadoY = aluno.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var b in aprovadoY)
            {
                Console.WriteLine(b.Nome);
            }

            Console.WriteLine("\n=== Chamada dos alunos ===");
            var chamada = aluno.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var b in chamada)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\n=== Aprovados por Idade ===");
            var alunosAprovados =
                from alunos in aluno
                where alunos.Nota >= 7
                orderby alunos.Idade
                select alunos.Nome;
            foreach(var alunos in alunosAprovados)
            {
                Console.WriteLine(alunos);
            }

    
        }
    }
}
