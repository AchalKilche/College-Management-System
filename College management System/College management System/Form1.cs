using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace College_management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox1.Text;
           
            if (username =="student" && password =="student")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                rectangleShape2.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            New_Admissions na = new New_Admissions();
            na.Show();
        
        }

        private void upgradeSemesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void fEESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

       
        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndivisualDetail sid = new StudentIndivisualDetail();
            sid.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Teachers st = new Search_Teachers();
            st.Show();
        }

        private void rEMOVESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student ss = new Search_Student();
            ss.Show();
        }
        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }
       

        private void eXITSYSTEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?This will Delete Your Unsaved Data", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
