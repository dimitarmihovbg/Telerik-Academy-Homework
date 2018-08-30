
using System;
using System.Text.RegularExpressions; // needed for Regex

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();        
        //string text = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
        string[] emails = text.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
        string[] validEmails = Array.FindAll(emails, IsValidEmail);
        PrintEmails(validEmails);
    }

    static bool IsValidEmail(string email)
    {
        const string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        return new Regex(pattern).IsMatch(email);
    }

    static void PrintEmails(string[] validEmails)
    {
        Console.WriteLine("Extracted e-mail addresses from the sample text: ");
        foreach (string email in validEmails)
        {
            Console.WriteLine(email);
        }
        Console.WriteLine();
    }
}