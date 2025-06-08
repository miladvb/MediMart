
using KRB.Application.Identity;
using KRB.Application.Senders;
using KRB.Application.Services.Implementations;
using KRB.Application.Services.Interfaces;
using KRB.Data.Context;
using KRB.Data.Repositories;
using KRB.Domain.Entities;
using KRB.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KRB.IOC.Dependencies;


public static class DependencyContainer
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {

        var allowedOrigins = configuration.GetSection("Cors:AllowedOrigins").Get<string[]>();

        services.AddCors(opt =>
        {
            opt.AddPolicy("ReactivitiesPloicy", policy =>
            {
                policy.AllowAnyMethod()
                      .AllowAnyHeader()
                      .WithOrigins(allowedOrigins);
            });
        });



        #region  repository

        services.AddScoped<IMessageSender, MessageSender>();
        services.AddScoped<IActivityRepository, ActivityRepository>();

        #endregion

        #region Services

        services.AddScoped<IActivityService, ActivityService>();

        #endregion


        #region dbcontext

        services.AddDbContext<KRBContext>(option =>
        {
            option.UseSqlServer(configuration.GetConnectionString("KRBConnectionString"));
        });

        services.AddIdentity<User, Role>(opt =>
                {
                    opt.User.AllowedUserNameCharacters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890!@.";
                    opt.User.RequireUniqueEmail = true;

                    opt.Password.RequireLowercase = true;
                    opt.Password.RequireUppercase = true;
                    opt.Password.RequiredLength = 8;
                    opt.Password.RequireDigit = true;
                    opt.Password.RequireNonAlphanumeric = true;

                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    opt.Lockout.MaxFailedAccessAttempts = 5;



                })
                .AddEntityFrameworkStores<KRBContext>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<PersianErrorDescriber>();

        #endregion

        #region conteroller

        #endregion
    }
}
