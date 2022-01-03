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
using QlyHocBa.DAL;
using QlyHocBa.ViewModel;

namespace QlyHocBa
{
    public partial class frmSinhVien : Form
    {
        private int k;
        public frmSinhVien()
        {
            InitializeComponent();
            k = 0;
            setCmbHocKy();
            setCmbLop();
            setCmbNamHoc();
        }

        public void setCmbNamHoc()
        {
            NamHocBL namHoc = new NamHocBL();
            cmbNamHoc.DataSource = namHoc.GetNamHocs();
            cmbNamHoc.DisplayMember = "ID";
            cmbNamHoc.ValueMember = "ID";
            k++;
        }
        public void setCmbHocKy()
        {
            cmbHocKy.DataSource = new List<int> { 1, 2 };
            k++;
        }
        public void setCmbLop()
        {
            LopHocBL lopHoc = new LopHocBL();
            cmbLop.DataSource = lopHoc.GetLopHocs();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "ID";
            k++;
        }

        private NamHoc selectedNamHoc
        {
            get
            {
                return cmbNamHoc.SelectedItem as NamHoc;
            }
        }

        public void loadHocSinh()
        {
            int hocky = cmbHocKy.SelectedIndex+1;
            LopHoc lopHoc = cmbLop.SelectedItem as LopHoc;

            HocSinhBL hs = new HocSinhBL();
            hocSinhBLBindingSource.DataSource = hs.GetHocSinhVMs(selectedNamHoc.ID, hocky, lopHoc.ID);
            dataGridView.DataSource = hocSinhBLBindingSource;
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(k >= 2)
                loadHocSinh();
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k >= 2)
                loadHocSinh();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k >= 2)
                loadHocSinh();
        }

        private HocSinhVM selectedHocSinh
        {
            get
            {
                return hocSinhBLBindingSource.Current as HocSinhVM;
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if(selectedHocSinh != null && selectedHocSinh.ID > 0)
            {
                frmHocBa frm = new frmHocBa(selectedHocSinh.ID, selectedNamHoc.ID);
                frm.ShowDialog();
            }
        }
    }
}
