using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using sql.Models;

namespace sql.DAL
{
    internal class AgentDAL
    {
        string connection = "server=localhost;database=eagleeye;username=root;password=;";
        MySqlConnection conn;
        public AgentDAL()
        {
            conn = new MySqlConnection(connection);

            try
            {
                conn.Open();
                Console.WriteLine("connection!!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"err: {e.Message}");
            }
        }
        public void AddAgent(Agent agent)
        {
            try
            {
                string query = $"INSERT INTO agents(codName, realName, location, status, missionsCompleted)VALUES ('{agent.CodName}', '{agent.RealName}', '{agent.Location}','{agent.Status}', '{agent.MissionsCompleted}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Agent added successfully!");
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
        public List<Agent> GetAllAgents()
        {
            List<Agent> listAgent = new List<Agent>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connection);
                conn.Open();
                string query = "SELECT * FROM agents";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Agent agent = new Agent
                    {
                        Id = reader.GetInt32("id"),
                        CodName = reader.GetString("codName"),
                        RealName = reader.GetString("realName"),
                        Location = reader.GetString("location"),
                        Status = reader.GetString("status"),
                        MissionsCompleted = reader.GetInt32("missionsCompleted")
                    };
                    listAgent.Add(agent);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in GetAllAgents: {e.Message}");
            }
            return listAgent;
        }
        public void UpdateAgent(int agentId, string newLocation)
        {
            try
            {
                conn.Open();
                string query = $"UPDATE agents SET location = '{newLocation}' WHERE id = {agentId}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in UpdateAgentLocation: {e.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteAgent(int agentId)
        {
            try
            {
                conn.Open();
                string query = $"DELETE FROM agents WHERE id = {agentId}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in DeleteAgent: {e.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
