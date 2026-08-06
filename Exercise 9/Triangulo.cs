using System.Globalization;

namespace teste
{
    internal class Triangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2)) + (Math.Pow(Altura, 2)));
        }

        public override string ToString()
        {
            return $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}\nPerímetro = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\nDiagonal = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}