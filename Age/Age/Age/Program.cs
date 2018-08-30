using System;

    class Program
    {
        static void Main()
        {
            DateTime Dob;
            Console.WriteLine("Enter date of Birth in format MM/DD/YYYY: ");
            //accepts date in MM/dd/yyyy format
            Dob = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = (int)((now - Dob).TotalDays / 365.242199);
            Console.WriteLine("Man, you are exactly " + age + " old");
        Console.WriteLine("After those 10 years you SHALL BE: " + (age + 10)+" years old. You old fart!");
          
          
        }
    }
