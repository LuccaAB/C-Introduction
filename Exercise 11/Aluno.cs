using System.Globalization;

namespace teste
{
    internal class Aluno
    {
        public string Nome;

        public double A;
        public double B;
        public double C;

        public double NotaFinal()
        {
            return A + B + C;
        }
        public override string ToString()
        {
            if (NotaFinal() >= 60)
            {
                return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\nAPROVADO!";
            }
            else
            {
                double faltou = 60 - NotaFinal();
                return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO!\nFALTARAM {faltou.ToString("F2", CultureInfo.InvariantCulture)} PONTOS!";
            }
        }
    }
}