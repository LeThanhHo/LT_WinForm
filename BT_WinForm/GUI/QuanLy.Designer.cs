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
            SDT = new DataGridViewTextBoxColumn();
            BOPHAN = new DataGridViewTextBoxColumn();
            lbma = new Label();
            lbten = new Label();
            lbtuoi = new Label();
            lbphone = new Label();
            lbbophan = new Label();
            lbloai = new Label();
            lbluong = new Label();
            tbma = new TextBox();
            tbten = new TextBox();
            tbtuoi = new TextBox();
            tbphone = new TextBox();
            tbbophan = new TextBox();
            tbloai = new TextBox();
            tbluong = new TextBox();
            ckbgioitinh = new CheckBox();
            btnthem = new Button();
            btnxoa = new Button();
            bntthoat = new Button();
            bntLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmloyee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmloyee
            // 
            dgvEmloyee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmloyee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmloyee.Columns.AddRange(new DataGridViewColumn[] { MANV, TENNV, TUOINV, GIOITINH, LOAINV, LUONGNV, SDT, BOPHAN });
            dgvEmloyee.Location = new Point(12, 12);
            dgvEmloyee.Name = "dgvEmloyee";
            dgvEmloyee.RowHeadersWidth = 51;
            dgvEmloyee.Size = new Size(1000, 220);
            dgvEmloyee.TabIndex = 0;
            dgvEmloyee.CellClick += dgvEmloyee_CellClick;
            // 
            // MANV
            // 
            MANV.HeaderText = "MÃ NV";
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
            // SDT
            // 
            SDT.HeaderText = "SĐT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            // 
            // BOPHAN
            // 
            BOPHAN.HeaderText = "BỘ PHẬN";
            BOPHAN.MinimumWidth = 6;
            BOPHAN.Name = "BOPHAN";
            // 
            // lbma
            // 
            lbma.Location = new Point(30, 260);
            lbma.Name = "lbma";
            lbma.Size = new Size(100, 23);
            lbma.TabIndex = 1;
            lbma.Text = "Mã Nhân Viên:";
            // 
            // lbten
            // 
            lbten.Location = new Point(30, 300);
            lbten.Name = "lbten";
            lbten.Size = new Size(100, 23);
            lbten.TabIndex = 3;
            lbten.Text = "Họ và Tên:";
            // 
            // lbtuoi
            // 
            lbtuoi.Location = new Point(30, 340);
            lbtuoi.Name = "lbtuoi";
            lbtuoi.Size = new Size(100, 23);
            lbtuoi.TabIndex = 5;
            lbtuoi.Text = "Tuổi:";
            // 
            // lbphone
            // 
            lbphone.Location = new Point(380, 260);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(100, 23);
            lbphone.TabIndex = 7;
            lbphone.Text = "Số Điện Thoại:";
            // 
            // lbbophan
            // 
            lbbophan.Location = new Point(380, 300);
            lbbophan.Name = "lbbophan";
            lbbophan.Size = new Size(100, 23);
            lbbophan.TabIndex = 9;
            lbbophan.Text = "Bộ Phận:";
            // 
            // lbloai
            // 
            lbloai.Location = new Point(380, 340);
            lbloai.Name = "lbloai";
            lbloai.Size = new Size(100, 23);
            lbloai.TabIndex = 11;
            lbloai.Text = "Loại (ft/pt):";
            // 
            // lbluong
            // 
            lbluong.Location = new Point(380, 380);
            lbluong.Name = "lbluong";
            lbluong.Size = new Size(100, 23);
            lbluong.TabIndex = 13;
            lbluong.Text = "Công:";
            // 
            // tbma
            // 
            tbma.Location = new Point(140, 257);
            tbma.Name = "tbma";
            tbma.Size = new Size(180, 27);
            tbma.TabIndex = 2;
            // 
            // tbten
            // 
            tbten.Location = new Point(140, 297);
            tbten.Name = "tbten";
            tbten.Size = new Size(180, 27);
            tbten.TabIndex = 4;
            // 
            // tbtuoi
            // 
            tbtuoi.Location = new Point(140, 337);
            tbtuoi.Name = "tbtuoi";
            tbtuoi.Size = new Size(180, 27);
            tbtuoi.TabIndex = 6;
            // 
            // tbphone
            // 
            tbphone.Location = new Point(500, 257);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(180, 27);
            tbphone.TabIndex = 8;
            // 
            // tbbophan
            // 
            tbbophan.Location = new Point(500, 297);
            tbbophan.Name = "tbbophan";
            tbbophan.Size = new Size(180, 27);
            tbbophan.TabIndex = 10;
            // 
            // tbloai
            // 
            tbloai.Location = new Point(500, 337);
            tbloai.Name = "tbloai";
            tbloai.Size = new Size(180, 27);
            tbloai.TabIndex = 12;
            // 
            // tbluong
            // 
            tbluong.Location = new Point(500, 377);
            tbluong.Name = "tbluong";
            tbluong.Size = new Size(180, 27);
            tbluong.TabIndex = 14;
            // 
            // ckbgioitinh
            // 
            ckbgioitinh.Location = new Point(140, 380);
            ckbgioitinh.Name = "ckbgioitinh";
            ckbgioitinh.Size = new Size(104, 24);
            ckbgioitinh.TabIndex = 15;
            ckbgioitinh.Text = "GT Nam";
            // 
            // btnthem
            // 
            btnthem.Location = new Point(780, 238);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(120, 45);
            btnthem.TabIndex = 16;
            btnthem.Text = "Thêm Mới";
            btnthem.Click += btnthem_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(780, 340);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(120, 45);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xóa";
            btnxoa.Click += btnxoa_Click;
            // 
            // bntthoat
            // 
            bntthoat.Location = new Point(780, 403);
            bntthoat.Name = "bntthoat";
            bntthoat.Size = new Size(120, 45);
            bntthoat.TabIndex = 18;
            bntthoat.Text = "Thoát";
            bntthoat.Click += bntthoat_Click;
            // 
            // bntLuu
            // 
            bntLuu.Location = new Point(780, 289);
            bntLuu.Name = "bntLuu";
            bntLuu.Size = new Size(120, 43);
            bntLuu.TabIndex = 19;
            bntLuu.Text = "Cập Nhật";
            bntLuu.UseVisualStyleBackColor = true;
            bntLuu.Click += bntLuu_Click;
            // 
            // QuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 460);
            Controls.Add(bntLuu);
            Controls.Add(dgvEmloyee);
            Controls.Add(lbma);
            Controls.Add(tbma);
            Controls.Add(lbten);
            Controls.Add(tbten);
            Controls.Add(lbtuoi);
            Controls.Add(tbtuoi);
            Controls.Add(lbphone);
            Controls.Add(tbphone);
            Controls.Add(lbbophan);
            Controls.Add(tbbophan);
            Controls.Add(lbloai);
            Controls.Add(tbloai);
            Controls.Add(lbluong);
            Controls.Add(tbluong);
            Controls.Add(ckbgioitinh);
            Controls.Add(btnthem);
            Controls.Add(btnxoa);
            Controls.Add(bntthoat);
            Name = "QuanLy";
            Text = "Hệ Thống Quản Lý Nhân Viên";
            Load += QuanLy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmloyee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmloyee;
        private Label lbma, lbten, lbtuoi, lbloai, lbluong, lbphone, lbbophan;
        private TextBox tbma, tbten, tbtuoi, tbloai, tbluong, tbphone, tbbophan;
        private CheckBox ckbgioitinh;
        private Button bntthoat, btnxoa, btnthem;
        private DataGridViewTextBoxColumn MANV, TENNV, TUOINV, GIOITINH, LOAINV, LUONGNV, SDT, BOPHAN;
        private Button bntLuu;
    }
}