using Calculadora_POO.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Classes
{
    public class Divisao : CalculaOperacoes
    {
        public decimal Resultado { get; set; }

        public override void Calcular()
        {
            LeituraDadosPrimeiroValor valor1 = new LeituraDadosPrimeiroValor();
            LeituraDadosSegundoValor valor2 = new LeituraDadosSegundoValor();
            valor1.LerDadosPrimeiroValor();
            valor2.LerDadosSegundoValor();
            Resultado = valor1.Valor1 / valor2.Valor2;
        }
    }
}
