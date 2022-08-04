using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double Valorsaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo,double valorsaque) :this("Tentativa de Saque do valor de R$" + valorsaque + " em uma conta com saldo de R$" + saldo)
        {// Com esse this eu estou chamando esse construtor abaixo, onde ele envia uma string
            Saldo = saldo;
            Valorsaque = valorsaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(string mensagem,Exception excecaoInterna) : base(mensagem, excecaoInterna)
        { // exception excecaoInterna -> é uma innerException e é esperado essa boa pratica de uma exception

        }
    }
}
