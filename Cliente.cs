namespace ProjetoConcessionaria
{
    public class Cliente : Pessoa
    {
        private string Email { get; set; }
        private string Telefone { get; set; }
        public Cliente(string nome, string cpf, string dataNascimento, string email, string telefone) : base(nome, cpf, dataNascimento)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}