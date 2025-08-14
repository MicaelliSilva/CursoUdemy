using BancoSimples;
ContaBancaria conta = new ContaBancaria();

Console.Write("Entre com o numero da conta: ");
string numeroConta = Console.ReadLine();

Console.Write("\nEntre com o titular: ");
string nometitular = Console.ReadLine();

Console.Write("\nHavera deposito inicial? (S/N): ");
char opcao = char.Parse(Console.ReadLine());
if (opcao == 'S')
{
    Console.Write("\nEntre com o deposito inicial: ");
    decimal depositoInicial = decimal.Parse(Console.ReadLine());

    conta = new ContaBancaria()
    {
        NumeroConta = numeroConta,
        Saldo = depositoInicial,
        NomeTitular = nometitular
    };
}
else
{
    conta = new ContaBancaria()
    {
        NumeroConta = numeroConta,
        Saldo = 0,
        NomeTitular = nometitular
    };
}

Console.WriteLine("\nDados da conta: ");
Console.WriteLine("Conta: " + conta.NumeroConta + " Titular: "
    + conta.NomeTitular + ", Saldo: $" + conta.Saldo );

Console.Write("\nEntre com um valor para o deposito: ");
decimal deposito = decimal.Parse(Console.ReadLine());

conta.Depositar(deposito);

Console.WriteLine("\nDados da conta: ");
Console.WriteLine("Conta: " + conta.NumeroConta + " Titular: "
    + conta.NomeTitular + ", Saldo: $" + conta.Saldo);

Console.Write("\nEntre um valor para saque: ");
decimal saque = decimal.Parse(Console.ReadLine());

conta.Sacar(saque);

Console.WriteLine("\nDados da conta: ");
Console.WriteLine("Conta: " + conta.NumeroConta + " Titular: "
    + conta.NomeTitular + ", Saldo: $" + conta.Saldo);