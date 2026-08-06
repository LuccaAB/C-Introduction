using teste;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vetor = new Produto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qnt; i++)
            {
                Console.Write($"\nAluguel #{i + 1}:\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Produto { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] == null)
                {

                }
                else
                {
                    Console.WriteLine($"{i}: {vetor[i]}");
                }
            }
        }
    }
}