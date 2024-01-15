﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    { 
        class Carro {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano) { //construtur que recebe 3 parametros que são 2 string e um int ect
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            
            }
            public Carro() { 
                // um construtor que não recebe nada para que o var carro1 = new Carro(); possa ser usado 
            
            }
        
        }
        public static void Executar() { 
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        
        }
    }
}
