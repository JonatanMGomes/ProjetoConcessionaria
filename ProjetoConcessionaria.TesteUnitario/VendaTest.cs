using ProjetoConcessionaria.Lib.Models;
using Xunit;

namespace ProjetoConcessionaria.TesteUnitario
{
    public class VendaTest
    {
        [Fact]
        public void TestandoSeVendaSalvaCompradorCorretamente()
        {
            //Arrange - Preparando
            var compradorEsperado = new Cliente("jonatan", "11122233344", "11/07/1994", "email@email.com", "999887766");
            var vendedorParaOTest = new Funcionario("fulano", "11122233344", "01/01/1990", "vendedor");
            var veiculoParaOTest = new Veiculo("gm", "celta", "01/01/2015", 50000, "cinza", 10000);
            var vendaTest = new Venda(compradorEsperado, vendedorParaOTest, veiculoParaOTest, "financiamento");
            //Act - Agindo
            var compradorATestar = vendaTest.GetComprador();
            //Assert - 
            Assert.Equal(compradorEsperado, compradorATestar);
        }
        [Fact]
        public void TestandoSeVendaSalvaVendedorCorretamente()
        {
            //Arrange - Preparando
            var compradorParaOTest = new Cliente("jonatan", "11122233344", "11/07/1994", "email@email.com", "999887766");
            var vendedorEsperado = new Funcionario("fulano", "11122233344", "01/01/1990", "vendedor");
            var veiculoParaOTest = new Veiculo("gm", "celta", "01/01/2015", 50000, "cinza", 10000);
            var vendaTest = new Venda(compradorParaOTest, vendedorEsperado, veiculoParaOTest, "financiamento");
            //Act - Agindo
            var vendedorATestar = vendaTest.GetVendedor();
            //Assert - 
            Assert.Equal(vendedorEsperado, vendedorATestar);
        }
        [Fact]
        public void TestandoSeVendaSalvaVeiculoCorretamente()
        {
            //Arrange - Preparando
            var compradorParaOTest = new Cliente("jonatan", "11122233344", "11/07/1994", "email@email.com", "999887766");
            var vendedorParaOTest = new Funcionario("fulano", "11122233344", "01/01/1990", "vendedor");
            var veiculoEsperado = new Veiculo("gm", "celta", "01/01/2015", 50000, "cinza", 10000);
            var vendaTest = new Venda(compradorParaOTest, vendedorParaOTest, veiculoEsperado, "financiamento");
            //Act - Agindo
            var veiculoATestar = vendaTest.GetVeiculo();
            //Assert - 
            Assert.Equal(veiculoEsperado, veiculoATestar);
        }
        [Fact]
        public void TestandoSeVendaSalvaFormaPagamentoCorretamente()
        {
            //Arrange - Preparando
            var formaPagamentoEsperada = "financiamento";
            var compradorParaOTest = new Cliente("jonatan", "11122233344", "11/07/1994", "email@email.com", "999887766");
            var vendedorParaOTest = new Funcionario("fulano", "11122233344", "01/01/1990", "vendedor");
            var veiculoParaOTest = new Veiculo("gm", "celta", "01/01/2015", 50000, "cinza", 10000);
            var vendaTest = new Venda(compradorParaOTest, vendedorParaOTest, veiculoParaOTest, formaPagamentoEsperada);
            //Act - Agindo
            var formaPagamentoATestar = vendaTest.GetFormaPagamento();
            //Assert - 
            Assert.Equal(formaPagamentoEsperada, formaPagamentoATestar);
        }
        [Fact]
        public void TestandoSeVendaSalvaValorFinalCorretamente()
        {
            //Arrange - Preparando
            var compradorParaOTest = new Cliente("jonatan", "11122233344", "11/07/1994", "email@email.com", "999887766");
            var vendedorParaOTest = new Funcionario("fulano", "11122233344", "01/01/1990", "gerente");
            var veiculoParaOTest = new Veiculo("gm", "celta", "01/01/2015", 50000, "cinza", 10000);
            var vendaTest = new Venda(compradorParaOTest, vendedorParaOTest, veiculoParaOTest, "financiamento");
            var valorFinalEsperado = vendaTest.AplicarDesconto();
            //Act - Agindo
            var valorFinalATestar = vendaTest.GetValorFinal();
            //Assert - 
            Assert.Equal(valorFinalEsperado, valorFinalATestar);
        }
    }
}