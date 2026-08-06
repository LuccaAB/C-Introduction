using System.Globalization;

namespace teste
{
    internal class Funcionario
    {
        public int _ID { get; set; }
        public string _Nome { get; set; }
        public double _Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            _ID = id;
            _Nome = nome;
            _Salario = salario;
        }

        public Funcionario() { }
        public void AumentoSalario(double porcentagem)
        {
            _Salario += _Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return $"{_ID}, {_Nome}, {_Salario.ToString("F2", CultureInfo.InvariantCulture)} \n";
        }
    }
}