using System.Globalization;
using teste;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;

            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produto { Name = name, preco = price };

                soma += vetor[i].preco;
            }

            soma = soma / n;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}