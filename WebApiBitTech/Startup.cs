using WebApiBitTech.Application.Services.Garantias;
using WebApiBitTech.Application.Services.Produtos;
using WebApiBitTech.Application.Services.Vendas;
using WebApiBitTech.Infrastructure.Repositories.Garantias;
using WebApiBitTech.Infrastructure.Repositories.Produtos;
using WebApiBitTech.Infrastructure.Repositories.Vendas;

namespace WebApiBitTech
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

            //Services
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IGarantiaService, GarantiaService>();
            services.AddScoped<IVendaService, VendaService>();

            //Repositories
            services.AddSingleton<IProdutoRepository, ProdutoRepository>();
            services.AddSingleton<IGarantiaRepository, GarantiaRepository>();
            services.AddSingleton<IVendaRepository, VendaRepository>();

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
