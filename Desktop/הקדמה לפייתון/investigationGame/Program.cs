using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new InvestigationManager();  // יוצרים את מנהל המשחק
            manager.Start();                           // מתחילים את החקירה
        }
    }
}
