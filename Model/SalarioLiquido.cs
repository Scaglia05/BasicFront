namespace ApostilaFront.Model
{
    public class SalarioLiquido
    {
        public decimal ValorHora { get; set; }

        public decimal AulasMes { get; set; }
        public decimal PorcentualDesconto { get; set; }

        public decimal CalculoSalario { get; private set; }
        public decimal CalculoSalarioComDesconto { get; private set; }

        public void CalcularSalarioLiquido()
        {

            CalculoSalario = 8 * ValorHora * AulasMes;
            CalculoSalarioComDesconto = (100 - PorcentualDesconto) / 100 * CalculoSalario;



        }
    }
}
