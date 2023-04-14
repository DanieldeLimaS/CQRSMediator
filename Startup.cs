using System.Reflection;
using System;
using CQRSMediator.Domain.Commands.Handlers;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace CQRSMediator
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext...
            services.AddControllers();
            services.AddMediatR(config=>config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
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