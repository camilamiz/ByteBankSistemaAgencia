using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    //internal - classe interna do ByteBank.Modelos - não pode ser usada por outros projetos, por exemplo, o Program.cs do ByteBank.SistemaAgencia
    //quando não coloco nenhum modificador de acesso em uma classe, o compilador assume que a classe é uma internal
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
