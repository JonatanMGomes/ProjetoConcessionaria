namespace ProjetoConcessionaria.Lib.Models
{
    public class Venda
    {
        public int Id { get; set; }
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public virtual Carro Carro { get; set; }
        public virtual Moto Moto { get; set; }
        private string FormaPagamento { get; set; }
        private double ValorFinal { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
       
        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaPagamento)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculos(veiculo);
            SetFormaPagamento(formaPagamento);
            SetValorFinal(AplicarDesconto());
        }
        public Cliente GetComprador()
        {
            return Comprador;
        }
        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }
        public Funcionario GetVendedor()
        {
            return Vendedor;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }
        public Veiculo GetVeiculo()
        {
            return Veiculo;
        }
        public void SetVeiculos(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }
        public string GetFormaPagamento()
        {
            return FormaPagamento;
        }
        public void SetFormaPagamento(string formaPagamento)
        {
            FormaPagamento = formaPagamento;
        }
        public double GetValorFinal()
        {
            return ValorFinal;
        }
        public void SetValorFinal(double valorFinal)
        {
            ValorFinal = valorFinal;
        }
        public double AplicarDesconto(){
            /* double valorARetornar = 0;
            for (var contador = 0; contador < Veiculos.Count; contador++)
            {
                valorARetornar = valorARetornar + Veiculos[contador].GetValor();
            }*/
            double valorARetornar = Veiculo.GetValor();
            string cargoGerente = "gerente";
            if(Vendedor.GetCargo().Contains(cargoGerente)){
                valorARetornar = valorARetornar * 0.95;
            }
            return valorARetornar;
        }
    }
}