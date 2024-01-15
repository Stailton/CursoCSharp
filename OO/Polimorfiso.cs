using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class Polimorfiso
    {
        public class Comida
        {
            public double Peso;
            public Comida(double peso)
            {
                Peso = peso;
            }
            public Comida() { }
        }
        public class Feijão : Comida
        {
            
        }

        public class Arroz : Comida
        {
            
        }

        public class Carne : Comida
        {
            
        }

        public class Pessoa
        {
            public double Peso;
          //  public void Comer(Feijão feijao)
          //  {
          //      Peso += feijao.Peso;
          //  }
          //  public void Comer(Arroz arroz)
          //  {
          //       Peso += arroz.Peso;
          //  }

            public void Comer (Comida comida)
            {
                Peso += comida.Peso;
            }
        }
        public static void Executar() { 
            Feijão ingrediente1 = new Feijão();
            ingrediente1.Peso = 1;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 2;

            Carne ingredient3 = new Carne();
            ingredient3.Peso = 3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 4;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);    
            cliente.Comer(ingredient3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso} KG");
        }
    }
}
