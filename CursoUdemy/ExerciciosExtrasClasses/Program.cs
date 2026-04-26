using System;


namespace Produtos;

class Program
{

    static void Main(string[] args)
    {

        Produto p = new Produto();

        System.Console.WriteLine("Entre os dados do produto: ");
        System.Console.WriteLine("Nome: ");
        p.nome = Console.ReadLine();
        System.Console.WriteLine("Preço: ");
        p.preco = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Quantidade: ");
        p.quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine(p.ToString());

        Console.WriteLine("Digite a quantidade de produtos a adicionar ao estoque: ");
        int qtd = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qtd);

        Console.WriteLine(p.ToString());

        Console.WriteLine("Digite a quantidade de produtos a remover do estoque: ");
        qtd = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qtd);

        Console.WriteLine(p.ToString());

    }


}