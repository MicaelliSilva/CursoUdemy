using PrecoMedioProdutos;
using System.Net.Http.Headers;

Console.Write("Digite a quantidade de produtos: ");
int quantidade = int.Parse(Console.ReadLine());

Produtos[] p = new Produtos[quantidade];
string nome;
decimal preco;

for (int i = 0; i < quantidade; i++)
{
    Console.Write("\nDigite o nome do produto: ");
    nome = Console.ReadLine();
    Console.Write("Digite o preco do produto: ");
    preco = decimal.Parse(Console.ReadLine());

    p[i] = new Produtos()
    {
        Nome = nome,
        Preco = preco,
    };
}

decimal media = 0;

for (int i = 0; i < quantidade; i++)
{
    media += p[i].Preco / quantidade;
}

Console.WriteLine("Preço Medio = " + media.ToString("F2"));
