namespace BT_WinForm
{
    partial class Form1
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
            // FlowLayoutPanel giúp các nút tự xếp hàng
            mainContainer = new FlowLayoutPanel();

            btn1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnGame = new Button();

            mainContainer.SuspendLayout();
            SuspendLayout();

            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Padding = new Padding(30); // Cách lề 30px cho đẹp
            mainContainer.BackColor = Color.FromArgb(240, 240, 240);
            mainContainer.AutoScroll = true; // Hiện thanh cuộn nếu quá nhiều nút

            // Thêm các nút vào Container
            mainContainer.Controls.Add(btn1);
            mainContainer.Controls.Add(button2);
            mainContainer.Controls.Add(button3);
            mainContainer.Controls.Add(button4);
            mainContainer.Controls.Add(button5);
            mainContainer.Controls.Add(button6);
            mainContainer.Controls.Add(button8);
            mainContainer.Controls.Add(button9);
            mainContainer.Controls.Add(button10);
            mainContainer.Controls.Add(btnGame);

            // Cấu hình Style cho từng nút
            ConfigureModernButton(btn1, "User Profile", Color.DodgerBlue);
            btn1.Click += btn1_Click;

            ConfigureModernButton(button2, "Phone & Year", Color.DodgerBlue);
            button2.Click += button2_Click;

            ConfigureModernButton(button3, "Calculator", Color.DodgerBlue);
            button3.Click += button3_Click;

            ConfigureModernButton(button4, "Calculator Pro", Color.DodgerBlue);
            button4.Click += button4_Click;

            ConfigureModernButton(button5, "Quick Calc", Color.DodgerBlue);
            button5.Click += button5_Click_1;

            ConfigureModernButton(button6, "System Khoa", Color.DodgerBlue);
            button6.Click += button6_Click_1;

            ConfigureModernButton(button8, "Management", Color.DodgerBlue);
            button8.Click += button8_Click;

            ConfigureModernButton(button9, "Image Library", Color.DodgerBlue);
            button9.Click += button9_Click;

            ConfigureModernButton(button10, "System Time", Color.DodgerBlue);
            button10.Click += button10_Click;

            // Nút Game làm to và khác màu
            ConfigureModernButton(btnGame, "🎮 START MINI GAME", Color.Crimson);
            btnGame.Size = new Size(320, 100); // Làm nút game to gấp đôi
            btnGame.Click += btnGame_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 650);
            Controls.Add(mainContainer);
            Name = "Form1";
            Text = "Main Menu";
            mainContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Hàm tạo Style nút hiện đại
        private void ConfigureModernButton(Button btn, string text, Color themeColor)
        {
            btn.Text = text;
            btn.Size = new Size(150, 80); // Kích thước nút vuông vắn
            btn.Margin = new Padding(10);  // Khoảng cách giữa các nút
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = themeColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        #endregion

        private FlowLayoutPanel mainContainer;
        private Button btn1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnGame;
    }
}