using System;
using System.Collections.Generic;

namespace ContactManagement
{
    class Program
    {
        static List<Contact> contacts = new List<Contact>();

        static void Main(string[] args)
        {
            bool continueApp = true;

            while (continueApp)
            {
                Console.WriteLine("Contact Management System");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        ViewContacts();
                        break;
                    case "3":
                        UpdateContact();
                        break;
                    case "4":
                        DeleteContact();
                        break;
                    case "5":
                        continueApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddContact()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            contacts.Add(new Contact { Name = name, Phone = phone, Email = email });
            Console.WriteLine("Contact added successfully!");
        }

        static void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                Console.WriteLine("Contacts:");
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {contacts[i].Name} - {contacts[i].Phone} - {contacts[i].Email}");
                }
            }
        }

        static void UpdateContact()
        {
            ViewContacts();
            Console.Write("Enter the number of the contact to update: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < contacts.Count)
            {
                Console.Write("Enter new Name: ");
                contacts[index].Name = Console.ReadLine();
                Console.Write("Enter new Phone: ");
                contacts[index].Phone = Console.ReadLine();
                Console.Write("Enter new Email: ");
                contacts[index].Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid contact number.");
            }
        }

        static void DeleteContact()
        {
            ViewContacts();
            Console.Write("Enter the number of the contact to delete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid contact number.");
            }
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
