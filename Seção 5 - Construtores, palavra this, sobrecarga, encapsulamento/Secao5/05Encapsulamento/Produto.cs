using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05Encapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        private bool _atualizou;

        public Produto()
        {
            _quantidade = 0;
            _atualizou = false;
        }


        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
            _atualizou = true;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
            _atualizou = true;
        }


        public override string ToString()
        {
            if (!_atualizou)
            {
                return "Dados do produto: " + _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
            return "Dados atualizados: " + _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
