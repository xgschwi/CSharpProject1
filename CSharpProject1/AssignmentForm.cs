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
    public partial class AssignmentForm : Form
    {

        public int ClassID { get; set; }
        public string ClassName { get; set; }

        public AssignmentForm()
        {
            InitializeComponent();
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.AssignmentsTBL' table. You can move, or remove it, as needed.
            this.assignmentsTBLTableAdapter.Fill(this.dataSet1.AssignmentsTBL);
            labelClassID.Text = ClassID.ToString();
            labelClassName.Text = ClassName;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.assignmentsTBLBindingSource.EndEdit();
            this.assignmentsTBLTableAdapter.Update(dataSet1.AssignmentsTBL);
        }
    }
}
