using ControleEstoque;
using System.Runtime;

Produto p = new Produto();

Console.WriteLine("Entre com os dados do produto");

Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine());

Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados produto: " + p);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser adicionados: ");
int qtd = int.Parse(Console.ReadLine());
p.AdicionarProduto(qtd);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.WriteLine("Digite a quantidade que deseja remover do estoque: ");
qtd = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtd);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);