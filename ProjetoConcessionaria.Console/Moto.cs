using ProjetoConcessionaria.MinhasExceptions;

namespace ProjetoConcessionaria
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }
        public Moto()
        {
            
        }
        public Moto(string marca, string modelo, string ano, int kilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, kilometragem, cor, valor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
            SetValor(CalcularValor());
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
        public override double CalcularValor()
        {
            double valorBase = GetCilindrada() * 50;
            var partida = GetPartida();
            if (partida == "injeção eletrônica")
            {
                //valorBase = valorBase * 1.1;
                valorBase = valorBase + (valorBase*0.1);
            }
            return valorBase;
        }
        public override bool ValidarValor(double valor)
        {
            if (valor >= 2000)
            {
                return true;
            }
            throw new ValidacaoDados("valor inválido!");
        }
    }
}