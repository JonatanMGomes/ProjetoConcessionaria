namespace ProjetoConcessionaria.MinhasExceptions
{
    public class ValidacaoDados : Exception
    {
        public ValidacaoDados()
        {

        }
        public ValidacaoDados(string msg) : base(msg)
        {

        }
    }
}