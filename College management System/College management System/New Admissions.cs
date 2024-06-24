using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_management_System
{
    public partial class New_Admissions : Form
    {
        int abc;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        
        public New_Admissions()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DESKTOP-JFUNDO4\SQLEXPRESS;Initial Catalog=collegeManagement;Integrated Security=True");
            conn.Open();
            cmd = new SqlCommand();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtFullName.Text;
            String mname = txtMotherName.Text;
            String gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64  mobile = Convert.ToInt64(txtMobile.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String program=txtProgramming.Text;
            String sname = txtSchoolName.Text;
            String duration = txtDuration.Text;
            String add = txtAddress.Text;

            
            //sqlConnection con = new sqlConnection();
            //con.ConnectionString = "data source= DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
            //SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into NewAdmission(fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres)values('" + name + "','" + mname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + add + "')";
            cmd.ExecuteNonQuery();

            //DA = new SqlDataAdapter(cmd);
            //DS = new DataSet();
            //DA.Fill(DS);
            //con.Close();
            conn.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();
        }

        private void New_Admissions_Load(object sender, EventArgs e)
        {
            //sqlConnection con = new sqlConnection();
            //con.ConnectionString = "data source= DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
            
            //SqlCommand cmd = new SqlCommand();
            //conn.Open();
            //cmd.Connection = conn  ;

           //cmd.CommandText="select max(NAID) from NewAdmission";
           DA = new SqlDataAdapter("select max(NAID) from NewAdmission", conn);
           DS = new DataSet();
            DA.Fill(DS);

             MessageBox.Show("Click on ok to open",DS.Tables[0].Rows[0][0].ToString());
            label13.Text = (abc+1).ToString();
           
            conn.Close();
        }

      

       

      
    }
}
