namespace ProjetoConcessionaria.Lib.Models
{
    public class Funcionario : Pessoa
    {
        private string Cargo { get; set; }
        
        public Funcionario(string nome, string cpf, string dataNascimento, string cargo) : base(nome, cpf, dataNascimento)
        {
            SetCargo(cargo);
        }
        public string GetCargo()
        {
            return Cargo;
        }
        public void SetCargo(string cargo)
        {
            Cargo = cargo;
        }
    }
}