using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSTestPL
{
    public class ResultClearance
    {
        public String so_TK { get; set; }
        public DateTime? ngay_DK { get; set; }
        public String ma_HQ { get; set; }
        public String ma_DN { get; set; }
        public String luong_TK { get; set; }
        public int? kt_HINHTHUC { get; set; }
        public int? kt_MUCDO { get; set; }
        public List<Criteria> dstieuChiDinh { get; set; }        
    }
}
