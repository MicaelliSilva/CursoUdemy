using ControleFuncionarios_V2;

List<Funcionario> listaFuncionarios = new List<Funcionario>();

Console.Write("Digite a quantidade de funcionarios: ");
int qtdFuncionarios = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdFuncionarios; i++)
{
    Console.Write("\nDigite o Id do funcionario: ");
    int id = int.Parse(Console.ReadLine());

    if (listaFuncionarios.Any(f => f.Id == id))
    {
        Console.WriteLine("\nId ja existente digite novamente.");
        i--;
        continue;
    }

    Console.Write("\nDigite o Nome do funcionario: ");
    string nome = Console.ReadLine();

    Console.Write("\nDigite o valor do salario do funcionario: ");
    decimal salario = decimal.Parse(Console.ReadLine());

    Funcionario f = new Funcionario(id, nome, salario);

    listaFuncionarios.Add(f);
}

Console.WriteLine("\nLista dos funcionarios:");

foreach (Funcionario f in listaFuncionarios)
{
    Console.WriteLine("Id: " + f.Id + ", " + "Nome: " + f.Nome + ", "
        + "Salario: " + f.Salario);
}

Console.Write("\nDigite o id do funcionario que deseja realizar o aumento: ");
int id_Busca = int.Parse(Console.ReadLine());

Funcionario f_Busca = listaFuncionarios.Find(x => x.Id == id_Busca);

if (f_Busca == null)
{
    Console.WriteLine("\nUsuario nao encontrado!!, operação abortada.");
}
else
{
    Console.Write("\nDigite em quantos % deseja aumentar o salario do funcionario: ");
    decimal porcentagem = decimal.Parse(Console.ReadLine());

    f_Busca.AumentarSalario(porcentagem);

    Console.WriteLine("\nLista atualizada dos funcionarios:");

    foreach (Funcionario f in listaFuncionarios)
    {
        Console.WriteLine("Id: " + f.Id + ", " + "Nome: " + f.Nome + ", "
            + "Salario: " + f.Salario);
    }
}