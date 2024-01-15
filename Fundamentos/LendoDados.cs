using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Eu sou o {0} e tenho {1} anos.", nome, idade);

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("o meu salário é {0}", salario);
            Console.WriteLine("Qual é o seu salário?");
            double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("o meu salário é de {0}", salario1);
        }
    }
}
