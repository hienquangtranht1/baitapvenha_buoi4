using System;
using System.Windows.Forms;

namespace btvn_buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string NVID)
        {
            for (int i = 0; i < dvgGVT.Rows.Count; i++)
            {
                if (dvgGVT.Rows[i].Cells[0].Value?.ToString() == NVID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (Form2 frm = new Form2())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int selectedRow = GetSelectedRow(frm.ms);
                    if (selectedRow == -1) 
                    {
                        selectedRow = dvgGVT.Rows.Add();
                        InsertUpdate(selectedRow, frm);
                    }
                    else
                    {
                        MessageBox.Show("Mã số nhân viên đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void InsertUpdate(int selectedRow, Form2 frm)
        {
            dvgGVT.Rows[selectedRow].Cells[0].Value = frm.ms;     
            dvgGVT.Rows[selectedRow].Cells[1].Value = frm.us;     
            dvgGVT.Rows[selectedRow].Cells[2].Value = frm.luong; 
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (dvgGVT.CurrentRow != null)
            {
                int selectedRow = dvgGVT.CurrentRow.Index;
                string currentID = dvgGVT.Rows[selectedRow].Cells[0].Value.ToString();

                using (Form2 frm = new Form2())
                {
                    frm.SetData(currentID, dvgGVT.Rows[selectedRow].Cells[1].Value.ToString(), dvgGVT.Rows[selectedRow].Cells[2].Value.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        InsertUpdate(selectedRow, frm);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgGVT.CurrentRow != null)
            {
                var result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRow = dvgGVT.CurrentRow.Index;
                    dvgGVT.Rows.RemoveAt(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
