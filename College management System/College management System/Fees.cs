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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
           if (txtRegNumber.Text != "")
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "select fname,mname,duration from NewAdmission where NAID = " + txtRegNumber.Text + "";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (DS1.Tables[0].Rows.Count != 0)
                {
                    fnameLabel.Text = DS1.Tables[0].Rows[0][0].ToString();
                    mnameLabel.Text = DS1.Tables[0].Rows[0][1].ToString();
                    durationLabel.Text = DS1.Tables[0].Rows[0][2].ToString();
                }

                else
                {
                    fnameLabel.Text = "________";
                    mnameLabel.Text = "________";
                    durationLabel.Text = "________";
                }
            }

            else
            {
                txtRegNumber.Text = "";
                txtRegNumber.Text = "";
                fnameLabel.Text = "________";
                mnameLabel.Text = "________";
                durationLabel.Text = "________";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fee where NAID = " + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count == 0)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-JFUNDO4\\SQLEXPRESS;database = collegeManagement;integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;

                cmd1.CommandText = "insert into fee (NAID,fee) values('" + txtRegNumber.Text + "','" + txtFees.Text + "')";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("fees Submission Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnameLabel.Text = "________";
                    mnameLabel.Text = "________";
                    durationLabel.Text = "________";
                }
            }
            else
            {
                MessageBox.Show("fees is Already Submitted.");
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "_______";
                mnameLabel.Text = "_______";
                durationLabel.Text = "_______";
            }







        }
    }
}
