namespace ApostilaFront.Model
{
    public class CalculoEnergia
    {
        public decimal SalarioMinimo { get; set; }
        public decimal QtdWatts { get; set; }
        public decimal ValorPorKWatts { get; private set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorTotalDesconto { get; private set; }

        public void CalcularValor()
        {
            ValorPorKWatts = SalarioMinimo / 7 / 100;
            ValorTotal = ValorPorKWatts * QtdWatts;
            ValorTotalDesconto = ValorTotal * 0.9m;
        }
    }
}
