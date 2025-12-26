namespace BT_WinForm.GUI
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            bird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.BackColor = SystemColors.Menu;
            bird.Image = Properties.Resources.OIP__5_;
            bird.Location = new Point(4, 183);
            bird.Name = "bird";
            bird.Size = new Size(108, 70);
            bird.SizeMode = PictureBoxSizeMode.Zoom;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.BackColor = Color.ForestGreen;
            pipeTop.Location = new Point(367, 0);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(107, 55);
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.ForestGreen;
            pipeBottom.Location = new Point(367, 325);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(107, 78);
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            pipeBottom.Click += pipeBottom_Click;
            // 
            // ground
            // 
            ground.BackColor = Color.Sienna;
            ground.Location = new Point(4, 394);
            ground.Name = "ground";
            ground.Size = new Size(795, 94);
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(4, 5);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(50, 20);
            lblScore.TabIndex = 4;
            lblScore.Text = "label1";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(lblScore);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(bird);
            Name = "Game";
            Text = "Game";
            KeyDown += Game_KeyDown;
            KeyUp += Game_KeyUp;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}