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
    public partial class LoginForm : Form
    {

        public bool loginFlag { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(userText.Text, passText.Text);

            if(dt.Rows.Count > 0)
            {
                // valid
                MessageBox.Show("Login Ok");
                loginFlag = true;
            }
            else
            {
                // invalid
                MessageBox.Show("Login Failed");
                loginFlag = false;
            }

            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
