using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DataLayer;

namespace QLNHANSU.Reports
{
    public partial class rptBangCongCTNV : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongCTNV()
        {
            InitializeComponent();
        }
        public List<tb_BANGCONG_NV_CT> _bcct;
        public rptBangCongCTNV(List<tb_BANGCONG_NV_CT> bcct)
        {
            InitializeComponent();
            this._bcct = bcct;
            this.DataSource = _bcct;
            BindingData();
        }
        void BindingData()
        {
            lblMANV.DataBindings.Add("Text", DataSource, "MANV");
            lblHOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            lblNGAY.DataBindings.Add("Text", DataSource, "NGAY");
            lblTHU.DataBindings.Add("Text", DataSource, "THU");
            lblGIOVAO.DataBindings.Add("Text", DataSource, "GIOVAO");
            lblGIORA.DataBindings.Add("Text", DataSource, "GIORA");
            lblNGAYLE.DataBindings.Add("Text", DataSource, "CONGNGAYLE");
            lblNGAYPHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lblCHUNHAT.DataBindings.Add("Text", DataSource, "CONGCHUNHAT");
            lblNGAYCONG.DataBindings.Add("Text", DataSource, "NGAYCONG");
            lblKYHIEU.DataBindings.Add("Text", DataSource, "KYHIEU");
            lblGHICHU.DataBindings.Add("Text", DataSource, "GHICHU");
            lblMAKYCONG.DataBindings.Add("Text", DataSource, "MAKYCONG");
        }
    }
}
