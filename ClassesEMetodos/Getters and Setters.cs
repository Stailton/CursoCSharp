using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Getters_and_Setters
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;
            
            public Moto( string marca, string modelo, int cilindrada)// Construtor moto
            {
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
            }
            public Moto() { }

            public string GetMarca() { return Marca; }
            public void SetMarca( string marca ) {  Marca = marca; }
            public string GetModelo() { return Modelo; }
            public void SetModelo(string modelo) {  Modelo = modelo; }

            public int GetCilindrada() {  return Cilindrada; }
            public void SetCilindrada(int cilindrada) { Cilindrada= cilindrada; }
        }
        public static void Execute()
        {
            var moto1 = new Moto("kawasaki", "Ninja ZX - GR", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);
            Console.WriteLine($"{moto2.GetMarca()}");
            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetCilindrada());

        }
    }
}
