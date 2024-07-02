using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VI_MediCare_Object.Enum;

namespace VI_MediCare_Object
{
    public class ResultObject<T>
    {
        public ResultObject() { }
        public ResultObject(ResultType resultType, T resultData, bool flage = false, string message = null)
        {
            ResultType = resultType;
            ResultData = resultData;
            Flage = flage;
            Message = message;
        }
        public ResultType ResultType { get; set; }
        public T ResultData { get; set; }
        public bool Flage { get; set; }
        public string Message { get; set; }

    }
}
