using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //acessar variáverl 'a' dentro do método Executar!


            //criar instacia desafioAtributo
            DesafioAtributo desafioAtributo = new DesafioAtributo();
            Console.WriteLine(desafioAtributo.a) ;
            
            
        }
    }
}
