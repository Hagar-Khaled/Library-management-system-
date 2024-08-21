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

namespace ADOproj
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            string connectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            string query = "SELECT * FROM Books";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                dgvBooks.DataSource = booksTable;  
            }
        }
        private void LoadMembers()
        {
            string connectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            string query = "SELECT * FROM Members";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable membersTable = new DataTable();
                adapter.Fill(membersTable);

                dgvBooks.DataSource = membersTable;  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }
    }
}
