using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<Moto> MotosDaClasse { get; set; } = new List<Moto>();

        [HttpGet("Get MotosDaLista")]
        public IActionResult GetMotosDaLista()
        {
            return Ok(MotosDaClasse);
        }

        [HttpPost("Set MotoNaLista")]
        public IActionResult SetMotoNaLista(Moto moto)
        {
            MotosDaClasse.Add(moto);
            return Ok(MotosDaClasse);
        }

        [HttpDelete("Delete MotoDaLista")]
        public IActionResult DeleteMotoDaLista()
        {
            MotosDaClasse.RemoveAt(MotosDaClasse.Count - 1);
            return Ok(MotosDaClasse);
        }

    }
}