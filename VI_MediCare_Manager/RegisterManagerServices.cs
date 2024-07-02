using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VI_MediCare_Manager.Login;

namespace VI_MediCare_Manager
{
    public static class RegisterManagerServices
    {
        public static void AddManagerServices(this IServiceCollection serviceCollectionMgr)
        {
            serviceCollectionMgr.AddTransient<ILogin_Mgr, Login_Mgr>();
        }
    }
}
