using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Lista_de_Funcionários.Controller;

namespace Desafio_Lista_de_Funcionários
{
    internal class Program
    {
        private static String mostraMensagem()
        {
           return  ("\nPressione qualquer tecla para continuar...");
        }
        static void Main(string[] args)
        {
            var funcionariosController = new FuncionariosController();
            int escolha;
            bool sair = false;
            do
            {

                Console.Clear();
                Console.WriteLine("Bem-vindo ao sistema de funcionários!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Filtrar funcionários com salário > R$3000");
                Console.WriteLine("2. Dar 5% de aumento para quem tem > 10 anos de serviço");
                Console.WriteLine("3. Ordenar por nome");
                Console.WriteLine("4. Calcular total gasto com salários");
                Console.WriteLine("5. Agrupar por departamento e mostrar média salarial");
                Console.WriteLine("6. Encontrar funcionário com mais tempo de serviço");
                Console.WriteLine("7. Formatar saída com lambda");
                Console.WriteLine("8. Sair");

                if (!int.TryParse(Console.ReadLine(), out escolha)|| escolha < 1 || escolha > 8)
                {
                    Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }              
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Filtrar funcionários com salário acima R$3000.00");
                        Console.WriteLine(funcionariosController.FiltrarFuncionariosAcimaDe3000());
                        Console.WriteLine(mostraMensagem());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Dar 5% de aumento para quem tem mais de 10 anos de serviço");
                        Console.WriteLine(funcionariosController.DarAumento5AcimaDe10Anos());
                        Console.WriteLine(mostraMensagem());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ordenar por nome");
                        Console.WriteLine(funcionariosController.OrdenarPorNome());
                        Console.WriteLine(mostraMensagem());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Calcular total gasto com salários");
                        Console.WriteLine(funcionariosController.calcularTotalSalarios());
                        Console.WriteLine(mostraMensagem());
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Agrupar por departamento e mostrar média salarial de cada departamento");
                        Console.WriteLine(funcionariosController.AgruparPorDepartamentoEMostrarMediaSalarial());
                        Console.WriteLine(mostraMensagem());
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Encontrar funcionário com mais tempo de serviço");
                        Console.WriteLine(funcionariosController.EncontrarFuncionarioComMaisTempoDeServico());
                        Console.WriteLine(mostraMensagem());
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Formatar saída com lambda");
                        Console.WriteLine(funcionariosController.FormatarSaidaComLambda());
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        sair = true;
                        break;
                }
                
            } while (!sair);
        }
    }
}
