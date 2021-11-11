using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Net;
using TesteTecnicoConfitec.Domain.Core.Commands;
using TesteTecnicoConfitec.Domain.Core.Exceptions;
using TesteTecnicoConfitec.Domain.Usuarios.CommandHandlers;
using TesteTecnicoConfitec.Domain.Usuarios.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.Repositories;
using TesteTecnicoConfitec.Infrastructure;
using TesteTecnicoConfitec.Infrastructure.AutoMapper;
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

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

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

            app.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var exceptionHandlerFeatures = context.Features.Get<IExceptionHandlerFeature>();

                    if (exceptionHandlerFeatures != null)
                    {
                        var exception = exceptionHandlerFeatures.Error;
                        var message = exception.Message;

                        if (exception is DomainException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                        }
                        else
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        }

                        context.Response.ContentType = "application/json";

                        var json = new
                        {
                            statusCode = context.Response.StatusCode,
                            message = message
                        };

                        await context.Response.WriteAsync(JsonConvert.SerializeObject(json));
                    }
                });
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(option => option.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
