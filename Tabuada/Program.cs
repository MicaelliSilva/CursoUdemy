int n;
int multiplicacao;

Console.Write("Digite o número a ser calculado na tabuada: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    multiplicacao = i * n;
    Console.WriteLine("\n" + i + "x" + n + "=" + multiplicacao);
}