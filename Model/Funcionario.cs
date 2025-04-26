using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Lista_de_Funcionários.Model
{   
    internal class Funcionario
    {
        public String Nome { get; private set; }
        public String Departamento { get; private set; }
        public double Salario { get; private set; }
        public int AnosDeServico { get; private set; }
        public Funcionario(string nome, string departamento, double salario, int anosDeServico)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            AnosDeServico = anosDeServico;
        }
    }
}
