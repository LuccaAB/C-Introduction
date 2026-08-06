namespace teste
{
    internal class Calculadora
    {
        public static double ConversorDeMoeda(double money, double cotacao)
        {
            return (money * cotacao) + ((money * cotacao) * 0.06);
        }
    }
}