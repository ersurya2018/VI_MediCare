using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VI_MediCare_Object;
using VI_MediCare_Object.Login;

namespace VI_MediCare_Manager.Login
{
    public interface ILogin_Mgr
    {
        ResultObject<EntityUserDetailsModel> GetName();
    }
}
