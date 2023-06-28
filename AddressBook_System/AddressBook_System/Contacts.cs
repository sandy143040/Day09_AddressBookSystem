using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public void DisplayContactInfo()
        {
            Console.WriteLine("Contact Information:");
            Console.WriteLine($"First Name: " + firstName);
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"ZIP: {zip}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine();
        }
        public void AddNewContact()
        {

        }
    }
}
