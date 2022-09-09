using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
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
        public void EditContact(string name)
        {
            foreach (var contact in contacts)
            {
                if (contact.PhoneNumber == name)
                {
                    Console.WriteLine("\nSelect Option to Edit\n 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zip\n 7.Email\n");
                    Contact contact1 = new Contact();
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter FirstName to Edit");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter LastName to Edit");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address to Edit");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter City to Edit");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter State to Edit");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip to Edit");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter Email to Edit");
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("\nEdited Contact List:");
                    Display();
                }
            }
        }
    }
}
    

