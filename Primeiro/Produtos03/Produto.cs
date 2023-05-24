using System;
using System.Globalization;

namespace Produtos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // sobrecarga
        public Produto()
        {
            Quantidade = 10;
        }

        //construtores
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        //sobrecarga
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Quantidade + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
