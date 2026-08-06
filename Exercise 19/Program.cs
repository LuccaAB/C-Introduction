using System.Globalization;
using teste;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionários você vai registrar? ");
            int func = int.Parse(Console.ReadLine());

            for (int i = 0; i < func; i++)
            {
                Console.WriteLine($"\nFuncionario #{i + 1}:");
                Console.Write("ID: ");
                int ID = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(ID, nome, salario));
            }

            Console.Write("\nEntre com o ID do funcionario que receberá aumento: ");
            int aumento = int.Parse(Console.ReadLine());

            Funcionario esse = lista.Find(x => x._ID == aumento);

            if (esse != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                esse.AumentoSalario(porcent);
            }

            else
            {
                Console.WriteLine("ERRO");
            }

            Console.WriteLine("Lista atualizada: ");

            foreach (Funcionario obj in lista)
            {
                Console.Write($"{obj}");
            }
        }
    }
}