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
                Console.WriteLine("Enter the Number of Contacts list you want add in AddressBook:");
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
                Console.WriteLine("Edit by using First name");
                string name = Console.ReadLine();
                foreach(Contacts data in addressBook)
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("Enter option to edit:\n1.First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Phone Number\n7.Email\n8.Exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)

                        {
                            case 1:
                                Console.WriteLine("Enter first name ");
                                data.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter last name ");
                                data.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter address");
                                data.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter city");
                                data.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter state");
                                data.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter phone number");
                                data.phoneNumber = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter email");
                                data.email = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("Exiting the program....");
                                break;
                            default:
                                Console.WriteLine("Entered Invalid Option");
                                break;
                        }
                        Console.WriteLine("After Edit contact: \n");
                        data.DisplayContactInfo();
                    }
                    else
                    {
                        Console.WriteLine("Given first name is not found");
                        return;
                    }
                }
                Console.ReadLine();
            } 
        }
    }
}
