namespace ProjetoConcessionaria
{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }
        public Carro(string marca, string modelo, string ano, int kilometragem, string cor, bool transmissaoAutomatica, string combustivel) : base(marca, modelo, ano, kilometragem, cor)
        {
            SetTransmissaoAutomatica(transmissaoAutomatica);
            SetCombustivel(combustivel);
        }
        public bool GetTransmissaoAutomatica()
        {
            return TransmissaoAutomatica;
        }
        public void SetTransmissaoAutomatica(bool transmissaoAutomatica)
        {
            TransmissaoAutomatica = transmissaoAutomatica;
        }
        public string GetCombustivel()
        {
            return Combustivel;
        }
        public void SetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }
    }
}