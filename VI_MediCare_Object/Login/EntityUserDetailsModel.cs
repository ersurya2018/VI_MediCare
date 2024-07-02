using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI_MediCare_Object.Login
{
    public class EntityUserDetailsModel
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public int Role_Id { get; set; }
        public int ProfileID { get; set; }
        public string Role_Name { get; set; }
        public string ProfileName { get; set; }
        public string Base_url { get; set; }
        public long BUID { get; set; }
        public string BUName { get; set; }
    }
}
