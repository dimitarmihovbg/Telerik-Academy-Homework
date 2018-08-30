using System;

namespace Company_Info
{
    class Program
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();
            string companyFaxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            uint managerAge = uint.Parse(Console.ReadLine());
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine();   
            Console.WriteLine(companyName);
            Console.WriteLine(companyAddress);
            Console.WriteLine(companyPhoneNumber);
            if (string.IsNullOrWhiteSpace(companyFaxNumber))
            {
                Console.WriteLine("Fax: (no fax)");
            }
                 else
            {
                    Console.WriteLine("Fax: " + companyFaxNumber);
            }
            Console.WriteLine(website);
            Console.WriteLine("Manager: "+managerFirstName+" "+managerLastName+" "+"(age: "+managerAge+", tel. "+managerPhoneNumber+")");

        }
    }
}
