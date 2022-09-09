using AddressBook;
Console.WriteLine("Welcome to Address Book Program");
AddressBookprogram addressbook = new AddressBookprogram();
while (true)
{
    Console.WriteLine("\nSelect Option\n 1.Add\n");
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

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}
