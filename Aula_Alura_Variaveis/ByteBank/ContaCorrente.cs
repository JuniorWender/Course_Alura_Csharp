using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using _02_ByteBank; ESTÁ NO MESMO NAMESPACE POR ISSO NÃO É NECESSARIO DAR O USING


namespace ByteBank
{
    public class ContaCorrente
    {
        private double _saldo = 100; // impede essa variavel de ser alterada no programa principal

 // Como esse Titular não está nem setando nada nem pegando nenhuma info podemos utilizar ; ao inves de utilizar {
        public Cliente Titular{get;set;} // assim fica mais facil de visualizar
        public int Agencia {get;set;}
        public int Numero {get;set;}

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

        //public void SetSaldo(double saldo)
        //{

        //    if (saldo < 0)
        //    {
        //        return;
        //    }
                      
        //    this.saldo = this.saldo + saldo; // não utiliza else pq se entrar no if ele ja para devido ao return.
            

        //}
        //public double GetSaldo()
        //{

        //    return saldo; // assim será possivel acessar o saldo indiretamente.

        //}

        public bool Sacar(double valor)
        {

            if (_saldo < valor) //Se o saldo em conta for menor que o valor que quer sacar ele retorna falso
            {

                return false;

            }
            else // se o saldo em conta for maior do que o valor que quer sacar, ele retorna true e desconta o valor.
            {
                _saldo -= valor;
                return true;

            }

        }

        public void Depositar(double valor)
        {

            _saldo += valor;

        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {

            if (_saldo < valor)
            {

                return false;

            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;


        }

    }
}