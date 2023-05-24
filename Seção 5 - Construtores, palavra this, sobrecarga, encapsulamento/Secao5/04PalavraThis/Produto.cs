using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _04PalavraThis
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        private bool Atualizou;

        public Produto()
        {
            Quantidade = 0;
            Atualizou = false;
        }


        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }


        public Produto(string nome, double preco, int quantidade) : this(nome,preco)
        {
            Quantidade = quantidade;
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
