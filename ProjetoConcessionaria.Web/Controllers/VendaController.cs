using Microsoft.AspNetCore.Mvc;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<Venda> VendasDaClasse { get; set; } = new List<Venda>();

        [HttpGet("Get VendasDaLista")]
        public IActionResult GetVendasDaLista()
        {
            return Ok(VendasDaClasse);
        }

        [HttpPost("Set VendaNaLista")]
        public IActionResult SetVendaNaLista(Venda venda)
        {
            VendasDaClasse.Add(venda);
            return Ok(VendasDaClasse);
        }

        [HttpDelete("Delete VendaDaLista")]
        public IActionResult DeleteVendaDaLista()
        {
            VendasDaClasse.RemoveAt(VendasDaClasse.Count - 1);
            return Ok(VendasDaClasse);
        }
    }
}