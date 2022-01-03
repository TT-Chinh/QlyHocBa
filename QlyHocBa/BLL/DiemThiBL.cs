using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QlyHocBa.ViewModel;
using QlyHocBa.DAL;

namespace QlyHocBa.BLL
{
    class DiemThiBL
    {
        public List<DiemThiVM> getDiemThis(long id, string namhoc)
        {
            HocBaModel model = new HocBaModel();
            var list1 = from dt in model.DiemThis
                       where dt.NamHocID.Equals(namhoc) && dt.HocSinhID == id
                       group dt by dt.MonHocID into gr
                       let sl = gr.Count()
                       let total = gr.Sum(e => e.Diem)
                       select new
                       {
                           MonHocID = gr.Key,
                           Diem = (float) total / sl
                       };
            var list = from mh in model.MonHocs
                       join dt in list1 on mh.ID equals dt.MonHocID into d
                       from t in d.DefaultIfEmpty()
                       select new DiemThiVM
                       {
                           MonHocID = mh.ID,
                           TenMonHoc = mh.TenMonHoc,
                           Diem =  t == null ? 0 : t.Diem
                       };
            return list.ToList();
        }

        public short getDiem(long hs, string mon, string nam, short hocky)
        {
            HocBaModel model = new HocBaModel();
            var  d = model.DiemThis.Where(
                e => e.HocSinhID == hs
                && e.MonHocID == mon
                && e.NamHocID == nam
                && e.HocKy == hocky).FirstOrDefault();
            if (d == null) return -1;
            return (short) d.Diem;
        }

        public void update(long hocsinhId, string monhoc, string namhoc, short hocky, short diem)
        {
            HocBaModel model = new HocBaModel();
            var d = model.DiemThis.Where(
                e => e.HocSinhID == hocsinhId
                && e.NamHocID == namhoc 
                && e.HocKy == hocky
                && e.MonHocID == monhoc
                ).FirstOrDefault();
            if(d == null)
            {
                model.DiemThis.Add(new DiemThi
                {
                    MonHocID = monhoc,
                    HocSinhID = hocsinhId,
                    NamHocID = namhoc,
                    HocKy = hocky,
                    Diem = diem
                });
            }else d.Diem = diem;
            model.SaveChanges();
        }

        public void delete(long hocsinhId, string monhoc, string namhoc, short hocky)
        {
            HocBaModel model = new HocBaModel();
            var d = model.DiemThis.Where(
                e => e.HocSinhID == hocsinhId
                && e.NamHocID == namhoc
                && e.HocKy == hocky
                && e.MonHocID == monhoc
                ).FirstOrDefault();
            if (d != null)
            {
                model.DiemThis.Remove(d);
                model.SaveChanges();
            }
        }
    }
}
