using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using _02_ByteBank; ESTÁ NO MESMO NAMESPACE POR ISSO NÃO É NECESSARIO DAR O USING


namespace Aula_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public int Agencia { get; }

        // significa que é uma caracteristica da classe e não do objeto,então todos compartilham (static)
        public static int TotalDeContasCriadas {get; private set;} 
        public Cliente Titular{get;set;} // assim fica mais facil de visualizar

        public int ContadorSaquesNaoPermitidos { get;private set;}

        public int ContadorTransferenciaNaoPermitidos { get;private set;}

        public int Numero { get; }
 

        private double _saldo = 100; // impede essa variavel de ser alterada no programa principal
        public double Saldo // Escrito sempre com a primeira letra maiuscula 
        {
            get
            {
                return _saldo; // Utiliza esse _ lá na variavel publica para não confundir com as funções
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        
        public ContaCorrente(int agencia,int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if(numero <= 0) 
            { 
                throw new ArgumentException("O argumento numero Devem Ser Maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor) //Se o saldo em conta for menor que o valor que quer sacar ele retorna falso
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo,valor);

            }
           
            // se o saldo em conta for maior do que o valor que quer sacar, ele retorna true e desconta o valor.
            _saldo -= valor;
                
        }

        public void Depositar(double valor)
        {

            _saldo += valor;

        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a Transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor); //chama o método SACAR , onde ele irá fazer fazer a operação de "retirar" o dinheiro da conta.
         // e se tentarmos transferir um valor MAIOR do que oq há em conta, ele irá cair na exceção "saldoInsuficienteException" criada
            }

            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciaNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex); // ao fazer dessa maneira ele preserva o stackTrace, devido ao fato de utilizarmos a função "sacar" ele
                //precisa manter isso no stackTrace para poder acertar eventuais problemas futuros.
            }
            
            contaDestino.Depositar(valor);

        }

    }
}