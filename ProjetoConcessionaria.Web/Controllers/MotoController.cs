using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<MotoDTO> MotosDaClasseDTO { get; set; } = new List<MotoDTO>();

        [HttpGet("Get MotosDaLista")]
        public IActionResult GetMotosDaLista()
        {
            return Ok(MotosDaClasseDTO);
        }

        [HttpPost("Set MotoNaLista")]
        public IActionResult SetMotoNaLista(MotoDTO motoDto)
        {
            try
            {
                var moto = new Moto(motoDto.Marca, motoDto.Modelo, motoDto.Ano.ToString(), motoDto.Kilometragem, motoDto.Cor, motoDto.Valor, motoDto.Cilindrada, motoDto.Partida);
                MotosDaClasseDTO.Add(motoDto);
                return Ok(MotosDaClasseDTO);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("Delete MotoDaLista")]
        public IActionResult DeleteMotoDaLista()
        {
            MotosDaClasseDTO.RemoveAt(MotosDaClasseDTO.Count - 1);
            return Ok(MotosDaClasseDTO);
        }

    }
}