using System.Globalization;
using treinamneto;
namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco cliente;

            Console.Write("Entre o número da conta: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char op = char.Parse(Console.ReadLine());

            if (op == 's' || op == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cliente = new Banco(codigo, titular, saldo);

            }
            else
            {
                cliente = new Banco(codigo, titular);
            }

            Console.Write($"Dados da conta:\nConta {cliente._codigo}, Titular: {cliente._titular}, Saldo: $ {cliente._saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\n\nEntre com um valor para depósito: ");
            double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cliente.Deposito(dinheiro);

            Console.Write($"Dados atualizados:\nConta {cliente._codigo}, Titular: {cliente._titular}, Saldo: $ {cliente._saldo.ToString("F2", CultureInfo.InvariantCulture)}");


            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cliente.Saque(saque);

            Console.Write($"Dados atualizados:\nConta {cliente._codigo}, Titular: {cliente._titular}, Saldo: $ {cliente._saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}