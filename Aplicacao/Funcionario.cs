namespace Aplicacao
{
    public class Funcionario
    {
        public string Nome { get; private set; }

        public string Cargo { get; private set; }

        public decimal Salario { get; private set; }

        public Funcionario(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public string Apresentar() => $"Oi! Meu nome é {Nome} e trabalho como {Cargo}.";

        public void ConcederAumentoSalarial(decimal percentual)
        {
            if (percentual < 0)
            {
                return;
            }
            Salario += Salario * (percentual / 100);
        }
    }
}
