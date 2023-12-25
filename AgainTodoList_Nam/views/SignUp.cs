using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AgainTodoList_Nam.Models;
using AgainTodoList_Nam.Services;
using AgainTodoList_Nam.FileSave;


namespace AgainTodoList_Nam.views
{
    public partial class SignUp : Form
    {
        readonly SignUpImp _signUpImp = new SignUpImp();
        readonly FileFactory<CSignUp> fileFactory = new FileFactory<CSignUp>();
        bool ischecked = false;

        public SignUp()
        {
            InitializeComponent();
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ischecked = true;
            CSignUp signUp = new CSignUp();
            signUp.EMAIL= txtEmailSignUp.Text;
            if (!checkEmail(signUp.EMAIL))
            {
                MessageBox.Show(" Please enter the correct email format ");
                return;
            }
            signUp.PASS= txtPasswordSignUp.Text;
            string re_pass = txtReSignPassword.Text;
            if (re_pass != signUp.PASS)
            {
                MessageBox.Show(" Password Incorrect ");
                return;
            }

            CLogin.signUpLists.Add(signUp);

            if (ischecked)
            {
                DialogResult=DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

            string path = Application.StartupPath +"\\signUp.txt";
            bool result = fileFactory.SaveFile(_signUpImp.GetAll(), path);
            if (result)
            {
                MessageBox.Show("Sign Up susccessfully");
            }
            this.Close();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\signUp.txt";
            if (System.IO.File.Exists(path))
            {
                _signUpImp.setAll(fileFactory.LoadFile(path));

            }
            CLogin.signUpLists = _signUpImp.GetAll();
            ischecked = true;
            return;
        }

		private void txtEmailSignUp_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPasswordSignUp_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtReSignPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
