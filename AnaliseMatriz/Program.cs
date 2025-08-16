Console.Write("Digite o tamanho da matriz: ");
int tamanho = int.Parse(Console.ReadLine());

int[,] mat = new int[tamanho,tamanho];

Console.WriteLine("\nDigite os valores da matriz: ");
for (int i = 0; i < tamanho; i++)
{
    for(int j = 0; j < tamanho; j++)
    {
        mat[i,j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nMatriz: ");
for(int i = 0;i < tamanho; i++)
{
   for(int j = 0;j < tamanho; j++)
    {
        Console.Write(mat[i,j] + " ");
        
    }
    Console.Write("\n");
}

Console.WriteLine("\nDiagonal Principal: ");
for(int i = 0; i < tamanho; i++)
{
    Console.Write(mat[i, i] + " ");
}

int negativos = 0;

for(int i = 0; i < tamanho ; i++)
{
    for(int j = 0;j < tamanho; j++)
    {
        if (mat[i,j] < 0)
        {
            negativos++;

        }
    }
}

Console.WriteLine("\n\nQuantidade de negativos: " + negativos);