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
    public partial class ManageClassForm : Form
    {
        public int UserID { get; set; }
        public ManageClassForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTBLTableAdapter ada = new DataSet1TableAdapters.ClassesTBLTableAdapter();
            ada.AddClass(metroTextBox1.Text, UserID);
            Close();
        }

        private void FormAddClass_Load(object sender, EventArgs e)
        {

        }
    }
}
