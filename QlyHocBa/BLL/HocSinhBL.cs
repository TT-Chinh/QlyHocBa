using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QlyHocBa.ViewModel;
using QlyHocBa.DAL;

namespace QlyHocBa.BLL
{
    class HocSinhBL
    {
        public HocSinhBL() { }

        public HocSinhVM getHocSinh(long id)
        {
            HocBaModel model = new HocBaModel();
            var hs = model.HocSinhs.Where(h => h.ID == id).FirstOrDefault();
            if (hs == null)
                return null;
            return new HocSinhVM
            {
                ID = id,
                HoTen = hs.HoTen,
                NgaySinh = hs.NgaySinh,
                GioiTinh = hs.GioiTinh ? HocSinhVM.GT.Nam : HocSinhVM.GT.NU
            };
        }

        public List<HocSinhVM> GetHocSinhVMs(string namhoc, int hocky, int lopId)
        {
            HocBaModel model = new HocBaModel();
            var list1 = from hs in model.HocSinhs
                        join kq in model.KetQuas on hs.ID equals kq.HocSinhID
                        where kq.NamHocID == namhoc && kq.LopHocID == lopId
                        select new
                        {
                            ID = hs.ID,
                            HoTen = hs.HoTen,
                            GioiTinh = hs.GioiTinh ? HocSinhVM.GT.Nam : HocSinhVM.GT.NU,
                            NgaySinh = hs.NgaySinh
                        };
            var list2 = from dt in model.DiemThis
                         where dt.NamHocID == namhoc && dt.HocKy == hocky
                         group dt by dt.HocSinhID into gr
                         let sl = gr.Count()
                         let total = gr.Sum(e => e.Diem)
                         select new
                         {
                             ID = gr.Key,
                             DTB = (long)total/sl
                         };


            var list = from hs in list1
                       join kq in list2 on hs.ID equals kq.ID into t
                       from k in t.DefaultIfEmpty()
                       select new HocSinhVM
                                {
                                    ID = hs.ID,
                                    HoTen = hs.HoTen,
                                    GioiTinh = hs.GioiTinh,
                                    NgaySinh = hs.NgaySinh,
                                    DTB = k == null ? 0 : k.DTB
                                };
            return list.ToList();
        } 
    }
}
