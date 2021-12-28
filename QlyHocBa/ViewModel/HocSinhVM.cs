using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyHocBa.ViewModel
{
    class HocSinhVM
    {
        public HocSinhVM() { }
        public long ID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public enum GT { Nam = 1, NU = 0 }
        public GT GioiTinh { get; set; }
        public float DTB { get; set; }
    }
}
