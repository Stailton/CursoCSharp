using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Execute()
        {
            dynamic meuObjeto = "Teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.1;
            aluno.idade = 24;

            Console.WriteLine($"nome:{aluno.nome} nota: {aluno.nota} idade: {aluno.idade}");
        }
    }
}
