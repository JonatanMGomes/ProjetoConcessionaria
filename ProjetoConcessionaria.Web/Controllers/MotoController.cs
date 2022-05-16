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
            try
            {
                moto.ValidarAno(moto.GetAno());
                moto.ValidarValor(moto.GetValor());
                MotosDaClasse.Add(moto);
                return Ok(MotosDaClasse);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("Delete MotoDaLista")]
        public IActionResult DeleteMotoDaLista()
        {
            MotosDaClasse.RemoveAt(MotosDaClasse.Count - 1);
            return Ok(MotosDaClasse);
        }

    }
}