using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    internal class Diretorios
    {
        public static void Executar() {
            var novoDir =@"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCsharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();

            if(Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("=== Pastas ===");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n=== Arquivos ===");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos) { Console.WriteLine(arquivo); }

            Console.WriteLine("\n\n=== Raiz ===");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
