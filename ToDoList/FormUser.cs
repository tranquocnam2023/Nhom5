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
    public partial class FormUser : Form
    {
        List<CUser> users = new List<CUser>();
        public FormUser()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CUser user = new CUser();
            //user.ID = Convert.ToInt32(txtId.Text);
            //user.Name = txtUserName.Text;
            user.Email = txtEmail.Text;
            //user.Phone = txtPhoneUser.Text;
            
            users.Add(user);

            FormCongViec formLoginMenu = new FormCongViec();
            if (formLoginMenu.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormCongViec());
            }
        }

		private void pnUserMain_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
