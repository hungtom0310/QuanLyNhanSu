﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class HOPDONGLAODONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_HOPDONG getIterm(string sohd)
        {
            return db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        }
        public List<HOPDONG_DTO> getItemFull(string sohd)
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x=>x.SOHD==sohd).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = "ngày " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKETTHUC = "ngày " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKY = "ngày " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETE_DATE = item.DELETE_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
            public List<tb_HOPDONG> getList()
        {
            return db.tb_HOPDONG.ToList();
        }
        public List<HOPDONG_DTO> getListFull()
        {
            List<tb_HOPDONG> lstHD= db.tb_HOPDONG.ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU ="Từ ngày " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(0,2)+ " tháng " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(3, 2)+ " năm " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKETTHUC = "ngày " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKY = "ngày " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETE_DATE = item.DELETE_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
        public tb_HOPDONG Add(tb_HOPDONG hd)
        {
            try
            {
                db.tb_HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public tb_HOPDONG Update(tb_HOPDONG hd)
        {
            try
            {
                var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBATDAU = hd.NGAYBATDAU;
                _hd.NGAYKETTHUC = hd.NGAYKETTHUC;
                _hd.MANV = hd.MANV;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.LANKY = hd.LANKY;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.LUONGCOBAN = hd.LUONGCOBAN;
                _hd.NOIDUNG = hd.NOIDUNG;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.SOHD = hd.SOHD;
                _hd.MACTY = hd.MACTY;
                _hd.UPDATED_BY = hd.UPDATED_BY;
                _hd.UPDATED_DATE = hd.UPDATED_DATE;
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Delete(string sohd)
        {
            var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
           
            _hd.DELETED_BY = _hd.DELETED_BY;
            _hd.DELETE_DATE = _hd.DELETE_DATE;
            db.SaveChanges();
        }
        public string MaxSoHopDong()
        {
            var _hd = db.tb_HOPDONG.OrderByDescending(x=>x.CREATED_DATE).FirstOrDefault();
            if (_hd!=null)
            {
                return _hd.SOHD;
            }
            else
            {
                return "00000";
            }
        }
        public List<HOPDONG_DTO> getLenLuong()
        {
            //List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x=>(x.NGAYKETTHUC.Value.Month - DateTime.Now.Month)==0 &&(DateTime.Now.Year - x.NGAYKETTHUC.Value.Year ) == 2).ToList();
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x => (x.NGAYKETTHUC.Value.Month - DateTime.Now.Month) == 0 && (x.NGAYKETTHUC.Value.Year - DateTime.Now.Year) == 0).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = "ngày " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKETTHUC = "ngày " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKY = "ngày " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKY.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETE_DATE = item.DELETE_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }

    }
}
