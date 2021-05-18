using CSharpProject1.DataSet1TableAdapters;
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


        private void FormAddClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ClassesTBL' table. You can move, or remove it, as needed.
            this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ClassesTBLTableAdapter clada = new ClassesTBLTableAdapter();
            clada.AddClass(metroTextBox1.Text, UserID);

            // Updates Tables with new Class
            this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
        }

        // Remove Classes
        private void metroButton2_Click(object sender, EventArgs e)
        {
            ClassesTBLTableAdapter clada = new ClassesTBLTableAdapter();
            clada.RemoveClass((int)metroComboBox1.SelectedValue, UserID);

            // Updates Tables
            this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
        }
    }
}
