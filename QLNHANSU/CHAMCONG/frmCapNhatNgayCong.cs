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
using BusinessLayer;
using DataLayer;

namespace QLNHANSU.CHAMCONG
{
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;
        KYCONGCHITIET _kcct;
        BANGCONG_NV_CT _bcct_nv;
        frmBangCongChiTiet frmBCCC = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];

        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct_nv = new BANGCONG_NV_CT();
            lblID.Text = _manv.ToString();
            lblHoTen.Text = _hoten;
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNgayCong.SetDate(_d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _valueChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
            string _valueNgayNghi = rdgNgayNghi.Properties.Items[rdgNgayNghi.SelectedIndex].Value.ToString();
            string fieldName = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);

            
            if (cldNgayCong.SelectionRange.Start.Year * 100 + cldNgayCong.SelectionRange.Start.Month != +_makycong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Cập nhật KYCONGCHITIET=> cập nhật BANGCONG_NV_CT
            QLNS_Funcitons.execQuery("UPDATE tb_KYCONGCHITIET SET " + fieldName + "='" + _valueChamCong + "' WHERE MAKYCONG=" + _makycong + " AND MANV=" + _manv);

            tb_BANGCONG_NV_CT bcctnv = _bcct_nv.getItem(_makycong, _manv, cldNgayCong.SelectionStart.Day);
            

            if (cldNgayCong.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                if (_valueNgayNghi == "NN")
                {
                    bcctnv.CONGCHUNHAT = 1;
                    bcctnv.NGAYCONG = 0;

                }
                else
                {
                    bcctnv.CONGCHUNHAT = 0.5;
                    bcctnv.NGAYCONG = 0;

                }
            }
            else
            {
                bcctnv.KYHIEU = _valueChamCong;
                switch (_valueChamCong)
                {
                    case "P":

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYPHEP = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;

                        }
                        break;

                    case "NL":

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.CONGNGAYLE = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.CONGNGAYLE = 0.5;
                        }

                        break;


                    case "CT":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 1;
                            bcctnv.NGAYPHEP = 0;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    case "X":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 1;
                            bcctnv.NGAYPHEP = 0;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    case "V":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 0;
                            bcctnv.NGHIKHONGPHEP = 1;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGHIKHONGPHEP = 0.5;
                        }
                        break;
                    case "VR":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 0;
                            bcctnv.NGHIKHONGPHEP = 1;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGHIKHONGPHEP = 0.5;
                        }
                        break;
                    default:
                        break;
                }
            }


            //Update tb_BANGCONG_NV_CT
            _bcct_nv.Update(bcctnv);

            //Tính lại tổng các ngày: ngày phép, ngày công, ngày vắng,...
            double congchunhat = _bcct_nv.tongNgayCongChuNhat(_makycong,_manv);
            double tongngaycong = _bcct_nv.tongNgayCong(_makycong, _manv);
            double tongngayphep = _bcct_nv.tongNgayPhep(_makycong, _manv);
            double tongngaykhongphep = _bcct_nv.tongNgayKhongPhep(_makycong, _manv);
            double tongngayle = _bcct_nv.tongNgayLe(_makycong, _manv);
            kcct.CONGCHUNHAT = congchunhat;
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG = tongngaycong;
            kcct.NGHIKHONGPHEP = tongngaykhongphep;
            kcct.CONGNGAYLE = tongngayle;
            _kcct.Update(kcct);


            frmBCCC.loadBangCong();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldNgayCong.SelectionRange.Start.Day;
        }
    }
}