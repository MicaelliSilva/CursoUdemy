using ComparadorDeTriangulos;

Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo X:");
 x.Lado1 = double.Parse(Console.ReadLine());
 x.Lado2 = double.Parse(Console.ReadLine());
 x.Lado3 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triangulo Y:");
 y.Lado1= double.Parse(Console.ReadLine());
 y.Lado2= double.Parse(Console.ReadLine());
 y.Lado3= double.Parse(Console.ReadLine());

double xP = (x.Lado1 + x.Lado2 + x.Lado3) / 2;
double xarea = Math.Sqrt(xP * (xP - x.Lado1) * (xP - x.Lado2) * (xP - x.Lado3));

double yP = (y.Lado1 + y.Lado2 + y.Lado3) / 2;
double yarea = Math.Sqrt(yP * (yP - y.Lado1) * (yP - y.Lado2) * (yP - y.Lado3));


Console.WriteLine("Area de X: " + xarea.ToString("F4"));
Console.WriteLine("Area de Y: " + yarea.ToString("F4"));

if (xarea > yarea)
{
    Console.WriteLine("Maior area é: X");
}
else
{
    Console.WriteLine("Maior area é: Y");
}