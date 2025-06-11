using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.Data
{
    internal class DAL
    {
        private string connection = "server=localhost;database=malshinon;userName=root;password=;";
        MySqlConnection conn;
        MySqlDataReader reader;
        public DAL()
        {
            this.conn = new MySqlConnection(connection);
        }
        public void start()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }
        public bool GetPerson(string firstName, string lastName)
        {
            bool rez = false;
            try
            {
                start();
                string query = "SELECT * FROM People WHERE first_name = @firstName AND last_name = @lastName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);

                this.reader = cmd.ExecuteReader();
                rez = reader.Read();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"err{e.Message}");
            }
            finally
            {
                Close();
            }

            return rez;
        }
        public void AddPeopl(string firstName, string lastName, string type)
        {
            string secretCode = Guid.NewGuid().ToString();
            try
            {
                conn.Open();
                string query = @"INSERT INTO People (first_name, last_name, secret_code, type, num_reports, num_mentions)
                                 VALUES (@firstName, @lastName, @secretCode, @type, 0, 0)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@secretCode", secretCode);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in AddAgent: {e.Message}");
            }
            finally
            {
                conn.Close();
            }

        }
        public int GetPersonIdByName(string firstName, string lastName)
        {
            int id = - 1;
            {
                conn.Open();
                string query = "SELECT id FROM People WHERE first_name = @firstName AND last_name = @lastName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);

                this.reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                    
                
                conn.Close();
                return id;
            
            }
        }









        public string[] InsertReport(string text)
        {
            
            string[] words = text.Split(' ');

            if (words.Length < 2)
                throw new ArgumentException("The report must begin with a first name and last name.");

            return words;

            
        }
        public void UpdateReportAndMention(int reporterId, int targetId, string text)
        {
            try
            {
                conn.Open();

                
                string query1 = @"UPDATE People 
                           SET num_reports = num_reports + 1
                           WHERE id = @reporterId";

                
                string query2 = @"UPDATE People 
                           SET num_mentions = num_mentions + 1
                           WHERE id = @targetId";

               
                string insertReport = @"INSERT INTO Reports (reporter_id, target_id, text, timestamp)
                                VALUES (@reporterId, @targetId, @text, NOW())";

                using (MySqlCommand cmd1 = new MySqlCommand(query1, conn))
                {
                    cmd1.Parameters.AddWithValue("@reporterId", reporterId);
                    cmd1.ExecuteNonQuery();
                }

                using (MySqlCommand cmd2 = new MySqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@targetId", targetId);
                    cmd2.ExecuteNonQuery();
                }

                using (MySqlCommand cmd3 = new MySqlCommand(insertReport, conn))
                {
                    cmd3.Parameters.AddWithValue("@reporterId", reporterId);
                    cmd3.Parameters.AddWithValue("@targetId", targetId);
                    cmd3.Parameters.AddWithValue("@text", text);
                    cmd3.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error updating report: {e.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
