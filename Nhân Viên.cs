using System;
using System.Windows.Forms;

namespace btvn_buoi4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ms => txtMaso.Text;
        public string us => txtTen.Text;
        public string luong => txtLuong.Text;

        public void SetData(string maso, string ten, string luong)
        {
            txtMaso.Text = maso;
            txtTen.Text = ten;
            txtLuong.Text = luong;

           

        }

        private void btnoke_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ms) || string.IsNullOrWhiteSpace(us) || string.IsNullOrWhiteSpace(luong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnskip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
