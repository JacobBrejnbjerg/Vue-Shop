﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web.Areas.Identity.Data;
using Web.Models;

[assembly: HostingStartup(typeof(Web.Areas.Identity.IdentityHostingStartup))]
namespace Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebIdentityContextConnection")));

                services.AddDefaultIdentity<WebIdentityUser>()
                .AddRoles<IdentityRole>()

                .AddEntityFrameworkStores<WebIdentityContext>();
            });
        }
    }
}