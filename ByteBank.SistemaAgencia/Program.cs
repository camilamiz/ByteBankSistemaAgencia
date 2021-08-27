using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //AULA 6 ---------------------------------
            string url = "pagina?argumentos?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(indiceInterrogacao);
            Console.WriteLine(argumentos);

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);
            string valor = extrator.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valor2 = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor2);

            string valor3 = extrator.GetValor("VALOR");
            Console.WriteLine("Valor de valor: " + valor3);

            string urlTeste = "https://www.bytebank.com/cambio";
            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 478419876";
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);

            object conta = new ContaCorrente(456, 555245);

            string contaToString = conta.ToString();
            Console.WriteLine("Resultado " + contaToString);
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.Profissao = "Designer";
            carlos_1.CPF = "123.456.700-88";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.Profissao = "Designer";
            carlos_2.CPF = "123.456.700-88";

            //O método Equals para objetos está sobrescrito na classe Cliente para que o resultado abaixo saia como true
            Console.WriteLine(carlos_1.Equals(carlos_2));

            ContaCorrente conta2 = new ContaCorrente(333, 333456);
            Console.WriteLine(carlos_1.Equals(conta2));


            //AULA 5-------------------------------
            //ContaCorrente conta = new ContaCorrente(847, 4897847);
            //DateTime dataFimPagamento = new DateTime(2021, 9, 30);
            //DateTime dataCorrente = DateTime.Now;
            //TimeSpan diferenca = dataFimPagamento - dataCorrente;
            //TimeSpan diferenca2 = TimeSpan.FromMinutes(60);

            //string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            //Console.WriteLine(mensagem);
            //Console.WriteLine(diferenca2);
            //Console.WriteLine(dataCorrente);

            //Console.WriteLine(dataFimPagamento);

            //Console.WriteLine(conta.Numero);
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
