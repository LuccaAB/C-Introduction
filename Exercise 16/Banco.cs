namespace treinamneto
{
    internal class Banco
    {
        public string _titular;
        public int _codigo { get; private set; }
        public double _saldo { get; private set; }

        public Banco(int codigo, string titular)
        {
            _codigo = codigo;
            _titular = titular;
            _saldo = 0;
        }

        public Banco(int codigo, string titular, double saldo) : this(codigo, titular)
        {
            _saldo = saldo;
        }

        public void Deposito(double dinheiro)
        {
            _saldo += dinheiro;
        }

        public void Saque(double saque)
        {
            _saldo = _saldo - saque - 5.0;
        }
    }
}