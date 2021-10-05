using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Classes
{
    public class Operacoes
    {
        public decimal ExecutarOperacoes(int operacao)
        {
            decimal resultado = 0;

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Opção Selecionada - SOMA");
                    Soma totalSoma = new Soma();
                    totalSoma.Calcular();
                    resultado = totalSoma.Resultado;
                    break;
                case 2:
                    Console.WriteLine("Opção Selecionada - SUBTRAÇÃO");
                    Subtracao totalSubtracao = new Subtracao();
                    totalSubtracao.Calcular();
                    resultado = totalSubtracao.Resultado;
                    break;
                case 3:
                    Console.WriteLine("Opção Selecionada - MULTIPLICAÇÃO");
                    Multiplicacao totalMultiplicacao = new Multiplicacao();
                    totalMultiplicacao.Calcular();
                    resultado = totalMultiplicacao.Resultado;
                    break;
                case 4:
                    Console.WriteLine("Opção Selecionada - DIVISÃO");
                    Divisao totalDivisao = new Divisao();
                    totalDivisao.Calcular();
                    resultado = totalDivisao.Resultado;
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}
