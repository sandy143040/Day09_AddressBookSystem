using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");
            List<Contacts> addressBook = new List<Contacts>();

            while (true)
            {
                Console.WriteLine("Enter the Number of contact list you want add in AddressBook");
                int input = Convert.ToInt32(Console.ReadLine());
                for (int index = 0; index < input; index++)
                {
                    Console.WriteLine("Enter contact information:");

                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Address: ");
                    string address = Console.ReadLine();

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("State: ");
                    string state = Console.ReadLine();

                    Console.Write("ZIP: ");
                    string zip = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contacts contact = new Contacts()
                    {
                        firstName = firstName,
                        lastName = lastName,
                        address = address,
                        city = city,
                        state = state,
                        zip = zip,
                        phoneNumber = phoneNumber,
                        email = email
                    };

                    addressBook.Add(contact);

                    Console.WriteLine("Contact created successfully!");
                    Console.WriteLine("\n");
                    Console.WriteLine("Address Book Entries:");
                    foreach (Contacts contactList in addressBook)
                    {
                        contactList.DisplayContactInfo();
                    }
                }
                Console.ReadLine();
            } 
        }
    }
}
