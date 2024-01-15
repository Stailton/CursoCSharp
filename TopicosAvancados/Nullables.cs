using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if(num1 != null)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor:");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleano = null;
            bool resultado = booleano.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
