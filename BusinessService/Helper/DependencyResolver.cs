using BusinessService.Abstract;
using BusinessService.Concrete;
using DBAccess.AutoMapper;
using DBAccess.Concrete;
using DBAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositry.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Helper
{
    public static class DependencyResolver
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper(typeof(AutoMapperProfileDal));

            services.AddScoped<IAccountRepositry, AccountRepositry>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddDbContext<DataAccess>(option => option.UseSqlServer(Configuration.GetConnectionString("dbConnectionString")));

        }
    }
}
