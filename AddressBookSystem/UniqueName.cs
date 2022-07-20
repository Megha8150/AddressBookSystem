using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    
        public class UniqueName
        {
            public Dictionary<string, AddressBook> adressBooks = new Dictionary<string, AddressBook>();
            public void AddAddressBook()
            {
                AddressBook adressBook = new AddressBook();
                adressBook.AddMultipleContact();
                Console.WriteLine("enter the addressbook name");
                string addressName = Convert.ToString(Console.ReadLine());
                adressBooks.Add(addressName.ToLower(), adressBook);

            }
        }
    
}
