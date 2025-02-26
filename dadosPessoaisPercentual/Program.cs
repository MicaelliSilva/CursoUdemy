int n;

Console.Write("Digite a quantidade de pessoas: ");
n = int.Parse(Console.ReadLine());

string[] nomes = new string[n];
int[] idades = new int[n];
double[] alturas = new double[n];

Console.WriteLine("\nDigite o Nome, Idade e Altura: ");
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    nomes[i] = s[0];
    idades[i] = int.Parse(s[1]);
    alturas[i] = double.Parse(s[2]);
}

double soma = 0;
for (int i = 0; i < n; i++)
{
    soma += alturas[i];
}

double alturaMedia = soma / n;

Console.WriteLine("\nResultado da média das alturas: " + alturaMedia);

int quantidadeIdade = 0;
for (int i = 0; i < n; i++)
{
    if (idades[i] > 16)
    {
        quantidadeIdade++;
    }
}

double porcentagem = (double)quantidadeIdade / n * 100.0;

Console.WriteLine("\nPessoas com menos que 16 anos: " + porcentagem.ToString("F1") + "%");
