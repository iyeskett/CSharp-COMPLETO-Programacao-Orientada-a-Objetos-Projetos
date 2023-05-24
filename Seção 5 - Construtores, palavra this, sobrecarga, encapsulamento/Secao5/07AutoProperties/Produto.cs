using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _07AutoProperties
{
    class Produto
    {
        private string _nome;
        private bool _atualizou;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 0;
            _atualizou = false;
        }


        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
            _atualizou = true;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
            _atualizou = true;
        }


        public override string ToString()
        {
            if (!_atualizou)
            {
                return "Dados do produto: " + _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
            return "Dados atualizados: " + _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
