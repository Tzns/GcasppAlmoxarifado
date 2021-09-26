using Almoxarifado.Data;
using Almoxarifado.Models;
using Almoxarifado.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado
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
            string connectionString = Configuration.GetConnectionString("Default");
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IGProdutoUnidadeRepository, GProdutoUnidadeRepository>();
            services.AddScoped<IGFornecedorRepository, GFornecedorRepository>();
            services.AddScoped<IGProdutoRepository, GProdutoRepository>();
            services.AddScoped<IGEntradaRepository, GEntradaRepository>();
            services.AddScoped<IGEntradaItemRepository, GEntradaItemRepository>();
            services.AddScoped<IGEstoqueRepository, GEstoqueRepository>();
            services.AddScoped<IGSaidaItemRepository, GSaidaItemRepository>();
            services.AddScoped<IGSaidaRepository, GSaidaRepository>();
            services.AddRazorPages();    
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
