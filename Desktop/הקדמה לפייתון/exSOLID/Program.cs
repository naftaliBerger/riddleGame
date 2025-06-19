using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot sparrow = new Parrot("Parrot");
            Penguin penguin = new Penguin("Pingo");

            MakeBirdFly(sparrow); 

            



        }
        public static void MakeBirdFly(IMakeBirdFly bird)
        {
            bird.Fly();

        }




    }
}
