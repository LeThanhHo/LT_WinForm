using BT_WinForm.GUI;

namespace BT_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            {
                Form f = new Form2();
                f.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Caculator();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Caculator_2();
            f.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form f = new Simple_Caculator();
            f.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form f = new Khoa();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new QuanLy();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new Article19();
            f.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new Article24();
            f.Show();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Form f = new Game();
            f.Show();
        }
    }

}
