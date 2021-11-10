using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TesteTecnicoConfitec.Domain.Core.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.CommandHandlers;
using TesteTecnicoConfitec.Domain.Usuarios.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.Repositories;
using TesteTecnicoConfitec.Infrastructure;
using TesteTecnicoConfitec.Infrastructure.CQRS;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core.EntityFramework;
using TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.QueryHandlers;
using TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.Repositories;
using TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers;

namespace TesteTecnicoConfitec
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors();

            services.AddDbContext<Context>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICommandRouter, CommandRouter>();

            services.AddScoped<IUsuarioQueryHandler, UsuarioQueryHandler>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<ICommandHandler<RegistrarUsuario>, UsuarioCommandHandler>();
            services.AddScoped<ICommandHandler<AlterarUsuario>, UsuarioCommandHandler>();
            services.AddScoped<ICommandHandler<RemoverUsuario>, UsuarioCommandHandler>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(option => option.AllowAnyOrigin());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
