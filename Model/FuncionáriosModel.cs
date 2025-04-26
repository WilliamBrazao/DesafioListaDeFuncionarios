using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Lista_de_Funcionários.Model
{
    internal class FuncionariosModel
    {
        private List<Funcionario> funcionario = new List<Funcionario>()
        {
            new Funcionario("Carlos", "TI", 5000, 15),
            new Funcionario("Ana", "RH", 4000, 3),
            new Funcionario("Pedro", "Financeiro", 6000, 7),
            new Funcionario("Maria", "Marketing", 4500, 10),
            new Funcionario("Lucas", "TI", 5500, 6),
            new Funcionario("Fernanda", "RH", 4200, 2),
            new Funcionario("Roberto", "Financeiro", 6200, 8),
            new Funcionario("Juliana", "Marketing", 4800, 11),
            new Funcionario("Ricardo", "TI", 5300, 4),
            new Funcionario("Patricia", "RH", 4100, 23),
            new Funcionario("Eduardo", "Financeiro", 6100, 7),
            new Funcionario("Sofia", "Marketing", 4700, 4),
            new Funcionario("Gabriel", "TI", 5400, 5),
            new Funcionario("Larissa", "RH", 4300, 12),
            new Funcionario("Carlos", "Vendas", 3500, 12),
            new Funcionario("Ana", "Marketing", 4000, 5),
            new Funcionario("Beatriz", "Vendas", 2800, 8),
            new Funcionario("João", "Limpeza", 1200, 1),
            new Funcionario("Mariana", "Recepção", 1500, 2),
            new Funcionario("Felipe", "Entregador", 1100, 1),
            new Funcionario("Camila", "Atendente", 1300, 3),
            new Funcionario("Rafael", "Auxiliar", 1400, 2),
            new Funcionario("Isabela", "Estagiária", 900, 0),
            new Funcionario("Marcos", "Porteiro", 1600, 5),
            new Funcionario("Tatiane", "Serviços Gerais", 1250, 4),
            new Funcionario("Vinícius", "Aprendiz", 950, 1),
            new Funcionario("Laura", "Atendente", 1300, 2),
            new Funcionario("Gustavo", "Auxiliar", 1400, 1),
            new Funcionario("Renata", "Estagiária", 900, 0),
            new Funcionario("Diego", "Entregador", 1100, 2)

        };
       
        public void AddFuncionario(Funcionario funcionarios)
        {
            funcionario.Add(funcionarios);
        }
        public List<Funcionario> ObiterFuncionarios()
        {
            return funcionario;
        }
    }
}
