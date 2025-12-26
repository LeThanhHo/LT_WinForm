namespace BT_WinForm.GUI
{
    partial class QuanLy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvEmloyee = new DataGridView();
            MANV = new DataGridViewTextBoxColumn();
            TENNV = new DataGridViewTextBoxColumn();
            TUOINV = new DataGridViewTextBoxColumn();
            GIOITINH = new DataGridViewTextBoxColumn();
            LOAINV = new DataGridViewTextBoxColumn();
            LUONGNV = new DataGridViewTextBoxColumn();
            lbma = new Label();
            lbten = new Label();
            lbtuoi = new Label();
            tbma = new TextBox();
            tbten = new TextBox();
            tbtuoi = new TextBox();
            ckbgioitinh = new CheckBox();
            lbloai = new Label();
            tbloai = new TextBox();
            lbluong = new Label();
            tbluong = new TextBox();
            bntthoat = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmloyee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmloyee
            // 
            dgvEmloyee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmloyee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmloyee.Columns.AddRange(new DataGridViewColumn[] { MANV, TENNV, TUOINV, GIOITINH, LOAINV, LUONGNV });
            dgvEmloyee.Location = new Point(10, 10);
            dgvEmloyee.Name = "dgvEmloyee";
            dgvEmloyee.RowHeadersWidth = 51;
            dgvEmloyee.Size = new Size(860, 230);
            dgvEmloyee.TabIndex = 0;
            dgvEmloyee.CellClick += dgvEmloyee_CellClick;
            // 
            // MANV
            // 
            MANV.HeaderText = "MÃ";
            MANV.MinimumWidth = 6;
            MANV.Name = "MANV";
            // 
            // TENNV
            // 
            TENNV.HeaderText = "HỌ TÊN";
            TENNV.MinimumWidth = 6;
            TENNV.Name = "TENNV";
            // 
            // TUOINV
            // 
            TUOINV.HeaderText = "TUỔI";
            TUOINV.MinimumWidth = 6;
            TUOINV.Name = "TUOINV";
            // 
            // GIOITINH
            // 
            GIOITINH.HeaderText = "GIỚI TÍNH";
            GIOITINH.MinimumWidth = 6;
            GIOITINH.Name = "GIOITINH";
            // 
            // LOAINV
            // 
            LOAINV.HeaderText = "LOẠI";
            LOAINV.MinimumWidth = 6;
            LOAINV.Name = "LOAINV";
            // 
            // LUONGNV
            // 
            LUONGNV.HeaderText = "LƯƠNG";
            LUONGNV.MinimumWidth = 6;
            LUONGNV.Name = "LUONGNV";
            // 
            // lbma
            // 
            lbma.AutoSize = true;
            lbma.Location = new Point(20, 260);
            lbma.Name = "lbma";
            lbma.Size = new Size(102, 20);
            lbma.TabIndex = 1;
            lbma.Text = "Mã Nhân Viên";
            // 
            // lbten
            // 
            lbten.AutoSize = true;
            lbten.Location = new Point(20, 305);
            lbten.Name = "lbten";
            lbten.Size = new Size(104, 20);
            lbten.TabIndex = 3;
            lbten.Text = "Tên Nhân Viên";
            // 
            // lbtuoi
            // 
            lbtuoi.AutoSize = true;
            lbtuoi.Location = new Point(20, 350);
            lbtuoi.Name = "lbtuoi";
            lbtuoi.Size = new Size(38, 20);
            lbtuoi.TabIndex = 5;
            lbtuoi.Text = "Tuổi";
            // 
            // tbma
            // 
            tbma.Location = new Point(140, 257);
            tbma.Name = "tbma";
            tbma.Size = new Size(250, 27);
            tbma.TabIndex = 2;
            // 
            // tbten
            // 
            tbten.Location = new Point(140, 302);
            tbten.Name = "tbten";
            tbten.Size = new Size(300, 27);
            tbten.TabIndex = 4;
            // 
            // tbtuoi
            // 
            tbtuoi.Location = new Point(140, 347);
            tbtuoi.Name = "tbtuoi";
            tbtuoi.Size = new Size(120, 27);
            tbtuoi.TabIndex = 6;
            // 
            // ckbgioitinh
            // 
            ckbgioitinh.AutoSize = true;
            ckbgioitinh.Location = new Point(300, 348);
            ckbgioitinh.Name = "ckbgioitinh";
            ckbgioitinh.Size = new Size(63, 24);
            ckbgioitinh.TabIndex = 7;
            ckbgioitinh.Text = "Nam";
            // 
            // lbloai
            // 
            lbloai.AutoSize = true;
            lbloai.Location = new Point(20, 395);
            lbloai.Name = "lbloai";
            lbloai.Size = new Size(104, 20);
            lbloai.TabIndex = 8;
            lbloai.Text = "Loại nhân viên";
            // 
            // tbloai
            // 
            tbloai.Location = new Point(140, 392);
            tbloai.Name = "tbloai";
            tbloai.Size = new Size(200, 27);
            tbloai.TabIndex = 9;
            // 
            // lbluong
            // 
            lbluong.AutoSize = true;
            lbluong.Location = new Point(20, 440);
            lbluong.Name = "lbluong";
            lbluong.Size = new Size(100, 20);
            lbluong.TabIndex = 10;
            lbluong.Text = "Lương / Công";
            // 
            // tbluong
            // 
            tbluong.Location = new Point(140, 437);
            tbluong.Name = "tbluong";
            tbluong.Size = new Size(200, 27);
            tbluong.TabIndex = 11;
            // 
            // bntthoat
            // 
            bntthoat.Location = new Point(760, 390);
            bntthoat.Name = "bntthoat";
            bntthoat.Size = new Size(110, 40);
            bntthoat.TabIndex = 14;
            bntthoat.Text = "Thoát";
            bntthoat.Click += bntthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(630, 390);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(110, 40);
            btnxoa.TabIndex = 13;
            btnxoa.Text = "Xóa";
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(500, 390);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(110, 40);
            btnthem.TabIndex = 12;
            btnthem.Text = "Thêm";
            btnthem.Click += btnthem_Click;
            // 
            // QuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(dgvEmloyee);
            Controls.Add(lbma);
            Controls.Add(tbma);
            Controls.Add(lbten);
            Controls.Add(tbten);
            Controls.Add(lbtuoi);
            Controls.Add(tbtuoi);
            Controls.Add(ckbgioitinh);
            Controls.Add(lbloai);
            Controls.Add(tbloai);
            Controls.Add(lbluong);
            Controls.Add(tbluong);
            Controls.Add(btnthem);
            Controls.Add(btnxoa);
            Controls.Add(bntthoat);
            Name = "QuanLy";
            Text = "Quản Lý Nhân Viên";
            Load += QuanLy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmloyee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmloyee;
        private Label lbma, lbten, lbtuoi, lbloai, lbluong;
        private TextBox tbma, tbten, tbtuoi, tbloai, tbluong;
        private CheckBox ckbgioitinh;
        private Button bntthoat, btnxoa, btnthem;

        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn TENNV;
        private DataGridViewTextBoxColumn TUOINV;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn LOAINV;
        private DataGridViewTextBoxColumn LUONGNV;
    }
}
