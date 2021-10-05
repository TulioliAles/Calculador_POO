using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Interfaces
{
    public interface ICalcula
    {
        decimal Valor1 { get; set; }

        decimal Valor2 { get; set; }

        decimal Resultado { get; set; }

        void Calcular();
    }
}
