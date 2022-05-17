namespace ProjetoConcessionaria.Web.DTOs
{
    public class CarroDTO : VeiculoDTO
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }
    }
}