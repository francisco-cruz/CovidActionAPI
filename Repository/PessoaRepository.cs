using CovidActionAPI.Entity;
using System.Data.SqlClient;
using Dapper;
using CovidActionAPI.Interface;

namespace CovidActionAPI.Repository
{
  public class PessoaRepository: IPessoaRepository
  {
    public string _connectionString = "Server=DESKTOP-CVI6NM7\\SQLEXPRESS;Database=CovidAction;Trusted_Connection=True;";
    public List<Pessoa> Listar()
    {
      string query = @"SELECT [Id]
                     ,[Nome]
                     ,[CPF]
                     FROM[dbo].[Pessoa]";

      SqlConnection conn = new SqlConnection(_connectionString);
      conn.Open();
      return conn.Query<Pessoa>(query).ToList();
    }
    public Pessoa Obter(int Id)
    {
      string query = @"SELECT [Id]
                     ,[Nome]
                     ,[CPF]
                     FROM[dbo].[Pessoa],
                     WHERE [Id] = @Id";

      SqlConnection conn = new SqlConnection(_connectionString);
      conn.Open();
      return conn.QueryFirstOrDefault<Pessoa>(query, new { Id });
    }


  }
}
