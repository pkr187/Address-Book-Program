using AddressBookProgram;
using System.Net.NetworkInformation;

using AddressBookProgram;
Console.WriteLine("Welcome to Address Book Program");
Contacts contact = new Contacts()
{
    FirstName = "Pankaj",
    LastName = "kumar",
    Address = "Banglore",
    City = "Whitefield",
    State = "Karnatika",
    Zip = 560048,
    PhoneNumber = "8825178849",
    Email = "pankajroman187@gmail.com"
};
Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);
