using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 0 a 5");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0: Console.WriteLine("Péssimo");
                    break;
                    case 1: Console.WriteLine("Ruim");
                    break;
                    case 2: Console.WriteLine("Regular");
                    break;
                    case 3: Console.WriteLine("Bom");
                        break;
                    case 4: Console.WriteLine("Ótimo");
                    break;
                    case 5: Console.WriteLine("Muito Bom");
                    break;
                    default : Console.WriteLine("Obrigado pela avaliação");
                    break;
            }
            Console.WriteLine("FIM!");
        }
    }
}
