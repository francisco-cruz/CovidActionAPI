using CovidActionAPI.Entity;
using CovidActionAPI.Interface;
using CovidActionAPI.Model;

namespace CovidActionAPI.Service
{
  public class PessoaService : IPessoaService
  {
    private IPessoaRepository _pessoaRepository;

    public PessoaService(IPessoaRepository pessoaRepository)
    {
      _pessoaRepository = pessoaRepository;
    }

    public List<PessoaResponse> Listar()
    {
      var entity = _pessoaRepository.Listar();

      List<PessoaResponse> response = new();

      entity.ForEach(p => {
        response.Add(new PessoaResponse()
        {
          Id = p.Id,
          Nome = p.Nome,
          CPF = p.CPF,
        });
      });

      return response;
    }
    public PessoaResponse Obter(int Id)
    {
      var entity = _pessoaRepository.Obter();

      return new PessoaResponse()
      {
        Id = entity.Id,
        Nome = entity.Nome,
        CPF = entity.CPF
      };
    }
  }
}
