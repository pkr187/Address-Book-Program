using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram;

internal class AddressBook
{
    List<Contact> contacts = new List<Contact>();
    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Display();
    }
    public void Display()
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "Phone Number: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);
        }
    }
}


