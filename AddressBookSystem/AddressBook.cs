using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public List<Contact> addressBook = new List<Contact>();
    
        public void AddPerson()
        {
            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == person.FirstName.ToLower())
                {
                    Console.WriteLine("person already exist");
                    return;
                }
            }
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter city name: ");
            person.City = Console.ReadLine();
            Console.Write("Enter state name: ");
            person.State = Console.ReadLine();
            Console.Write("Enter zip number: ");
            person.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhNo = Console.ReadLine();
            Console.Write("Enter Phone Email: ");
            person.Email = Console.ReadLine();
            Console.Write("Enter Address 1: ");
            person.Address = Console.ReadLine();
            addressBook.Add(person);
        }
        public void EditContact()
        {
            Console.WriteLine("enter the first name you want to edit");
            string firstname = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    Console.WriteLine("enter which information you wnat to change");
                    Console.WriteLine("enter 1 to edit last name,2 to change the city,3 to state,4 to zip,5 to Email,6 to phonenumber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("enter the lastname");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("enter the city");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the state");
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("enter the zip");
                            contact.Zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("enter the phone number");
                            contact.PhNo = Console.ReadLine();
                            break;
                    }
                    return;
                }
            }
            Console.WriteLine("no contact with this firstname");

        }
        public void RemoveContact()
        {
            Console.WriteLine("enter the first name you want to remove");
            string firstname = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    addressBook.Remove(contact);
                    Console.WriteLine("the firstname you have entered is deleted ");
                    return;
                }
            }
            Console.WriteLine("contact not found");
        }
        public void Display()
        {
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine($"Firstname \t{contact.FirstName}\n Lastname \t {contact.LastName}\n PhoneNumber \t{contact.PhNo}\ncity \t{contact.City}\n zip \t{contact.Zip}\n Email \t{contact.Email}\n Adress \t{contact.Address}\n ");
            }
        }
        public void AddMultipleContact()
        {
            Console.WriteLine("enter number of contact you want to add");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                AddPerson();
                N--;
            }
        }

    }
}
