using CovidActionAPI.Interface;
using CovidActionAPI.Repository;

namespace CovidActionAPI.Service
{
  public class Startup
  {
    public Startup (IConfiguration configuration)
    {
      Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    // Esse metodo pega a chamada de iniciação. Use esse metodo para adicionar serviços para o container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddTransient<IPessoaRepository, PessoaRepository>();
      services.AddTransient<IPessoaService, PessoaService>();
    }
    // Esse metodo pega a chamada de iniciação. Use esse metodo para configurar o HTTP request piperline
    public void configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseDeveloperExceptionPage();

      app.UseRouting();

      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
