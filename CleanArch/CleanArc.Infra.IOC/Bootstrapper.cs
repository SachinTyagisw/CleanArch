using System.Runtime.CompilerServices;
using CleanArc.Domain.Interfaces;
using CleanArch.Application.Interface;
using CleanArch.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infra.IOC
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IScheduleService, ScheduleService>();

            //Infra DataLayer
            services.AddScoped<IScheduleRepository, IScheduleRepository>();
        }
    }
}
