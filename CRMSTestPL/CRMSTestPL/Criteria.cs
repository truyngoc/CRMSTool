using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSTestPL
{
    public class Criteria
    {
        public int? id { get; set; }

        public int? id_CHUYENDE { get; set; }

        public String id_TEN { get; set; }

        public String id_LOAI { get; set; }

        public String tc_SO_QL { get; set; }

        public int? kt_HINHTHUC { get; set; }

        public int? kt_MUCDO { get; set; }

        public int? mucdo_CANHBAO { get; set; }

        public String cdrr_HETHONG { get; set; }

        public String cdrr_CONGCHUC { get; set; }

        public String cdrr_NGHIEPVU { get; set; }

        public int? tl_KHANCAP { get; set; }

        public DateTime? ngay_HL { get; set; }

        public DateTime? ngay_HHL { get; set; }

        public String ma_HQ_THIETLAP { get; set; }

        public String phamvi_APDUNG { get; set; }

        public String ghi_CHU { get; set; }

        public DateTime? ngay_NHAP { get; set; }

        public String nguoi_NHAP { get; set; }

        public DateTime? ngay_SUA { get; set; }

        public String nguoi_SUA { get; set; }

        public String tt_XL { get; set; }

        public Dictionary<int, CriteriaDetail> tieuChiCT { get; set; }
        public List<ToKhaiData> dsgiaTriDinh { get; set; }
    }
}
