namespace ProjetoConcessionaria.Web.DTOs
{
    public class VendaDTO
    {
        public ClienteDTO CompradorDTO { get; set; }
        public FuncionarioDTO VendedorDTO { get; set; }
        public VeiculoDTO VeiculoDTO { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }
    }
}