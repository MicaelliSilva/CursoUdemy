int quantidadeNumeros, numero, soma;
double media;

Console.WriteLine("Quantos numeros deseja inserir?");
quantidadeNumeros = int.Parse(Console.ReadLine());

if (quantidadeNumeros == 0)
{
    Console.WriteLine("Não é possivel divir por zero");
    Console.WriteLine("\nDigite uma tecla para encerrar.");
    Console.ReadKey();
    return;
}

soma = 0;
for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.WriteLine("Digite os numeros:");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
}

media = soma / quantidadeNumeros;

Console.WriteLine("\nO resultado da media é: " + media);
Console.WriteLine("\nDigite uma tecla para encerrar.");
Console.ReadKey();