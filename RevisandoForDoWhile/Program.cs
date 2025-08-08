int x = 0;

Console.Write("Digite um numero: ");
x = int.Parse(Console.ReadLine());

do 
{  
    if (x < 1 || x > 1000)
    {
        Console.Write("Digite Novamente: ");
        x = int.Parse(Console.ReadLine());
    }

} while (x < 1 || x > 1000);

for (int i = 1; i <= x; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
