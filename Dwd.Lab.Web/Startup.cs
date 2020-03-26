using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;
using Dwd.Lab.Repositorio.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dwd.Lab.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                });
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

           
            services.AddDbContext<LabDataContext>(option =>
                                                    option.UseLazyLoadingProxies()
                                                    .UseSqlServer(Configuration.GetConnectionString("DwdLab")));

            //Todo c�digo que tiver no construtor a interface IXRepositorio,
            //automaticamente receber� uma inst�ncia de XRepositorio,
            //conforme abaixo (inst�ncia �nica do runtime):
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IFormaPagamentoRepositorio, FormaPagamentoRepositorio>();
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();            
            services.AddScoped<IImagem, Imagem>();
            services.AddScoped<ICategoriaProdutoRepositorio, CategoriaProdutoRepositorio>();
            services.AddScoped<IEstadoRepositorio, EstadoRepositorio>();
            services.AddScoped<ICidadeRepositorio, CidadeRepositorio>();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(MyAllowSpecificOrigins);
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    //spa.UseAngularCliServer(npmScript: "start");

                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                }
            });
        }
    }
}
