using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Contentstack.AspNetCore;
using contentstack_dotnet_starter_app.Data;
using Contentstack.Core;
using System.Linq;
using Microsoft.Extensions.Primitives;

namespace contentstack_dotnet_starter_app
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string _policyName = "CorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            services.AddContentstack(Configuration);
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<HeaderService>();
            services.AddSingleton<PageService>();
            services.AddSingleton<FooterService>();
            services.AddSingleton<BlogService>();
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
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseRouting();
            app.Use(async (context, next) =>
            {
                var contentstackClient = app.ApplicationServices.GetService<ContentstackClient>();
                var dict = context.Request.Query.Keys.Cast<string>().ToDictionary(k => k, v =>
                {
                    StringValues hash;
                    context.Request.Query.TryGetValue(v, out hash);
                    return hash.ToString();
                });
                contentstackClient.LivePreviewQuery(dict);
                await next.Invoke();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
