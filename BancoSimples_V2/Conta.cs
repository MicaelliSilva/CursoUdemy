namespace BancoSimples
{
    internal class Conta
    {
        static Decimal Taxa = 5.00m;

        public string Nome { get; set; }
        public int Numero { get; private set; }

        public decimal Saldo { get; private set; }

        public Conta(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }

        public Conta(string nome, int numero, decimal depositoInicial) : this(nome, numero)
        {
            EfetuarDeposito(depositoInicial);
        }

        public decimal EfetuarDeposito(decimal deposito)
        {
            if (deposito > 0)
            {
                Saldo += deposito;
            }

            return Saldo;
        }

        public decimal EfetuarSaque(decimal saque)
        {
            Saldo -= saque;

            Saldo -= Taxa;

            return Saldo;
        }
    }
}