using LinqDemo.Models;
using LinqDemo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LinqDemo", Version = "v1" });
            });

            //Transient lifetime services are created each time when they are requested.
            //It means the Transient lifetime service creates a new instance for every controller/service as well as for every request.
            services.AddTransient<IStudentRepository, DemoTestRepository>();
            services.AddTransient<StudentService, StudentService>();

            //Scoped lifetime services are created once per request.
            //It means the Scoped objects are the same within a request, but different across different requests.
            //services.AddScoped<IStudentRepository, DemoTestRepository>();
            //services.AddScoped<StudentService, StudentService>();

            //Singleton lifetime services are created only the first time when they are requested.
            //It means the Singleton lifetime service creates the instance for the first request then the same is available throughout the application 
            //services.AddSingleton<IStudentRepository, DemoTestRepository>();
            //services.AddSingleton<StudentService, StudentService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LinqDemo v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
