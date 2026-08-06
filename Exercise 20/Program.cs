namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[2];
            int lugar;

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < 2; i++)
            {
                vetor[i] = int.Parse(valores[i]);
            }

            int l = vetor[0];
            int c = vetor[1];
            int[,] mat = new int[l, c];

            Console.WriteLine();

            for (int x = 0; x < l; x++)
            {
                string[] nums = Console.ReadLine().Split(' ');

                for (int y = 0; y < c; y++)
                {
                    mat[x, y] = int.Parse(nums[y]);
                }
            }

            lugar = int.Parse(Console.ReadLine());

            for (int x = 0; x < l; x++)
            {
                for (int y = 0; y < c; y++)
                {
                    if (mat[x, y] == lugar)
                    {
                        Console.Write($"POSIÇÃO: [{x}, {y}]");

                        if (y > 0) { Console.Write($"LEFT: {mat[x, y - 1]} "); }
                        if (y < l - 1) { Console.Write($"RIGHT: {mat[x, y + 1]} "); }
                        if (x > 0) { Console.Write($"DOWN: {mat[x - 1, y]} "); }
                        if (x < l - 1) { Console.Write($"UP: {mat[x + 1, y]} "); }
                    }
                }
            }
        }
    }
}