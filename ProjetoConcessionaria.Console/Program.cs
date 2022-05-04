namespace ProjetoConcessionaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carroTest = new Carro("gm", "onix", "01/01/2020", 0, 10000, "preto", true, "flex");
            var motoTest = new Moto("honda", "twister", "01/01/2020",0,"preta", 1, 250, "injeção eletrônica");
            Console.WriteLine($"O carro tem cambio automatico? {carroTest.GetTransmissaoAutomatica()}. Valor do carro é:{carroTest.GetValor()}");
            Console.WriteLine($"A moto tem partida: {motoTest.GetPartida()}. Valor da moto é:{motoTest.GetValor()}");
        }
    }
}