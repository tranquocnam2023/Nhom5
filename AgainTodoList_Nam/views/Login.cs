using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgainTodoList_Nam.FileSave;
using AgainTodoList_Nam.Models;
using AgainTodoList_Nam.Services;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AgainTodoList_Nam.views
{
    public partial class Login : Form
    {
        readonly FileFactory<CSignUp> fileFactory = new FileFactory<CSignUp>();
        readonly SignUpImp _signUpImp = new SignUpImp();
        bool ischecked = false;

        public Login()
        {
            InitializeComponent();
            lbWelcome.Text+="         ";
            timeWelCome.Start();
        }

        private void showCombobox()
        {
            cmbEmail.Items.Clear();
            foreach (CSignUp item in CLogin.signUpLists)
            {
                cmbEmail.Items.Add(item);
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            foreach (CSignUp item in CLogin.signUpLists)
            {
                if (item.EMAIL == cmbEmail.Text)
                {
                    if (item.PASS == txtPasswordLogin.Text)
                    {
                        ToDoList toDoList = new ToDoList(cmbEmail.Text,txtPasswordLogin.Text);
                        this.Hide();
                        toDoList.ShowDialog();
                        return;
                        //break;
                    }
                    else
                    {
                        MessageBox.Show(" Password Incorrect ");
                        return;
                    }
                }
                if (cmbEmail.Text!= item.EMAIL)
                {
                    if (txtPasswordLogin.Text!=item.PASS)
                    {
                        MessageBox.Show(" Invalid Email ");
                    }
                }
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(); // tạo 1 form đăng ký mới
            if (signUp.ShowDialog()== DialogResult.OK)
            {
                showCombobox();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\signUp.txt";
            if (System.IO.File.Exists(path))
            {
                _signUpImp.setAll(fileFactory.LoadFile(path));

            }

            CLogin.signUpLists = _signUpImp.GetAll();

            showCombobox() ;
            return;
        }

        private void timeWelCome_Tick(object sender, EventArgs e)
        {
            lbWelcome.Text = lbWelcome.Text.Substring(1,lbWelcome.Text.Length - 1) + lbWelcome.Text.Substring(0,1);
        }

        private void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void txtPasswordLogin_TextChanged(object sender, EventArgs e)
		{
            
		}
	}
}
