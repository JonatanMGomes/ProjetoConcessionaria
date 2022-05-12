using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcessionariaController : ControllerBase
    {
        public Pessoa PessoaDaClasse { get; set; }

        [HttpGet("Get PessoaDaClasse")]
        public IActionResult SetPessoaDaClasse(Pessoa pessoa)
        {
            PessoaDaClasse = pessoa;
            return Ok(PessoaDaClasse);
        }
        [HttpGet("Get PessoaDaClasse")]
        public IActionResult GetPessoaDaClasse()
        {
            return Ok(PessoaDaClasse);
        }
    }
}