int n;
int[] numeros;

Console.Write("Digite a quantidade de números: ");
n = int.Parse(Console.ReadLine());

numeros = new int[n];

Console.WriteLine("\nDigite os números: ");
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nNúmeros negativos digitados: ");
for (int i = 0; i < n; i++)
{
    if (numeros[i] < 0)
    {
        Console.WriteLine(numeros[i]);  
    }
}