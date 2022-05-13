using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<Funcionario> FuncionariosDaClasse { get; set; } = new List<Funcionario>();

        [HttpGet("Get FuncionariosDaLista")]
        public IActionResult GetFuncionariosDaLista()
        {
            return Ok(FuncionariosDaClasse);
        }

        [HttpPost("Set FuncionarioNaLista")]
        public IActionResult SetFuncionarioNaLista(Funcionario funcionario)
        {
            FuncionariosDaClasse.Add(funcionario);
            return Ok(FuncionariosDaClasse);
        }

        [HttpDelete("Delete FuncionarioDaLista")]
        public IActionResult DeleteFuncionarioDaLista()
        {
            FuncionariosDaClasse.RemoveAt(FuncionariosDaClasse.Count - 1);
            return Ok(FuncionariosDaClasse);
        }
    }
}