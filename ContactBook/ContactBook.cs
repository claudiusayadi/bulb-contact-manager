namespace ContactBook;

public class ContactBook
{
	private readonly Dictionary<string, Contact.Contact> contacts = new Dictionary<string, Contact.Contact>();

	public void AddContact(Contact.Contact contact)
	{
		if (contacts.ContainsKey(contact.PhoneNumber))
		{
			Console.WriteLine($"Contact: phone number {contact.PhoneNumber} already exists.");
			return;
		}

		contacts.Add(contact.PhoneNumber, contact);
		Console.WriteLine($"Contact {contact.PhoneNumber} saved successfully!");
	}

	public void RemoveContact(string phoneNumber)
	{
		if (!contacts.ContainsKey(phoneNumber))
		{
			Console.WriteLine($"Contact: {phoneNumber} does not exist.");
			return;
		}

		contacts.Remove(phoneNumber);
		Console.WriteLine($"Contact: {phoneNumber} removed successfully!");
	}

	public void FindContact(string phoneNumber)
	{
		var person = contacts.Values.SingleOrDefault(c => c.PhoneNumber.Equals(phoneNumber));
		if (person == null)
		{
			Console.WriteLine($"Contact: {phoneNumber} does not exist.");
			return;
		}

		Console.WriteLine($"Contact: {person.PrintContact()}");
	}

	public void ListAll()
	{
		if (contacts.Count == 0)
		{
			Console.WriteLine("No contacts found. Please add contacts first.");
			return;
		}

		foreach (var contact in contacts.Values)
		{
			Console.WriteLine(contact.PrintContact());
		}

	}

}
