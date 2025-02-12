int m, n;
int[,] a;

Console.WriteLine("Digitar quantidade de linhas:\n");
m = int.Parse(Console.ReadLine());

Console.WriteLine("Digitar quantidade de colunas:\n");
n = int.Parse(Console.ReadLine());

a = new int[m, n];

Console.WriteLine("Digitar os valores da matriz:");
for (int i = 0; i < m; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        a[i, j] = int.Parse(s[j]);

    }
    Console.WriteLine();
}
Console.WriteLine("Matriz digitada:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}