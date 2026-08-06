using System.Globalization;

Console.WriteLine("Digite o valor dos seguintes itens para a peça 1: código da peça, numero de peças e valor da peça. (mesma linha)");
string[] vet = Console.ReadLine().Split(' ');

int codigo = int.Parse(vet[0]);
int pecas = int.Parse(vet[1]);
double valor = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.Write("peça 2: ");
string[] vet2 = Console.ReadLine().Split(' ');

int codigo2 = int.Parse(vet2[0]);
int pecas2 = int.Parse(vet2[1]);
double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

double calculo = (pecas * valor + pecas2 * valor2);

Console.WriteLine($"VALOR A PAGAR: {calculo.ToString("F2", CultureInfo.InvariantCulture)}");