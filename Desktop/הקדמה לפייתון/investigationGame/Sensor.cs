using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigationGame
{
    internal class Sensor
    {
        public string Name { get; }  // שם הסנסור (למשל: "תרמי")

        public Sensor(string name)
        {
            Name = name;  // שומר את השם שהתקבל
        }
    }
}
