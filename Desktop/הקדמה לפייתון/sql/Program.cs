using System;
using System.Collections.Generic;
using sql.DAL;
using sql.Models;

namespace sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgentDAL dal = new AgentDAL();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n====== Eagle Eye - Agent Management System ======");
                Console.WriteLine("1. Add Agent");
                Console.WriteLine("2. Show All Agents");
                Console.WriteLine("3. Update Agent Location");
                Console.WriteLine("4. Delete Agent");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Agent agent = new Agent();
                        Console.Write("Enter Code Name: ");
                        agent.CodName = Console.ReadLine();
                        Console.Write("Enter Real Name: ");
                        agent.RealName = Console.ReadLine();
                        Console.Write("Enter Location: ");
                        agent.Location = Console.ReadLine();
                        Console.Write("Enter Status (Active/Injured/Missing/Retired): ");
                        agent.Status = Console.ReadLine();
                        Console.Write("Enter Missions Completed: ");
                        agent.MissionsCompleted = int.Parse(Console.ReadLine());

                        dal.AddAgent(agent);
                        break;

                    case "2":
                        List<Agent> agents = dal.GetAllAgents();
                        foreach (Agent a in agents)
                        {
                            Console.WriteLine($"ID: {a.Id}, Code Name: {a.CodName}, Real Name: {a.RealName}, Location: {a.Location}, Status: {a.Status}, Missions: {a.MissionsCompleted}");
                        }
                        break;

                    case "3":
                        Console.Write("Enter Agent ID to update location: ");
                        int idToUpdate = int.Parse(Console.ReadLine());
                        Console.Write("Enter new location: ");
                        string newLoc = Console.ReadLine();
                        dal.UpdateAgent(idToUpdate, newLoc);
                        break;

                    case "4":
                        Console.Write("Enter Agent ID to delete: ");
                        int idToDelete = int.Parse(Console.ReadLine());
                        dal.DeleteAgent(idToDelete);
                        break;

                    

                    case "0":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
