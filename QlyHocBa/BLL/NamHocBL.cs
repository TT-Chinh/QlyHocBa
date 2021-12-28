using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QlyHocBa.DAL;

namespace QlyHocBa.BLL
{
    class NamHocBL
    {
        public List<NamHoc> GetNamHocs()
        {
            HocBaModel model = new HocBaModel();
            var list = model.NamHocs.OrderByDescending(n => n.ID).ToList();
            return list;
        }
    }
}
