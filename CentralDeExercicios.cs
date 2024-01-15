using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp
{
    public class CentralDeExercicios
    {
        Dictionary<string, Action> exercicios;
        public CentralDeExercicios(Dictionary<string, Action> exercicios)
        {
            this.exercicios = exercicios;
        }

        public void SelecionarEExecutar()
        {
            int i = 1;
            foreach (KeyValuePair<string, Action> entry in this.exercicios)
            {
                Console.WriteLine("{0} ) {1}", i++, entry.Key);
            }
            Console.WriteLine("Digite o número (ou vazio para o último)?");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            bool numValido = num > 0 && num <= this.exercicios.Count;
            num = numValido ? num - 1 : this.exercicios.Count - 1;
            string nomeDoEexercicio = this.exercicios.ElementAt(num).Key;

            Console.WriteLine("Executando exercicio");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(nomeDoEexercicio);
            Console.ResetColor();
            Console.WriteLine(String.Concat(Enumerable.Repeat("=", nomeDoEexercicio.Length + 21)) + "\n");

            Action exercicio = this.exercicios.ElementAt(num).Value;
            try
            {
                exercicio();
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();
                Console.WriteLine(e.StackTrace);
            }
        }
    }  
}