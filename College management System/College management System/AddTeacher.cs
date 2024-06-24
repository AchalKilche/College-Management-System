using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_management_System
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChecked = radioMale.Checked;
            if (isChecked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString="data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher(fname,gender,dob,mobile,email,semester,prog,yer,adr)values('" + txtFName.Text + "','" + gender + "','" + dateTimePickerDOB.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtSemester.Text + "','" + txtProgram.Text + "','" + txtDuration.Text + "','" + txtAddress.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

       

     
    }
}
