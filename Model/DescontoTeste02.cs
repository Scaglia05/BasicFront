namespace ApostilaFront.Model
{
    public class DescontoTeste02
    {
        public decimal ValorProduto { get; set; }
        public decimal ValorDesconto { get; private set; }

        public void CalcularDescontoTeste02()
        {
            ValorDesconto = ValorProduto * 0.91m;
        }
    }
}
