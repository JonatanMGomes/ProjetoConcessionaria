namespace ProjetoConcessionaria
{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }
        public Carro(string marca, string modelo, string ano, int kilometragem, double valor, string cor, bool transmissaoAutomatica, string combustivel) : base(marca, modelo, ano, kilometragem, cor, valor)
        {
            SetTransmissaoAutomatica(transmissaoAutomatica);
            SetCombustivel(combustivel);
            SetValor(CalcularValor());
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
        public override double CalcularValor()
        {
            double valorBase = GetValor();
            if (GetTransmissaoAutomatica() == true)
            {
                valorBase = valorBase * 1.2;
            }
            return valorBase;
        }
    }
}