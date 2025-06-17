using Contact;
using ContactBook;

namespace Main;


public class Program
{
	static void Main()
	{
		ContactBook.ContactBook contactBook = new ContactBook.ContactBook();
		bool exit = false;

		while (!exit)
		{
			Console.WriteLine("\n--- Contact Book Menu ---");
			Console.WriteLine("1. Add a new contact");
			Console.WriteLine("2. Remove an existing contact");
			Console.WriteLine("3. Find a contact by name");
			Console.WriteLine("4. List all contacts");
			Console.WriteLine("5. Exit");
			Console.WriteLine("Enter your choice (1-5): ");

			string input = Console.ReadLine()!;
			int.TryParse(input, out int choice);

			switch (choice)
			{
				case 1:
					Console.WriteLine("Enter name: ");
					string name = Console.ReadLine()!;
					Console.WriteLine("Enter phone number: ");
					string phone = Console.ReadLine()!;

					var contact = new Contact.Contact(name, phone);
					contactBook.AddContact(contact);
					break;

				case 2:
					Console.WriteLine("Enter phone number of contact to remove: ");
					string removedPhone = Console.ReadLine()!;
					contactBook.RemoveContact(removedPhone);
					break;

				case 3:
					Console.WriteLine("Enter phone number of contact to find: ");
					string phoneNumber = Console.ReadLine()!;
					contactBook.FindContact(phoneNumber);
					break;

				case 4:
					contactBook.ListAll();
					break;

				case 5:
					exit = true;
					Console.WriteLine("Exiting program. Goodbye!");
					break;

				default:
					Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
					break;
			}
		}
	}
}
