using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            //convertendo o obj para um Cliente por meio de cast
            //Cliente outroCliente = (Cliente)obj; //dá um erro de conversão
            Cliente outroCliente = obj as Cliente; //dá um erro de NullReferenceException

            if (outroCliente == null)
            {
                return false;
            }

            return 
                Nome == outroCliente.Nome 
                && CPF == outroCliente.CPF 
                && Profissao == outroCliente.Profissao;
        }
    }
}
