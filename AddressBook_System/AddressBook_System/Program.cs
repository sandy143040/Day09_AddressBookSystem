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
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Edit an existing contact");
                Console.WriteLine("3. Delete a contact");
                Console.WriteLine("4. Add multiple contacts");
                Console.WriteLine("5. Display all contacts");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        addressBook.AddContact();
                        break;
                    case "2":
                        Console.Write("Enter the first name of the contact to edit: ");
                        string firstNameToEdit = Console.ReadLine();
                        Console.Write("Enter the last name of the contact to edit: ");
                        string lastNameToEdit = Console.ReadLine();
                        addressBook.EditContact(firstNameToEdit, lastNameToEdit);
                        break;
                    case "3":
                        Console.Write("Enter the first name of the contact to delete: ");
                        string firstNameToDelete = Console.ReadLine();
                        Console.Write("Enter the last name of the contact to delete: ");
                        string lastNameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(firstNameToDelete, lastNameToDelete);
                        break;
                    case "4":
                        addressBook.AddMultipleContacts();
                        break;
                    case "5":
                        addressBook.DisplayAllContacts();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
