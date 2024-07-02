using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VI_MediCare_DA.Login;
using VI_MediCare_Object;
using VI_MediCare_Object.Enum;
using VI_MediCare_Object.Login;

namespace VI_MediCare_Manager.Login
{
    public class Login_Mgr : ILogin_Mgr
    {
        private ILogin_DA _loginDA;

        public Login_Mgr(ILogin_DA login_DA)
        {
            _loginDA = login_DA;
        }

        public ResultObject<EntityUserDetailsModel> GetName()
        {
            var result = new ResultObject<EntityUserDetailsModel>(ResultType.Error, null);
            result = _loginDA.GetName();
            return result;
        }
    }
}
