using System;

namespace Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiating variables
            int minDegree = 0;
            int maxDegree = 0;
            int currentMonth = 0;
            string evenOdd = "";
            string monthName = "";

            //getting data from end-users
            Console.WriteLine("Please enter the minimum weather temperature degree:");
            minDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the maximum weather temperature degree:");
            maxDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please enter the current month number (between 1 and 12)");
            currentMonth = int.Parse(Console.ReadLine());

            //calculations
            evenOdd = currentMonth % 2 == 0 ? "even" : "odd";
            monthName = GetMonthName(currentMonth);
            Console.WriteLine($"The entered month number is {evenOdd} number");
            Console.WriteLine($"The month name is {monthName}");
            Console.WriteLine($"The average temperature is {(minDegree+maxDegree)/2}");
            if((currentMonth == 12 || currentMonth == 1 || currentMonth == 2) && ((minDegree + maxDegree) / 2) > 0)
            {
                Console.WriteLine("The winter is rainy");
            }
        }

        static string GetMonthName(int m)
        {
            switch (m)
            {
                case 1: return "January";
                    break;
                case 2:
                    return "February";
                    break;
                case 3:
                    return "March";
                    break;
                case 4:
                    return "April";
                    break;
                case 5:
                    return "May";
                    break;
                case 6:
                    return "June";
                    break;
                case 7:
                    return "July";
                    break;
                case 8:
                    return "August";
                    break;
                case 9:
                    return "September";
                    break;
                case 10:
                    return "October";
                    break;
                case 11:
                    return "November";
                    break;
                case 12:
                    return "December";
                    break;
                default: return "incorrect month number";
                    break;
            }
        }
    }
}
