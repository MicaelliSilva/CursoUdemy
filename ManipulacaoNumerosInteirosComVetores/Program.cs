int quantidadeNumeros;

Console.Write("Digite a quantidade de números:");
quantidadeNumeros = int.Parse(Console.ReadLine());

while (quantidadeNumeros <= 0)
{
    Console.WriteLine("\nNúmero inválido!!");
    Console.Write("Digite a quantidade de números novamente:");
    quantidadeNumeros = int.Parse(Console.ReadLine());
}

int[] numeros = new int[quantidadeNumeros];

for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.Write("\nDigite um número:");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nNúmeros digitados:");
for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("\nNúmeros digitados na ordem inversa:");
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
Console.WriteLine("\nSoma dos números:" + soma + "\n");

int maiorNumero;

maiorNumero = numeros[0];
for (int i = 0; i < quantidadeNumeros; i++)
{
    if (numeros[i] > maiorNumero)
    {
        maiorNumero = numeros[i];
    }

}
Console.WriteLine("Maior número digitado:" + maiorNumero);

int menorNumero = numeros[0];
for (int i = 0; i < quantidadeNumeros; i++)
{
    if (numeros[i] < menorNumero)
    {
        menorNumero = numeros[i];
    }
}

Console.WriteLine("Menor número digitado:" + menorNumero + "\n");

int quantidadePares = 0;
int quantidadeImpares = 0;


for (int i = 0; i < quantidadeNumeros; i++)
{
    if (numeros[i] % 2 == 0)
    {
        quantidadePares++;
    }
    else
    {
        quantidadeImpares++;
    }
}

Console.WriteLine("Quantidade de números Pares:" + quantidadePares);
Console.WriteLine("Quantidade de números Ímpares:" + quantidadeImpares + "\n");

int posicaoPares = 0;
int posicaoImpares = 0;

int[] pares = new int[quantidadePares];
int[] impares = new int[quantidadeImpares];

for (int i = 0; i < quantidadeNumeros; i++)
{
    if (numeros[i] % 2 == 0)
    {
        pares[posicaoPares] = numeros[i];
        posicaoPares++;
    }
    else
    {
        impares[posicaoImpares] = numeros[i];
        posicaoImpares++;
    }
}

Console.WriteLine("Números Pares digitados:");
for (int i = 0; i < quantidadePares; i++)
    Console.WriteLine(pares[i]);

Console.WriteLine("Números Ímpares digitados:");
for (int i = 0; i < quantidadeImpares; i++)
    Console.WriteLine(impares[i]);