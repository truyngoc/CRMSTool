using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSTestPL
{
    public class ToKhaiData
    {
        public string fieldName { get; set; }
        public int position { get; set; }
        public string fieldType { get; set; }
        public string fieldValue { get; set; }
        public int groupIndex { get; set; }

        public ToKhaiData(string fieldName, int position, string fieldType, string fieldValue, int groupIndex)
        {
            this.fieldName = fieldName;
            this.position = position;
            this.fieldType = fieldType;
            this.fieldValue = fieldValue;
            this.groupIndex = groupIndex;
        }
    }
}
