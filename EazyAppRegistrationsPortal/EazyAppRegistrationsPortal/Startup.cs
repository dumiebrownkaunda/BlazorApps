using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EazyAppRegistrationsPortal.Data;
using EazyAppRegistrationsPortal.Models;
using EazyAppRegistrationsPortal.Repository;
using Microsoft.EntityFrameworkCore;
using EazyAppRegistrationsPortal.Utils;

namespace EazyAppRegistrationsPortal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<ISessionBasket, SessionBasket>();
            services.AddSingleton<ISessionChecker, SessionChecker>();
            services.AddSingleton<ISessionBridgeVmManager, SessionBridgeVmManager>();

            services.AddTransient<CustomerService>();
            services.AddTransient<SessionBridgeService>();
            services.AddTransient<IConfigReader, ConfigReader>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IUserActionsRepository, UserActionsRepository>();
            services.AddTransient<ISessionBridgeRepository, SessionBridgeRepository>();


            services.AddDbContext<SmartAppContext>(o =>
                o.UseSqlServer(Configuration.GetConnectionString("Customers")), ServiceLifetime.Transient);
            
            services.AddAutoMapper(typeof(Startup));
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}