using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using DevExpress.XtraReports.UI;

namespace QLNHANSU.Reports
{
    public partial class frmBangCongCT : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongCT()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        BANGCONG_NV_CT _bcct_nv;
        private void frmBangCongCT_Load(object sender, EventArgs e)
        {
            _nhanvien = new NHANVIEN();
            _bcct_nv = new BANGCONG_NV_CT();
            loadNhanVien();
            cboKyCong.SelectedIndex = DateTime.Now.Month-1;
            cboNam.Text = DateTime.Now.Year.ToString();
        }

        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
            /*cboNhanVien.DataSource = _nhanvien.getList();
            cboNhanVien.DisplayMember = "HOTEN";
            cboNhanVien.DisplayMember = "MANV";
            cboNhanVien.ValueMember = "MANV";*/
        }

        

        private void btnIn_Click(object sender, EventArgs e)
        {
            var lst = _bcct_nv.getBangCongCT(int.Parse(cboNam.Text) * 100 + int.Parse(cboKyCong.Text),int.Parse(slkNhanVien.EditValue.ToString()));
            rptBangCongCTNV frm = new rptBangCongCTNV(lst);
            frm.ShowPreviewDialog();

        }
        private void labelControl1_Click(object sender, EventArgs e)
        {
          
        }
    }
}