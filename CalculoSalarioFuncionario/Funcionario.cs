namespace CalculoSalarioFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(double salarioBruto, double imposto)
        {
            double salarioLiquido = salarioBruto - imposto;
            return salarioLiquido;
        }

        public double AumentarSalario(double porcentagem, double salarioBruto)
        {
            porcentagem = porcentagem / 100;
            double aumentarSalario = (porcentagem * salarioBruto) + salarioBruto;
            return aumentarSalario;
        }

    }
}
