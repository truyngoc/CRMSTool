using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Net;
using System.IO;
using RestSharp;

namespace CRMSTestPL
{
    public partial class CRMSTestPL : Form
    {
        private ReturnValue ret;
        public CRMSTestPL()
        {
            InitializeComponent();

            initialLoaiNghiepVu();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoTK.Text)) {
                MessageBox.Show("Nhập số tờ khai đi chứ !!!");
                return;
            }

            if (txtSoTK.TextLength < 12)
            {
                MessageBox.Show("Số tờ khai phải đủ 12 ký tự");
                return;
            }

            if (txtSoTK.Text.Substring(0, 1) == "1")
            {                
                getImportDeclarationInfo();                
            }
            else {
                getExportDeclarationInfo();
            }


            MessageBox.Show("Đã lấy xong dữ liệu tờ khai !!!" , "Thông báo");
        }

        private void btnPhanLuong_Click(object sender, EventArgs e)
        {            
            try
            {
                if (txtToKhaiData.TextLength > 0)
                {
                    ret = clearanceDeclaration();

                    if (ret.resultClearance != null && ret.resultClearance.dstieuChiDinh != null && ret.resultClearance.dstieuChiDinh.Count > 0)
                    {
                        dgvTieuChi.DataSource = ret.resultClearance.dstieuChiDinh;


                        var tieuChi = ret.resultClearance.dstieuChiDinh.Where(o => o.id == (int)dgvTieuChi.Rows[0].Cells[0].Value).SingleOrDefault();
                        dgvTieuChi_CT.DataSource = null;
                        dgvTieuChi_CT.DataSource = tieuChi.tieuChiCT.Values.ToList();


                        dgvGiaTriDinh.DataSource = null;
                        dgvGiaTriDinh.DataSource = tieuChi.dsgiaTriDinh;
                    } else {
                        MessageBox.Show("Không bị dính tiêu chí nào :D :D :D !!!", "Thông báo");    
                    }
                }
                else
                {
                    MessageBox.Show("Lấy dữ liệu tờ khai đi!", "Thông báo");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error");
            }

            
            
        }    

        private String getConnectionString() {
            String strConn = string.Empty;
            try
            {
                strConn = ConfigurationManager.AppSettings["VNACCS_SHAREDB"].ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            return strConn;
        }

        private OleDbConnection getConnection()
        {
            OleDbConnection conn = new OleDbConnection(getConnectionString());

            return conn;
        }

        private DataTable readerToTable(OleDbDataReader dr) {
            DataTable dt = new DataTable();
            dt.Load(dr);

            return dt;
        }

        private void getImportDeclarationInfo() {
            List<ToKhaiData> dlTK = new List<ToKhaiData>();
            OleDbConnection conn;
            OleDbCommand cmd;
            OleDbDataReader dr;

            try
            {
                conn = getConnection();

                cmd = new OleDbCommand();                
                cmd.CommandText = "SELECT N501A_SIKNO, N501A_RPEAT, N501A_SINKS, N501A_CARGO, N501A_TRANS, N501A_SHIKS, N501A_YUNYC, N501A_YUNN1, N501A_YUNYA, N501A_YUNTL, N501A_CYUK1, N501A_CYUK2, N501A_YUSYC, N501A_YUNN2, N501A_YUSYA1, N501A_YUSYA2, N501A_YUSYA3, N501A_YUSYA4, N501A_YUSYK, N501A_SINKY, N501A_AWBNB_1, N501A_AWBNB_2, N501A_AWBNB_3, N501A_AWBNB_4, N501A_AWBNB_5, N501A_KOSUK, N501A_KOSUT, N501A_WAIGW, N501A_WAIGT, N501A_ZOUTI, N501A_KAMK1, N501A_SENPC, N501A_TYBNA, N501A_TYNEP, N501A_TRORC, N501A_TRORN, N501A_TMDSI, N501A_TMDSM, N501A_YSYOS_1, N501A_YSYON_1, N501A_YSYOS_2, N501A_YSYON_2, N501A_YSYOS_3, N501A_YSYON_3, N501A_YSYOS_4, N501A_YSYON_4, N501A_YSYOS_5, N501A_YSYON_5, N501A_INVOB, N501A_INVNN, N501A_INVNO, N501A_INDAY, N501A_PAYCD, N501A_INVKU, N501A_INVKJ, N501A_TUKA1, N501A_INVKA, N501A_NOZGM, N501A_AWADP, N501A_AWAKB_1, N501A_AWAKA_1, N501A_AWAKD_1, N501A_AWAKB_2, N501A_AWAKA_2, N501A_AWAKD_2, N501A_AWAKB_3, N501A_AWAKA_3, N501A_AWAKD_3, N501A_AWAZC, N501A_AWAAL, N501A_SINKD, N501A_HENTD, N501A_NOZET, N501A_UKECD_1, N501A_UKEKM_1, N501A_TKANZ_1, N501A_TKANG_1, N501A_TKANM_1, N501A_KARAN_1, N501A_TISGI_1, N501A_UKECD_2, N501A_UKEKM_2, N501A_TKANZ_2, N501A_TKANG_2, N501A_TKANM_2, N501A_KARAN_2, N501A_TISGI_2, N501A_UKECD_3, N501A_UKEKM_3, N501A_TKANZ_3, N501A_TKANG_3, N501A_TKANM_3, N501A_KARAN_3, N501A_TISGI_3, N501A_UKECD_4, N501A_UKEKM_4, N501A_TKANZ_4, N501A_TKANG_4, N501A_TKANM_4, N501A_KARAN_4, N501A_TISGI_4, N501A_UKECD_5, N501A_UKEKM_5, N501A_TKANZ_5, N501A_TKANG_5, N501A_TKANM_5, N501A_KARAN_5, N501A_TISGI_5, N501A_ATZEI, N501A_ZEIBN, N501A_UWMEI, N501A_DAIRN, N501A_HKANZ, N501A_HOSKB FROM N501A WHERE N501A_SIKNO = '" + txtSoTK.Text + "'";
                cmd.Connection = conn;

                conn.Open();
                dr = cmd.ExecuteReader();                
                ImportDeclaration.readerToToKhaiData_Declaration(dr, ref dlTK);                
                
                dr.Close();


                cmd.CommandText = "SELECT N501B_SIKNO, N501B_RANNB, N501B_HINMC, N501B_HINME, N501B_ORGLC, N501B_ORGNK, N501B_SURY1, N501B_TANI1, N501B_SURY2, N501B_TANI2, N501B_BPRIC, N501B_TANKA, N501B_TCODE, N501B_TTANI, N501B_FOBCD, N501B_KAZEI, N501B_GMENF, N501B_GMEZG, N501B_KAZTK, N501B_KAZTN, N501B_ZEIIN, N501B_KANKS, N501B_KANKT, N501B_KANKG, N501B_KANRT, N501B_KANTU, N501B_LOWSY FROM N501B WHERE N501B_SIKNO = '" + txtSoTK.Text + "'";
                dr = cmd.ExecuteReader();
                ImportDeclaration.readerToToKhaiData_Goods(dr, ref dlTK);

                cmd.Dispose();
                conn.Close();

                // convert to JSON
                txtToKhaiData.Text = JsonConvert.SerializeObject(dlTK, Formatting.Indented);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getExportDeclarationInfo()
        {
            List<ToKhaiData> dlTK = new List<ToKhaiData>();
            OleDbConnection conn;
            OleDbCommand cmd;
            OleDbDataReader dr;

            try
            {
                conn = getConnection();

                cmd = new OleDbCommand();
                cmd.CommandText = "SELECT N502A_SIKNO,N502A_RPEAT,N502A_SINKS,N502A_CARGO,N502A_TRANS,N502A_SHIKS,N502A_YUNYC,N502A_YUNN1,N502A_YUNYA,N502A_YUNTL,N502A_CYUK1,N502A_CYUK2,N502A_YUSYC,N502A_YUNN2,N502A_YUSYA1,N502A_YUSYA2,N502A_YUSYA3,N502A_YUSYA4,N502A_YUSYK,N502A_SINKY,N502A_AWBNB,N502A_KOSUK,N502A_KOSUT,N502A_WAIGW,N502A_WAIGT,N502A_ZOUTI,N502A_KAMK1,N502A_SENPC,N502A_TYBNA,N502A_TYNEP,N502A_TRORC,N502A_TRORN,N502A_TMDSI,N502A_TMDSM,N502A_YSYOS_1,N502A_YSYON_1,N502A_YSYOS_2,N502A_YSYON_2,N502A_YSYOS_3,N502A_YSYON_3,N502A_YSYOS_4,N502A_YSYON_4,N502A_YSYOS_5,N502A_YSYON_5,N502A_INVOB,N502A_INVNN,N502A_INVNO,N502A_INDAY,N502A_PAYCD,N502A_INVKU,N502A_INVKJ,N502A_TUKA1,N502A_INVKA,N502A_NOZGM,N502A_AWADP,N502A_AWAKB_1,N502A_AWAKA_1,N502A_AWAKD_1,N502A_AWAKB_2,N502A_AWAKA_2,N502A_AWAKD_2,N502A_AWAKB_3,N502A_AWAKA_3,N502A_AWAKD_3,N502A_AWAZC,N502A_AWAAL,N502A_SINKD,N502A_HENTD,N502A_NOZET,N502A_UKECD_1,N502A_UKEKM_1,N502A_TKANZ_1,N502A_TKANG_1,N502A_TKANM_1,N502A_KARAN_1,N502A_TISGI_1,N502A_UKECD_2,N502A_UKEKM_2,N502A_TKANZ_2,N502A_TKANG_2,N502A_TKANM_2,N502A_KARAN_2,N502A_TISGI_2,N502A_UKECD_3,N502A_UKEKM_3,N502A_TKANZ_3,N502A_TKANG_3,N502A_TKANM_3,N502A_KARAN_3,N502A_TISGI_3,N502A_UKECD_4,N502A_UKEKM_4,N502A_TKANZ_4,N502A_TKANG_4,N502A_TKANM_4,N502A_KARAN_4,N502A_TISGI_4,N502A_UKECD_5,N502A_UKEKM_5,N502A_TKANZ_5,N502A_TKANG_5,N502A_TKANM_5,N502A_KARAN_5,N502A_TISGI_5,N502A_ATZEI,N502A_ZEIBN,N502A_UWMEI,N502A_DAIRN,N502A_HKANZ,N502A_HOSKB FROM N502A WHERE N502A_SIKNO = '" + txtSoTK.Text + "'";
                cmd.Connection = conn;

                conn.Open();
                dr = cmd.ExecuteReader();
                ExportDeclaration.readerToToKhaiData_Declaration(dr, ref dlTK);
                dr.Close();


                cmd.CommandText = "SELECT N502B_SIKNO,N502B_RANNB,N502B_HINMC,N502B_HINME,N502B_SURY1,N502B_TANI1,N502B_SURY2,N502B_TANI2,N502B_BPRIC,N502B_TANKA,N502B_TCODE,N502B_TTANI,N502B_FOBCD,N502B_KAZEI,N502B_GMENF,N502B_GMEZG,N502B_KAZTK,N502B_KAZTN,N502B_ZEIIN,N502B_KANKS,N502B_KANKT,N502B_KANKG,N502B_KANRT,N502B_KANTU,N502B_LOWSY FROM N502B WHERE N502B_SIKNO = '" + txtSoTK.Text + "'";
                dr = cmd.ExecuteReader();
                ExportDeclaration.readerToToKhaiData_Goods(dr, ref dlTK);

                cmd.Dispose();
                conn.Close();

                // convert to JSON
                txtToKhaiData.Text = JsonConvert.SerializeObject(dlTK, Formatting.Indented);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private ReturnValue clearanceDeclaration() {
            string baseUrl = txtURL.Text;

            var client = new RestClient();
            client.BaseUrl = new System.Uri(baseUrl);
            var request = new RestRequest("crms-clearance/api/clearance?clearanceType=" + cboLoaiNV.SelectedValue, Method.POST);
            
            // easily add HTTP Headers
            request.AddHeader("Accept", "application/json");

            request.Parameters.Clear();
            request.AddParameter("application/json", txtToKhaiData.Text, ParameterType.RequestBody);
            
            // add body (dung addParameter o tren)
            //request.RequestFormat = DataFormat.Json;
            //request.AddBody(txtToKhaiData.Text);

            // execute the request
            // C1:
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            ReturnValue ret = JsonConvert.DeserializeObject<ReturnValue>(content);

            JToken jt = JToken.Parse(content);
            txtKetQuaPL.Text = jt.ToString(Newtonsoft.Json.Formatting.Indented);            
            return ret;

            // C2:
            //IRestResponse<ReturnValue> response = client.Execute<ReturnValue>(request);

            
            // format content
            //JToken jt = JToken.Parse(response.Content);
            //txtKetQuaPL.Text = jt.ToString(Newtonsoft.Json.Formatting.Indented);

            //return response.Data;

        }












        public void initialLoaiNghiepVu() {
            List<LoaiNghiepVu> lstNV = new List<LoaiNghiepVu>();

            lstNV.Add(new LoaiNghiepVu() { MaNghiepVu = "QLPL_TTQB_DTQ", TenNghiepVu = "TTQ - Dừng hàng KVGS" });
            lstNV.Add(new LoaiNghiepVu() { MaNghiepVu = "QLTC_STQ_DH", TenNghiepVu = "STQ - KTSTQ trong vòng 60 ngày" });
            lstNV.Add(new LoaiNghiepVu() { MaNghiepVu = "QLTC_STQ_KT", TenNghiepVu = "STQ - KTSTQ theo dấu hiệu rủi ro" });

            cboLoaiNV.DataSource = lstNV;
            cboLoaiNV.DisplayMember = "TenNghiepVu";
            cboLoaiNV.ValueMember = "MaNghiepVu";

            cboLoaiNV.SelectedIndex = 0;
        }


        private void dgvTieuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTieuChi.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var tieuChi = ret.resultClearance.dstieuChiDinh.Where(o => o.id == (int)dgvTieuChi.Rows[e.RowIndex].Cells[0].Value).SingleOrDefault();
                
                dgvTieuChi_CT.DataSource = null;
                dgvTieuChi_CT.DataSource = tieuChi.tieuChiCT.Values.ToList();


                dgvGiaTriDinh.DataSource = null;
                dgvGiaTriDinh.DataSource = tieuChi.dsgiaTriDinh;
            }
        }

    }

    class LoaiNghiepVu {
        public string TenNghiepVu { get; set; }
        public string MaNghiepVu { get; set; }
    }
}
