using System.Globalization;

Console.Write("\nEscreva um numero inteiro: ");
int x = int.Parse(Console.ReadLine());

Console.Write("\nAgora escreva um caractere: ");
char ch = char.Parse(Console.ReadLine());

Console.Write("\nDigite um numero decimal: ");
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("\nEscreva nessa ordem seu: Nome Sexo Idade Altura\n");

string[] vet = Console.ReadLine().Split(' ');

string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine($"\n {x}");
Console.WriteLine($"\n {ch}");
Console.WriteLine($"\n {n2.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"\n {nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");