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
    public partial class Form5 : Form
    {
        private string connectionString = "Data Source =.; Initial Catalog = library; Integrated Security = True";

        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string borrowID = txtBorrowID.Text.Trim();
            string conn = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            
            string updateQuery = "UPDATE BorrowedBooks SET ReturnDate = @ReturnDate WHERE BorrowID = @BorrowID; " +
                        "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = " +
                        "(SELECT BookID FROM BorrowedBooks WHERE BorrowID = @BorrowID)";

            using (SqlConnection connection = new SqlConnection(conn))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@BorrowID", borrowID);
                command.Parameters.AddWithValue("@ReturnDate", DateTime.Now);

                try
                {
                    connection.Open();

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Book returned successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error returning book. Please check the BorrowID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            //int borrowId = int.Parse(txtBorrowID.Text);
            // ReturnBook(borrowId);
        }

/*        private void ReturnBook(int borrowId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateReturnDateQuery = "UPDATE BorrowedBooks SET ReturnDate = @ReturnDate WHERE BorrowID = @BorrowID";
                        SqlCommand updateReturnDateCommand = new SqlCommand(updateReturnDateQuery, connection, transaction);
                        updateReturnDateCommand.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                        updateReturnDateCommand.Parameters.AddWithValue("@BorrowID", borrowId);
                        updateReturnDateCommand.ExecuteNonQuery();

                        string getBookIdQuery = "SELECT BookID FROM BorrowedBooks WHERE BorrowID = @BorrowID";
                        SqlCommand getBookIdCommand = new SqlCommand(getBookIdQuery, connection, transaction);
                        getBookIdCommand.Parameters.AddWithValue("@BorrowID", borrowId);
                        int bookId = (int)getBookIdCommand.ExecuteScalar();

                        string updateAvailableCopiesQuery = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID";
                        SqlCommand updateAvailableCopiesCommand = new SqlCommand(updateAvailableCopiesQuery, connection, transaction);
                        updateAvailableCopiesCommand.Parameters.AddWithValue("@BookID", bookId);
                        updateAvailableCopiesCommand.ExecuteNonQuery();
                       
                        transaction.Commit();
                        MessageBox.Show("Book returned successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
*/    }
}
