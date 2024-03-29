﻿using CSharpProject1.DataSet1TableAdapters;
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
                    dateTimePicker1.Value = DateTime.Today.AddDays(-7);
                }
            }
        }

        // Add A Class
        private void metroButton3_Click(object sender, EventArgs e)
        {
            ManageClassForm addClass = new ManageClassForm();
            addClass.UserID = this.UserID;
            addClass.ShowDialog();

            // Updates Classes to choose from in Main Form
            metroComboBox1.DataSource = null;
            ClassesTBLTableAdapter clada = new ClassesTBLTableAdapter();
            metroComboBox1.DataSource = clada.GetData();
            metroComboBox1.DisplayMember = "ClassName";

            /* Alternative to above
             * this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
            */
        }
        

        // Add an assignment for the currently selected Class
        private void metroButton4_Click(object sender, EventArgs e)
        {
            AssignmentForm assignments = new AssignmentForm();
            assignments.ClassName = metroComboBox1.Text;
            assignments.ClassID = (int)metroComboBox1.SelectedValue;
            assignments.ShowDialog();
        }

        // Saving Changes to Assignments Data
        private void metroButton5_Click(object sender, EventArgs e)
        {
            // Check if records exists, if yes load for editing. If not, create record and load for edit
           
            AssignmentsTBLTableAdapter ada = new AssignmentsTBLTableAdapter();
            DataTable dt = ada.GetDataByClassDate((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            if(dt.Rows.Count > 0)
            {
                // Records are present
                foreach(DataRow row in dt.Rows)
                {

                    // Mark as Late
                    if (DateTime.Parse(row[3].ToString()) < System.DateTime.Now && row[4].ToString() != "Complete")
                    {
                        ada.UpdateStatus("Late", row[1].ToString(), (int) row[2]);
                        dt = ada.GetDataByClassDate((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                    }

                    // Mark as In Progress
                    else if (DateTime.Parse(row[3].ToString()) > System.DateTime.Now && row[4] == null)
                    {
                        ada.UpdateStatus("In Progress", row[1].ToString(), (int)row[2]);
                        dt = ada.GetDataByClassDate((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                    }
                }
                dataGridView1.DataSource = dt;
            }
            else MessageBox.Show("No assignments present");
        }

        // Save Changes to Assignments
        private void metroButton1_Click(object sender, EventArgs e)
        {
            AssignmentsTBLTableAdapter ada = new AssignmentsTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    ada.UpdateQuery(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), (int)metroComboBox1.SelectedValue);
                }

                if(row.Cells[2].Value != null && row.Cells[2].Value.ToString() != "Late")
                {
                    ada.UpdateStatus(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString(), (int)metroComboBox1.SelectedValue);
                }
            }
        }

    }
}
