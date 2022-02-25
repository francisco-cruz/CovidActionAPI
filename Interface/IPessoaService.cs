using CovidActionAPI.Model;

namespace CovidActionAPI.Interface
{
  public interface IPessoaService
  {
    List<PessoaResponse> Listar();
    PessoaResponse Obter(int Id);
  }
}
