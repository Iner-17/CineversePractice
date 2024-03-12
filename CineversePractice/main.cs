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
using Google.Protobuf.WellKnownTypes;
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

            
            try
            {

                conn.Open();
                string InsertMovieQuery = "INSERT INTO movies (movie_title, movie_price, movie_duration) VALUES (@title, @price, @duration);";
                MySqlCommand insertMovieCmd = new MySqlCommand(InsertMovieQuery, conn);
                insertMovieCmd.Parameters.AddWithValue("@title", txt_movieName.Text);
                insertMovieCmd.Parameters.AddWithValue("@price", textBox1.Text);
                insertMovieCmd.Parameters.AddWithValue("@duration", txt_duration.Text);
                insertMovieCmd.ExecuteNonQuery();



                int movieId = (int)insertMovieCmd.LastInsertedId;
                
                foreach (string date in cbx_datesList.Items)
                {
                    foreach (string time in cbx_timeList.Items)
                    {

                        string insertScreeningQuery = "INSERT INTO screenings (movie_id, date, time_start) VALUES (@movieId, @date, @time);";
                        MySqlCommand insertScreeningCmd = new MySqlCommand(insertScreeningQuery, conn);
                        insertScreeningCmd.Parameters.AddWithValue("@movieId", movieId);
                        insertScreeningCmd.Parameters.AddWithValue("@date", date);
                        insertScreeningCmd.Parameters.AddWithValue("@time", time);
                        insertScreeningCmd.ExecuteNonQuery();

                        int screeningId = (int)insertScreeningCmd.LastInsertedId;

                        for (int i = 0; i <= 10; i++)
                        {
                            string seatCode = "A" + i;
                            string insertSeatsQuery = "INSERT INTO seat (screening_id, seatcode, availability) VALUES (@screeningId, @seatcode, @availabiltiy);";
                            MySqlCommand insertSeatsCmd = new MySqlCommand(insertSeatsQuery, conn);
                            insertSeatsCmd.Parameters.AddWithValue("@screeningId", screeningId);
                            insertSeatsCmd.Parameters.AddWithValue("@seatcode", seatCode);
                            insertSeatsCmd.Parameters.AddWithValue("@availabiltiy", 1);
                            insertSeatsCmd.ExecuteNonQuery();
                        }
                    }
                }

        
                 
                
                
                MessageBox.Show("Successfully Added movie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();

            cbx_datesList.Items.Clear();
            cbx_timeList.Items.Clear();
        }

        private void dtp_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_addDate_Click(object sender, EventArgs e)
        {
            string selectedDate = dtp_dates.Text;
            if (!selectedDate.Equals("Dates Added"))
            {
                cbx_datesList.Items.Add(selectedDate);
            }
            
            
        }

        private void btn_addTime_Click(object sender, EventArgs e)
        {
            string selectedTime = dtp_time.Text;
            
            if (!selectedTime.Equals("00:00")) // Exclude the default time
            {
                cbx_timeList.Items.Add(selectedTime);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionDB.getConnection();

            string date = "Mar 01, 2024";
            string time = "09:00";
            string title = "the movie maker";

            int screeningId = -1;

            string query = "SELECT screening_id FROM screenings INNER JOIN movies ON movies.movie_id = screenings.movie_id WHERE date = @Date AND time_start = @Time AND movie_title = @Title";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Time", time);
            cmd.Parameters.AddWithValue("@Title", title);
            conn.Open();
            object result = cmd.ExecuteScalar();

            if (result != null) 
            {
                screeningId = Convert.ToInt32(result);
            }


            MessageBox.Show("choose from set" + screeningId);
        }
    }
}
