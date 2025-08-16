using ControleFuncionarios;
using System.Runtime.CompilerServices;

Console.Write("Digite o numero de funcionarios: ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> listaFuncionarios = new List<Funcionario>();


for (int i = 1; i <= n; i++)
{
    Console.Write("\nDigite o nome do funcionario " + i + ": ");
    string nome = Console.ReadLine();

    Console.Write("\nDigite o salario: ");
    decimal salario = decimal.Parse(Console.ReadLine());

    Funcionario funcionario = new Funcionario()
    {
        Id = i,
        Nome = nome,
        Salario = salario,
    };

    listaFuncionarios.Add(funcionario);
}

Console.WriteLine("\nDigite o id do funcionario: ");
int id = int.Parse(Console.ReadLine());

if (!listaFuncionarios.Any(f => f.Id == id))
{
    Console.WriteLine("Nao existe funcionario com esse ID!!");
}
else
{
    Console.Write("\nDigite a porcentagem que deseja aumentar do salario: ");
    decimal porcentagem = decimal.Parse(Console.ReadLine());

    Funcionario funcionarioEncontrado = listaFuncionarios.Find(f => f.Id == id);
    funcionarioEncontrado.AumentarSalario(porcentagem);

    Console.WriteLine("Id funcionario: " + funcionarioEncontrado.Id
        + " \nSalario com aumento: " + funcionarioEncontrado.Salario.ToString("F2"));
}