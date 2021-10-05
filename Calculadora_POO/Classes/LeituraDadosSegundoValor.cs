using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Classes
{
    public class LeituraDadosSegundoValor
    {
        public decimal Valor2 { get; set; }
        public void LerDadosSegundoValor()
        {
            Console.WriteLine("Informe o segundo valor");
            Valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"O valor informado foi {Valor2}");
        }
    }
}
