using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSTestPL
{
    public class CriteriaDetail
    {
        public int? id { get; set; }

        public int? id_TIEUCHI { get; set; }

        public int? id_THAMSO { get; set; }

        public int? id_TOANTU { get; set; }

        public int? hienthi_THI { get; set; }

        public DateTime? ngay_NHAP { get; set; }

        public String nguoi_NHAP { get; set; }

        public DateTime? ngay_SUA { get; set; }

        public String nguoi_SUA { get; set; }

        public String thamso_TEN { get; set; }

        public String toantu_GIATRI { get; set; }

        public Object tc_CT_GIATRI { get; set; }

        public Object gia_TRI { get; set; }
    }
}
