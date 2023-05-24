using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _03sintaxeAlt
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        private bool Atualizou;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Atualizou = false;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
            Atualizou = false;
        }

        public Produto()
        {

        }

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
            Atualizou = true;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
            Atualizou = true;
        }


        public override string ToString()
        {
            if (!Atualizou)
            {
                return "Dados do produto: " + Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
            return "Dados atualizados: " + Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
