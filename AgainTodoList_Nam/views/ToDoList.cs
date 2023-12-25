using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgainTodoList_Nam.FileSave;
using AgainTodoList_Nam.Models;
using AgainTodoList_Nam.Services;
using System.Runtime.Serialization.Formatters.Binary;

namespace AgainTodoList_Nam.views
{
    public partial class ToDoList : Form 
    {
        //readonly UnfinishedImp unfinishedImp = new UnfinishedImp();
        readonly CompletedImp completedImp = new CompletedImp();
        private string email,pass;
        readonly FileFactory<CWork> fileFactory = new FileFactory<CWork>();
        readonly WorkImp workImp = new WorkImp();
        CWork currentWork = null;

        readonly FileFactory<CCompleted> listCompleted = new FileFactory<CCompleted>();
        private List<CCompleted> cCompleteds = new List<CCompleted>();
        CCompleted currentCompleted = null;

        private string emailOpenCompleted;
        private string email1; // lưu các công việc đã hoàn thành
        public ToDoList()
        {
            InitializeComponent();
        }

        public ToDoList(string email,string pass)
        {
            InitializeComponent();
            this.email = email;
            this.pass = pass;   
        }

        private void btnAddCV_Click(object sender, EventArgs e)
        {
            CWork cWork = new CWork();
            cWork.Name = txtNameCV.Text;
            cWork.Created = DateTime.Now;

            CCompleted end = new CCompleted();
            end.Name = txtNameCV.Text;
            end.Created = DateTime.Now;
            end.END = DateTime.Now;


            workImp.create(end);
            dgvToDoList.DataSource = workImp.GetAll().ToList();

            clearBox();
            dgvToDoList.ClearSelection();

        }

        private void clearBox()
        {
            txtNameCV.Clear();
        }

        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
            if (currentWork!=null)
            {
                workImp.delete(currentWork);
                dgvToDoList.DataSource = workImp.GetAll().ToList();
                clearBox();
                dgvToDoList.ClearSelection();
            }
            else
            {
                MessageBox.Show(" ID doeasn't exists ");
            }
        }

        private void dgvToDoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                currentWork = (CWork)dgvToDoList.Rows[e.RowIndex].DataBoundItem; ;
                txtNameCV.Text = currentWork.Name.ToString();

                currentCompleted = (CCompleted)dgvToDoList.Rows[e.RowIndex].DataBoundItem;
                txtNameCV.Text = currentCompleted.Name.ToString();
            }
        }

        private void btnUpdateCV_Click(object sender, EventArgs e)
        {
            if (currentWork!=null)
            {
                currentWork.Name = txtNameCV.Text;
                currentWork.Created = DateTime.Now;

                dgvToDoList.DataSource = workImp.GetAll().ToList();
                clearBox();
                dgvToDoList.ClearSelection();
            }
            else
            {
                MessageBox.Show(" ID doesn't exists ");
            }
        }



        private void ToDoList_Load(object sender, EventArgs e)
        {
            foreach (CSignUp item in CLogin.signUpLists)
            {
                if (item.EMAIL == email) 
                {
                    string path = Application.StartupPath+email;
                    if (System.IO.File.Exists(path))
                    {
                        workImp.setAll(fileFactory.LoadFile(path));
                        dgvToDoList.DataSource = workImp.GetAll().ToList() ;
                    }
                }
            }            
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            email1 = email;
            emailOpenCompleted = "completed" + email1;

            string path1 = Application.StartupPath+emailOpenCompleted;
            if (System.IO.File.Exists(path1))
            {
                completedImp.SETALL(listCompleted.LoadFileCompleted(path1));
                cCompleteds = completedImp.GetAll();
            }

            if (currentWork!=null || currentCompleted!=null)
            {
                //CCompleted.listCompletedWork.Add(currentWork);
                cCompleteds.Add(currentCompleted);
                string path = Application.StartupPath+emailOpenCompleted;
                //bool result = fileFactory.SaveFile(CCompleted.listCompletedWork, path);
                bool result = listCompleted.SaveFile(cCompleteds, path);
                if (result)
                {
                    MessageBox.Show(" Task Completed ");
                    lvCompleted openCompleted = new lvCompleted(emailOpenCompleted);
                    openCompleted.ShowDialog();
                }
                workImp.delete(currentWork);
                dgvToDoList.DataSource = workImp.GetAll().ToList();
                clearBox();
                dgvToDoList.ClearSelection();
            }

        }

        private void mnuWorkCompleted_Click(object sender, EventArgs e)
        {
            email1 = email;
            emailOpenCompleted = "completed" + email1;
            string path = Application.StartupPath+emailOpenCompleted;
            if (System.IO.File.Exists(path))
            {
                lvCompleted openCompleted = new lvCompleted(emailOpenCompleted);
                openCompleted.ShowDialog();
            }
            else
            {
                lvCompleted openCompleted = new lvCompleted();
                openCompleted.ShowDialog();
            }
        }

		private void dgvToDoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void pnToDoMain_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSaveCV_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath+email;
            bool result = fileFactory.SaveFile(workImp.GetAll(),path);
            if (result)
            {
                MessageBox.Show(" Save success ");
            }
        }
    }
}
