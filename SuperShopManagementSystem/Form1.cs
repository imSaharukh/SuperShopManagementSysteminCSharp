﻿using Dapper;
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

namespace SuperShopManagementSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("\nUsername: "+txtboxUserName.Text+"\nPassword: "+txtPass.Text, "Info");
            SqlConnection connection = new  SqlConnection(@"Server=tcp:supershop.database.windows.net,1433;Database=supershop;User ID=supershop;Password=Saharukh123##;Trusted_Connection=False;Encrypt=True;");
            //connection.Open();
            //SqlCommand sqlCommand = new SqlCommand("select * from UserTable",connection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataSet dataSet = new DataSet();
            //sqlDataAdapter.Fill(dataSet);

            IDbConnection db = new SqlConnection(@"Server=tcp:supershop.database.windows.net,1433;Database=supershop;User ID=supershop;Password=Saharukh123##;Trusted_Connection=False;Encrypt=True;");


            var user = db.Query<Models.User>("Select * From UserTable").ToList();
            db.Close();
            MessageBox.Show(user[0].role);

            
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
