using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            Salario = salario;
            CPF = cpf;
            
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        internal protected abstract double GetBonificacao();
        //internal protected - é um modificador de acesso que torna o GetBonificacao visivel no projeto Modelos e para as classes derivadas
        //inclusive se as classes derivadas estiverem fora do projeto, como é o caso da classe Estagiario
    }
}
