using Microsoft.Extensions.DependencyInjection;
using PFLApp.BLL.Service.Interface;
using PFLApp.BLL.Service.Repository;
using PFLApp.DAL.Repository.Implementation;
using PFLApp.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Extensions
{
    public static class CustomService
    {
        public static void AddServices(this IServiceCollection services)
        {                      
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
         
        }
    }
}
