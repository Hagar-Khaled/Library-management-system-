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
using System.Xml.Linq;

namespace ADOproj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
     private string connectionString = "Data Source =.; Initial Catalog = library; Integrated Security = True";

        private void button1_Click(object sender, EventArgs e)
        {



            string memberName = textBox1.Text;
            string email = textBox2.Text;
            string phoneNumber = textBox3.Text;
            DateTime joinDate = DateTime.Now;

            AddMember(memberName, email, phoneNumber, joinDate);

        }

        private void AddMember(string name, string email, string phoneNumber, DateTime joinDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Members (Name, Email, PhoneNumber, JoinDate) " +
                               "VALUES (@Name, @Email, @PhoneNumber, @JoinDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@JoinDate", joinDate);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Member added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error adding member.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }
    }



    }
