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

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


        public void DisplayContactInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"ZIP: {zip}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine("--------------------");
        }
        
    }
}
