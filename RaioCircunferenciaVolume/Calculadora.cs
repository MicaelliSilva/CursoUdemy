
namespace RaioCircunferenciaVolume
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circuferencia(double r)
        {
            return 2 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
