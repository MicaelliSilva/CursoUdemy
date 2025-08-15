using ControleDeQuartosPensao;

Estudante[] p = new Estudante[10];

string nome, email;
int numQuarto;

Console.Write("Digite o numero de estudantes que vao alugar quartos: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("\nDigite o nome do estudante: ");
    nome = Console.ReadLine();

    Console.Write("Digite o email do estudante: ");
    email = Console.ReadLine();

    Console.Write("Digite o numero do quarto escolhido (0 a 9): ");
    numQuarto = int.Parse(Console.ReadLine());

    while (true)
    {
        if (numQuarto < 0 || numQuarto > 9)
        {
            Console.Write("\nDigite novamente o numero do quarto: ");
            numQuarto = int.Parse(Console.ReadLine());
        }
        else if (p[numQuarto] != null)
        {
            Console.Write("\nQuarto ocupado digite novamente: ");
            numQuarto = int.Parse(Console.ReadLine());
        }
        else
        {
            break;
        }

    }

    p[numQuarto] = new Estudante()
    {
        Nome = nome,
        Email = email,
    };
}

for (int i = 0; i < 10; i++)
{
    if (p[i] != null)
    {
        Console.WriteLine("\nQuarto: " + i + ", Nome: " + p[i].Nome
            + ", Email: " + p[i].Email);
    }
}
