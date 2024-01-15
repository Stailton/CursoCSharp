using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class Abstract
    {
        public abstract class Celular
        {
            public abstract string Assistente();
            public string Tocar() { return "TRIM TRIM TRIM"; }
        }

        public class Samsung : Celular {
            public override string Assistente()
            {
                return "Olá...Meu nome é BIXBY";
            }
        }

        public class IPhone : Celular
        {
            public override string Assistente()
            {
                return "Olá... Meu nome é SIRI";
            }
        }
        public static void Executar() { 
            var celulares = new List<Celular> { 
                new IPhone(), new Samsung(), 
            };

            foreach (var c in celulares)
            {
                Console.WriteLine(c.Assistente());
            }
        }
    }
}
