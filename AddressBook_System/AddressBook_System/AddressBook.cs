using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class AddressBook
    {
        private List<Contacts> contacts;

        public AddressBook()
        {
            contacts = new List<Contacts>();
        }

        public void AddContact()
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

            Contacts contact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            contacts.Add(contact);

            Console.WriteLine("Contact created successfully!");
            Console.WriteLine();
        }

        public void EditContact(string firstName, string lastName)
        {
            Contacts contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine("Enter updated contact information:");

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

                Console.WriteLine("Contact updated successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Contact not found.");
                Console.WriteLine();
            }
        }

        public void DeleteContact(string firstName, string lastName)
        {
            Contacts contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Contact not found.");
                Console.WriteLine();
            }
        }

        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter the number of contacts to add:");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                AddContact();
            }
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("Address Book Entries:");
            foreach (Contacts contact in contacts)
            {
                contact.DisplayContactInfo();
            }
            Console.WriteLine();
        }

        private Contacts FindContact(string firstName, string lastName)
        {
            return contacts.Find(c => c.firstName == firstName && c.lastName == lastName);
        }
    }
}
