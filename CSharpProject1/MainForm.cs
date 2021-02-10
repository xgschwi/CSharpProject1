using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject1
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ClassesTBL' table. You can move, or remove it, as needed.
            

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                // Open Login Form
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserID = newLogin.UserID;
                    statlblUser.Text = UserID.ToString();
                    loggedIn = 1;

                    this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);

                    classesTBLBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormAddClass addClass = new FormAddClass();
            addClass.UserID = this.UserID;
            addClass.ShowDialog();
        }
    }
}
