using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyHocBa.BLL
{
    class HocSinhBL
    {
        public HocSinhBL() { }

        public long ID { get; set; }
        public string Name { get; set; }
        public DateTime NgaySinh { get; set; }
        public enum GT{Nam = 1, NU = 0}
        public GT GioiTinh { get; set; }
        public float DTB { get; set; }
    }
}
