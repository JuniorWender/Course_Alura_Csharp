using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public String URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {

            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento URL não pode ser nulo ou vazio.",nameof(url));
            }

            URL = url;
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        //moedaOrigem=Real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentoCaixaAlta = _argumentos.ToUpper(); //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; //moedaDestino=
            int indiceTermo = argumentoCaixaAlta.IndexOf(termo); // x

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); //dolar
            int indiceE = resultado.IndexOf('&'); //

            if(indiceE == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceE);
        }
    }
}
