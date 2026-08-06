using System.Globalization;
using teste;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            x.Bruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            x.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.AumentarSalario();

            Console.WriteLine($"\nDados atualizados: {x}");
        }
    }
}