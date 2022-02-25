namespace CovidActionAPI.Entity
{
  public class Aplicacao
  {
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public int PessoaId { get; set; }
    public int FonecedorId { get; set; }

  }
}
