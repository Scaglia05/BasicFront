namespace ApostilaFront.Model
{
    public class Restaurante
    {
        public string NomePrato { get; set; }
        public decimal ValorPrato { get; set; }

        //public static decimal CalcularTotal04(List<Restaurante> listRestaurante)
        //{
        //    return listRestaurante.Sum(r => r.ValorPrato);
        //}

        //public static decimal CalcularValorGarcom(decimal valorTotal)
        //{
        //    return valorTotal * 1.1m;
        //}

    }
}
