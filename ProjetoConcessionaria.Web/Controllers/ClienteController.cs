using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<ClienteDTO> ClientesDaClasseDTO { get; set; } = new List<ClienteDTO>();

        [HttpGet("Get ClientesDaLista")]
        public IActionResult GetClientesDaLista()
        {
            return Ok(ClientesDaClasseDTO);
        }

        [HttpPost("Set ClienteNaLista")]
        public IActionResult SetClienteNaLista(ClienteDTO clienteDto)
        {
            try
            {
                var cliente = new Cliente(clienteDto.Nome, clienteDto.CPF, clienteDto.DataNascimento.ToString(), clienteDto.Email, clienteDto.Telefone);
                ClientesDaClasseDTO.Add(clienteDto);
                return Ok(ClientesDaClasseDTO);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete ClienteDaLista")]
        public IActionResult DeleteClienteDaLista()
        {
            ClientesDaClasseDTO.RemoveAt(ClientesDaClasseDTO.Count - 1);
            return Ok(ClientesDaClasseDTO);
        }
    }
}