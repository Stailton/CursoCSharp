using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar (params string[] pessoas)
        {
            foreach (string s in pessoas)
            {
                Console.WriteLine ("Olá {0}",s);
            }
        }
        public static void Idade (params int[] idade)
        {
            foreach(int id in idade) { Console.WriteLine("Sua idade é {0}",id); }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Ana");
            Idade(11, 22, 33);
            
        }
    }
}
