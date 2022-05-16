using ProjetoConcessionaria.MinhasExceptions;

namespace ProjetoConcessionaria
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Kilometragem { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
        public Veiculo()
        {

        }
        public Veiculo(string marca, string modelo, string ano, int kilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetKilometragem(kilometragem);
            SetCor(cor);
            SetValor(valor);
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
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public virtual double CalcularValor()
        {
            return 0;
        }
        public bool ValidarAno(DateTime ano)
        {
            if (ano.Year >= 2004 && ano.Year <= DateTime.Today.Year)
            {
                return true;
            }
            throw new ValidacaoDados("Ano inválido!");
        }
        public virtual bool ValidarValor(double valor)
        {
            if (valor >= 0)
            {
                return true;
            }
            throw new ValidacaoDados("valor inválido!");
        }
    }
}