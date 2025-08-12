using CalculoRetangulo;

Retangulo r = new Retangulo();

Console.WriteLine("Digite o valor da largura: ");
r.Largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da altura: ");
r.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("A Area e: " + r.Area(r.Altura,r.Largura));

Console.WriteLine("O Perimetro e: " + r.Perimetro(r.Altura, r.Largura));

Console.WriteLine("A diagonal e: "+ r.Diagonal(r.Altura,r.Largura));

