namespace ProjetoConcessionaria
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }
        public Moto(string marca, string modelo, string ano, int kilometragem, string cor, int cilindrada, string partida) : base(marca, modelo, ano, kilometragem, cor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
        public string GetPartida()
        {
            return Partida;
        }
        public void SetPartida(string partida)
        {
            Partida = partida;
        }
    }
}