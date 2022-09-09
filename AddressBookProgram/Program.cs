using AddressBookProgram;

using AddressBookProgram;
Console.WriteLine("Welcome to Address Book Program");
AddressBook addressbook = new AddressBook();
while (true)
{
    Console.WriteLine("\nSelect Option\n 1.Add\n 2.Edit\n 3.Delete\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Contact contact = new Contact();
            {
                Console.WriteLine("Enter FirstName: ");
                contact.FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName: ");
                contact.LastName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter State: ");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter Zip: ");
                contact.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter PhoneNumber: ");
                contact.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                contact.Email = Console.ReadLine();
            }
            Console.WriteLine("\nDisplay Added Contact:-");
            addressbook.AddContact(contact);
            break;

        case 2:
            Console.WriteLine("Enter Phone Number to Edit Contact Details");
            string PhoneNumber = Console.ReadLine();
            addressbook.EditContact(PhoneNumber);
            break;

        case 3:
            Console.WriteLine("Enter Phone Number to Delete Contact Details");
            string Phonenumber = Console.ReadLine();
            addressbook.DeleteContact(Phonenumber);
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}
