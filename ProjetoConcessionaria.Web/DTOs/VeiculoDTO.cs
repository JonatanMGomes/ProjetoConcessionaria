namespace ProjetoConcessionaria.Web.DTOs
{
    public class VeiculoDTO
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
    }
}