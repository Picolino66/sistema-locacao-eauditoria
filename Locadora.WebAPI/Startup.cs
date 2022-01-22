using Locadora.WebAPI.Data.Interfaces;
using Locadora.WebAPI.Data.Repositories;
using Locadora.WebAPI.Data;

using Microsoft.EntityFrameworkCore;

namespace Locadora.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }
    
        public void ConfigurationServices(IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(5, 7));
            services.AddDbContext<SmartContext>(
                context => context.UseMySql(Configuration.GetConnectionString("MySqlConnection"),serverVersion)
            );

            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ILocacaoRepository, LocacaoRepository>();

            services.AddControllers()
                    .AddNewtonsoftJson(
                        opt => opt.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}