using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Classes
{
    public class LeituraDadosPrimeiroValor
    {
        public decimal Valor1 { get; set; }

        public void LerDadosPrimeiroValor()
        {
            Console.WriteLine("Informe o primeiro valor");
            Valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"O valor informado foi {Valor1}");
        }
    }
}
