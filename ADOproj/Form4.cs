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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source =.; Initial Catalog = library; Integrated Security = True";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void BorrowBook(int memberId, int bookId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Check if the book is available
                        string checkQuery = "SELECT AvailableCopies FROM Books WHERE BookID = @BookID";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection, transaction);
                        checkCommand.Parameters.AddWithValue("@BookID", bookId);

                        int availableCopies = (int)checkCommand.ExecuteScalar();

                        if (availableCopies > 0)
                        {
                            // Insert into BorrowedBooks table
                            string insertQuery = "INSERT INTO BorrowedBooks (BookID, MemberID, BorrowDate) " +
                                                 "VALUES (@BookID, @MemberID, @BorrowDate)";

                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction);
                            insertCommand.Parameters.AddWithValue("@BookID", bookId);
                            insertCommand.Parameters.AddWithValue("@MemberID", memberId);
                            insertCommand.Parameters.AddWithValue("@BorrowDate", DateTime.Now);

                            insertCommand.ExecuteNonQuery();

                            // Update AvailableCopies in Books table
                            string updateQuery = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 " +
                                                 "WHERE BookID = @BookID";

                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                            updateCommand.Parameters.AddWithValue("@BookID", bookId);
                            updateCommand.ExecuteNonQuery();
                            transaction.Commit();

                            MessageBox.Show("Book borrowed successfully!");
                        }
                        else
                        {
                            MessageBox.Show("This book is not available.");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            int memberId = int.Parse(txtMemberID.Text);
            int bookId = int.Parse(txtBookID.Text);

            BorrowBook(memberId, bookId);
        }
    }
}
