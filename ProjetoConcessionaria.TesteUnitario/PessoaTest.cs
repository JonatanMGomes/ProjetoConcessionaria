using Xunit;

namespace ProjetoConcessionaria.TesteUnitario
{
    public class PessoaTest
    {
        [Fact]
        public void TestandoSePessoaSalvaNomeCorretamente()
        {
            //Arrange - Preparando
            var nomeEsperado = "Jonatan";
            var pessoaTest = new Pessoa(nomeEsperado, "11122233344", "11/07/1994");
            //Act - Agindo
            var nomeATestar = pessoaTest.GetNome();
            //Assert - 
            Assert.Equal(nomeEsperado, nomeATestar);
        }
        [Fact]
        public void TestandoSePessoaSalvaCPFCorretamente()
        {
            //Arrange - Preparando
            var cpfEsperado = "11122233344";
            var pessoaTest = new Pessoa("Jonatan", cpfEsperado, "11/07/1994");
            //Act - Agindo
            var cpfATestar = pessoaTest.GetCPF();
            //Assert - 
            Assert.Equal(cpfEsperado, cpfATestar);
        }
        [Fact]
        public void TestandoSePessoaSalvaDataNascimentoCorretamente()
        {
            //Arrange - Preparando
            var dataNascimentoEsperada = "11/11/1994 00:00:00";
            var pessoaTest = new Pessoa("Jonatan", "11122233344", dataNascimentoEsperada);
            //Act - Agindo
            var dataNascimentoATestar = pessoaTest.GetDataNascimento().ToString();
            //Assert - 
            Assert.Equal(dataNascimentoEsperada, dataNascimentoATestar);
        }
        [Fact]
        public void TestandoSeClienteSalvaEmailCorretamente()
        {
            //Arrange - Preparando
            var emailEsperado = "email@email.com";
            var pessoaTest = new Cliente("Jonatan", "11122233344", "11/07/1994", emailEsperado, "999887766");
            //Act - Agindo
            var emailATestar = pessoaTest.GetEmail();
            //Assert - 
            Assert.Equal(emailEsperado, emailATestar);
        }
        [Fact]
        public void TestandoSeClienteSalvaTelefoneCorretamente()
        {
            //Arrange - Preparando
            var telefoneEsperado = "999887766";
            var pessoaTest = new Cliente("Jonatan", "11122233344", "11/07/1994", "email@email.com", telefoneEsperado);
            //Act - Agindo
            var telefoneATestar = pessoaTest.GetTelefone();
            //Assert - 
            Assert.Equal(telefoneEsperado, telefoneATestar);
        }
        [Fact]
        public void TestandoSeFuncionarioSalvaEmailCorretamente()
        {
            //Arrange - Preparando
            var cargoEsperado = "gerente";
            var pessoaTest = new Funcionario("Jonatan", "11122233344", "11/07/1994", cargoEsperado);
            //Act - Agindo
            var caroATestar = pessoaTest.GetCargo();
            //Assert - 
            Assert.Equal(cargoEsperado, caroATestar);
        }
    }
}