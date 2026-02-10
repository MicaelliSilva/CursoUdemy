using BancoSimples;

Conta conta;

Console.Write("Entre com o numero da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("\nEntre com o nome do titular da conta: ");
string nome = Console.ReadLine();

Console.WriteLine("\nHavera deposito inicial (s/n)?");
char opcao = char.Parse(Console.ReadLine());

do
{
    Console.WriteLine("\nDigite a opção novamente:");
    opcao = char.Parse(Console.ReadLine());

    if (opcao == 's')
    {
        Console.Write("\nDigite o valor do deposito:");
        decimal depositoInicial = decimal.Parse(Console.ReadLine());

        conta = new Conta(nome, numero, depositoInicial);
    }
    else
    {
        conta = new Conta(nome, numero);
    }

} while (opcao != 's' && opcao != 'n');

Console.WriteLine("\nDados da conta:");
Console.WriteLine("Conta " + numero + ", Titular: " + nome +
    ", Saldo: $" + conta.Saldo.ToString("F2"));

Console.Write("\nEntre com um valor para deposito:");
decimal deposito = decimal.Parse(Console.ReadLine());

conta.EfetuarDeposito(deposito);

Console.WriteLine("\nDados da conta atualizados:");
Console.WriteLine("Conta " + numero + ", Titular: " + nome +
    ", Saldo: $" + conta.Saldo.ToString("F2"));

Console.Write("\nEntre com um valor para saque:");
decimal saque = decimal.Parse(Console.ReadLine());

conta.EfetuarSaque(saque);

Console.WriteLine("\nDados da conta atualizados:");
Console.WriteLine("Conta " + numero + ", Titular: " + nome +
    ", Saldo: $" + conta.Saldo.ToString("F2"));