int m, n;
int[,] mat;

Console.WriteLine("Digite o numero de linhas:");
m = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero de colunas:");
n = int.Parse(Console.ReadLine());

mat = new int[m, n];

Console.WriteLine("Digite os numeros da matriz:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

int[] vet = new int[m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        vet[i] += mat[i, j];
    }
}

Console.WriteLine("Soma das linhas da matriz:");
for (int i = 0; i < m; i++)
{
    Console.WriteLine(vet[i]);
}
