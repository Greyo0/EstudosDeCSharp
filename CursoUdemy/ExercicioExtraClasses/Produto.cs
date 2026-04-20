using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos
{
    class Produto
    {

        public String nome;
        public double preco;
        public int quantidade = 0;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {           
            quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {      
            quantidade -= qtd;
        }

        public override string ToString()
        {
            return "Dados do produto: " + nome + ", $ " + preco + ", " + quantidade + " unidades, Total: $ " + ValorTotalEmEstoque();
        }


    }
}
