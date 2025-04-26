using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Lista_de_Funcionários.Model;

namespace Desafio_Lista_de_Funcionários.Controller
{
    // Controller para gerenciar as operações relacionadas aos funcionários
    internal class FuncionariosController
    {
        private string mesangem()
        {
            return ("Nenhum funcionário encontrado");
        }
        private FuncionariosModel funcionarioModel = new FuncionariosModel();
        String sb;
        // 01 Filtrar funcionários com salário > R$3000
        public String FiltrarFuncionariosAcimaDe3000()
        {
            var sb = new StringBuilder();
            var funcionarios = funcionarioModel.ObiterFuncionarios()
                .Where(f => f.Salario > 3000)
                .OrderBy(f => f.Nome)
                .ToList();
            if (!funcionarios.Any())
            {
                sb.AppendLine($"{mesangem()} com salário acima de R$ 3000,00.");
            }
            else
            {
                foreach (var funcionario in funcionarios)
                {
                    sb.AppendLine($"Nome: {funcionario.Nome}, Salário: {funcionario.Salario}");
                }
            }

            return sb.ToString(); 
        }
        // 02 Dar 5% de aumento para quem tem > 10 anos de serviço
        public String DarAumento5AcimaDe10Anos()
        {
            var sb = new StringBuilder();
            var Funcionarios =funcionarioModel.ObiterFuncionarios()
                .Where(f => f.AnosDeServico > 10).Select(f => new 
                {
                    f.Nome,
                    f.AnosDeServico,
                    f.Salario,
                    salarioComAumento = f.Salario * 1.05
                })
                .OrderBy(f => f.Nome)
                .ToList();
            if (!Funcionarios.Any())
                {
                sb.AppendLine($"{mesangem()} com mais de 10 anos de serviço.");
            }
            else
            {
                foreach (var funcionario in Funcionarios)
                {
                    sb.AppendLine($"Nome: {funcionario.Nome}, Anos de Serviço: {funcionario.AnosDeServico}, Salário original: R${funcionario.Salario:f2} -> Salário com Aumento: R${funcionario.salarioComAumento:f2}");
                }
            }
            return  sb.ToString();
        }
        // 03 Ordenar por nome
        public String OrdenarPorNome()
        {
            var sb = new StringBuilder();
            var funcionario =funcionarioModel.ObiterFuncionarios()
                .OrderBy(f => f.Nome)
                .ToList();
            if (!funcionario.Any())
            {
                sb.AppendLine(mesangem());
            }
            else
            {
                foreach (var f in funcionario)
                {
                    sb.AppendLine($"Nome: {f.Nome}, Salário: R${f.Salario:f2}");
                }
            }
            return sb.ToString();
        }
        // 04 Calcular total gasto com salários
        public String calcularTotalSalarios()
        {
            string sb = "Total gasto com salários: R$" + funcionarioModel.ObiterFuncionarios()
                .Sum(f => f.Salario).ToString("f2");
            return sb;
        }
        // 05 Agrupar por departamento e mostrar média salarial
        public String AgruparPorDepartamentoEMostrarMediaSalarial()
        {
           var sb = new StringBuilder();
            var funcionarios = funcionarioModel.ObiterFuncionarios()
                .GroupBy(f => f.Departamento)
                .Select(g => new
                {
                    Departamento = g.Key,
                    MediaSalarial = g.Average(f => f.Salario)
                })
                .OrderBy(g => g.Departamento)
                .ToList();
            if (!funcionarios.Any())
            {
                sb.AppendLine(mesangem());
                return sb.ToString();
            }
            foreach (var grupo in funcionarios)
            {
                sb.Append ($"Departamento: {grupo.Departamento}, Média Salarial: R${grupo.MediaSalarial:f2}\n");
            }

            return sb.ToString();
        }

        // 06 Encontrar funcionário com mais tempo de serviço
        public String EncontrarFuncionarioComMaisTempoDeServico()
        {
           
            var funcionario = funcionarioModel.ObiterFuncionarios()
                .OrderByDescending(f => f.AnosDeServico)
                .FirstOrDefault();

            if (funcionario != null)
            {
                sb = $"Funcionário com mais tempo de serviço: {funcionario.Nome}, Anos de Serviço: {funcionario.AnosDeServico}\n";
            }
            else
            {
                sb = (mesangem());
            }

            return sb.ToString();
        }
        // 07 Formatar saída com lambda personalizada
        public String FormatarSaidaComLambda()
        {
            var sb = new StringBuilder();
            var funcionarios = funcionarioModel.ObiterFuncionarios()
                .Select(f => new
                {
                    Nome = f.Nome.ToUpper(),
                    Salario = f.Salario.ToString("C"),
                    AnosDeServico = f.AnosDeServico
                })
                .OrderBy(f => f.Nome)
                .ToList();

            foreach (var funcionario in funcionarios)
            {
                sb.AppendLine($"Nome: {funcionario.Nome}, Salário: {funcionario.Salario:f2}, Anos de Serviço: {funcionario.AnosDeServico}");
            }

            return sb.ToString();
        }
    }

}

