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

            lst.Add(new FullTime()
            {
                Id = "53418",
                Name = "Trần Tiến",
                Age = 20,
                Gender = true,
                WorkingDays = 28,
                PhoneNumber = "1234567891",
                Part = "Bán Hàng"
            });

            lst.Add(new PartTime()
            {
                Id = "53416",
                Name = "Nguyễn Cường",
                Age = 25,
                Gender = true,
                WorkingHours = 40,
                PhoneNumber = "1234567892",
                Part = "Kho"
            });

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
                    em.Salary(),
                    em.PhoneNumber,
                    em.Part
                );
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (char c in tbten.Text)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Tên không được chứa chữ số!");
                        tbten.Focus();
                        return;
                    }
                }


                string phone = tbphone.Text.Trim();
                if (phone.Length > 10)
                {
                    MessageBox.Show("Số điện thoại không được vượt quá 10 ký tự!");
                    tbphone.Focus();
                    return;
                }

                foreach (char c in phone)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Số điện thoại chỉ được chứa các ký số (0-9)!");
                        tbphone.Focus();
                        return;
                    }
                }


                if (tbloai.Text.ToLower() == "ft")
                {
                    FullTime f = new FullTime()
                    {
                        Id = tbma.Text,
                        Name = tbten.Text,
                        Age = int.Parse(tbtuoi.Text),
                        Gender = ckbgioitinh.Checked,
                        WorkingDays = int.Parse(tbluong.Text),
                        PhoneNumber = phone,
                        Part = tbbophan.Text
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
                        WorkingHours = int.Parse(tbluong.Text),
                        PhoneNumber = phone,
                        Part = tbbophan.Text
                    };
                    lst.Add(p);
                }
                else
                {
                    MessageBox.Show("Nhập loại nhân viên: ft = FullTime | pt = PartTime");
                    return;
                }

                LoadGrid();
                ClearInputs();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại: Tuổi và Lương phải là số nguyên!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
                ckbgioitinh.Checked = (gioitinh == "Nam");

                tbloai.Text = row.Cells[4].Value?.ToString();
                tbluong.Text = row.Cells[5].Value?.ToString();
                tbphone.Text = row.Cells[6].Value?.ToString();
                tbbophan.Text = row.Cells[7].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            tbma.Clear();
            tbten.Clear();
            tbtuoi.Clear();
            tbphone.Clear();
            tbbophan.Clear();
            tbloai.Clear();
            tbluong.Clear();
            ckbgioitinh.Checked = false;
            tbma.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvEmloyee.CurrentRow == null) return;

            int idx = dgvEmloyee.CurrentRow.Index;

            if (idx >= 0 && idx < lst.Count)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    lst.RemoveAt(idx);
                    LoadGrid();
                }
            }
        }

        private void bntthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
           
            if (dgvEmloyee.CurrentRow == null || dgvEmloyee.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên cụ thể từ bảng để cập nhật!");
                return;
            }

          
            string maNhap = tbma.Text.Trim();

            
            Emloyee empUpdate = lst.Find(x => x.Id == maNhap);

            if (empUpdate == null)
            {
                MessageBox.Show($"Không tìm thấy nhân viên có mã {maNhap} để cập nhật. Bạn chỉ có thể sửa thông tin của nhân viên đã tồn tại!");
                return;
            }

            
            try
            {
               
                foreach (char c in tbten.Text)
                {
                    if (char.IsDigit(c)) { MessageBox.Show("Tên không được có số!"); return; }
                }

                
                string phone = tbphone.Text.Trim();
                if (phone.Length > 10 || !IsAllDigits(phone))
                {
                    MessageBox.Show("SĐT phải là số và không quá 10 ký tự!");
                    return;
                }

               
                empUpdate.Name = tbten.Text;
                empUpdate.Age = int.Parse(tbtuoi.Text);
                empUpdate.Gender = ckbgioitinh.Checked;
                empUpdate.PhoneNumber = phone;
                empUpdate.Part = tbbophan.Text;

                if (empUpdate is FullTime f)
                    f.WorkingDays = int.Parse(tbluong.Text);
                else if (empUpdate is PartTime p)
                    p.WorkingHours = int.Parse(tbluong.Text);

                LoadGrid();
                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng: " + ex.Message);
            }
        }

        private bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }
    }
    }