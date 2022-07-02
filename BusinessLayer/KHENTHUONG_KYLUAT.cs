using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;
namespace BusinessLayer
{
    public class KHENTHUONG_KYLUAT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_KHENTHUONG_KYLUAT getItem(string soQD)
        {
            return db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
        }
        public List<tb_KHENTHUONG_KYLUAT> getList(int loai)
        {
            return db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
        }
        public List<KHENTHUONG_KYLUAT_DTO> getListFull(int loai)
        {
            List<tb_KHENTHUONG_KYLUAT> lstKT = db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.TUNGAY = item.TUNGAY;
                kt.DENNGAY = item.DENNGAY;               
                kt.NOIDUNG = item.NOIDUNG;
                kt.NGAY = item.NGAY;
                kt.LYDO = item.LYDO;
                kt.LOAI = item.LOAI;
                kt.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
                kt.CREATE_BY = item.CREATE_BY;
                kt.CREATE_DATE = item.CREATE_DATE;
                kt.UPDATE_BY = item.UPDATE_BY;
                kt.UPDATE_DATE = item.UPDATE_DATE;
                kt.DELETE_BY = item.DELETE_BY;
                kt.DELETE_DATE = item.DELETE_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }
        public tb_KHENTHUONG_KYLUAT Add(tb_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                db.tb_KHENTHUONG_KYLUAT.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: "+ex.Message);
            }            
        }
        public tb_KHENTHUONG_KYLUAT Update(tb_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.TUNGAY = kt.TUNGAY;
                _kt.DENNGAY = kt.DENNGAY;
                _kt.LYDO = kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
                _kt.LOAI = kt.LOAI;
                _kt.MANV = kt.MANV;
                _kt.UPDATE_BY = kt.UPDATE_BY;
                _kt.UPDATE_DATE = kt.UPDATE_DATE;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soQD,int maNV)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
                _kt.DELETE_BY = maNV;
                _kt.DELETE_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _kt = db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI==loai).OrderByDescending(x => x.CREATE_DATE).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SOQUYETDINH;
            }
            else
            {
                return "00000";
            }
        }
    }
}
