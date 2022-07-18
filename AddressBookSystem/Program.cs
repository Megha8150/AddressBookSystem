// See https://aka.ms/new-console-template for more information
using AddressBookSystem;

AddressBook address = new AddressBook();

address.AddNewContact();
Console.WriteLine();
address.Display();
Console.WriteLine();
address.EditContact();
Console.WriteLine();
address.RemoveContact();
