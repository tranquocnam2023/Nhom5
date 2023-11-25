using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class FormCongViec : Form
    {
        List<CongViec> list =new List<CongViec>();

        private void HienThi()
        {
            dgvCongViec.DataSource = list.ToList();
        }

        private CongViec timMa(int ma)
        {
            foreach (CongViec item in list)
            {
                if (item.ID == ma)
                {
                    return item;
                }
            }
            return null;
        }

        public FormCongViec()
        {
            InitializeComponent();
        }

        private void txtIdCongViec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCongViec_Click(object sender, EventArgs e)
        {
            CongViec congViec = new CongViec();
            congViec.ID = Convert.ToInt32(txtIdCongViec.Text);
            congViec.Name = txtTenCongViec.Text;
            congViec.Time = dptNgayBD.Value.Date;
            if (timMa(congViec.ID)==null)
            {
                list.Add(congViec);
                HienThi();
            }
            else
            {
                MessageBox.Show(" Da ton tai ");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CongViec congviec = new CongViec();
            congviec = timMa(Convert.ToInt32(txtIdCongViec.Text));
            if (congviec.ID!=null)
            {
                congviec.Name = txtTenCongViec.Text;
                congviec.Time = dptNgayBD.Value.Date;
                HienThi();
            }
            else
            {
                MessageBox.Show(" Ko tim thay ma ");
            }
        }

        private void dgvCongViec_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCongViec.Text = dgvCongViec.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenCongViec.Text = dgvCongViec.Rows[e.RowIndex].Cells[1].Value.ToString();
            dptNgayBD.Value = Convert.ToDateTime(dgvCongViec.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CongViec congViec = new CongViec();
            congViec = timMa(Convert.ToInt32(txtIdCongViec.Text));

            if (congViec.ID!=null)
            {
                list.Remove(congViec);
                HienThi();
            }
            else
            {
                MessageBox.Show(" Ko ton tai ma ");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            CongViec congViec = new CongViec();
            congViec = timMa(Convert.ToInt32(txtTim.Text));

            foreach (CongViec item in list)
            {
                if (item.ID == congViec.ID)
                {
                    MessageBox.Show(" Tim thay roi " + item.ID+" / " + item.Name+" / "+item.Time);
                }
            }

        }

		private void pnCongViecMain_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
