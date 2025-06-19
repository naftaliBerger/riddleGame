using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exSOLID
{
    internal class Parrot : Bird, IMakeBirdFly
    {
        public Parrot(string name) : base(name) 
        {
            
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying!");
        }
        public  void MakeBirdFly(IMakeBirdFly bird)
        {
            bird.Fly();
        }
    }
}
