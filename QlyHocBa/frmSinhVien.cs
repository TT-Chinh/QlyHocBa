using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyHocBa.BLL;

namespace QlyHocBa
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
            setCmbNamHoc();
            setCmbHocKy();
            setCmbLop();
        }

        public void setCmbNamHoc()
        {
            NamHocBL namHoc = new NamHocBL();
            cmbNamHoc.DataSource = namHoc.GetNamHocs();
            cmbNamHoc.DisplayMember = "ID";
            cmbNamHoc.ValueMember = "ID";
        }

        public void setCmbHocKy()
        {
            cmbHocKy.DataSource = new List<int> { 1, 2 };
        }
        public void setCmbLop()
        {
            LopHocBL lopHoc = new LopHocBL();
            cmbLop.DataSource = lopHoc.GetLopHocs();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "ID";
        }
    }
}
