namespace ProjetoConcessionaria
{
    public class Carro : Veiculo
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }
        public Carro()
        {

        }
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