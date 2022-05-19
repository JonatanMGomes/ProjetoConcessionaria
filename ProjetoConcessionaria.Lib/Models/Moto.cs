using ProjetoConcessionaria.Lib.MinhasExceptions;

namespace ProjetoConcessionaria.Lib.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }
        
        public Moto(string marca, string modelo, string ano, int Quilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, Quilometragem, cor, valor)
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
            throw new ValidacaoDados("Valor inválido!");
        }
    }
}