namespace ConversorDeMoeda
{
    internal class ConversorMoeda
    {
        public static double Iof = 0.06;

        public static double ConversorDolar(double valorDolar, double dolarComprado)
        {
            double calculoDolar = valorDolar * dolarComprado;

            double calculoImposto = calculoDolar * Iof;

            double valorTotal = calculoDolar + calculoImposto;

            return valorTotal;
        }
    }
}
