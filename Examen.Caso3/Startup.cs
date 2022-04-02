using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Examen.Caso3.Application.Contracts;
using Examen.Caso3.Application.Implementations;
using Examen.Caso3.Application.MapperProfiles;
using Examen.Caso3.Domain;
using Examen.Caso3.Domain.Aggregates.ClienteAgg;
using Examen.Caso3.Infrastructure.Data.Context;
using Examen.Caso3.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Examen.Caso3
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
            services.AddControllersWithViews();

            ConfigureInjections(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void ConfigureInjections(IServiceCollection services)
        {
            #region Inject settings

            services.AddAutoMapper(typeof(AutoMapperProfile));

            #endregion

            #region Inject dbcontext

            var sqlConnectionString = Configuration.GetConnectionString("AppDbContext");
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(sqlConnectionString));

            #endregion

            #region Inject App Service

            services.AddTransient<IClienteAppService, ClienteAppService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion

            #region Inject Repositories

            services.AddTransient<IClienteRepository, ClienteRepository>();

            #endregion
        }
    }
}
