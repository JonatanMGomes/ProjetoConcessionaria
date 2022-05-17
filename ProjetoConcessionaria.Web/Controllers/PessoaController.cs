using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        public static List<PessoaDTO> PessoasDaClasseDTO { get; set; } = new List<PessoaDTO>();

        [HttpGet("Get PessoaDaClasse")]
        public IActionResult GetPessoaDaClasse()
        {
            return Ok(PessoasDaClasseDTO);
        }

        [HttpPost("Set PessoaDaClasse")]
        public IActionResult SetPessoaDaClasse(PessoaDTO pessoaDto)
        {
            var pessoa = new Pessoa(pessoaDto.Nome, pessoaDto.CPF, pessoaDto.DataNascimento.ToString());
            PessoasDaClasseDTO.Add(pessoaDto);
            return Ok(PessoasDaClasseDTO);
        }
    }
}