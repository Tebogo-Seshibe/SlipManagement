using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SlipManagementApi.Database;
using Swashbuckle.AspNetCore.Swagger;

namespace SlipManagementApi
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
            var config = new Configuration(Configuration);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(config);
            services.AddDbContext<SqlContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(config.SqlConnectionString, settings =>
                {
                    settings.UseRowNumberForPaging();
                    settings.MigrationsHistoryTable("_MigrationsHistory");
                });

                optionsBuilder.Options.Freeze();
            });
            services.AddEntityFrameworkSqlServer();
            services.AddSwaggerGen(con =>
            {
                con.SwaggerDoc("v1", new Info
                {
                    Title = "Slip Management V1",
                    Version = "v1",
                    Contact = new Contact
                    {
                        Name = "Tebogo Christopher Seshibe",
                        Email = "tseshibe@retrorabbit.co.za",
                        Url = "https://www.github.com"
                    },
                    Description = "Simple api that connects a db",
                    License = new License
                    {
                        Name = "MIT"
                    }
                });
            });
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(con =>
            {
                con.SwaggerEndpoint("/swagger/v1/swagger.json", "SlipManagement API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
