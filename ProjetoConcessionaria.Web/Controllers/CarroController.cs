using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<CarroDTO> CarrosDaClasseDTO { get; set; } = new List<CarroDTO>();

        [HttpGet("Get CarrosDaLista")]
        public IActionResult GetCarrosDaLista()
        {
            return Ok(CarrosDaClasseDTO);
        }

        [HttpPost("Set CarroNaLista")]
        public IActionResult SetCarroNaLista(CarroDTO carroDto)
        {
            try
            {
                var carro = new Carro(carroDto.Marca, carroDto.Modelo, carroDto.Ano.ToString(), carroDto.Quilometragem, carroDto.Cor, carroDto.Valor,carroDto.TransmissaoAutomatica, carroDto.Combustivel);
                CarrosDaClasseDTO.Add(carroDto);
                return Ok(CarrosDaClasseDTO);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete CarroDaLista")]
        public IActionResult DeleteCarroDaLista()
        {
            CarrosDaClasseDTO.RemoveAt(CarrosDaClasseDTO.Count - 1);
            return Ok(CarrosDaClasseDTO);
        }

    }
}