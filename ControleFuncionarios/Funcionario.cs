using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public void AumentarSalario(decimal porcentagem)
        {
            Salario += porcentagem / 100 * Salario;
        } 
    }
}
