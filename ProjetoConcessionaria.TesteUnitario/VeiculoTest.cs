using ProjetoConcessionaria.Lib.MinhasExceptions;
using ProjetoConcessionaria.Lib.Models;
using Xunit;

namespace ProjetoConcessionaria.TesteUnitario;

public class VeiculoTest
{
    [Fact]
    public void TestandoSeVeiculoSalvaMarcaCorretamente()
    {
        //Arrange - Preparando
        var marcaEsperada = "gm";
        var veiculoTest = new Veiculo(marcaEsperada, "celta", "01/01/2020", 0, "cinza", 15000);
        //Act - Agindo
        var marcaATestar = veiculoTest.GetMarca();
        //Assert - 
        Assert.Equal(marcaEsperada, marcaATestar);
    }
    [Fact]
    public void TestandoSeVeiculoSalvaModeloCorretamente()
    {
        //Arrange - Preparando
        var modeloEsperado = "celta";
        var veiculoTest = new Veiculo("gm", modeloEsperado, "01/01/2020", 0, "cinza", 15000);
        //Act - Agindo
        var modeloATestar = veiculoTest.GetModelo();
        //Assert - 
        Assert.Equal(modeloEsperado, modeloATestar);
    }
    [Fact]
    public void TestandoSeVeiculoSalvaAnoCorretamente()
    {
        //Arrange - Preparando
        var anoEsperado = "01/01/2020 00:00:00";
        var veiculoTest = new Veiculo("gm", "celta", anoEsperado, 0, "cinza", 15000);
        //Act - Agindo
        var anoATestar = veiculoTest.GetAno().ToString();
        //Assert - 
        Assert.Equal(anoEsperado, anoATestar);
    }
    [Fact]
    public void TestandoSeVeiculoSalvaQuilometragemCorretamente()
    {
        //Arrange - Preparando
        var kmEsperada = 0;
        var veiculoTest = new Veiculo("gm", "celta", "01/01/2020", kmEsperada, "cinza", 15000);
        //Act - Agindo
        var kmATestar = veiculoTest.GetQuilometragem();
        //Assert - 
        Assert.Equal(kmEsperada, kmATestar);
    }
    [Fact]
    public void TestandoSeVeiculoSalvaCorCorretamente()
    {
        //Arrange - Preparando
        var corEsperada = "Cinza";
        var veiculoTest = new Veiculo("gm", "celta", "01/01/2020", 0, corEsperada, 15000);
        //Act - Agindo
        var CorATestar = veiculoTest.GetCor();
        //Assert - 
        Assert.Equal(corEsperada, CorATestar);
    }
    [Fact]
    public void TestandoSeVeiculoSalvaValorCorretamente()
    {
        //Arrange - Preparando
        var valorEsperado = 15000;
        var veiculoTest = new Veiculo("gm", "celta", "01/01/2020", 0, "cinza", valorEsperado);
        //Act - Agindo
        var valorATestar = veiculoTest.GetValor();
        //Assert - 
        Assert.Equal(valorEsperado, valorATestar);
    }
    [Fact]
    public void TestandoSeCarroSalvaTransmissaoCorretamente()
    {
        //Arrange - Preparando
        var transmissaoEsperada = true;
        var veiculoTest = new Carro("gm", "celta", "01/01/2020", 0, "cinza", 15000, transmissaoEsperada, "flex");
        //Act - Agindo
        var transmissaoATestar = veiculoTest.GetTransmissaoAutomatica();
        //Assert - 
        Assert.Equal(transmissaoEsperada, transmissaoATestar);
    }
    [Fact]
    public void TestandoSeCarroSalvaCombustivelCorretamente()
    {
        //Arrange - Preparando
        var combustivelEsperado = "flex";
        var veiculoTest = new Carro("gm", "celta", "01/01/2020", 0, "cinza", 15000, true, combustivelEsperado);
        //Act - Agindo
        var combustivelATestar = veiculoTest.GetCombustivel();
        //Assert - 
        Assert.Equal(combustivelEsperado, combustivelATestar);
    }
    [Fact]
    public void TestandoSeCarroCalculaValorCorretamente()
    {
        //Arrange - Preparando
        var valorCalculadoEsperado = 12000;
        var veiculoTest = new Carro("gm", "celta", "01/01/2020", 0, "cinza", 10000, true, "flex");
        //Act - Agindo
        var valorCalculadoATestar = veiculoTest.GetValor();
        //Assert - 
        Assert.Equal(valorCalculadoEsperado, valorCalculadoATestar);
    }
    [Fact]
    public void TestandoSeCarroNaoSalvaValorIncorreto()
    {
        //Arrange - Preparando
        var valorIncorreto = 150;
        //Act e Assert
        var exceptionTest = Assert.Throws<ValidacaoDados>(() => new Carro("gm", "celta", "01/01/2020", 0, "cinza", valorIncorreto, true, "flex"));
        Assert.Equal("valor inválido!", exceptionTest.Message);
    }
    [Fact]
    public void TestandoSeMotoSalvaCilindradaCorretamente()
    {
        //Arrange - Preparando
        var cilindradaEsperada = 250;
        var veiculoTest = new Moto("honda", "twister", "01/01/2020", 0, "azul", 10000, cilindradaEsperada, "injeção eletrônica");
        //Act - Agindo
        var cilindradaATestar = veiculoTest.GetCilindrada();
        //Assert - 
        Assert.Equal(cilindradaEsperada, cilindradaATestar);
    }
    [Fact]
    public void TestandoSeMotoSalvaPartidaCorretamente()
    {
        //Arrange - Preparando
        var partidaEsperada = "injeção eletrônica";
        var veiculoTest = new Moto("honda", "twister", "01/01/2020", 0, "azul", 10000, 250, partidaEsperada);
        //Act - Agindo
        var partidaATestar = veiculoTest.GetPartida();
        //Assert - 
        Assert.Equal(partidaEsperada, partidaATestar);
    }
    [Fact]
    public void TestandoSeMotoCalculaValorCorretamente()
    {
        //Arrange - Preparando
        var valorCalculadoEsperado = 13750;
        var veiculoTest = new Moto("honda", "twister", "01/01/2020", 0, "azul", 10000, 250, "injeção eletrônica");
        //Act - Agindo
        var valorCalculadoATestar = veiculoTest.GetValor();
        //Assert - 
        Assert.Equal(valorCalculadoEsperado, valorCalculadoATestar);
    }
    [Fact]
    public void TestandoSeMotoNaoSalvaValorIncorreto()
    {
        //Arrange - Preparando
        var valorIncorreto = 0; //vou passar em cilindrada pois é la que calcula valor...
        //Act e Assert
        var exceptionTest = Assert.Throws<ValidacaoDados>(() => new Moto("honda", "twister", "01/01/2020", 0, "azul", 10000, valorIncorreto, "injeção eletrônica"));
        Assert.Equal("valor inválido!", exceptionTest.Message);
    }
}