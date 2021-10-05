using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Classes
{
    public class ImpressaoMenu
    {
        public void ImprimirMenu()
        {
            Console.WriteLine("------------MENU------------");
            Console.WriteLine(" 1 - SOMA");
            Console.WriteLine(" 2 - SUBTRAÇÃO");
            Console.WriteLine(" 3 - MULTIPLICAÇÃO");
            Console.WriteLine(" 4 - DIVISÃO");
            Console.WriteLine("99 - SAIR");
            Console.WriteLine("------------------------");
        }
    }
}
