using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VI_MediCare_Object;
using VI_MediCare_Object.Enum;
using VI_MediCare_Object.Login;

namespace VI_MediCare_DA.Login
{
    public class Login_DA : ILogin_DA
    {
        public ResultObject<EntityUserDetailsModel> GetName()
        {
            var Result = new ResultObject<EntityUserDetailsModel>(ResultType.Error, null);
            EntityUserDetailsModel entityUserDetailsModel = new EntityUserDetailsModel()
            {
                UserID=1001,
                UserName="Coder[1001]",
                UserFullName="Coder World",
                Role_Id=1,
                Role_Name="Admin",
                ProfileID=1,
                ProfileName="SuperAdmin",
            };
            string CName = "Tech VNS";
            Result.ResultType = ResultType.Success;
            Result.ResultData = entityUserDetailsModel;
            Result.Flage = true;
            Result.Message = "Success";
            return Result;
        }

    }
}
