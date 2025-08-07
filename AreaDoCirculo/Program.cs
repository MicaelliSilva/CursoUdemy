Console.WriteLine("Digite o valor do raio:");

double raio = double.Parse(Console.ReadLine());

double area;
double valor_de_pi = 3.14159;
area = valor_de_pi * (raio * raio);

Console.WriteLine("O valor da area é: " + area.ToString("F4"));
