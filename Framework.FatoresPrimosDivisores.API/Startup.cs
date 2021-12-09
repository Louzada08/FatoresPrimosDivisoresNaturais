using Challenge.FatoresPrimosDivisores.API.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace Challenge.FatoresPrimosDivisores.API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      services.AddScoped<IFatoresPrimosDivisoresRepository, FatoresPrimosDivisoresRepository>();

      services.AddApiVersioning(option => option.ReportApiVersions = true);

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo()
        {
          Title = "Decomposição de Um Número - API com ASP.NET Core 3.1",
          Contact = new OpenApiContact() { Name = "Anderson Luiz Louzada", Email = "valuz.anderson.to@gmail.com" },
          Version = "v1",
          License = new OpenApiLicense() { Name = "Technical Challenge", Url = new Uri("https://technicalchallenge.com") }

        });
      });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
      });

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
