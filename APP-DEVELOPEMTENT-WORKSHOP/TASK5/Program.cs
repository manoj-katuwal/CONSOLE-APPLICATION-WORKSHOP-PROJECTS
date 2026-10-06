using System;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a DateTime variable representing your birthdate
            DateTime birthdate = new DateTime(2002, 5, 15);

            // 2. Create another DateTime variable representing the current date and time
            DateTime currentDate = DateTime.Now;

            // 3. Calculate your age using TimeSpan (subtracting the two DateTime values)
            TimeSpan ageSpan = currentDate - birthdate;

            // Convert total days from TimeSpan into years (approx. 365.25 days per year)
            int ageInYears = (int)(ageSpan.TotalDays / 365.25);

            // 4. Print birthdate, current date, and age in years
            Console.WriteLine($"Birthdate: {birthdate:yyyy-MM-dd}");
            Console.WriteLine($"Current Date: {currentDate:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Age in Years: {ageInYears} years");

            // 5. Add 10 days to your birthdate and print the resulting date
            DateTime birthdatePlus10Days = birthdate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 Days: {birthdatePlus10Days:yyyy-MM-dd}");
        }
    }
}