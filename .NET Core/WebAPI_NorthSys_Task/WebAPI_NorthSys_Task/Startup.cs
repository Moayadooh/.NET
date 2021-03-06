using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_NorthSys_Task
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
            //services.AddCors();
            var allowOrigns = Configuration.GetSection("AllowOrigins").Value.Split(',');
            services.AddCors(options =>
            {
                options.AddPolicy("origin_policy", builder => {
                    builder.WithOrigins(allowOrigns)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseStatusCodePages(); //return status code when error occur (e.g. Status Code: 404; Not Found)

            //app.UseCors(x => x
            //    .AllowAnyMethod() // "GET", "POST", "PUT", "DELETE"
            //    .AllowAnyHeader() // Content Type
            //    .SetIsOriginAllowed(origin => true) // allow any origin
            //    .AllowCredentials()); // allow credentials
            app.UseCors("origin_policy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
