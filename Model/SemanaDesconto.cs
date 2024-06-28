namespace ApostilaFront.Model
{
    public class SemanaDesconto
    {
        public string Nome { get; set; }
        public decimal ValordaConta { get; set; }
        public decimal ValorDesconto { get; private set; }

        public decimal CalcularSemanaDesconto()
        {

            ValorDesconto = ValordaConta * 0.70m;

            return ValorDesconto;
        }
    }
}
