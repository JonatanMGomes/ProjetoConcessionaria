using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<FuncionarioDTO> FuncionariosDaClasseDTO { get; set; } = new List<FuncionarioDTO>();

        [HttpGet("Get FuncionariosDaLista")]
        public IActionResult GetFuncionariosDaLista()
        {
            return Ok(FuncionariosDaClasseDTO);
        }

        [HttpPost("Set FuncionarioNaLista")]
        public IActionResult SetFuncionarioNaLista(FuncionarioDTO funcionarioDto)
        {
            var funcionario = new Funcionario(funcionarioDto.Nome, funcionarioDto.CPF, funcionarioDto.DataNascimento.ToString(), funcionarioDto.Cargo);
            FuncionariosDaClasseDTO.Add(funcionarioDto);
            return Ok(FuncionariosDaClasseDTO);
        }

        [HttpDelete("Delete FuncionarioDaLista")]
        public IActionResult DeleteFuncionarioDaLista()
        {
            FuncionariosDaClasseDTO.RemoveAt(FuncionariosDaClasseDTO.Count - 1);
            return Ok(FuncionariosDaClasseDTO);
        }
    }
}