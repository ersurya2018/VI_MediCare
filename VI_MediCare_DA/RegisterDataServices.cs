using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VI_MediCare_DA.Login;

namespace VI_MediCare_DA
{
    public static class RegisterDataServices
    {
        public static void AddDataServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILogin_DA, Login_DA>();
        }
    }
}
