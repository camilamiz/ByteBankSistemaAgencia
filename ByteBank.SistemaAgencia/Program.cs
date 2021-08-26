using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 4897847);
            DateTime dataFimPagamento = new DateTime(2021, 9, 30);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            TimeSpan diferenca2 = TimeSpan.FromMinutes(60);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
            Console.WriteLine(diferenca2);
            Console.WriteLine(dataCorrente);

            Console.WriteLine(dataFimPagamento);

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if (timeSpan.Days > 30)
        //    {
        //        int quantidadeMeses = timeSpan.Days / 30;
        //        if (quantidadeMeses == 1)
        //        {
        //            return "1 mês";
        //        }
        //        return quantidadeMeses + " meses";
        //    }

        //    return timeSpan.Days + " dias";
        //}
    }
}
