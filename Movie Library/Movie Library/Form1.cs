
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Movie_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MovieName from movies", connection);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Movies.Items.Add(dr["MovieName"].ToString());
            }

        }




        private void add_btn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";


            SqlConnection conn = new SqlConnection(connString);

            // Get the values entered by the user in the form. 
            string id = ID_add.Text;
            string name = name_add.Text;
            string director = director_add.Text;
            string genre = genre_add.Text;

            // Construct an INSERT SQL statement that includes the values entered by the user.
            string cmdText = "INSERT INTO [Movies].[dbo].[movies](ID, MovieName, director, genre)";
            cmdText += "VALUES (" + id + ", '" + name + "', '" + director + "', '" + genre + "')";

            // Create a new SqlCommand object with the connection and command text.
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            try
            {
                // Open the database connection.
                conn.Open();

                // Execute the SQL command to insert a new row.
                cmd.ExecuteNonQuery();

                //empty the textboxes

                // Clear the text boxes.
                ID_add.Clear(); // Set the numeric up-down value to 0.
                name_add.Clear(); // Clear the first name text box.
                director_add.Clear(); // Clear the last name text box.
                genre_add.Clear(); // Clear the email text box.


            }
            catch (Exception ex)
            {
                // If an error occurs, show an error message with the exception message.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the database connection.
                conn.Close();
            }
        }

        private void ID_search_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MovieName from movies WHERE ID like '%" + ID_search.Text + "%'", connection);
            da.Fill(dt);

            try
            {
                Movies.DataSource = null;
                Movies.DataSource = dt;
                Movies.DisplayMember = "MovieName";


            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_search_TextChanged(object sender, EventArgs e)
        {

            // Perform a database query to retrieve the filtered items
            string connectionString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MovieName from movies WHERE MovieName like '%" + name_search.Text + "%'", connection);
            da.Fill(dt);

            try
            {
                Movies.DataSource = null;
                Movies.DataSource = dt;
                Movies.DisplayMember = "MovieName";


            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Movies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void director_search_TextChanged(object sender, EventArgs e)
        {
            // Perform a database query to retrieve the filtered items
            string connectionString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MovieName from movies WHERE director like '%" + director_search.Text + "%'", connection);
            da.Fill(dt);

            try
            {
                Movies.DataSource = null;
                Movies.DataSource = dt;
                Movies.DisplayMember = "MovieName";


            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void genre_search_TextChanged(object sender, EventArgs e)
        {
            // Perform a database query to retrieve the filtered items
            string connectionString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MovieName from movies WHERE genre like '%" + genre_search.Text + "%'", connection);
            da.Fill(dt);

            try
            {
                Movies.DataSource = null;
                Movies.DataSource = dt;
                Movies.DisplayMember = "MovieName";


            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void genre_rec_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MovieName FROM movies WHERE genre like '%" + genre_rec.Text + "%' ORDER BY NEWID()", connection);
            da.Fill(dt);

            try
            {
                Recommend.DataSource = null;
                Recommend.DataSource = dt;
                Recommend.DisplayMember = "MovieName";


            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operations
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";


            SqlConnection conn = new SqlConnection(connString);

            // Get the values entered by the user in the form. 
            string id = ID_mod.Text;
            string name = name_mod.Text;
            string director = director_mod.Text;
            string genre = genre_mod.Text;

            string cmdText = "UPDATE [Movies].[dbo].[movies] SET MovieName = '" + name + "', director = '" + director + "', genre = '" + genre + "' WHERE ID = " + id;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            try
            {
                // This opens the database connection.
                conn.Open();

                // This executes the SQL command and returns the number of rows affected.
                int rowsAffected = cmd.ExecuteNonQuery();

                // If no rows were affected, the user is informed that the user was not found.
                if (rowsAffected == 0)
                {
                    MessageBox.Show("User not found.");
                }
                // If rows were affected, the user is informed that the user information was updated.
                else
                {
                    MessageBox.Show("movie information updated.");

                    // Clear the text boxes.
                    ID_add.Clear(); // Set the numeric up-down value to 0.
                    name_mod.Clear(); // Clear the first name text box.
                    director_mod.Clear(); // Clear the last name text box.
                    genre_mod.Clear(); // Clear the email text box.
                                       // Clear the password text box.
                }
            }
            // If an exception is thrown, the user is informed that an error occurred and the exception message is displayed.
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            // This closes the database connection.
            finally
            {
                conn.Close();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(local);Initial Catalog=Movies;Integrated Security=True;TrustServerCertificate=True";


            SqlConnection conn = new SqlConnection(connString);

            // Get the values entered by the user in the form. 
            string id = ID_del.Text;
            

            string cmdText = "Delete from [Movies].[dbo].[movies]  WHERE ID = " + id;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            try
            {
                // This opens the database connection.
                conn.Open();

                // This executes the SQL command and returns the number of rows affected.
                int rowsAffected = cmd.ExecuteNonQuery();

                // If no rows were affected, the user is informed that the user was not found.
                if (rowsAffected == 0)
                {
                    MessageBox.Show("User not found.");
                }
                // If rows were affected, the user is informed that the user information was updated.
                else
                {
                    MessageBox.Show("movie deleted.");

                    // Clear the text boxes.
                    ID_add.Clear(); // Set the numeric up-down value to 0.
                     // Clear the email text box.
                                       // Clear the password text box.
                }
            }
            // If an exception is thrown, the user is informed that an error occurred and the exception message is displayed.
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            // This closes the database connection.
            finally
            {
                conn.Close();
            }
        }
    }
}


