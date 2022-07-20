// See https://aka.ms/new-console-template for more information
using AddressBookSystem;




AddressBook address = new AddressBook();
Console.WriteLine("Welcome to Address Book : ");

UniqueName UniqueName = new UniqueName();
string command1 = "";

while (command1 != "exit")
{
    Console.WriteLine("enter the Number : 1. for Add AdressBook, 2. for Edit AddressBook, 3.for exit: ");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            UniqueName.AddAddressBook();
            break;
        case 2:
            Console.WriteLine("enter the addressbook name you want to edit");
            string addressBookName = Console.ReadLine();
            if (UniqueName.adressBooks.ContainsKey(addressBookName.ToLower()))
            {
                string command = "";
                while (command != "exit")
                {
                    Console.WriteLine("Please enter a command: add , edit, remove, display, multipleperson, exit :");
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
                        case "multipleperson":
                            address.AddMultipleContact();
                            break;
                        default:
                            break;

                    }
                }
            }
            break;
        default:
            command1 = "exit";
            break;

    }
}