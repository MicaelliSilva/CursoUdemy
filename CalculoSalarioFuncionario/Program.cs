using CalculoSalarioFuncionario;

Funcionario f = new Funcionario();

Console.Write("Digite o nome do funcionario: ");
f.Nome = Console.ReadLine();

Console.WriteLine();
Console.Write("Digite o salario bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Digite o imposto: ");
f.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Salario liquido: "
    + f.SalarioLiquido(f.SalarioBruto, f.Imposto).ToString("F2"));

Console.WriteLine();
Console.WriteLine("Digite a porcentagem para aumentar salario: ");
double porcentagem = double.Parse(Console.ReadLine());

Console.WriteLine("Dados atualizados: " + f.Nome + ", " + f.AumentarSalario(porcentagem, f.SalarioBruto));
