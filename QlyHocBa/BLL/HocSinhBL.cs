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

        public List<HocSinhVM> GetHocSinhVMs(string namhoc, int hocky, int lopId)
        {
            HocBaModel model = new HocBaModel();
            var list = model.HocSinhs.Select(e => new HocSinhVM
            {
                ID = e.ID,
                HoTen = e.HoTen,
                GioiTinh = e.GioiTinh ? HocSinhVM.GT.Nam: HocSinhVM.GT.NU,
                NgaySinh = e.NgaySinh,
                DTB = 0
            }).ToList();
            return list;
        }
    }
}
