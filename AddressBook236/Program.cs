using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook236
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Address Book");
            Console.WriteLine("Enter your details :-\n");
            Console.WriteLine("First Name - " + "\n" + "Last Name - " + "\n" + "Address - " + "\n" +
                "City Name - " + "\n" + "State Name - " + "\n" + "Zip Code - " + "\n" +
                "Phone Number - " + "\n" + "Email ID - ");
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt64(Console.ReadLine()),
                PhoneNumber = Convert.ToInt64(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            Console.WriteLine("\nFirst Name - " + contact.FirstName + "\nLast Name - " + contact.LastName + "\nAddress - " + contact.Address +
                "\nCity Name - " + contact.City + "\nState Name - " + contact.State + "\nZip Code - " + contact.Zip +
                "\nPhone Number - " + contact.PhoneNumber + "\nEmail ID - " + contact.Email);
            Console.ReadLine();
        }
    }
}
