using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUpTestJan21
{
    internal class Program
    {

        static bool IsBalancedGuy(int[] array)
        {
            // בדיקת תקינות מערך
            if (array.Length < 2)
            {
                return false;
            }

            // אמצע המערך
            int midpoint = array.Length / 2;

            // אמצע המערך
            int sumFirstHalf = 0;
            for (int i = 0; i < midpoint; i++)
            {
                sumFirstHalf += array[i];
            }

            //חישוב אמצע המערך
            int sumSecondHalf = 0;
            // אם המערך זוגי אז האינדקס של האמצע הוא האמצע
            int startIndex;
            if (array.Length % 2 == 0)
            {
                startIndex = midpoint;
            }
            // אם המערך אי זוגי אז האינדקס של האמצע הוא האמצע + 1
            else
            {
                startIndex = midpoint + 1;
            }

            for (int i = startIndex; i < array.Length; i++)
            {
                sumSecondHalf += array[i];
            }

            // בדיקה אם הסכום של שתי החצאים שווה
            return sumFirstHalf == sumSecondHalf;
        }
        static int FindIndexGuy(int[] array)
        {
            if (array.Length < 2)
            {
                return -1; // אין סיבה לבדוק אם יש זוג שאריות עבור מערך של פחות משני איברים
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % array[i + 1] == 0)
                {
                    return i;
                }
            }

            return -1; // אם לא נמצא זוג שאריות מתאים
        }

        static double CalcComfortIndexGuy(double temp, double humidity)
        {
            const double bestTemp = 26;
            const double bestHumidity = 35;

            // חישוב הנוחות על פי הנוסחה
            double comfortIndex = 100 - Math.Abs(bestTemp - temp) - Math.Abs(bestHumidity - humidity);

            // החזרת התוצאה
            return comfortIndex;
        }
        static double RainChanceGuy(double temp, double humidity)
        {
            // חישוב הסיכוי לגשם על פי הנוסחה
            double probability = humidity - (30 - temp);

            // החזרת התוצאה, עם הגבלה לטווח 0-100
            return probability;
        }


        public static bool IsBalanced(int[] arr)
        {
            if (arr.Length == 1)
            {
                return false;
            }

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Length/2; i++) 
            {
                sum1 += arr[i];
            }
            int ln;
            if (arr.Length % 2 == 0)
            {
                ln = arr.Length / 2;
            }
            else
            {
                ln = arr.Length / 2 + 1;
            }

            for (int i = ln; i < arr.Length; i++)
            {
                sum2 += arr[i];
            }

            if (sum1 == sum2)
            {
                return true;
            }
            return false;

            // return sum1 == sum2;
        }

        public static bool IsBalanced2(int[] arr)
        {
            int odd = 0;
            int halfArr = arr.Length / 2;
            int sum1 = 0;
            int sum2 = 0;
            if (arr.Length ==1)
            {
                return false;
            }
            if (arr.Length % 2 != 0)
            {
                odd = 1;
            }

            for (int i =0; i < halfArr; i++)
            {
                sum1 += arr[i];
                sum2 += arr[i + halfArr+ odd];
            }
            return sum1 == sum2;

        }

        public static int Targil2(int[] arr)
        {
            if (arr.Length == 1)
            {
                return -1;
            }

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] % arr[i+1] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static double CalcComfortIndex(double humidity, double temp)
        {
/*          double bestTemp = 26;
            double bestHumidity = 35;
            double index = 100 - Math.Abs(bestTemp - temp) - Math.Abs(bestHumidity - humidity);
            return index;*/
            return 100 - Math.Abs(26 - temp) - Math.Abs(35 - humidity);
        }

        public static double RainChance(double humidity, double temp)
        {
            return humidity - (30 - temp);
        }

        public static void Main(string[] args)
        {
            int[] array1 = { 1,8,7,10,4,2 };
            int[] array2 = { 1, 8, 2, 6, 3 };
            int[] array3 = { 2, 2, 10, 7, 8, 11 };


          /*  int[] array5 = new int[10];
            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array5[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(IsBalanced(array5));*/
            
            int[] array4 = { 7, 2, 7, 3, 4, 5 };
            Console.WriteLine(Targil2(array4));


        }
    }
}
