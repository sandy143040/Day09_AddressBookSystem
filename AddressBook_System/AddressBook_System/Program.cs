using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
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

            Console.WriteLine("Enter the Number of Contacts you want to add to the Address Book:");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int index = 0; index < input; index++)
            {
                Contacts contact = new Contacts();

                Console.WriteLine("Enter contact information:");
                Console.Write("First Name: ");
                contact.firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                contact.lastName = Console.ReadLine();

                Console.Write("Address: ");
                contact.address = Console.ReadLine();

                Console.Write("City: ");
                contact.city = Console.ReadLine();

                Console.Write("State: ");
                contact.state = Console.ReadLine();

                Console.Write("ZIP: ");
                contact.zip = Console.ReadLine();

                Console.Write("Phone Number: ");
                contact.phoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                contact.email = Console.ReadLine();

                addressBook.Add(contact);

                Console.WriteLine("Contact created successfully!");
                Console.WriteLine("\n");
            }

            Console.WriteLine("Address Book Entries:");
            foreach (Contacts contact in addressBook)
            {
                contact.DisplayContactInfo();
            }

            Console.WriteLine("Delete a contact by using the first name");
            Console.WriteLine("Enter the first name: ");
            string firstNameToDelete = Console.ReadLine();

            bool contactDeleted = false;
            for (int i = 0; i < addressBook.Count; i++)
            {
                if (addressBook[i].firstName == firstNameToDelete)
                {
                    addressBook.RemoveAt(i);
                    contactDeleted = true;
                    break;
                }
            }

            if (contactDeleted)
            {
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }

            Console.ReadLine();
        }
    }
}
