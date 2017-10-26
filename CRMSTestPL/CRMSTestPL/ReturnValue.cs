using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSTestPL
{
    public class ReturnValue
    {
        public  int? resultCode { get; set; }
        public String errorMessage { get; set; }
        public String errorTrace { get; set; }
        public ResultClearance resultClearance { get; set; }
    }
}
