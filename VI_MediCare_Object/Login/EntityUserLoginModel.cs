using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI_MediCare_Object.Login
{
    public class EntityUserLoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RequestType { get; set; }
        public long CompanyId { get; set; } 
        public long Buid { get; set; }
    }
}
