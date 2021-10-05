using Calculadora_POO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while (menu == 0)
            {
                try
                {
                    ImpressaoMenu impressaoMenu = new ImpressaoMenu();
                    impressaoMenu.ImprimirMenu();
                    menu = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (menu)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            Operacoes operacoes = new Operacoes();
                            Console.WriteLine($"Resultado: {operacoes.ExecutarOperacoes(menu)}");
                            break;
                        case 99:
                            Console.WriteLine("Deseja realmente sair?");
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }

                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();

                    Console.WriteLine("Pressione 1 para retornar ao menu ou qualquer tecla para sair");
                    var opcao = Console.ReadLine();

                    if (opcao == "1")
                        menu = 0;
                    else
                        menu = 99;

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                finally
                {
                    Console.Clear();
                }
            }
        }        
    }
}
