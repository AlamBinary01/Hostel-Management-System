﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class student_signup : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public student_signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stlogin_btn_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO STUDENTlogin VALUES('" +student_username.Text+"','"+student_password.Text+"','"+cninc_t.Text+"')";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!! ");
            }
            ocl.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_login l = new student_login();
            l.Show();
        }

        private void password_staff_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
