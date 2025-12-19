namespace BT_WinForm.GUI
{
    partial class Article19
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
            lbId = new Label();
            lbName = new Label();
            lbImg = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            pbImage = new PictureBox();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(32, 40);
            lbId.Name = "lbId";
            lbId.Size = new Size(97, 20);
            lbId.TabIndex = 0;
            lbId.Text = "Mã nhân viên";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(36, 105);
            lbName.Name = "lbName";
            lbName.Size = new Size(99, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Tên nhân viên";
            // 
            // lbImg
            // 
            lbImg.AutoSize = true;
            lbImg.Location = new Point(40, 202);
            lbImg.Name = "lbImg";
            lbImg.Size = new Size(70, 20);
            lbImg.TabIndex = 2;
            lbImg.Text = "Ảnh 3 x 4";
            // 
            // tbId
            // 
            tbId.Location = new Point(135, 33);
            tbId.Name = "tbId";
            tbId.Size = new Size(220, 27);
            tbId.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Location = new Point(142, 107);
            tbName.Name = "tbName";
            tbName.Size = new Size(219, 27);
            tbName.TabIndex = 4;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(172, 207);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(185, 192);
            pbImage.TabIndex = 5;
            pbImage.TabStop = false;
            // 
            // btFile
            // 
            btFile.Location = new Point(606, 180);
            btFile.Name = "btFile";
            btFile.Size = new Size(122, 46);
            btFile.TabIndex = 6;
            btFile.Text = "Chọn ảnh.....";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Article19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btFile);
            Controls.Add(pbImage);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(lbImg);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Name = "Article19";
            Text = "Article19";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbName;
        private Label lbImg;
        private TextBox tbId;
        private TextBox tbName;
        private PictureBox pbImage;
        private Button btFile;
    }
}