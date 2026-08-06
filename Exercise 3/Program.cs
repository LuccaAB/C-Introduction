using System.Globalization;

Console.WriteLine("Digite seu nome completo");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço do produto");
double produto = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");

string[] vet = Console.ReadLine().Split(' ');

string lastName = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine($"\n\n{nome}");
Console.WriteLine($"{quartos}");
Console.WriteLine($"{produto}");
Console.WriteLine($"{lastName} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");