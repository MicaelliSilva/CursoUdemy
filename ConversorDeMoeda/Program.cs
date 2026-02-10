using ConversorDeMoeda;

Console.Write("Digite o valor do dolar:");
double valorDolar = double.Parse(Console.ReadLine());

Console.Write("\nDigite o valor que deseja comprar:");
double dolarComprado = double.Parse(Console.ReadLine());

double conversao = ConversorMoeda.ConversorDolar(valorDolar, dolarComprado);

Console.WriteLine("\nValor a ser pago em reais: " + conversao.ToString("F2"));
