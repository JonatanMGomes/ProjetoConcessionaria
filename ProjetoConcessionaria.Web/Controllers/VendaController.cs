using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<VendaDTO> VendasDaClasseDTO { get; set; } = new List<VendaDTO>();
        public ILogger<VendaController> Log { get; set; }
        public VendaController(ILogger<VendaController> log)
        {
            Log = log;
        }

        [HttpGet("Get VendasDaLista")]
        public IActionResult GetVendasDaLista()
        {
            return Ok(VendasDaClasseDTO);
        }

        [HttpPost("Set VendaNaLista")]
        public IActionResult SetVendaNaLista(VendaDTO vendaDto)
        {
            try
            {
                var compradorTeste = new Cliente(vendaDto.CompradorDTO.Nome, vendaDto.CompradorDTO.CPF, vendaDto.CompradorDTO.DataNascimento.ToString(), vendaDto.CompradorDTO.Email, vendaDto.CompradorDTO.Telefone);
                var vendedorTeste = new Funcionario(vendaDto.VendedorDTO.Nome, vendaDto.VendedorDTO.CPF, vendaDto.VendedorDTO.DataNascimento.ToString(), vendaDto.VendedorDTO.Cargo);
                var veiculoTeste = new Veiculo(vendaDto.VeiculoDTO.Marca, vendaDto.VeiculoDTO.Modelo, vendaDto.VeiculoDTO.Ano.ToString(), vendaDto.VeiculoDTO.Quilometragem, vendaDto.VeiculoDTO.Cor, vendaDto.VeiculoDTO.Valor);
                var venda = new Venda(compradorTeste, vendedorTeste, veiculoTeste, vendaDto.FormaPagamento);
                VendasDaClasseDTO.Add(vendaDto);
                return Ok(VendasDaClasseDTO);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("Delete VendaDaLista")]
        public IActionResult DeleteVendaDaLista()
        {
            VendasDaClasseDTO.RemoveAt(VendasDaClasseDTO.Count - 1);
            return Ok(VendasDaClasseDTO);
        }
    }
}