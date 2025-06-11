using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Data;

namespace Malshinon.Models
{
    internal class Management
    {
        public DAL dAL = new DAL();
        public void management()
        {
            Console.WriteLine("-------Welcome to Malshinon-------");
            Console.WriteLine("");
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            bool exists = dAL.GetPerson(firstName, lastName);
            if (exists == false)
            {
                Console.WriteLine("The name does not exist in the system: ");
                Console.WriteLine("");
                Console.WriteLine("--------Welcome to connect------");
                Console.WriteLine("Please enter your status(reporter or target");
                string type = Console.ReadLine();
                dAL.AddPeopl(firstName, lastName, type);
            }
            int id = dAL.GetPersonIdByName(firstName, lastName);
            Console.WriteLine("Please enter the report: ");
            string reportText = Console.ReadLine();
            string[] text = dAL.InsertReport(reportText);
            string TargetFirstName = text[0];
            string TargetLastName = text[1];
            bool existsTarget = dAL.GetPerson(TargetFirstName, TargetLastName);
            if (existsTarget == false)
            {
                Console.WriteLine("The name does not exist in the system: ");
                Console.WriteLine("");
                Console.WriteLine("--------Welcome to connect------");
                Console.WriteLine("Please enter your status(reporter or target)");
                string type = Console.ReadLine();
                dAL.AddPeopl(TargetFirstName, TargetLastName, type);
            }
            int TargetId = dAL.GetPersonIdByName(TargetFirstName, TargetLastName);
            dAL.UpdateReportAndMention(id, TargetId, reportText);
            Console.WriteLine("We're done! Thank you for your contribution to national security 💂");

        }
    }
}
