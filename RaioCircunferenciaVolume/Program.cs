using RaioCircunferenciaVolume;

Console.Write("Digite o valor do raio:");
double raio = double.Parse(Console.ReadLine());

double circ = Calculadora.Circuferencia(raio);
double volume = Calculadora.Volume (raio);

Console.WriteLine("Circuferencia: " + circ.ToString("F2"));
Console.WriteLine("Volume: " + volume.ToString("F2"));

Console.WriteLine("Valor de pi e: " + Calculadora.Pi.ToString("F2"));

