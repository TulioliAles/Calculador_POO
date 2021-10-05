using Calculadora_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.ClassesAbstratas
{
    public abstract class CalculaOperacoes : ICalcula
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public decimal Resultado { get; set; }

        public abstract void Calcular();
    }
}
