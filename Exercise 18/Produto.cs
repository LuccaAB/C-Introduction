namespace teste
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Email} ";
        }

    }
}