using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Data;
using Malshinon.Models;

namespace Malshinon
{
    internal class Program
    {
        static Management management1 = new Management();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n--- Main menu ---");
                Console.WriteLine("1. informing");
                Console.WriteLine("2. List of potential agents");
                Console.WriteLine("3. List of dangerous targets");
                Console.WriteLine("4. exit");
                

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        management1.management();
                        break;
                    case "2":
                        //ShowPotentialAgents();
                        break;
                    case "3":
                        //ShowDangerousTargets();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
            }
        }

        
    }
}
