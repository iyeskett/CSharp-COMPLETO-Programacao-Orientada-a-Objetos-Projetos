using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _03Resolvendo2ProblemaEx
{
    class Produto
    {
        // Atributos
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool Atualizou { get; set; }

        public Produto()
        {
            Atualizou = false;
        }



        // Metodos
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
            Atualizou = true;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
            Atualizou = true;  
        }



        public override string ToString()
        {
            if (!Atualizou)
            {
                return "Dados do produto: " + Nome + ", $" + Preco + ", " + Quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                return "Dados atualizados: " + Nome + ", $" + Preco + ", " + Quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }

        }
    }
}
