﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class TANGCA
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_TANGCA getItem(int id)
        {
            return db.tb_TANGCA.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_TANGCA> getList()
        {
            return db.tb_TANGCA.ToList();
        }
        public List<TANGCA_DTO> getListFull()
        {
            var lstTangCa = db.tb_TANGCA.ToList();
            List<TANGCA_DTO> lstDTO = new List<TANGCA_DTO>();
            TANGCA_DTO tc;
            foreach (var item in lstTangCa)
            {
                tc = new TANGCA_DTO();
                tc.ID = item.ID;
                tc.NAM = item.NAM;
                tc.THANG = item.THANG;
                tc.NGAY = item.NGAY;
                tc.SOGIO = item.SOGIO;
                tc.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                tc.HOTEN = nv.HOTEN;
                tc.IDLLOAICA = item.IDLLOAICA;
                var lc = db.tb_LOAICA.FirstOrDefault(l => l.IDLOAICA == item.IDLLOAICA);
                tc.TENLOAICA = lc.TENLOAICA;
                tc.HESO = lc.HESO;
                tc.SOTIEN = item.SOTIEN;
                tc.GHICHU = item.GHICHU;
                tc.THANG = item.THANG;
                tc.NGAY = item.NGAY;
                tc.CREATED_BY = item.CREATED_BY;
                tc.CREATED_DATE = item.CREATED_DATE;
                tc.UPDATED_BY = item.UPDATED_BY;
                tc.UPDATED_DATE = item.UPDATED_DATE;
                tc.DELETED_BY = item.DELETED_BY;
                tc.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(tc);
            }
            return lstDTO;
        }
        public tb_TANGCA Add(tb_TANGCA tc)
        {
            try
            {
                db.tb_TANGCA.Add(tc);
                db.SaveChanges();
                return tc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_TANGCA Update(tb_TANGCA tc)
        {
            try
            {
                var _tc = db.tb_TANGCA.FirstOrDefault(x => x.ID == tc.ID);
                _tc.NAM = tc.NAM;
                _tc.THANG = tc.THANG;
                _tc.NGAY = tc.NGAY;
                _tc.SOGIO = tc.SOGIO;
                _tc.SOTIEN = tc.SOTIEN;
                _tc.MANV = tc.MANV;
                _tc.IDLLOAICA = tc.IDLLOAICA;
                _tc.GHICHU = tc.GHICHU;
                _tc.UPDATED_BY = tc.UPDATED_BY;
                _tc.UPDATED_DATE = tc.UPDATED_DATE;
                db.SaveChanges();
                return tc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id, int iduser)
        {
            try
            {
                var _tc = db.tb_TANGCA.FirstOrDefault(x => x.ID == id);
                _tc.DELETED_BY = iduser;
                _tc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
