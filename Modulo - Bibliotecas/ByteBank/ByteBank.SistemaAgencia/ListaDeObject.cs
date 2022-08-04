using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObject
    {


        private Object[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ListaDeObject(int capacidadeInicial = 5) // argumento opicional
        {//quando não for informado um valor de entrada, ele será setado em 5, quando for dado entrada com um valor,ele sobrescreverá o 5

            _itens = new object[5];
            _proximaPosicao = 0;
        }

        public void Adicionar(Object item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params Object[] itens)
        {
            foreach (Object item in itens)
            {
                Adicionar(item);
            }
        }

        public void remover(Object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                Object itemAtual = _itens[i];

                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public Object GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            Console.WriteLine("aumentando capacidade da lista!");

            Object[] novoArray = new Object[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;
        }

        public Object GetObjectNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public Object this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }


    }
}
