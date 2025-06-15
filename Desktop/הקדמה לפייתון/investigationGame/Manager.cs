using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigationGame
{
    // מנהל את החקירה – שואל שחקן, מציג תוצאות, מפעיל את המשחק
    class InvestigationManager
    {
        private IranianAgent agent;  // שומר את הסוכן הנוכחי
        private List<string> availableSensorTypes;  // סוגי סנסורים זמינים לבחירה

        public InvestigationManager()
        {
            // יוצרים סוכן עם חולשות: 2 סנסורים תרמיים (זהה)
            agent = new IranianAgent(new List<string> { "תרמי", "תרמי" });

            // שני סוגי סנסורים זמינים לבחירה
            availableSensorTypes = new List<string> { "תרמי", "תנועה" };
        }

        // מריץ את המשחק
        public void Start()
        {
            Console.WriteLine("🎯 התחלת חקירה של סוכן איראני");

            while (!agent.IsExposed())  // כל עוד הסוכן לא נחשף – המשך
            {
                Console.WriteLine("\nבחר סוג סנסור להצמדה:");
                for (int i = 0; i < availableSensorTypes.Count; i++)
                {
                    // מדפיס רשימת אפשרויות בחירה (1. תרמי, 2. תנועה)
                    Console.WriteLine($"{i + 1}. {availableSensorTypes[i]}");
                }

                string input = Console.ReadLine();  // קולט את בחירת המשתמש

                if (int.TryParse(input, out int choice) &&
                    choice >= 1 && choice <= availableSensorTypes.Count)
                {
                    // לוקחים את שם הסנסור שהשחקן בחר (לפי המספר)
                    string selectedType = availableSensorTypes[choice - 1];

                    // יוצרים סנסור חדש לפי הסוג, ומצמידים אותו לסוכן
                    agent.AttachSensor(new Sensor(selectedType));

                    // מפעילים את כל הסנסורים שכבר הוצמדו
                    var (correct, total) = agent.Activate();

                    // מדפיסים את כמות הסנסורים הנכונים מתוך הסך הכולל
                    Console.WriteLine($"תוצאה: {correct}/{total} סנסורים נכונים");
                }
                else
                {
                    Console.WriteLine("❌ בחירה לא חוקית. נסה שוב.");
                }
            }

            // ברגע שכל הסנסורים הנכונים הוצמדו → הסוכן נחשף
            Console.WriteLine("✅ הסוכן נחשף בהצלחה!");
        }
    }

}
