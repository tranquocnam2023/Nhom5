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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CUser user = new CUser();
            user.Email = "a@gmail.com";
            user.Password = "1234";
			if (txtUsernameLogin.Text == user.Email)
            {
                if (txtPasswordLogin.Text == user.Password )
                {
					FormCongViec formLoginMenu = new FormCongViec();
                    this.Hide();
					if (formLoginMenu.ShowDialog() == DialogResult.OK)
					{
                        
						Application.Run(new FormCongViec());
					}
				}
                else
                {
                    MessageBox.Show(" Nhap sai mat khau roi ");
                }
            }
            else
            {
                MessageBox.Show(" Nhap sai username ");
            }
        }

		private void grbLogin_Enter(object sender, EventArgs e)
		{

		}

		private void pnMainLogin_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
