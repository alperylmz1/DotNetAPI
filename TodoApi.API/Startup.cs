﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TodoApi.API.Controllers;
using TodoApi.Business.Abstract;
using TodoApi.Business.Concrete;
using TodoApi.DataAccess;
using TodoApi.DataAccess.Abstract;
using TodoApi.DataAccess.Concrete;

namespace TodoApi.API
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

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserController>();
            services.AddScoped<TodoDbContext>();

            /*
            services.AddScoped<IPasswordService, PasswordManager>();
            services.AddScoped<IPasswordRepository, PasswordRepository>();
            services.AddScoped<PasswordController>();
            */
            

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                            .WithOrigins("*")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials()
                        ;
                    });

            });

            /*
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            //.AllowCredentials()
                        ;
                    });

            });
            */

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                options => options.WithOrigins("*")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials()
            );


            app.UseMvc();
        }
    }
}
