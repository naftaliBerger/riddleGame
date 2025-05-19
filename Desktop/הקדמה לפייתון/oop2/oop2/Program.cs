using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Tool> list = new List<Tool>();
            list.Add(new Hammer("name: Hammer " , 1.8));
            list.Add(new Drill("name: Drill ", 2.5));
            list.Add(new Hammer("name: Drill ", 1));
            list.Add(new Hammer("name: Wrench " , 1.3));
            list.Add(new Hammer("name: Hammer " , 1.8));
            list.Add(new Hammer("name: Hammer " , 1.8));

            foreach (Tool tool in list) 
            {
                tool.Describe();
                Console.WriteLine("");
                tool.Use();
                Console.WriteLine("");
            }

        }
    }
}
