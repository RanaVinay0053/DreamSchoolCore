using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace DreamSchool
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("JWTSetting").GetSection("Key").Value);
            DateTime final = DateTime.Now.AddHours(Convert.ToDouble(2));
            TimeSpan duration = final.Subtract(DateTime.Now);
            services.AddAuthentication(
                //CookieAuthenticationDefaults.AuthenticationScheme
                options =>
                {
                    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                }
                ).AddCookie(options =>
                {
                    options.ClaimsIssuer = "";
                    options.ExpireTimeSpan = duration;
                    options.LoginPath = "/Auth/Login";
                    options.Cookie.Domain = this.Configuration["Domain"];
                    options.Cookie.Name = "AuthCookie";
                    options.Cookie.SameSite = SameSiteMode.Strict;
                    options.Cookie.HttpOnly = true;
                    //options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.None;
                }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = true,
                        ValidIssuer = Configuration.GetSection("JWTSetting").GetSection("Issuer").Value,// Configuration["Jwt:Issuer"],
                        ValidateAudience = false,
                        ValidateLifetime = false
                    };
                });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddSingleton<IFileProvider>(
            new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(x => x
           .AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            app.UseExceptionHandler(
               options =>
               {
                   options.Run(
                   async context =>
                   {
                       var ex = context.Features.Get<IExceptionHandlerFeature>();
                       if (ex != null)
                       {
                           var err = $"<h1>Error: {ex.Error.Message}</h1>{ex.Error.StackTrace }";
                           if (!Directory.Exists(Path.Combine(env.ContentRootPath, $"Logs")))
                           {
                               Directory.CreateDirectory(Path.Combine(env.ContentRootPath, $"Logs"));
                           }
                           StreamWriter sw = new StreamWriter(Path.Combine(env.ContentRootPath, $"Logs/{DateTimeOffset.Now.ToString("yyyyMMMdd")}.txt"), true);
                           sw.WriteLine("---------------------" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm ss tt") + "---------------------");
                           sw.WriteLine("[Log Type]: - System Exception");
                           sw.WriteLine("=================================================================");
                           sw.WriteLine(ex.Error.Message.ToString());
                           sw.WriteLine(ex.Error.StackTrace.ToString());
                           sw.WriteLine(ex.Error.Source.ToString());
                           sw.WriteLine("=================================================================");
                           sw.WriteLine();
                           sw.Flush();
                           sw.Close();
                           context.Response.StatusCode = 200;
                           context.Response.ContentType = "application/json";
                           var result = JsonConvert.SerializeObject(new ResponseModel
                           {
                               response = 0,
                               data = null,
                               sys_message = "INTERNAL APPLICATION ERROR"
                           });
                           await context.Response.WriteAsync(result);
                       }
                   });
               }
           );
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
    public class ResponseModel
    {
        public Int16 response { get; set; }
        public string sys_message { get; set; }
        public object data { get; set; }
    }
}
