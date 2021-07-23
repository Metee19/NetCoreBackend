using Business.Abstract;
using Business.Concrete;
<<<<<<< HEAD
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
=======
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD
using Microsoft.IdentityModel.Tokens;
=======
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
        { //Autofac,Ninject,CastleWindsor,StructureMap,LightInject,DryInject -->IoC Contaniner
            services.AddControllers();
<<<<<<< HEAD

            //services.AddSingleton<IProductService,ProductManager>();
            //services.AddSingleton<IProductDal, EfProductDal>();
            services.AddCors();
            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
            services.AddDependencyResolvers(new ICoreModule[]
            {
                new CoreModule()
            });
=======
            services.AddSingleton<IProductService,ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
<<<<<<< HEAD
            app.ConfigureCustomExceptionMiddleware();

            app.UseCors(builder=>builder.WithOrigins("http://localhost:4200").AllowAnyHeader());
=======
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c

            app.UseHttpsRedirection();

            app.UseRouting();

<<<<<<< HEAD
            app.UseAuthentication();

=======
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
