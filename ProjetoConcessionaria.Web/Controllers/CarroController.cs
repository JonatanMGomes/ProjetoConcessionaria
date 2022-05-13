using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Carro> CarrosDaClasse { get; set; } = new List<Carro>();

        [HttpGet("Get CarrosDaLista")]
        public IActionResult GetCarrosDaLista()
        {
            return Ok(CarrosDaClasse);
        }

        [HttpPost("Set CarroNaLista")]
        public IActionResult SetCarroNaLista(Carro carro)
        {
            CarrosDaClasse.Add(carro);
            return Ok(CarrosDaClasse);
        }

        [HttpDelete("Delete CarroDaLista")]
        public IActionResult DeleteCarroDaLista()
        {
            CarrosDaClasse.RemoveAt(CarrosDaClasse.Count - 1);
            return Ok(CarrosDaClasse);
        }

    }
}