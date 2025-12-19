namespace BT_WinForm.GUI
{
    partial class Article24
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
            tmStopwatch = new System.Windows.Forms.Timer(components);
            lblDisplay = new Label();
            btStop = new Button();
            btStart = new Button();
            SuspendLayout();
            // 
            // tmStopwatch
            // 
            tmStopwatch.Tick += tmStopwatch_Tick;
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(200, 47);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(393, 137);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "00:00";
            // 
            // btStop
            // 
            btStop.Location = new Point(627, 244);
            btStop.Name = "btStop";
            btStop.Size = new Size(94, 29);
            btStop.TabIndex = 1;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // btStart
            // 
            btStart.Location = new Point(432, 245);
            btStart.Name = "btStart";
            btStart.Size = new Size(111, 40);
            btStart.TabIndex = 2;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // Article24
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btStart);
            Controls.Add(btStop);
            Controls.Add(lblDisplay);
            Name = "Article24";
            Text = "Article24";
            Load += Article24_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmStopwatch;
        private Label lblDisplay;
        private Button btStop;
        private Button btStart;
    }
}