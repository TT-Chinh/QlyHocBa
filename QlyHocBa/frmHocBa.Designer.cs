
namespace QlyHocBa
{
    partial class frmHocBa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHocLuc = new System.Windows.Forms.TextBox();
            this.txtHanhKiem = new System.Windows.Forms.TextBox();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioTinh = new System.Windows.Forms.Label();
            this.btnEditHocLuc = new System.Windows.Forms.Button();
            this.btnEditHanhKiem = new System.Windows.Forms.Button();
            this.btnEditNhanXet = new System.Windows.Forms.Button();
            this.btnEditDiem = new System.Windows.Forms.Button();
            this.tenMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.btnEditLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học bạ học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(91, 139);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(153, 24);
            this.cmbNamHoc.TabIndex = 4;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Tính:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMonHocDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diemThiVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(305, 325);
            this.dataGridView1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Xếp Loại Học Lực:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Xếp Loại Hạnh Kiểm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhận Xét:";
            // 
            // txtHocLuc
            // 
            this.txtHocLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocLuc.Location = new System.Drawing.Point(511, 181);
            this.txtHocLuc.Name = "txtHocLuc";
            this.txtHocLuc.ReadOnly = true;
            this.txtHocLuc.Size = new System.Drawing.Size(146, 22);
            this.txtHocLuc.TabIndex = 5;
            // 
            // txtHanhKiem
            // 
            this.txtHanhKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanhKiem.Location = new System.Drawing.Point(511, 217);
            this.txtHanhKiem.Name = "txtHanhKiem";
            this.txtHanhKiem.ReadOnly = true;
            this.txtHanhKiem.Size = new System.Drawing.Size(146, 22);
            this.txtHanhKiem.TabIndex = 5;
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanXet.Location = new System.Drawing.Point(377, 274);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.ReadOnly = true;
            this.txtNhanXet.Size = new System.Drawing.Size(314, 183);
            this.txtNhanXet.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(535, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(616, 511);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(84, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label9";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(374, 98);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(51, 16);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "label9";
            // 
            // lblGioTinh
            // 
            this.lblGioTinh.AutoSize = true;
            this.lblGioTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioTinh.Location = new System.Drawing.Point(622, 98);
            this.lblGioTinh.Name = "lblGioTinh";
            this.lblGioTinh.Size = new System.Drawing.Size(51, 16);
            this.lblGioTinh.TabIndex = 8;
            this.lblGioTinh.Text = "label9";
            // 
            // btnEditHocLuc
            // 
            this.btnEditHocLuc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditHocLuc.BackgroundImage = global::QlyHocBa.Properties.Resources.edit_26px;
            this.btnEditHocLuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditHocLuc.Location = new System.Drawing.Point(663, 181);
            this.btnEditHocLuc.Name = "btnEditHocLuc";
            this.btnEditHocLuc.Size = new System.Drawing.Size(27, 23);
            this.btnEditHocLuc.TabIndex = 9;
            this.btnEditHocLuc.UseVisualStyleBackColor = false;
            this.btnEditHocLuc.Click += new System.EventHandler(this.btnEditHocLuc_Click);
            // 
            // btnEditHanhKiem
            // 
            this.btnEditHanhKiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditHanhKiem.BackgroundImage = global::QlyHocBa.Properties.Resources.edit_26px;
            this.btnEditHanhKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditHanhKiem.Location = new System.Drawing.Point(663, 217);
            this.btnEditHanhKiem.Name = "btnEditHanhKiem";
            this.btnEditHanhKiem.Size = new System.Drawing.Size(27, 23);
            this.btnEditHanhKiem.TabIndex = 9;
            this.btnEditHanhKiem.UseVisualStyleBackColor = false;
            this.btnEditHanhKiem.Click += new System.EventHandler(this.btnEditHanhKiem_Click);
            // 
            // btnEditNhanXet
            // 
            this.btnEditNhanXet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditNhanXet.BackgroundImage = global::QlyHocBa.Properties.Resources.edit_26px;
            this.btnEditNhanXet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditNhanXet.Location = new System.Drawing.Point(663, 252);
            this.btnEditNhanXet.Name = "btnEditNhanXet";
            this.btnEditNhanXet.Size = new System.Drawing.Size(27, 23);
            this.btnEditNhanXet.TabIndex = 9;
            this.btnEditNhanXet.UseVisualStyleBackColor = false;
            this.btnEditNhanXet.Click += new System.EventHandler(this.btnEditNhanXet_Click);
            // 
            // btnEditDiem
            // 
            this.btnEditDiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditDiem.BackgroundImage = global::QlyHocBa.Properties.Resources.edit_26px;
            this.btnEditDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditDiem.Location = new System.Drawing.Point(301, 511);
            this.btnEditDiem.Name = "btnEditDiem";
            this.btnEditDiem.Size = new System.Drawing.Size(29, 31);
            this.btnEditDiem.TabIndex = 9;
            this.btnEditDiem.UseVisualStyleBackColor = false;
            this.btnEditDiem.Click += new System.EventHandler(this.btnEditDiem_Click);
            // 
            // tenMonHocDataGridViewTextBoxColumn
            // 
            this.tenMonHocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMonHocDataGridViewTextBoxColumn.DataPropertyName = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.HeaderText = "Môn học";
            this.tenMonHocDataGridViewTextBoxColumn.Name = "tenMonHocDataGridViewTextBoxColumn";
            this.tenMonHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemDataGridViewTextBoxColumn.Width = 70;
            // 
            // diemThiVMBindingSource
            // 
            this.diemThiVMBindingSource.DataSource = typeof(QlyHocBa.ViewModel.DiemThiVM);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lớp:";
            // 
            // cmbLop
            // 
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Enabled = false;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(511, 139);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(146, 24);
            this.cmbLop.TabIndex = 4;
            // 
            // btnEditLop
            // 
            this.btnEditLop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditLop.BackgroundImage = global::QlyHocBa.Properties.Resources.edit_26px;
            this.btnEditLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditLop.Location = new System.Drawing.Point(663, 139);
            this.btnEditLop.Name = "btnEditLop";
            this.btnEditLop.Size = new System.Drawing.Size(27, 23);
            this.btnEditLop.TabIndex = 9;
            this.btnEditLop.UseVisualStyleBackColor = false;
            this.btnEditLop.Click += new System.EventHandler(this.btnEditLop_Click);
            // 
            // frmHocBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(727, 564);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditDiem);
            this.Controls.Add(this.btnEditNhanXet);
            this.Controls.Add(this.btnEditHanhKiem);
            this.Controls.Add(this.btnEditLop);
            this.Controls.Add(this.btnEditHocLuc);
            this.Controls.Add(this.lblGioTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNhanXet);
            this.Controls.Add(this.txtHanhKiem);
            this.Controls.Add(this.txtHocLuc);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbNamHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHocBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học bạ học sinh";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHocLuc;
        private System.Windows.Forms.TextBox txtHanhKiem;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioTinh;
        private System.Windows.Forms.BindingSource diemThiVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditHocLuc;
        private System.Windows.Forms.Button btnEditHanhKiem;
        private System.Windows.Forms.Button btnEditNhanXet;
        private System.Windows.Forms.Button btnEditDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Button btnEditLop;
    }
}