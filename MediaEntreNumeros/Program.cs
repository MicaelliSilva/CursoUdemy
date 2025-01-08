int qtdNum, num, soma;
double media;

Console.WriteLine("Quantos numeros deseja inserir?");
qtdNum = int.Parse(Console.ReadLine());

if (qtdNum == 0)
{
    Console.WriteLine("Não é possivel divir por zero");
    Console.WriteLine("\nDigite uma tecla para encerrar.");
    Console.ReadKey();
    return;
}

soma = 0;
for (int i = 0; i < qtdNum; i++)
{
    Console.WriteLine("Digite os numeros:");
    num = int.Parse(Console.ReadLine());
    soma += num;
}

media = soma / qtdNum;

Console.WriteLine("\nO resultado da media é: " + media);
Console.WriteLine("\nDigite uma tecla para encerrar.");
Console.ReadKey();