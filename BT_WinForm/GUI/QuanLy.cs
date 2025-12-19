using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class QuanLy : Form
    {
        List<Emloyee> lst;

        public QuanLy()
        {
            InitializeComponent();
        }

        public List<Emloyee> GetData()
        {
            List<Emloyee> lst = new List<Emloyee>();

            FullTime f1 = new FullTime()
            {
                Id = "53418",
                Name = "Trần Tiến",
                Age = 20,
                Gender = true,
                WorkingDays = 28,
            };
            lst.Add(f1);

            PartTime p1 = new PartTime()
            {
                Id = "53416",
                Name = "Nguyễn Cường",
                Age = 25,
                Gender = true,
                WorkingHours = 40,
            };
            lst.Add(p1);

            PartTime p2 = new PartTime()
            {
                Id = "53417",
                Name = "Nguyễn Hào",
                Age = 23,
                Gender = true,
                WorkingHours = 30,
            };
            lst.Add(p2);

            return lst;
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            lst = GetData();
            LoadGrid();
        }

        void LoadGrid()
        {
            dgvEmloyee.Rows.Clear();

            foreach (var em in lst)
            {
                string type = (em is FullTime) ? "Chính thức" : "Part-time";

                dgvEmloyee.Rows.Add(
                    em.Id,
                    em.Name,
                    em.Age,
                    em.Gender ? "Nam" : "Nữ",
                    type,
                    em.Salary()
                );
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (tbloai.Text.ToLower() == "ft")   
            {
                FullTime f = new FullTime()
                {
                    Id = tbma.Text,
                    Name = tbten.Text,
                    Age = int.Parse(tbtuoi.Text),
                    Gender = ckbgioitinh.Checked,
                    WorkingDays = int.Parse(tbluong.Text)   
                };

                lst.Add(f);
            }
            else if (tbloai.Text.ToLower() == "pt")  
            {
                PartTime p = new PartTime()
                {
                    Id = tbma.Text,
                    Name = tbten.Text,
                    Age = int.Parse(tbtuoi.Text),
                    Gender = ckbgioitinh.Checked,
                    WorkingHours = int.Parse(tbluong.Text) 
                };

                lst.Add(p);
            }
            else
            {
                MessageBox.Show("Nhập loại nhân viên: ft = FullTime | pt = PartTime");
                return;
            }

            LoadGrid();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvEmloyee.CurrentCell == null) return;

            int idx = dgvEmloyee.CurrentCell.RowIndex;

            if (idx >= 0 && idx < lst.Count)
            {
                lst.RemoveAt(idx);
                LoadGrid();
            }
        }

        private void dgvEmloyee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmloyee.Rows[e.RowIndex];

                tbma.Text = row.Cells[0].Value?.ToString();
                tbten.Text = row.Cells[1].Value?.ToString();
                tbtuoi.Text = row.Cells[2].Value?.ToString();

                string gioitinh = row.Cells[3].Value?.ToString();
                ckbgioitinh.Checked = gioitinh == "Nam";

                tbloai.Text = row.Cells[4].Value?.ToString();
                tbluong.Text = row.Cells[5].Value?.ToString();
            }
        }

        private void bntthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
