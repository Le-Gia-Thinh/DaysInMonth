using System;

namespace DayInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid month entered.");
                    return;
            }

            Console.WriteLine($"Month {month} in year {year} has {days} days.");
        }
    }
}
