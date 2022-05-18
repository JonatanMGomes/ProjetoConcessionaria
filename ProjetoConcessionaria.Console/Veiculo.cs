using ProjetoConcessionaria.MinhasExceptions;

namespace ProjetoConcessionaria
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private DateTime Ano { get; set; }
        private int Quilometragem { get; set; }
        private string Cor { get; set; }
        private double Valor { get; set; }
    
        public Veiculo(string marca, string modelo, string ano, int Quilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(Quilometragem);
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
            ValidarAno(anoDesejado);
            Ano = anoDesejado;
        }
        public int GetQuilometragem()
        {
            return Quilometragem;
        }
        public void SetQuilometragem(int Quilometragem)
        {
            Quilometragem = Quilometragem;
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
            ValidarValor(valor);
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