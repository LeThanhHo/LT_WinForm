using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{

    public partial class Game : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        Random rand = new Random();
        public Game()
        {
            InitializeComponent();
        }
        private void endGame()
        {
            gameTimer.Stop();
            lblScore.Text += " - GAME OVER!";
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;

            // Khi ống bên dưới đi khuất màn hình bên trái
            if (pipeBottom.Left < -150)
            {
                // Đưa ống về lại phía sau bên phải (khoảng cách 800px)
                pipeBottom.Left = 800;

                // Ngẫu nhiên độ cao cho ống dưới (Ví dụ từ 200 đến 400)
                pipeBottom.Top = rand.Next(250, 450);

                score++;
            }

            // Khi ống bên trên đi khuất màn hình bên trái
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;

                // Ngẫu nhiên độ cao cho ống trên (Ví dụ từ -150 đến 0)
                // Lưu ý: Số âm để đẩy ống lên phía trên khuất mép Form
                pipeTop.Top = rand.Next(-150, 50);

                score++;
            }

            // Kiểm tra va chạm (giữ nguyên như cũ)
            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -25)
            {
                endGame();
            }
        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10; // Khi nhấn phím, chim bay lên
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; // Khi thả phím, chim rơi xuống lại
            }
        }
    }
}
