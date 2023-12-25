using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AgainTodoList_Nam.Models;
using AgainTodoList_Nam.Services;
using AgainTodoList_Nam.FileSave;
using System.Globalization;

namespace AgainTodoList_Nam.views
{
    public partial class lvCompleted : Form
    {
        private string email;
        readonly private FileFactory<CCompleted> fileFactory = new FileFactory<CCompleted>();

        readonly private CompletedImp completedImp = new CompletedImp();

        private List<CCompleted> listCompleted = new List<CCompleted>();


        private string ListViewContentOpen;
        

        public lvCompleted()
        {
            InitializeComponent();
        }

        public lvCompleted(string email1)
        {
            InitializeComponent();
            email = email1;
        }

        private void Completed_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + email;
            if (System.IO.File.Exists(path))
            {
                completedImp.SETALL(fileFactory.LoadFileCompleted(path));
            }

            listCompleted = completedImp.GetAll();

            ListViewContentOpen = "LVCO" + email + ".txt";

            string path1 = Application.StartupPath + ListViewContentOpen;

            ListViewItem lvItem = null;


            if (System.IO.File.Exists(path1)) // nếu file tồn tại thì sẽ xuất ra giá trị trong listView
            {

                #region 
                
                string[] lines = File.ReadAllLines(path1);

                foreach (string item in lines)
                {
                    string[] values = item.Split(',');

                    if (item.Length>=3)
                    {
                        lvItem = new ListViewItem(values[0]);
                        lvItem.SubItems.Add(values[1]);
                        lvItem.SubItems.Add(values[2]);
                        lstViewComplete.Items.Add(lvItem);
                    }
                }

                while (listCompleted.Count > lstViewComplete.Items.Count)
                {
                    for (int i = listCompleted.Count; i >= 0; i++)
                    {
                        i--;

                        lvItem = new ListViewItem(listCompleted[i].Name);

                        DateTime dtCreate = DateTime.Parse(listCompleted[i].Created.ToString());
                        string created = dtCreate.ToString("dd/M/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                        lvItem.SubItems.Add(created);

                        listCompleted[i].END = DateTime.Now;

                        DateTime dtEnd = DateTime.Parse(listCompleted[i].END.ToString());
                        string end = dtEnd.ToString("dd/M/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                        lvItem.SubItems.Add(end);

                        lstViewComplete.Items.Add(lvItem);

                        using (StreamWriter writeLV = new StreamWriter(path1))
                        {
                            foreach (ListViewItem item1 in lstViewComplete.Items)
                            {
                                string line = $"{item1.SubItems[0].Text}, {item1.SubItems[1].Text} , {item1.SubItems[2].Text}";
                                writeLV.WriteLine(line);
                            }

                            writeLV.Close();
                        }
                        break;
                    }

                    break;
                }


                #endregion


            }
            else
            {
                foreach (CCompleted item in listCompleted)
                {
                    lvItem = new ListViewItem(item.Name);

                    DateTime dtCreate = DateTime.Parse(item.Created.ToString());
                    string created = dtCreate.ToString("dd/M/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    lvItem.SubItems.Add(created);
                      
                    item.END = DateTime.Now;

                    DateTime dtEnd = DateTime.Parse(item.END.ToString());
                    string end = dtEnd.ToString("dd/M/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    lvItem.SubItems.Add(end);

                    lstViewComplete.Items.Add(lvItem);

                   using (StreamWriter writeLV =  new StreamWriter(path1))
                    {
                        foreach (ListViewItem item1 in lstViewComplete.Items)
                        {
                            string line = $"{item1.SubItems[0].Text}, {item1.SubItems[1].Text} , {item1.SubItems[2].Text}";
                            writeLV.WriteLine(line);    
                        }

                        writeLV.Close();
                    }

                }
            }
        }

        private void lstViewComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lvCompleted_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show(" Bạn có muốn thoát ", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Question)==DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pnUnfinishedIcon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
