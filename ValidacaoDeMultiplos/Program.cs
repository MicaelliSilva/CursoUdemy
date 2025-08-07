Console.WriteLine("Digite os numeros:");

string[] vet = Console.ReadLine().Split(' ');
int n1 = int.Parse(vet[0]);
int n2 = int.Parse(vet[1]);

if (n1 > n2)
{
    if (n1 % n2 == 0)
        Console.WriteLine("São multiplos");
    else Console.WriteLine("Não são multiplos");
}
else if (n2 > n1)
{
    if (n2 % n1 == 0)
        Console.WriteLine("São multiplos");
    else Console.WriteLine("Não são multiplos");
}
