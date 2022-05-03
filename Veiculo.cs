namespace ProjetoConcessionaria
{
    public class Veiculo
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected DateTime Ano { get; set; }
        protected int Kilometragem { get; set; }
        protected string Cor { get; set; }
        protected double Valor { get; set; }
        public Veiculo(string marca, string modelo, string ano, int kilometragem, string cor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetKilometragem(kilometragem);
            SetCor(cor);
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public DateTime GetAno()
        {
            return Ano;
        }
        public void SetAno(string ano)
        {
            var anoDesejado = DateTime.Parse(ano);
            Ano = anoDesejado;
        }
        public int GetKilometragem()
        {
            return Kilometragem;
        }
        public void SetKilometragem(int kilometragem)
        {
            Kilometragem = kilometragem;
        }
        public string GetCor()
        {
            return Cor;
        }
        public void SetCor(string cor)
        {
            Cor = cor;
        }
    }
}