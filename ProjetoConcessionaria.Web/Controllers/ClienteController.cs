using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<Cliente> ClientesDaClasse { get; set; } = new List<Cliente>();

        [HttpGet("Get ClientesDaLista")]
        public IActionResult GetClientesDaLista()
        {
            return Ok(ClientesDaClasse);
        }

        [HttpPost("Set ClienteNaLista")]
        public IActionResult SetClienteNaLista(Cliente cliente)
        {
            ClientesDaClasse.Add(cliente);
            return Ok(ClientesDaClasse);
        }

        [HttpDelete("Delete ClienteDaLista")]
        public IActionResult DeleteClienteDaLista()
        {
            ClientesDaClasse.RemoveAt(ClientesDaClasse.Count - 1);
            return Ok(ClientesDaClasse);
        }
    }
}