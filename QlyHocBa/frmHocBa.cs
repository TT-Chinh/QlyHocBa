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
    public partial class frmHocBa : Form
    {
        private long ID;
        public frmHocBa(long id, string namhoc)
        {
            InitializeComponent();
            ID = id;
            setCmbLop();
            setCmbNamHoc(namhoc);
            setHocSinh();
        }

        private NamHoc selectedNamHoc
        {
            get { return cmbNamHoc.SelectedItem as NamHoc; }
        }

        private DiemThiVM selectedDiem
        {
            get { return diemThiVMBindingSource.Current as DiemThiVM; }
        }

        private LopHoc selectedLop
        {
            get { return cmbLop.SelectedItem as LopHoc; }
        }

        private void setHocSinh()
        {
            HocSinhBL hocSinhBL = new HocSinhBL();
            HocSinhVM hocSinhVM = hocSinhBL.getHocSinh(ID);
            if(hocSinhVM != null)
            {
                lblName.Text = hocSinhVM.HoTen;
                lblGioTinh.Text = hocSinhVM.GioiTinh.ToString();
                lblNgaySinh.Text = hocSinhVM.NgaySinh.ToString("dd/MM/yyyy");
            }
        }

        private void loadData()
        {
            DiemThiBL diemThiBL = new DiemThiBL();
            diemThiVMBindingSource.DataSource = diemThiBL.getDiemThis(ID,selectedNamHoc.ID);
            dataGridView1.DataSource = diemThiVMBindingSource;

            KetQuaBL ketQuaBL = new KetQuaBL();
            cmbLop.SelectedValue = ketQuaBL.getLopHoc(ID, selectedNamHoc.ID);
            txtHocLuc.Text = ketQuaBL.getHocLuc(ID, selectedNamHoc.ID);
            txtHanhKiem.Text = ketQuaBL.getHanhKiem(ID, selectedNamHoc.ID);
            txtNhanXet.Text = ketQuaBL.getNhanXet(ID, selectedNamHoc.ID);
        }

        public void setCmbNamHoc(string namhoc)
        {
            NamHocBL namHoc = new NamHocBL();
            cmbNamHoc.DataSource = namHoc.GetNamHocs();
            cmbNamHoc.DisplayMember = "ID";
            cmbNamHoc.ValueMember = "ID";
            cmbNamHoc.SelectedValue = namhoc;
        }

        public void setCmbLop()
        {
            LopHocBL lopHoc = new LopHocBL();
            cmbLop.DataSource = lopHoc.GetLopHocs();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "ID";
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnEditHocLuc_Click(object sender, EventArgs e)
        {
            txtHocLuc.ReadOnly = false;
        }

        private void btnEditHanhKiem_Click(object sender, EventArgs e)
        {
            txtHanhKiem.ReadOnly = false;
        }

        private void btnEditNhanXet_Click(object sender, EventArgs e)
        {
            txtNhanXet.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KetQuaBL ketQuaBL = new KetQuaBL();
            ketQuaBL.update(ID, selectedNamHoc.ID, selectedLop.ID, txtHocLuc.Text, txtHanhKiem.Text, txtNhanXet.Text);
            txtHocLuc.ReadOnly = true;
            txtHanhKiem.ReadOnly = true;
            txtNhanXet.ReadOnly = true;
            cmbLop.Enabled = false;
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnEditDiem_Click(object sender, EventArgs e)
        {
            if (selectedDiem != null)
            {
                frmDiemThi f = new frmDiemThi(ID, selectedDiem.MonHocID, selectedDiem.TenMonHoc, selectedNamHoc.ID);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
            else MessageBox.Show("Vui lòng chọn môn!");
        }

        private void btnEditLop_Click(object sender, EventArgs e)
        {
            cmbLop.Enabled = true;
        }
    }
}
