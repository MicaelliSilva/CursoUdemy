namespace ControleFuncionarios_V2;

internal class Funcionario
{
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Salario { get; private set; }

        public Funcionario(int id, string nome, decimal salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(decimal porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }
}