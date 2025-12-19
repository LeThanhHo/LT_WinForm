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

            MANV = new DataGridViewTextBoxColumn();
            TENNV = new DataGridViewTextBoxColumn();
            TUOINV = new DataGridViewTextBoxColumn();
            GIOITINH = new DataGridViewTextBoxColumn();
            LOAINV = new DataGridViewTextBoxColumn();
            LUONGNV = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dgvEmloyee).BeginInit();
            SuspendLayout();

            // ===== DATAGRIDVIEW =====
            dgvEmloyee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmloyee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmloyee.Columns.AddRange(new DataGridViewColumn[]
            {
                MANV, TENNV, TUOINV, GIOITINH, LOAINV, LUONGNV
            });
            dgvEmloyee.Location = new Point(10, 10);
            dgvEmloyee.Name = "dgvEmloyee";
            dgvEmloyee.RowHeadersWidth = 51;
            dgvEmloyee.Size = new Size(860, 230);
            dgvEmloyee.TabIndex = 0;
            dgvEmloyee.CellClick += dgvEmloyee_CellClick;

            // ===== LABELS + TEXTBOX =====
            lbma.AutoSize = true;
            lbma.Location = new Point(20, 260);
            lbma.Text = "Mã Nhân Viên";

            tbma.Location = new Point(140, 257);
            tbma.Size = new Size(250, 27);

            lbten.AutoSize = true;
            lbten.Location = new Point(20, 305);
            lbten.Text = "Tên Nhân Viên";

            tbten.Location = new Point(140, 302);
            tbten.Size = new Size(300, 27);

            lbtuoi.AutoSize = true;
            lbtuoi.Location = new Point(20, 350);
            lbtuoi.Text = "Tuổi";

            tbtuoi.Location = new Point(140, 347);
            tbtuoi.Size = new Size(120, 27);

            ckbgioitinh.AutoSize = true;
            ckbgioitinh.Location = new Point(300, 348);
            ckbgioitinh.Text = "Nam";

            lbloai.AutoSize = true;
            lbloai.Location = new Point(20, 395);
            lbloai.Text = "Loại nhân viên";

            tbloai.Location = new Point(140, 392);
            tbloai.Size = new Size(200, 27);

            lbluong.AutoSize = true;
            lbluong.Location = new Point(20, 440);
            lbluong.Text = "Lương / Công";

            tbluong.Location = new Point(140, 437);
            tbluong.Size = new Size(200, 27);

            // ===== BUTTONS =====
            btnthem.Location = new Point(500, 390);
            btnthem.Size = new Size(110, 40);
            btnthem.Text = "Thêm";
            btnthem.Click += btnthem_Click;

            btnxoa.Location = new Point(630, 390);
            btnxoa.Size = new Size(110, 40);
            btnxoa.Text = "Xóa";
            btnxoa.Click += btnxoa_Click;

            bntthoat.Location = new Point(760, 390);
            bntthoat.Size = new Size(110, 40);
            bntthoat.Text = "Thoát";
            bntthoat.Click += bntthoat_Click;

            // ===== COLUMNS =====
            MANV.HeaderText = "MÃ";
            TENNV.HeaderText = "HỌ TÊN";
            TUOINV.HeaderText = "TUỔI";
            GIOITINH.HeaderText = "GIỚI TÍNH";
            LOAINV.HeaderText = "LOẠI";
            LUONGNV.HeaderText = "LƯƠNG";

            // ===== FORM =====
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
