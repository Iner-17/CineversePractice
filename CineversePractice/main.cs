using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CineversePractice
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public async Task addAsync()
        {
            MySqlConnection conn = ConnectionDB.getConnection();

            try
            {
                conn.Open();

                // Add movie
                string addMovieQuery = "INSERT INTO movie (title, price) VALUES (@title, @price)";
                MySqlCommand cmdMovie = new MySqlCommand(addMovieQuery, conn);
                cmdMovie.Parameters.AddWithValue("@title", txt_movieName.Text);
                cmdMovie.Parameters.AddWithValue("@price", txt_moviePrice.Text);
                cmdMovie.ExecuteNonQuery();  // Insert movie without retrieving movie_id

                // Add showtime with movie_id retrieved using LAST_INSERT_ID()
                string addShowtimeQuery = "INSERT INTO showtime (movie_id, date) VALUES (LAST_INSERT_ID(), @date)";
                MySqlCommand cmdShowtime = new MySqlCommand(addShowtimeQuery, conn);
                cmdShowtime.Parameters.AddWithValue("@date", setDate.Text);
                cmdShowtime.ExecuteNonQuery();  // Insert showtime using LAST_INSERT_ID() directly

                MessageBox.Show("Successfully added movie and showtime.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addAsync();
        }
    }
}
