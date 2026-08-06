using System.Globalization;

namespace teste
{
    internal class Funcionario
    {
        public string Nome;
        public double Bruto;
        public double Imposto;
        public double Porcentagem;

        public double Liquido()
        {
            return Bruto - Imposto;
        }

        public void AumentarSalario()
        {
            Bruto = Bruto + (Bruto * Porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"{Nome},{Liquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}