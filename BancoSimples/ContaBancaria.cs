namespace BancoSimples
{
    internal class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public decimal Saldo { get; set; }

        public void Depositar(decimal deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(decimal saque)
        {
            Saldo -= 5 + saque;
        }

    }
}
