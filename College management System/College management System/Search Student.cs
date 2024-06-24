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
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.NAID,NewAdmission.fname,NewAdmission.mname,NewAdmission.gender,NewAdmission.dob,NewAdmission.mobile,NewAdmission.email,NewAdmission.semester,NewAdmission.prog,NewAdmission.sname,NewAdmission.duration,NewAdmission.addres,fee.fee as fee from NewAdmission inner join fee on NewAdmission.NAID =fee.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"demo");

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID="+textBox1.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

      
    }
}
