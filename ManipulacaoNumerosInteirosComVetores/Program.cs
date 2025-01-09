int quantidadeNumeros;

Console.WriteLine("Digite a quantidade de numeros:");
quantidadeNumeros = int.Parse(Console.ReadLine());

while (quantidadeNumeros <= 0)
{
    Console.WriteLine("Número inválido!!");
    Console.WriteLine("Digite a quantidade de numeros novamente:");
    quantidadeNumeros = int.Parse(Console.ReadLine());
}

int[] numeros = new int[quantidadeNumeros];

for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine("Digite numeros:");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nOs numeros digitados foram:");
for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("\nOs numeros digitados na ordem inversa foram:");
for (int i = quantidadeNumeros - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}

int soma;

soma = 0;

for (int i = 0; i < quantidadeNumeros; i++)
{
    soma += numeros[i];
}
Console.WriteLine("\nA soma dos numeros é: " + soma);
