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

        public void add()
        {
            MySqlConnection conn = ConnectionDB.getConnection();

            String addMovieQuery = "INSERT INTO movie (title, price) VALUES (@title, @price)";
            MySqlCommand cmdMovie = new MySqlCommand(addMovieQuery, conn);
            cmdMovie.Parameters.AddWithValue("@title", txt_movieName.Text);
            cmdMovie.Parameters.AddWithValue("@price", txt_moviePrice.Text);

            try
            {
                conn.Open();

                int rowsAffected = cmdMovie.ExecuteNonQuery();
                     
                String addShowtimeQuery = "INSERT INTO showtime (date) VALUES (@date)";
                MySqlCommand cmdShowtime = new MySqlCommand(addShowtimeQuery, conn);
                cmdShowtime.Parameters.AddWithValue("@date", setDate.Text);

                int rowsAffected1 = cmdShowtime.ExecuteNonQuery();

                if (rowsAffected1 > 0 && rowsAffected > 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
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
            add();
        }
    }
}
