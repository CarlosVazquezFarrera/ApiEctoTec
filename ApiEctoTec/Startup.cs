using EctoTec.Infrastrucure.Config;
using EctoTec.Infrastrucure.Data;
using EctoTec.Infrastrucure.Repositories;
using EctoTect.Core.Interfaces.Repository;
using EctoTect.Core.Interfaces.Service;
using EctoTect.Core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ApiEctoTec
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Configuracion.CurrentValues.Mail  = Configuration.GetSection("MySettings").GetSection("Email").Value;
            Configuracion.CurrentValues.PasswordCorreo  = Configuration.GetSection("MySettings").GetSection("PasswordEmail").Value;
            Configuracion.CurrentValues.Servidor  = Configuration.GetSection("MySettings").GetSection("Servidor").Value;
            Configuracion.CurrentValues.Puerto  = Convert.ToInt32(Configuration.GetSection("MySettings").GetSection("SMTPPort").Value);
        }

        public IConfiguration Configuration { get; }



        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext <EctoTecContext> (options =>
                options.UseSqlServer(Configuration.GetConnectionString("EctoTec"))
            );
            //Registro de interfaces            

            services.AddTransient<IDireccionRepository, DireccionRepository>();
            services.AddTransient<IDireccionesService, DireccionService>();

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            
            services.AddTransient<IMailRepository, MailRepository>();
            services.AddTransient<IMailService, MailService>();


            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Cors
            services.AddCors(o => o.AddPolicy(MyAllowSpecificOrigins, builder =>
            {
                builder.WithOrigins("http://localhost:4200")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            }));

            //Formato Json
            services.AddMvc().AddJsonOptions(options => {
                options.JsonSerializerOptions.IgnoreNullValues = true;
            });
            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
