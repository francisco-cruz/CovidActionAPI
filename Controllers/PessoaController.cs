using CovidActionAPI.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CovidActionAPI.Controllers
{
  [Microsoft.AspNetCore.Components.Route("[controller]")]
  public class PessoaController
  {
    private IPessoaService _pessoaService;
      public PessoaController(IPessoaService pessoaService)
    {
       _pessoaService = pessoaService;
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
      var response = _pessoaService.Listar();
      return new ObjectResult(response) { StatusCode = 200 };
    }
    [HttpGet("obter")]
    public IActionResult Obter([FromQuery] int Id)
    {
      var response = _pessoaService.Obter(Id);
      return new ObjectResult(response) { StatusCode = 200 };
    }

  }
}
