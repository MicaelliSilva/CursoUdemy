using ControleEstoque;
using System.Runtime;

Console.WriteLine("Entre com os dados do produto");

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco, quantidade);

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