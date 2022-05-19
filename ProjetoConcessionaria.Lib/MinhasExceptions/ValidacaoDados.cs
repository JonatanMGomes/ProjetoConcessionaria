namespace ProjetoConcessionaria.Lib.MinhasExceptions
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