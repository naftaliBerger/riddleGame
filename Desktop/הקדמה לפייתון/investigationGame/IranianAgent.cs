using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigationGame
{
    // מייצג סוכן איראני עם חולשות סודיות וסנסורים מוצמדים
    class IranianAgent
    {
        private List<string> secretWeaknesses;  // הסנסורים שיכולים לחשוף את הסוכן
        private List<Sensor> attachedSensors;   // כל הסנסורים שהשחקן כבר הצמיד

        public IranianAgent(List<string> weaknesses)
        {
            secretWeaknesses = weaknesses;       // שומר את רשימת החולשות
            attachedSensors = new List<Sensor>(); // מתחיל בלי סנסורים מוצמדים
        }

        // מצמיד סנסור חדש לסוכן
        public void AttachSensor(Sensor sensor)
        {
            attachedSensors.Add(sensor);  // מוסיף את הסנסור לרשימה
        }

        // מפעיל את כל הסנסורים ומחזיר כמה מהם מתאימים לחולשות
        public (int correct, int total) Activate()
        {
            int correct = 0;  // סופר כמה סנסורים נכונים נמצאו
            var copy = new List<string>(secretWeaknesses);  // יוצרים עותק כדי לא להרוס את המקור

            foreach (var sensor in attachedSensors)  // עבור כל סנסור מוצמד
            {
                if (copy.Contains(sensor.Name))  // אם החולשה עדיין ברשימה
                {
                    correct++;  // סנסור נכון!
                    copy.Remove(sensor.Name);  // מסירים כדי לא לספור אותו פעמיים
                }
            }

            return (correct, secretWeaknesses.Count);  // מחזיר כמה נכונים מתוך כמה שצריך
        }

        // מחזיר true אם כל הסנסורים שנדרשו כבר הוצמדו
        public bool IsExposed()
        {
            var (correct, total) = Activate();  // מפעיל את הפונקציה הקודמת
            return correct == total;  // נחשף אם כולם נכונים
        }
    }

}
