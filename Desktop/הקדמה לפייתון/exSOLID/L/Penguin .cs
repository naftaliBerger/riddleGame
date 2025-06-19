using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exSOLID
{
    internal class Penguin: Bird
    {
        public Penguin(string name) : base(name)
        {
            
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming!");
        }

    }
}
