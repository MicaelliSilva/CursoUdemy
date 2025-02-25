int n;
int[,] mat;

Console.WriteLine("Digite um numero inteiro: ");
n = int.Parse(Console.ReadLine());

mat = new int[n, n];

Console.WriteLine("Digite os numeros da matriz: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(Console.ReadLine());

    }
    Console.WriteLine();
}

int quantidadeDeNegativos = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            quantidadeDeNegativos++;
        }
        Console.Write(mat[i, j] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine("\nQuantidade de numeros negativos = " + quantidadeDeNegativos);

Console.WriteLine("Diagonal Principal: ");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}