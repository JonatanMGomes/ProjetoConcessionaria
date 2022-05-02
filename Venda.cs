namespace ProjetoConcessionaria
{
    public class Venda
    {
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        private Veiculo Veiculo { get; set; }
        private string FormaPagamento { get; set; }
        private double ValorFinal { get; set; }
    }
}