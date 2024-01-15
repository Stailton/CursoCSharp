using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C sharp");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
                return rand.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
            //
            Func<int, string> conversorHex = numero => numero.ToString("x");
            Console.WriteLine(conversorHex(1234));

            //
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2022));
        }
    }
}
