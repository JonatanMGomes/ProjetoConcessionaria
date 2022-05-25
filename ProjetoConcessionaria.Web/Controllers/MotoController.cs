using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<MotoDTO> MotosDaClasseDTO { get; set; } = new List<MotoDTO>();
        public ILogger<MotoController> Log { get; set; }
        public MotoController(ILogger<MotoController> log)
        {
            Log = log;
        }

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
                var moto = new Moto(motoDto.Marca, motoDto.Modelo, motoDto.Ano.ToString(), motoDto.Quilometragem, motoDto.Cor, motoDto.Valor, motoDto.Cilindrada, motoDto.Partida);
                MotosDaClasseDTO.Add(motoDto);
                return Ok(MotosDaClasseDTO);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
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