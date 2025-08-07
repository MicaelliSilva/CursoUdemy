Console.WriteLine("digite o valor de x:");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de y:");
double y = double.Parse(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Quadrante 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Quadrante 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Quadrante 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Quadrante 4");
} 