namespace ProjetoConcessionaria
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        protected string CPF { get; set; }
        protected DateTime DataNascimento { get; set; }
        public Pessoa(string nome, string cpf, string dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetCPF()
        {
            return CPF;
        }
        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento(string dataNascimento)
        {
            var dataNascimentoDesejada = DateTime.Parse(dataNascimento);
            DataNascimento = dataNascimentoDesejada;
        }

    }
}