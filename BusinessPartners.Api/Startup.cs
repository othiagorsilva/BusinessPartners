using BusinessPartners.Api.Services;
using BusinessPartners.Domain.Repositories;
using BusinessPartners.Domain.Services;
using BusinessPartners.InfraData.DataContext;
using BusinessPartners.InfraData.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BusinessPartners.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(op => op.EnableEndpointRouting = false);

            services.AddTransient<BusinessPartnersContext, BusinessPartnersContext>();
            services.AddTransient<IPartnerRepository, PartnerRepository>();
            services.AddTransient<IPartnerService, PartnerService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Business Partners API");
                });
            });
        }
    }
}