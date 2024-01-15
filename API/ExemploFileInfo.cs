using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using(StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original");
            }

            FileInfo origem = new FileInfo(caminhoDestino);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
