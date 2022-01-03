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
    public partial class frmDiemThi : Form
    {
        private long HocinhID;
        private string MonID;
        private string NamHocID;
        private short D1;
        private short D2;
        public frmDiemThi(long hs, string monId, string tenMon, string nam)
        {
            InitializeComponent();
            lblMon.Text = "Môn " + tenMon;
            this.HocinhID = hs;
            this.MonID = monId;
            this.NamHocID = nam;

            //get diem thi
            DiemThiBL diemThiBL = new DiemThiBL();
            D1 = diemThiBL.getDiem(hs, monId, nam, 1);
            D2 = diemThiBL.getDiem(hs, monId, nam, 2);
            if (D1 > -1) txt1.Text = $"{D1}";
            if (D2 > -1) txt2.Text = $"{D2}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DiemThiBL diemThiBL = new DiemThiBL();
            //hoc ky 1:
            if (!string.IsNullOrEmpty(txt1.Text))
            {
                D1 = short.Parse(txt1.Text);
                diemThiBL.update(HocinhID, MonID, NamHocID, 1, D1);
            }
            else if(D1 > -1)
            {
                diemThiBL.delete(HocinhID, MonID, NamHocID, 1);
            }
            //hoc ky 2:
            if (!string.IsNullOrEmpty(txt2.Text))
            {
                D2 = short.Parse(txt2.Text);
                diemThiBL.update(HocinhID, MonID, NamHocID, 2, D2);
            }
            else if (D2 > -1)
            {
                diemThiBL.delete(HocinhID, MonID, NamHocID, 2);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
