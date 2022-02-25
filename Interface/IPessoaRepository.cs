using CovidActionAPI.Entity;

namespace CovidActionAPI.Interface
{
  public interface IPessoaRepository
  {
    List<Pessoa> Listar();
    Pessoa Obter(int Id);
  }
}
