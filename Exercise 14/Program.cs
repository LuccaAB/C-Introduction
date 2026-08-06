using System.Globalization;
using teste;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quandos dolares você vai comprar? ");
            double comprarDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagar = Calculadora.ConversorDeMoeda(dolar, comprarDolar);

            Console.WriteLine($"Valor a ser pago em reais = {pagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}