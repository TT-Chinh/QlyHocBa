using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QlyHocBa.DAL;

namespace QlyHocBa.BLL
{
    class LopHocBL
    {
        public List<LopHoc> GetLopHocs()
        {
            HocBaModel model = new HocBaModel();
            return model.LopHocs.OrderBy(l => l.TenLop).ToList();
        }
    }
}
