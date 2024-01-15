using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine("NumeroCelular não pode ser acessado");
            Console.WriteLine("SegredoDeFamilia não pode ser acessado");
            Console.WriteLine("UsaMuitoPhotoshop não pode ser acessado");
        }
        
        public class AmigoDistante
        {
            public readonly SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos()
            {
                Console.WriteLine("AmigoDistante...");
                Console.WriteLine(amiga.InfoPublica);
                Console.WriteLine("amiga.CorDosOlhos não pode ser acessado");
                Console.WriteLine("amiga.NumeroCelular não pode ser acessado");
                Console.WriteLine("amiga.JeitoDeFalar não pode ser acessado");
                Console.WriteLine("amiga.SegredoDeFamilia não pode ser acessado");
                Console.WriteLine("amiga.UsaMuitoPhotoshop não pode ser acessado");
                Console.WriteLine();
            }
        }
    }
    internal class Encapsulamento
    {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido() .MeusAcessos();
            
        
        }
    }
}
