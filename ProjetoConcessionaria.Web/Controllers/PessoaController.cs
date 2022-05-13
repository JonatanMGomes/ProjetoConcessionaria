using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        public static List<Pessoa> PessoasDaClasse { get; set; } = new List<Pessoa>();

        [HttpPost("Set PessoaDaClasse")]
        public IActionResult SetPessoaDaClasse(Pessoa pessoa)
        {
            PessoasDaClasse.Add(pessoa) ;
            return Ok(PessoasDaClasse);
        }
        [HttpGet("Get PessoaDaClasse")]
        public IActionResult GetPessoaDaClasse()
        {
            return Ok(PessoasDaClasse);
        }
    }
}