using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gvbh
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter a car speed");
            int speed=Convert.ToInt32(Console.ReadLine());
            Car car1=new AudiCar(speed);
            car1.getSpeed();
            Console.WriteLine("How much would you like to accelerate the car?");
            int num=Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                car1.AccelerationSpeed();
            }
            Console.WriteLine("after acceleration and before deceleration");
            Console.WriteLine(car1);
            car1.DecelerationSpeed();
            car1.DecelerationSpeed();
            Console.WriteLine("after deceleration*2");
            Console.WriteLine(car1);
            car1.StopCar();
            Console.WriteLine(" ");
            Console.WriteLine("the other car");
            Console.WriteLine("enter a car speed");
            int speed2 = Convert.ToInt32(Console.ReadLine());
            Car car2 = new LexusCar(speed2);
            car2.getSpeed();
            Console.WriteLine("How much would you like to accelerate the car?");
            int num1 = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < num1; i++)
            {
                car2.AccelerationSpeed();
            }
            Console.WriteLine("after accelartion");

            Console.WriteLine(car2);  
           ((LexusCar) car2).playSong();
           
           car2.DecelerationSpeed();
           car2.DecelerationSpeed();
           Console.WriteLine("after deceleration*2");
           Console.WriteLine(car2);
           ((LexusCar)car2).pauseSong();
           car2.StopCar();


//קריאה לפונקציות
            Console.WriteLine(First(7));
            Console.WriteLine(untilMinus());
            FibonacciSeries(35);
            BiggestTriple();


            Console.ReadLine();


        }
        // שאלה ראשונה
        public static Boolean First(int num)
        {  //תנאי קצה
            if (num < 2)
                return false;
            else
            { //כדי לקבוע אם מספר  הוא ראשוני,
              //מספיק לבדוק את ההתחלקות במספרים עד לשורש הריבועי שלו
              //  , שכן כל גורמים פוטנציאליים של המספר גדולים מהשורש הריבועי כבר היו מובאים בחשבון.
              // כי הגורמים הכי גדולים זה השורש כפול עצמו .כלומר ברגע שאבדוק מעבר לשורש אני בעצם בטוחה שלא יהיה
              //תוצאה שלמה למעט הגורמים הפוטנציאלים שאותם כבר בדקתי לפי הזוג של הגורם שבוודאי עברתי עליו
              //כי כמו שאמרנו בדקנו עד השורש שהוא הגורם הגדול ביותר
              //אם לא נמצא מחלק בטווח זה, נוכל להסיק שהוא ראשוני
              //וזה חוסך הרבה בדיקות מיותרות
                for (int i = 2; i < Convert.ToInt16(Math.Sqrt(num)) + 1; i++)

                {    //בדיקה עד שורש המספר .
                     //ברגע שהתחלק באחד המספרים עד אליו ניתן לומר שהוא לא ראשוני
                    if (num % i == 0)
                        return false;
                }
                //גמר את הלולאה ולא מצא אף מספר שמתחלק בו אז הוא יכול להחזיר חיובי
                return true;
            }
        }
       
        public static int untilMinus()
        {
            int maxNum = 0,number;
            do
            {
                //קבלת מספר מהמשתמש עד שיהיה מינוס אחד והשוואה בכל פעם 
                //למספר המקסימלי שהיה עד כה.
                Console.WriteLine("enter a number");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > maxNum)
                    maxNum = number;

            } while (number != -1); 
                
            return maxNum;
        }

         public static void FibonacciSeries(int n)
        {
            
            int a = 0, b = 1,temp=0;
///כל עוד המספר שאמור להיות מודפס קטן מהנתון. 
///שמירת הערך האחרון שהודפס על מנת להוסיףבכל פעם למספר הקיים הקודם
          while(a<=n)
            {
              Console.Write(a+",");

                temp = a;
                a = b;
                b = temp + b;
            }

            
        }

        public static void BiggestTriple()
        {
            // קבלת מספרים עד למינוס אחד והכנסתם לליסט המספרים
            int number;
            List<int>numbersList=new List<int>();

            do
            {
                Console.WriteLine("enter a number");
                number = Convert.ToInt32(Console.ReadLine());
                numbersList.Add(number);

            } while (number != -1);

            int largestSum = 0;
            List<int> largestSumSequence = new List<int>();

            for (int i = 0; i < numbersList.Count - 2; i++)
            {  //עובר על כל הליסט בלולאה ובודק על התא הנוכחי +2הבאים אח"כ ומשווא למקסימום 
                //שהיה עד פה. באם גדול ממנו מחליף את המקסימום
                //ושם את הערכים שיצרו את המשפר הגדול בתוך ליסט של הסדרה המקסימלית
                int currentSum = numbersList[i] + numbersList[i + 1] + numbersList[i + 2];
                if (currentSum > largestSum)
                {
                    largestSum = currentSum;
                    largestSumSequence = new List<int> { numbersList[i], numbersList[i + 1], numbersList[i + 2] };
                }
            }
            Console.Write("The sequence with the largest sum is: ");
            // הדפסת מערך הסדרה המקסימלית
            foreach (int num in largestSumSequence)
            {
                Console.Write(num + " ");
            }





        }

    }
}
