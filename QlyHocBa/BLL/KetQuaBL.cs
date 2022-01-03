using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QlyHocBa.DAL;

namespace QlyHocBa.BLL
{
    class KetQuaBL
    {
        public string getHocLuc(long hocsinhId, string namhoc)
        {
            HocBaModel model = new HocBaModel();
            var kq = model.KetQuas.Where(k => k.HocSinhID == hocsinhId && k.NamHocID == namhoc).FirstOrDefault();
            return kq == null ? "" : kq.HocLuc;
        }

        public string getHanhKiem(long hocsinhId, string namhoc)
        {
            HocBaModel model = new HocBaModel();
            var kq = model.KetQuas.Where(k => k.HocSinhID == hocsinhId && k.NamHocID == namhoc).FirstOrDefault();
            return kq == null ? "" : kq.HanhKiem;
        }

        public string getNhanXet(long hocsinhId, string namhoc)
        {
            HocBaModel model = new HocBaModel();
            var kq = model.KetQuas.Where(k => k.HocSinhID == hocsinhId && k.NamHocID == namhoc).FirstOrDefault();
            return kq == null ? "" : kq.NhanXet;
        }

        public int getLopHoc(long hocsinhId, string namhoc)
        {
            HocBaModel model = new HocBaModel();
            var kq = model.KetQuas.Where(k => k.HocSinhID == hocsinhId && k.NamHocID == namhoc).FirstOrDefault();
            return kq == null ? 0 : kq.LopHocID;
        }

        public void update(long hocsinhId, string namhoc, int lopId, string hocluc, string hanhkiem, string nhanxet)
        {
            HocBaModel model = new HocBaModel();
            var kq = model.KetQuas.Where(k => k.HocSinhID == hocsinhId && k.NamHocID == namhoc).FirstOrDefault();
            if(kq != null)
            {
                kq.HocLuc = hocluc;
                kq.HanhKiem = hanhkiem;
                kq.NhanXet = nhanxet;
                kq.LopHocID = lopId;
                model.SaveChanges();
            }
            else
            {
                kq = new KetQua();
                kq.HocSinhID = hocsinhId;
                kq.HanhKiem = hanhkiem;
                kq.HocLuc = hocluc;
                kq.NamHocID = namhoc;
                kq.LopHocID = lopId;
                kq.NhanXet = nhanxet;
                model.KetQuas.Add(kq);
                model.SaveChanges();
            }
        }
    }
}
