namespace CalculoRetangulo
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area(double altura, double largura)
        {
            double area = altura * largura;
            return area;
        }

        public double Perimetro(double altura, double largura)
        {
            double perimetro = altura + altura + largura + largura;
            return perimetro;
        }

        public double Diagonal(double altura, double largura)
        {
            double soma = (altura * altura) + (largura * largura);
            double diagonal = Math.Sqrt(soma);
            return diagonal;
        }




    }
}
