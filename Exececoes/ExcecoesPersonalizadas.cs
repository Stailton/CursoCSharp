using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exececoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }
    internal class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random rnd = new Random();
            int valor = rnd.Next(-30,30);

            if(valor < 0)
            {
                throw new NegativoException("Numero negativo...");
            }
            if(valor% 2 == 1)
            {
                throw new NegativoException("Valor impar");
            }
            return valor;
        }
      
        public static void Executar() {
            try
            {
                Console.WriteLine(PositivoPar());
            }catch(NegativoException ex) { Console.WriteLine(ex.Message); }
            catch(ImparException ex) { Console.WriteLine(ex.Message); }
        }
    }
}
