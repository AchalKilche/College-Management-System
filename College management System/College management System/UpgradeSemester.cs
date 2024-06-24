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
    public partial class UpgradeSemester : Form
    {
        string comboBoxFrom;
        string comboBoxTo;
        public UpgradeSemester()
        {
            InitializeComponent();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Semester Update Warning !", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection =con;

                cmd.CommandText = "update NewAdmission set semester= '" +comboBoxTo+ "' where semester ='" + comboBoxFrom+ "')";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Upgrade Successful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upgrade cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
