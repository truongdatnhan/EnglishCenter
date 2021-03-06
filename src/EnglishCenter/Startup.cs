using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EnglishCenter
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
            services.AddDbContextPool<CenterContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EnglishCenterDB")));

            //EF
            services.AddScoped(typeof(IEFRepository<>), typeof(EFRepository<>));


            //ThiSInh
            services.AddScoped<IThiSinhRepository, ThiSinhRepository>();

            //SBD
            services.AddScoped<ISoBaoDanhRepository, SoBaoDanhRepository>();

            //ThamGiaDuThi
            services.AddScoped<IThamGiaDuThiRepository, ThamGiaDuThiRepository>();

            //KhoaThi
            services.AddScoped<IKhoaThiRepository, KhoaThiRepository>();

            //PhongThi
            services.AddScoped<IPhongThiRepository, PhongThiRepository>();
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
    }
}
