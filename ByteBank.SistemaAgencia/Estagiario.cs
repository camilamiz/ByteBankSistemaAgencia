using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        //aqui não é internal protected, pois o internal protected faz sentido somente na classe base e nas classes derivadas dentro do projeto
        //nas classes filhas fora do projeto usamos somente o protected
        //o internal é relacionado a projetos
        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
