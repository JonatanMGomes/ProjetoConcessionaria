namespace ProjetoConcessionaria
{
    public class Venda
    {
        public Cliente Comprador { get; set; }
        public Funcionario Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }
        public Venda()
        {
            
        }
        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaPagamento)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculo(veiculo);
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
        public void SetVeiculo(Veiculo veiculo)
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
            double valorVeiculo = Veiculo.GetValor();
            string cargoGerente = "gerente";
            if(Vendedor.GetCargo().Contains(cargoGerente)){
                valorVeiculo = valorVeiculo * 0.95;
            }
            return valorVeiculo;
        }
    }
}