// See https://aka.ms/new-console-template for more information
using AddressBookSystem;


AddressBook address = new AddressBook();

Console.WriteLine("Welcome to Address Book : ");

string command = "";

while (command != "exit")
{
    Console.WriteLine("Please enter a command: add , edit, remove, display,  exit :");
    command = Console.ReadLine().ToLower();

    switch (command)
    {
        case "add":
            address.AddPerson();
            break;
        case "edit":
            address.EditContact();
            break;
        case "remove":
            address.RemoveContact();
            break;
        case "display":
            address.Display();
            break;
        default:
            break;

    }

}
