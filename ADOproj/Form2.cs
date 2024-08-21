using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_BookID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source =.; Initial Catalog = library; Integrated Security = True";
            string query = "INSERT INTO Books (BookID, Title, Author, ISBN, PublishedYear, Genre, AvailableCopies) " +
                  "VALUES (@BookID, @Title, @Author, @ISBN, @PublishedYear, @Genre, @AvailableCopies)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookID", txt_BookID.Text);
                    cmd.Parameters.AddWithValue("@Title", tbx_Title.Text);
                    cmd.Parameters.AddWithValue("@Author", tbx_Author.Text);
                    cmd.Parameters.AddWithValue("@ISBN", tbx_ISBN.Text);
                    cmd.Parameters.AddWithValue("@PublishedYear", tbx_year.Text);
                    cmd.Parameters.AddWithValue("@Genre", tbx_genre.Text);
                    cmd.Parameters.AddWithValue("@AvailableCopies", textBox6.Text);

                    try
                    {
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Book added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error adding book.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }


            /*SqlCommand cmd = new SqlCommand(query, con);
            //Open Connection
            DataTable dt = new DataTable();
            SqlDataAdapter adpater = new SqlDataAdapter(cmd);
            adpater.Fill(dt);*/
            //Execute Command
            //SqlDataReader dr = cmd.ExecuteReader();
            //        if (dt.Rows.Count == 0)
            //       {
            //          MessageBox.Show("No Data Found", "Error No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //         tbx_ID.Text = tbx_Name.Text = tbx_Salary.Text = "";
            //        tbx_ID.Focus();
            //   }
            //         else
            //         {
            //             tbx_Name.Text = dt.Rows[0]["FirstName"].ToString();
            //           tbx_Salary.Text = dt.Rows[0]["Salary"].ToString();

            //         MessageBox.Show("I Found Your Data", "Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //   }
            //Close Connection

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }


    }
}
